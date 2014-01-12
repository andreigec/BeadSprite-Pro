using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ANDREICSLIB;
using ANDREICSLIB.NewControls;

namespace BeadSprite_Pro
{
    public class controller
    {
        public static void ChangePalette(Beads b)
        {
            if (Beads.SelectedBeadColours==null)
                Beads.SelectedBeadColours = new List<Color>();

            var l = new List<selectItemFromListBox.SelectItem>();
            foreach(var f in Beads.AllBeadColours)
            {
                var si = new selectItemFromListBox.SelectItem(f.Key,Beads.SelectedBeadColours.Contains(f.Value));
                l.Add(si);
            }
            var res=SelectPalette.ShowDialog("Select the beads you wish to use", "Bead Palette Editor", l);
            if (res == null)
                return;

            Beads.SelectedBeadColours = new List<Color>();
            foreach(var s in res)
            {
                Beads.SelectedBeadColours.Add(Beads.AllBeadColours[s]);
            }
            b.UpdatePalette();
        }


        public static Dictionary<string, Color> GetBeadColoursFromFile(String filename)
        {
            var f = FileExtras.LoadFile("beads.txt");
            if (String.IsNullOrWhiteSpace(f))
                return new Dictionary<string, Color>();

            var f2 = f.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            var ret = new Dictionary<string, Color>();
            foreach (var f3 in f2)
            {
                var f4 = f3.Split(new[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);

                var c = ColorExtras.HexColourToColour(f4[1]);

                if (c == null)
                    continue;

                var c2 = (Color)c;
                //only keep unique values as well
                if (ret.ContainsValue(c2)==false)
                ret.Add(f4[0],c2);
            }
            
            return ret;
        }

        public static string GetColourDescription(Color c,bool orig)
        {
            if (c.Equals(Color.Transparent))
            {
                return "Transparent";
            }

            //get matching
            var bc = Beads.AllBeadColours.Where(s => ColorExtras.TestColourByRGB(s.Value, c));
            if (bc.Count() == 0)
                return c.ToString();
            var bcf = bc.First();
            return bcf.Key + " " + bcf.Value;
        }

        public static Tuple<int,int> GetGridPos(int x,int y,Panel p,Beads b)
        {
            if (p.BackgroundImageLayout == ImageLayout.None)
                return new Tuple<int, int>(x, y);

            if (p.BackgroundImageLayout == ImageLayout.Stretch)
            {
                //get pixel size
                var px = (float)p.Width / b.width;
                var py = (float)p.Height / b.height;
                var x1 = (int)Math.Floor(x / px);
                var y1 = (int)Math.Floor(y / py);
                return new Tuple<int, int>(x1, y1);
            }
            return new Tuple<int, int>(0, 0);
        }

        public static void UpdateMousePos(Beads LoadedBeads,Panel p, ToolStripStatusLabel newts, ToolStripStatusLabel oldts, int x, int y)
        {
            if (LoadedBeads == null)
                return;

            var pos = GetGridPos(x, y, p, LoadedBeads);
            if (pos == null)
            {
                newts.Text = "";
                newts.BackColor = Color.Transparent;
                newts.ForeColor = Color.Black;

                oldts.Text = "";
                oldts.BackColor = Color.Transparent;
                oldts.ForeColor = Color.Black;
            }
            else
            {
                SetColourText(LoadedBeads, newts, false, pos.Item1, pos.Item2);
                SetColourText(LoadedBeads, oldts, true, pos.Item1, pos.Item2);
            }
        }

        public static void SetColourText(Beads b, ToolStripStatusLabel ts, bool orig, int x, int y)
        {
            var c = b.GetPixelColour(x, y, orig);

            ts.Text = GetColourDescription(c, orig);
            ts.BackColor = c;
            ts.ForeColor = ColorExtras.getNegative(c);
        }

        public static void SaveCustomImageToFile(Beads beads,String filename,bool drawgrid)
        {
            var b = new Bitmap(beads.width, beads.height);
            var i = (Image)b;

            DrawToGraphics(ref i, beads, false, drawgrid);

            i.Save(filename, ImageFormat.Png);
        }

        public static void DrawBeads(Control p, Beads b, bool orig, bool drawgrid)
        {
            if (b == null)
                return;

            b.Grid = new List<Tuple<Tuple<int, int>, Rectangle>>();

            Image i = p.BackgroundImage;
            DrawToGraphics(ref i, b, orig,drawgrid,p.BackColor);
            p.BackgroundImage = i;
        }

        public static void DrawToGraphics(ref Image i,Beads b,bool original,bool drawgrid,Color? TransparentColourOverload=null)
        {
            const int pixelsize = 10;
            int w = b.width*pixelsize;
            int h = b.height*pixelsize;
            int cx = 0;
            int cy = 0;
            
            Brush brush = new SolidBrush(Color.White);
            i = new Bitmap(w, h);
            Graphics graphics = Graphics.FromImage(i);
            
            //clear
            graphics.FillRectangle(brush, 0, 0, w, h);
            b.Grid = new List<Tuple<Tuple<int, int>, Rectangle>>();
            //draw imagae
            for (int y = 0; y < b.height; y++)
            {
                for (int x = 0; x < b.width; x++)
                {
                    var c = b.GetPixelColour(x, y, original);
                    if (TransparentColourOverload != null && c.Equals(Color.Transparent))
                        c = (Color)TransparentColourOverload;
                    brush = new SolidBrush(c);

                    var r = new Rectangle(cx*pixelsize, cy*pixelsize, pixelsize,pixelsize);
                    b.Grid.Add(new Tuple<Tuple<int, int>, Rectangle>(new Tuple<int, int>(x, y), r));

                    graphics.FillRectangle(brush, r);

                    if ((x + 1) == b.width)
                    {
                        cx = 0;
                        cy++;
                    }
                    else
                    {
                        cx++;
                    }
                }
            }

            //overlay
            if (drawgrid)
            {
                var pen = new Pen(Color.White);
                
                for (int x=0;x<b.width;x++)
                {
                    graphics.DrawLine(pen, x * pixelsize,0,x*pixelsize,h);
                }

                for (int y = 0; y < b.height; y++)
                {
                    graphics.DrawLine(pen, 0,y * pixelsize, w, y * pixelsize);
                }
            }
        }
    }
}
