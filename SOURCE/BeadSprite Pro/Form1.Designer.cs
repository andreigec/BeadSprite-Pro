using System.Windows.Forms;

namespace BeadSprite_Pro
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePaletteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stretchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCustomImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.newts = new System.Windows.Forms.ToolStripStatusLabel();
            this.oldts = new System.Windows.Forms.ToolStripStatusLabel();
            this.toppanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitcont = new System.Windows.Forms.SplitContainer();
            this.ignoreWhiteBeadsFromOutsideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitcont)).BeginInit();
            this.splitcont.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.changePaletteToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.statsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.loadImageToolStripMenuItem.Text = "Load Image";
            this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.loadImageToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // changePaletteToolStripMenuItem
            // 
            this.changePaletteToolStripMenuItem.Name = "changePaletteToolStripMenuItem";
            this.changePaletteToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.changePaletteToolStripMenuItem.Text = "Change Palette";
            this.changePaletteToolStripMenuItem.Click += new System.EventHandler(this.changePaletteToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewGridToolStripMenuItem,
            this.zoomModeToolStripMenuItem,
            this.saveCustomImageToolStripMenuItem,
            this.ignoreWhiteBeadsFromOutsideToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.optionsToolStripMenuItem.Text = "Image Options";
            // 
            // viewGridToolStripMenuItem
            // 
            this.viewGridToolStripMenuItem.Checked = true;
            this.viewGridToolStripMenuItem.CheckOnClick = true;
            this.viewGridToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewGridToolStripMenuItem.Name = "viewGridToolStripMenuItem";
            this.viewGridToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.viewGridToolStripMenuItem.Text = "View Grid";
            this.viewGridToolStripMenuItem.Click += new System.EventHandler(this.viewGridToolStripMenuItem_Click);
            // 
            // zoomModeToolStripMenuItem
            // 
            this.zoomModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stretchToolStripMenuItem,
            this.zoomToolStripMenuItem,
            this.originalToolStripMenuItem});
            this.zoomModeToolStripMenuItem.Name = "zoomModeToolStripMenuItem";
            this.zoomModeToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.zoomModeToolStripMenuItem.Text = "Zoom Mode";
            // 
            // stretchToolStripMenuItem
            // 
            this.stretchToolStripMenuItem.Checked = true;
            this.stretchToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.stretchToolStripMenuItem.Name = "stretchToolStripMenuItem";
            this.stretchToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.stretchToolStripMenuItem.Text = "Stretch";
            this.stretchToolStripMenuItem.Click += new System.EventHandler(this.stretchToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
            // 
            // originalToolStripMenuItem
            // 
            this.originalToolStripMenuItem.Name = "originalToolStripMenuItem";
            this.originalToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.originalToolStripMenuItem.Text = "Original";
            this.originalToolStripMenuItem.Click += new System.EventHandler(this.originalToolStripMenuItem_Click);
            // 
            // saveCustomImageToolStripMenuItem
            // 
            this.saveCustomImageToolStripMenuItem.Name = "saveCustomImageToolStripMenuItem";
            this.saveCustomImageToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.saveCustomImageToolStripMenuItem.Text = "Save Custom Image";
            this.saveCustomImageToolStripMenuItem.Click += new System.EventHandler(this.saveCustomImageToolStripMenuItem_Click);
            // 
            // statsToolStripMenuItem
            // 
            this.statsToolStripMenuItem.Name = "statsToolStripMenuItem";
            this.statsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.statsToolStripMenuItem.Text = "Stats";
            this.statsToolStripMenuItem.Click += new System.EventHandler(this.statsToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newts,
            this.oldts});
            this.statusStrip1.Location = new System.Drawing.Point(0, 435);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // newts
            // 
            this.newts.Name = "newts";
            this.newts.Size = new System.Drawing.Size(38, 17);
            this.newts.Text = "newts";
            // 
            // oldts
            // 
            this.oldts.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.oldts.Name = "oldts";
            this.oldts.Size = new System.Drawing.Size(531, 17);
            this.oldts.Spring = true;
            this.oldts.Text = "toolStripStatusLabel2";
            this.oldts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toppanel.Controls.Add(this.label2);
            this.toppanel.Controls.Add(this.label1);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 24);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(584, 47);
            this.toppanel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Original";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Custom";
            // 
            // splitcont
            // 
            this.splitcont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitcont.Location = new System.Drawing.Point(0, 71);
            this.splitcont.Name = "splitcont";
            // 
            // splitcont.Panel1
            // 
            this.splitcont.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.splitcont.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitcont.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitcont_Panel1_Paint);
            this.splitcont.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitcont_Panel1_MouseMove);
            // 
            // splitcont.Panel2
            // 
            this.splitcont.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.splitcont.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitcont.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitcont_Panel2_Paint);
            this.splitcont.Panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitcont_Panel2_MouseMove);
            this.splitcont.Size = new System.Drawing.Size(584, 364);
            this.splitcont.SplitterDistance = 274;
            this.splitcont.TabIndex = 5;
            // 
            // ignoreWhiteBeadsFromOutsideToolStripMenuItem
            // 
            this.ignoreWhiteBeadsFromOutsideToolStripMenuItem.Checked = true;
            this.ignoreWhiteBeadsFromOutsideToolStripMenuItem.CheckOnClick = true;
            this.ignoreWhiteBeadsFromOutsideToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ignoreWhiteBeadsFromOutsideToolStripMenuItem.Name = "ignoreWhiteBeadsFromOutsideToolStripMenuItem";
            this.ignoreWhiteBeadsFromOutsideToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.ignoreWhiteBeadsFromOutsideToolStripMenuItem.Text = "White to Transparent";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 457);
            this.Controls.Add(this.splitcont);
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitcont)).EndInit();
            this.splitcont.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private Panel toppanel;
        private ToolStripMenuItem changePaletteToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem viewGridToolStripMenuItem;
        private ToolStripMenuItem zoomModeToolStripMenuItem;
        private ToolStripMenuItem stretchToolStripMenuItem;
        private ToolStripMenuItem zoomToolStripMenuItem;
        private ToolStripStatusLabel newts;
        private ToolStripStatusLabel oldts;
        private SplitContainer splitcont;
        private ToolStripMenuItem originalToolStripMenuItem;
        private Label label2;
        private Label label1;
        private ToolStripMenuItem statsToolStripMenuItem;
        private ToolStripMenuItem saveCustomImageToolStripMenuItem;
        private ToolStripMenuItem ignoreWhiteBeadsFromOutsideToolStripMenuItem;
    }
}

