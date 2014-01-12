using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ANDREICSLIB;

namespace BeadSprite_Pro
{
    public partial class Stats : Form
    {
        private Beads b;
        private ListViewSorter lvs;

        public Stats(Beads b)
        {
            InitializeComponent();
            this.b = b;
        }

        private void Stats_Load(object sender, EventArgs e)
        {
            statsLV.Items.Clear();

            totalnew.Text = "Total Unique Colours for Custom:" + Beads.GetUniqueCount(b,false);
            totalold.Text = "Total Unique Colours for Original:" + Beads.GetUniqueCount(b,true);
            totalbeadcount.Text = "Total Beads:" + b.width*b.height;

            foreach(var kvp in b.MappedPalette)
            {
                var lvi = new ListViewItem();
                var name = DictionaryExtras.GetKeyByValue(Beads.AllBeadColours, kvp.Value);
                if (name==null)
                    continue;

                lvi.Text = name;
                lvi.BackColor = kvp.Value;
                lvi.ForeColor = ColorExtras.getNegative(kvp.Value);
                lvi.SubItems.Add(MatrixOps.Count(b.BeadColours, kvp.Value).ToString());

                statsLV.Items.Add(lvi);
            }

            lvs = new ListViewSorter();
            
            ListViewSorter.ColumnSort(lvs,statsLV,1,SortOrder.Descending);
        }

        private void statsLV_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewSorter.ColumnSort(lvs, statsLV, e.Column);
        }

        
    }
}
