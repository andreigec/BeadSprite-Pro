using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ANDREICSLIB;
using ANDREICSLIB.ClassExtras;
using ANDREICSLIB.Helpers;

namespace BeadSprite_Pro
{
    public class Beads
    {
        public static Dictionary<string, Color> AllBeadColours = null;
        public static List<Color> SelectedBeadColours = null;
        public Dictionary<Color, Color> MappedPalette = null;

        private Color[][] OriginalColours;
        public Color[][] BeadColours;
        /// <summary>
        /// pixel size to rectangle for mouse
        /// </summary>
        public List<Tuple<Tuple<int, int>, Rectangle>> Grid;
        public int width;
        public int height;

        private Beads()
        {

        }

        public Beads Clone()
        {
            var b = new Beads();
            b.width = width;
            b.height = height;
            b.OriginalColours = MatrixOps.CloneMatrix(OriginalColours, width, height);
            b.BeadColours = MatrixOps.CloneMatrix(BeadColours, width, height);
            return b;
        }

        public static int GetUniqueCount(Beads b, bool original)
        {
            var seen = new List<Color>();
            var l = new object();

            Parallel.For(0, b.height, (y) =>
            {
                for (int x = 0; x < b.width; x++)
                {
                    var c = b.GetPixelColour(x, y, original);

                    if (seen.Contains(c) == false)
                    {
                        lock (l)
                        {
                            seen.Add(c);
                        }
                    }
                }
            });
            return seen.Count;
        }

        public void UpdatePalette()
        {
            if (SelectedBeadColours == null)
                SelectedBeadColours = new List<Color>();
            MappedPalette = new Dictionary<Color, Color>();

            //create fresh
            BeadColours = MatrixOps.CreateMatrix<Color>(width, height);
            MatrixOps.SetAll(BeadColours, Color.Empty);

            //foreach, map the closest colour from the palettes
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    var old = OriginalColours[y][x];
                    if (old.Equals(Color.Transparent))
                    {
                        BeadColours[y][x] = Color.Transparent;
                        continue;
                    }

                    if (MappedPalette.ContainsKey(old) == false)
                        MappedPalette.Add(old, ColorExtras.GetNearestColour(old, SelectedBeadColours));

                    BeadColours[y][x] = MappedPalette[old];
                }
            }
        }

        private static void ClearEdges(Beads b, bool original = true)
        {
            if (original)
                MatrixOps.Replace(ref b.OriginalColours, Color.White, Color.Transparent, ColorExtras.Equals);
            else
                MatrixOps.Replace(ref b.BeadColours, Color.White, Color.Transparent, ColorExtras.Equals);
        }

        public static Beads Create(String fileName, bool ignorewhiteedge)
        {
            var cm = BitmapExtras.LoadFileToColourMatrix(fileName);
            if (cm == null)
                return null;

            var b = new Beads();
            b.height = cm.Count();
            b.width = cm[0].Count();
            b.OriginalColours = cm;
            b.BeadColours = MatrixOps.CreateMatrix<Color>(b.width, b.height);
            MatrixOps.SetAll(b.BeadColours, Color.Transparent);

            if (ignorewhiteedge)
                ClearEdges(b);

            return b;
        }

        public Color GetPixelColour(int x, int y, bool original = true)
        {
            if (x < 0 || y < 0 || x >= width || y >= height)
                return Color.Transparent;
            if (original)
                return OriginalColours[y][x];
            return BeadColours[y][x];
        }

        public void SetPixelColour(int x, int y, Color c, bool original = true)
        {
            Color[][] grid;
            grid = original ? OriginalColours : BeadColours;
            grid[y][x] = c;
        }
    }
}
