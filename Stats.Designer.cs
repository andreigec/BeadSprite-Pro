namespace BeadSprite_Pro
{
    partial class Stats
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statsLV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalold = new System.Windows.Forms.Label();
            this.totalnew = new System.Windows.Forms.Label();
            this.totalbeadcount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // statsLV
            // 
            this.statsLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.statsLV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statsLV.Location = new System.Drawing.Point(0, 105);
            this.statsLV.Name = "statsLV";
            this.statsLV.Size = new System.Drawing.Size(321, 261);
            this.statsLV.TabIndex = 0;
            this.statsLV.UseCompatibleStateImageBehavior = false;
            this.statsLV.View = System.Windows.Forms.View.Details;
            this.statsLV.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.statsLV_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Colour";
            this.columnHeader1.Width = 198;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Count";
            this.columnHeader2.Width = 88;
            // 
            // totalold
            // 
            this.totalold.AutoSize = true;
            this.totalold.Location = new System.Drawing.Point(47, 7);
            this.totalold.Name = "totalold";
            this.totalold.Size = new System.Drawing.Size(35, 13);
            this.totalold.TabIndex = 1;
            this.totalold.Text = "label1";
            // 
            // totalnew
            // 
            this.totalnew.AutoSize = true;
            this.totalnew.Location = new System.Drawing.Point(47, 30);
            this.totalnew.Name = "totalnew";
            this.totalnew.Size = new System.Drawing.Size(35, 13);
            this.totalnew.TabIndex = 2;
            this.totalnew.Text = "label1";
            // 
            // totalbeadcount
            // 
            this.totalbeadcount.AutoSize = true;
            this.totalbeadcount.Location = new System.Drawing.Point(47, 58);
            this.totalbeadcount.Name = "totalbeadcount";
            this.totalbeadcount.Size = new System.Drawing.Size(78, 13);
            this.totalbeadcount.TabIndex = 3;
            this.totalbeadcount.Text = "totalbeadcount";
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 366);
            this.Controls.Add(this.totalbeadcount);
            this.Controls.Add(this.totalnew);
            this.Controls.Add(this.totalold);
            this.Controls.Add(this.statsLV);
            this.Name = "Stats";
            this.Text = "Stats";
            this.Load += new System.EventHandler(this.Stats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView statsLV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label totalold;
        private System.Windows.Forms.Label totalnew;
        private System.Windows.Forms.Label totalbeadcount;
    }
}