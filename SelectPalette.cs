using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ANDREICSLIB.ClassExtras;

namespace ANDREICSLIB.NewControls
{
    public partial class SelectPalette : Form
    {
        private const string PaletteDirectory = "Palettes";
        private int mustSelectCount = 0;
        private List<string> returnvalues = new List<string>();
        private SelectPalette()
        {
            InitializeComponent();
        }

        public static List<String> ShowDialog(String labelText, String title, List<SelectItemFromListBox.SelectItem> listBoxItems, int mustSelectCountIN = -1)
        {
            var s = new SelectPalette();
            s.GetPalettes();
            s.mustSelectCount = mustSelectCountIN;

            s.Text = title;
            s.label1.Text = labelText;

            s.checkedListBox1.Items.Clear();
            var a = 0;
            foreach (var v in listBoxItems)
            {
                s.checkedListBox1.Items.Add(v.Text);
                s.checkedListBox1.SetItemChecked(a, v.Preselected);
                a++;
            }

            s.ShowDialog();
            return s.returnvalues;
        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count < mustSelectCount && mustSelectCount != -1)
            {
                MessageBox.Show("You must select at least " + mustSelectCount.ToString() + " items");
                return;
            }
            foreach (var v in checkedListBox1.CheckedItems)
            {
                returnvalues.Add(v.ToString());
            }
            Close();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            returnvalues = null;
            Close();
        }

        private void selectallbutton_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < checkedListBox1.Items.Count; a++)
                checkedListBox1.SetItemChecked(a, true);
        }

        private void selectnonebutton_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < checkedListBox1.Items.Count; a++)
                checkedListBox1.SetItemChecked(a, false);
        }

        private void applyregex_Click(object sender, EventArgs e)
        {
            String t = regextextbox.Text;
            for (int a = 0; a < checkedListBox1.Items.Count; a++)
            {
                var m = Regex.Match(checkedListBox1.Items[a].ToString(), t, RegexOptions.IgnoreCase);
                if (m.Success == false)
                    continue;

                checkedListBox1.SetItemChecked(a, true);
            }
        }


        private void GetPalettes()
        {
            var o = paletteCB.Text;
            if (Directory.Exists(PaletteDirectory) == false)
                Directory.CreateDirectory(PaletteDirectory);

            var f = DirectoryExtras.GetFilesRecursive(PaletteDirectory);

            paletteCB.Items.Clear();
            foreach (var f2 in f)
            {
                var f3 = FileExtras.TrimFileName(f2, false, true, false);
                paletteCB.Items.Add(f3);
            }

            if (string.IsNullOrWhiteSpace(o) == false)
                paletteCB.Text = o;
            else if (paletteCB.Items.Count > 0)
                paletteCB.Text = paletteCB.Items[0].ToString();

        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            SavePalette();

        }

        private void SavePalette()
        {
            var sfd = new SaveFileDialog();
            sfd.Title = "Save palette file";
            sfd.Filter = "|*.palette";
            sfd.InitialDirectory = DirectoryExtras.GetExePath() + "\\" + PaletteDirectory;
            var res = sfd.ShowDialog();
            if (res != DialogResult.OK)
                return;

            String ret = "";
            foreach (var c in checkedListBox1.CheckedItems)
            {
                ret += c + "\r\n";
            }

            FileExtras.SaveToFile(sfd.FileName, ret);
            GetPalettes();
        }

        private void loadbutton_Click(object sender, EventArgs e)
        {
            LoadPalette();
        }

        private void LoadPalette()
        {
            if (String.IsNullOrWhiteSpace(paletteCB.Text))
                return;

            var p = DirectoryExtras.GetExePath() + "\\"+PaletteDirectory + "\\";
            var f1 = FileExtras.GetAbsoluteFilePath(paletteCB.Text, p);
            if (f1 == null)
                return;

            var f2 = FileExtras.LoadFile(f1);
            if (string.IsNullOrEmpty(f2))
                return;

            var s = StringExtras.SplitString(f2, "\r\n");

            CheckedListBoxExtras.CheckAll(checkedListBox1, false);
            foreach (var s1 in s)
            {
                CheckedListBoxExtras.CheckItem(checkedListBox1, s1);
            }
        }
    }
}
