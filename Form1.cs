using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using ANDREICSLIB;
using ANDREICSLIB.ClassExtras;
using ANDREICSLIB.Helpers;
using ANDREICSLIB.Licensing;
using ANDREICSLIB.NewControls;
using BeadSprite_Pro.ServiceReference1;

namespace BeadSprite_Pro
{
    public partial class Form1 : Form
    {
        #region licensing

        private const string AppTitle = "BeadSprite Pro";
        private const string AppRepo = "BeadSprite-Pro";
        private const String HelpString = "";

        private readonly String OtherText =
            @"©" + DateTime.Now.Year +
            @" Andrei Gec (http://www.andreigec.net)

Licensed under GNU LGPL (http://www.gnu.org/)

Zip Assets © SharpZipLib (http://www.sharpdevelop.net/OpenSource/SharpZipLib/)
";
        public void InitLicensing()
        {
            Licensing.CreateLicense(this, menuStrip1,
                new Licensing.SolutionDetails(GitHubLicensing.GetGitHubReleaseDetails, HelpString, AppTitle, AppRepo,
                    AssemblyExtras.GetAssemblyFileVersionInfo(), OtherText));
        }

        #endregion

        #region settings

        private static string configPath = AppRepo + ".cfg";
        public void SaveConfig()
        {
            var savethese1 = new List<Control>();
            var savethese2 = new List<ToolStripItem>();
            var tp = new List<Tuple<string, string>>();

            if (dontSaveOptionsToolStripMenuItem.Checked)
            {
                savethese2.Add(dontSaveOptionsToolStripMenuItem);
            }
            else
            {

                savethese2.Add(viewGridToolStripMenuItem);
            }

            FormConfigRestore.SaveConfig(this, configPath, savethese1, savethese2, tp);
        }

        public List<Tuple<string, string>> LoadConfig()
        {
            return FormConfigRestore.LoadConfig(this, configPath);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                SaveConfig();
            }
            catch (Exception)
            {
            }
        }

        #endregion settings

        private Beads LoadedBeads = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            newts.Text = "";
            oldts.Text = "";

            InitLicensing();
            LoadConfig();

            Beads.AllBeadColours = controller.GetBeadColoursFromFile("beads.txt");

            RedrawBeads();
        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Title = "Select Image file to import";
            ofd.InitialDirectory = DirectoryExtras.GetExePath();
            var res = ofd.ShowDialog();
            if (res != DialogResult.OK)
                return;

            LoadedBeads = Beads.Create(ofd.FileName, ignoreWhiteBeadsFromOutsideToolStripMenuItem.Checked);
            RedrawBeads();
        }

        private ImageLayout GetLayout()
        {
            if (stretchToolStripMenuItem.Checked)
                return ImageLayout.Stretch;
            if (zoomToolStripMenuItem.Checked)
                return ImageLayout.Zoom;
            if (originalToolStripMenuItem.Checked)
                return ImageLayout.None;

            return ImageLayout.Zoom;
        }

        private void RedrawBeads()
        {
            splitcont.Panel1.BackgroundImageLayout = splitcont.Panel2.BackgroundImageLayout = GetLayout();

            controller.DrawBeads(splitcont.Panel2, LoadedBeads, true, viewGridToolStripMenuItem.Checked);
            controller.DrawBeads(splitcont.Panel1, LoadedBeads, false, viewGridToolStripMenuItem.Checked);
        }

        private void viewGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RedrawBeads();
        }

        private void stretchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stretchToolStripMenuItem.Checked)
                return;

            zoomToolStripMenuItem.Checked = false;
            originalToolStripMenuItem.Checked = false;
            stretchToolStripMenuItem.Checked = true;

            splitcont.Panel1.BackgroundImageLayout =
            splitcont.Panel2.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (zoomToolStripMenuItem.Checked)
                return;

            zoomToolStripMenuItem.Checked = true;
            originalToolStripMenuItem.Checked = false;
            stretchToolStripMenuItem.Checked = false;

            splitcont.Panel1.BackgroundImageLayout =
             splitcont.Panel2.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void originalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (originalToolStripMenuItem.Checked)
                return;

            zoomToolStripMenuItem.Checked = false;
            originalToolStripMenuItem.Checked = true;
            stretchToolStripMenuItem.Checked = false;

            splitcont.Panel1.BackgroundImageLayout =
              splitcont.Panel2.BackgroundImageLayout = ImageLayout.None;
        }

        private void splitcont_Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            controller.UpdateMousePos(LoadedBeads, sender as Panel, newts, oldts, e.X, e.Y);
        }

        private void splitcont_Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            controller.UpdateMousePos(LoadedBeads, sender as Panel, newts, oldts, e.X, e.Y);
        }

        private void changePaletteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoadedBeads == null)
            {
                MessageBox.Show("Please load an image first");
                return;
            }
            controller.ChangePalette(LoadedBeads);
            RedrawBeads();
        }

        private void statsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoadedBeads == null)
            {
                MessageBox.Show("Please load an image first");
                return;
            }

            Stats s = new Stats(LoadedBeads);
            s.ShowDialog();
        }

        private void saveCustomImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Title = "Select path for copied custom image";
            sfd.InitialDirectory = DirectoryExtras.GetExePath();
            sfd.Filter = "|*.png";
            var res = sfd.ShowDialog();
            if (res != DialogResult.OK)
                return;

            controller.SaveCustomImageToFile(LoadedBeads, sfd.FileName, viewGridToolStripMenuItem.Checked);
        }

        private void splitcont_Panel2_Paint(object sender, PaintEventArgs e)
        {
            ImageDraw.PaintEvent(sender, e);
        }

        private void splitcont_Panel1_Paint(object sender, PaintEventArgs e)
        {
            ImageDraw.PaintEvent(sender, e);
        }
    }
}
