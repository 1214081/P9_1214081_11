namespace P9_1214081.view
{
    partial class formDashboard
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
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataMahasiswa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAboutMe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataTransaksi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataNilai = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp,
            this.menuDataTransaksi});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDataMahasiswa,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // menuDataMahasiswa
            // 
            this.menuDataMahasiswa.Name = "menuDataMahasiswa";
            this.menuDataMahasiswa.Size = new System.Drawing.Size(159, 22);
            this.menuDataMahasiswa.Text = "Data Mahasiswa";
            this.menuDataMahasiswa.Click += new System.EventHandler(this.menuDataMahasiswa_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(159, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAboutMe});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "Help";
            // 
            // menuAboutMe
            // 
            this.menuAboutMe.Name = "menuAboutMe";
            this.menuAboutMe.Size = new System.Drawing.Size(127, 22);
            this.menuAboutMe.Text = "About Me";
            this.menuAboutMe.Click += new System.EventHandler(this.menuAboutMe_Click);
            // 
            // menuDataTransaksi
            // 
            this.menuDataTransaksi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDataNilai});
            this.menuDataTransaksi.Name = "menuDataTransaksi";
            this.menuDataTransaksi.Size = new System.Drawing.Size(93, 20);
            this.menuDataTransaksi.Text = "Data Transaksi";
            // 
            // menuDataNilai
            // 
            this.menuDataNilai.Name = "menuDataNilai";
            this.menuDataNilai.Size = new System.Drawing.Size(125, 22);
            this.menuDataNilai.Text = "Data Nilai";
            this.menuDataNilai.Click += new System.EventHandler(this.menuDataNilai_Click_1);
            // 
            // formDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::P9_1214081.Properties.Resources.Background_Dashboard;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formDashboard";
            this.Text = "Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuDataMahasiswa;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuAboutMe;
        private System.Windows.Forms.ToolStripMenuItem menuDataTransaksi;
        private System.Windows.Forms.ToolStripMenuItem menuDataNilai;
    }
}