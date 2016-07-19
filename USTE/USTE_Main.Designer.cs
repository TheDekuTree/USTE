namespace NathansProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Save = new System.Windows.Forms.ToolStripButton();
            this.Open = new System.Windows.Forms.ToolStripButton();
            this.openimage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Settings = new System.Windows.Forms.ToolStripButton();
            this.TextColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Program = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save,
            this.Open,
            this.openimage,
            this.toolStripSeparator1,
            this.Settings,
            this.TextColor,
            this.toolStripSeparator2,
            this.Program});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(811, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Save
            // 
            this.Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Save.Image = ((System.Drawing.Image)(resources.GetObject("Save.Image")));
            this.Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(23, 22);
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Open
            // 
            this.Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Open.Image = ((System.Drawing.Image)(resources.GetObject("Open.Image")));
            this.Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(23, 22);
            this.Open.Text = "Open";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // openimage
            // 
            this.openimage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openimage.Image = ((System.Drawing.Image)(resources.GetObject("openimage.Image")));
            this.openimage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openimage.Name = "openimage";
            this.openimage.Size = new System.Drawing.Size(23, 22);
            this.openimage.Text = "Open Image";
            this.openimage.Click += new System.EventHandler(this.openimage_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Settings
            // 
            this.Settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Settings.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            this.Settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(23, 22);
            this.Settings.Text = "Font";
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // TextColor
            // 
            this.TextColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TextColor.Image = ((System.Drawing.Image)(resources.GetObject("TextColor.Image")));
            this.TextColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TextColor.Name = "TextColor";
            this.TextColor.Size = new System.Drawing.Size(23, 22);
            this.TextColor.Text = "TextColor";
            this.TextColor.Click += new System.EventHandler(this.TextColor_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Program
            // 
            this.Program.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Program.Image = ((System.Drawing.Image)(resources.GetObject("Program.Image")));
            this.Program.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Program.Name = "Program";
            this.Program.Size = new System.Drawing.Size(23, 22);
            this.Program.Text = "About";
            this.Program.Click += new System.EventHandler(this.Program_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(728, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Image Viewer";
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Text Editor";
            this.label2.UseMnemonic = false;
            // 
            // TextBox
            // 
            this.TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox.Location = new System.Drawing.Point(3, 32);
            this.TextBox.Name = "TextBox";
            this.TextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.TextBox.Size = new System.Drawing.Size(399, 325);
            this.TextBox.TabIndex = 15;
            this.TextBox.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(408, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 325);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(811, 389);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ultra Small Text Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Save;
        private System.Windows.Forms.ToolStripButton Open;
        private System.Windows.Forms.ToolStripButton Settings;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripButton Program;
        private System.Windows.Forms.ToolStripButton TextColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton openimage;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

