namespace Final_project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.melumatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arazAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.əyləncəToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atYarisiOyunuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musiqiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edvHesablamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kalkulyatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.melumatToolStripMenuItem,
            this.əyləncəToolStripMenuItem,
            this.maToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(886, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // melumatToolStripMenuItem
            // 
            this.melumatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arazAppToolStripMenuItem});
            this.melumatToolStripMenuItem.Font = new System.Drawing.Font("Ravie", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.melumatToolStripMenuItem.Name = "melumatToolStripMenuItem";
            this.melumatToolStripMenuItem.Size = new System.Drawing.Size(110, 31);
            this.melumatToolStripMenuItem.Text = "Market";
            this.melumatToolStripMenuItem.Click += new System.EventHandler(this.melumatToolStripMenuItem_Click);
            // 
            // arazAppToolStripMenuItem
            // 
            this.arazAppToolStripMenuItem.Name = "arazAppToolStripMenuItem";
            this.arazAppToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.arazAppToolStripMenuItem.Text = "Ailə Market";
            this.arazAppToolStripMenuItem.Click += new System.EventHandler(this.arazAppToolStripMenuItem_Click);
            // 
            // əyləncəToolStripMenuItem
            // 
            this.əyləncəToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atYarisiOyunuToolStripMenuItem,
            this.musiqiToolStripMenuItem});
            this.əyləncəToolStripMenuItem.Font = new System.Drawing.Font("Script MT Bold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.əyləncəToolStripMenuItem.Name = "əyləncəToolStripMenuItem";
            this.əyləncəToolStripMenuItem.Size = new System.Drawing.Size(78, 31);
            this.əyləncəToolStripMenuItem.Text = "Əyləncə";
            // 
            // atYarisiOyunuToolStripMenuItem
            // 
            this.atYarisiOyunuToolStripMenuItem.Name = "atYarisiOyunuToolStripMenuItem";
            this.atYarisiOyunuToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.atYarisiOyunuToolStripMenuItem.Text = "At Yarisi Oyunu";
            this.atYarisiOyunuToolStripMenuItem.Click += new System.EventHandler(this.atYarisiOyunuToolStripMenuItem_Click);
            // 
            // musiqiToolStripMenuItem
            // 
            this.musiqiToolStripMenuItem.Name = "musiqiToolStripMenuItem";
            this.musiqiToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.musiqiToolStripMenuItem.Text = "Musiqi";
            this.musiqiToolStripMenuItem.Click += new System.EventHandler(this.musiqiToolStripMenuItem_Click);
            // 
            // maToolStripMenuItem
            // 
            this.maToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edvHesablamaToolStripMenuItem,
            this.kalkulyatorToolStripMenuItem});
            this.maToolStripMenuItem.Font = new System.Drawing.Font("Urdu Typesetting", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.maToolStripMenuItem.Name = "maToolStripMenuItem";
            this.maToolStripMenuItem.Size = new System.Drawing.Size(76, 31);
            this.maToolStripMenuItem.Text = "Maliyye";
            this.maToolStripMenuItem.Click += new System.EventHandler(this.maToolStripMenuItem_Click);
            // 
            // edvHesablamaToolStripMenuItem
            // 
            this.edvHesablamaToolStripMenuItem.Name = "edvHesablamaToolStripMenuItem";
            this.edvHesablamaToolStripMenuItem.Size = new System.Drawing.Size(193, 32);
            this.edvHesablamaToolStripMenuItem.Text = "Edv Hesablama";
            this.edvHesablamaToolStripMenuItem.Click += new System.EventHandler(this.edvHesablamaToolStripMenuItem_Click);
            // 
            // kalkulyatorToolStripMenuItem
            // 
            this.kalkulyatorToolStripMenuItem.Name = "kalkulyatorToolStripMenuItem";
            this.kalkulyatorToolStripMenuItem.Size = new System.Drawing.Size(193, 32);
            this.kalkulyatorToolStripMenuItem.Text = "Kalkulyator";
            this.kalkulyatorToolStripMenuItem.Click += new System.EventHandler(this.kalkulyatorToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(445, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(439, 374);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Unispace", 25.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 233);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aile Markete Xos Geldiniz.Sizi Burada Gormek Xos Oldu.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 376);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "HomePage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem melumatToolStripMenuItem;
        private ToolStripMenuItem əyləncəToolStripMenuItem;
        private ToolStripMenuItem atYarisiOyunuToolStripMenuItem;
        private ToolStripMenuItem maToolStripMenuItem;
        private ToolStripMenuItem arazAppToolStripMenuItem;
        private PictureBox pictureBox1;
        private Label label1;
        private ToolStripMenuItem musiqiToolStripMenuItem;
        private ToolStripMenuItem edvHesablamaToolStripMenuItem;
        private ToolStripMenuItem kalkulyatorToolStripMenuItem;
    }
}