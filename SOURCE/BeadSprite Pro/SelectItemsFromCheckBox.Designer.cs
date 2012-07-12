namespace ANDREICSLIB.NewControls
{
    partial class SelectPalette
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.okbutton = new System.Windows.Forms.Button();
            this.selectallbutton = new System.Windows.Forms.Button();
            this.selectnonebutton = new System.Windows.Forms.Button();
            this.applyregex = new System.Windows.Forms.Button();
            this.regextextbox = new System.Windows.Forms.TextBox();
            this.loadbutton = new System.Windows.Forms.Button();
            this.paletteCB = new System.Windows.Forms.ComboBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 129);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.ScrollAlwaysVisible = true;
            this.checkedListBox1.Size = new System.Drawing.Size(318, 364);
            this.checkedListBox1.TabIndex = 1;
            // 
            // cancelbutton
            // 
            this.cancelbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelbutton.Location = new System.Drawing.Point(93, 499);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelbutton.TabIndex = 7;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // okbutton
            // 
            this.okbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.okbutton.Location = new System.Drawing.Point(12, 499);
            this.okbutton.Name = "okbutton";
            this.okbutton.Size = new System.Drawing.Size(75, 23);
            this.okbutton.TabIndex = 6;
            this.okbutton.Text = "OK";
            this.okbutton.UseVisualStyleBackColor = true;
            this.okbutton.Click += new System.EventHandler(this.okbutton_Click);
            // 
            // selectallbutton
            // 
            this.selectallbutton.Location = new System.Drawing.Point(12, 40);
            this.selectallbutton.Name = "selectallbutton";
            this.selectallbutton.Size = new System.Drawing.Size(75, 23);
            this.selectallbutton.TabIndex = 8;
            this.selectallbutton.Text = "Select All";
            this.selectallbutton.UseVisualStyleBackColor = true;
            this.selectallbutton.Click += new System.EventHandler(this.selectallbutton_Click);
            // 
            // selectnonebutton
            // 
            this.selectnonebutton.Location = new System.Drawing.Point(93, 40);
            this.selectnonebutton.Name = "selectnonebutton";
            this.selectnonebutton.Size = new System.Drawing.Size(75, 23);
            this.selectnonebutton.TabIndex = 9;
            this.selectnonebutton.Text = "Select None";
            this.selectnonebutton.UseVisualStyleBackColor = true;
            this.selectnonebutton.Click += new System.EventHandler(this.selectnonebutton_Click);
            // 
            // applyregex
            // 
            this.applyregex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.applyregex.Location = new System.Drawing.Point(216, 66);
            this.applyregex.Name = "applyregex";
            this.applyregex.Size = new System.Drawing.Size(114, 23);
            this.applyregex.TabIndex = 10;
            this.applyregex.Text = "Allow by regex";
            this.applyregex.UseVisualStyleBackColor = true;
            this.applyregex.Click += new System.EventHandler(this.applyregex_Click);
            // 
            // regextextbox
            // 
            this.regextextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regextextbox.Location = new System.Drawing.Point(12, 69);
            this.regextextbox.Name = "regextextbox";
            this.regextextbox.Size = new System.Drawing.Size(198, 20);
            this.regextextbox.TabIndex = 11;
            // 
            // loadbutton
            // 
            this.loadbutton.Location = new System.Drawing.Point(135, 93);
            this.loadbutton.Name = "loadbutton";
            this.loadbutton.Size = new System.Drawing.Size(75, 23);
            this.loadbutton.TabIndex = 12;
            this.loadbutton.Text = "Load Palette";
            this.loadbutton.UseVisualStyleBackColor = true;
            this.loadbutton.Click += new System.EventHandler(this.loadbutton_Click);
            // 
            // paletteCB
            // 
            this.paletteCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paletteCB.FormattingEnabled = true;
            this.paletteCB.Location = new System.Drawing.Point(12, 95);
            this.paletteCB.Name = "paletteCB";
            this.paletteCB.Size = new System.Drawing.Size(121, 21);
            this.paletteCB.TabIndex = 13;
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(216, 95);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(91, 23);
            this.savebutton.TabIndex = 14;
            this.savebutton.Text = "Save Palette";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // SelectPalette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 534);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.paletteCB);
            this.Controls.Add(this.loadbutton);
            this.Controls.Add(this.regextextbox);
            this.Controls.Add(this.applyregex);
            this.Controls.Add(this.selectnonebutton);
            this.Controls.Add(this.selectallbutton);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.okbutton);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Name = "SelectPalette";
            this.Text = "SelectItemsFromCheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button okbutton;
        private System.Windows.Forms.Button selectallbutton;
        private System.Windows.Forms.Button selectnonebutton;
        private System.Windows.Forms.Button applyregex;
        private System.Windows.Forms.TextBox regextextbox;
        private System.Windows.Forms.Button loadbutton;
        private System.Windows.Forms.ComboBox paletteCB;
        private System.Windows.Forms.Button savebutton;
    }
}