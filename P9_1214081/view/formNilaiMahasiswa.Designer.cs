namespace P9_1214081.view
{
    partial class formNilaiMahasiswa
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
            this.gbTabelNilai = new System.Windows.Forms.GroupBox();
            this.DataNilai = new System.Windows.Forms.DataGridView();
            this.gbTombol = new System.Windows.Forms.GroupBox();
            this.btHapus = new System.Windows.Forms.Button();
            this.btUbah = new System.Windows.Forms.Button();
            this.btSimpan = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.gbPencarian = new System.Windows.Forms.GroupBox();
            this.tbCari = new System.Windows.Forms.TextBox();
            this.lbCariData = new System.Windows.Forms.Label();
            this.gbForm = new System.Windows.Forms.GroupBox();
            this.cbMatkul = new System.Windows.Forms.ComboBox();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.cbNPM = new System.Windows.Forms.ComboBox();
            this.tbNilai = new System.Windows.Forms.TextBox();
            this.lbNilai = new System.Windows.Forms.Label();
            this.lbMatkul = new System.Windows.Forms.Label();
            this.lbKategori = new System.Windows.Forms.Label();
            this.lbNPM = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.gbTabelNilai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataNilai)).BeginInit();
            this.gbTombol.SuspendLayout();
            this.gbPencarian.SuspendLayout();
            this.gbForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTabelNilai
            // 
            this.gbTabelNilai.Controls.Add(this.DataNilai);
            this.gbTabelNilai.Location = new System.Drawing.Point(12, 12);
            this.gbTabelNilai.Name = "gbTabelNilai";
            this.gbTabelNilai.Size = new System.Drawing.Size(775, 224);
            this.gbTabelNilai.TabIndex = 2;
            this.gbTabelNilai.TabStop = false;
            this.gbTabelNilai.Text = "Tabel Nilai Mahasiswa";
            // 
            // DataNilai
            // 
            this.DataNilai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataNilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataNilai.Location = new System.Drawing.Point(6, 26);
            this.DataNilai.Name = "DataNilai";
            this.DataNilai.Size = new System.Drawing.Size(762, 198);
            this.DataNilai.TabIndex = 0;
            this.DataNilai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataNilai_CellClick);
            // 
            // gbTombol
            // 
            this.gbTombol.Controls.Add(this.btHapus);
            this.gbTombol.Controls.Add(this.btUbah);
            this.gbTombol.Controls.Add(this.btSimpan);
            this.gbTombol.Controls.Add(this.btRefresh);
            this.gbTombol.Location = new System.Drawing.Point(593, 346);
            this.gbTombol.Name = "gbTombol";
            this.gbTombol.Size = new System.Drawing.Size(194, 177);
            this.gbTombol.TabIndex = 16;
            this.gbTombol.TabStop = false;
            this.gbTombol.Text = "Tombol Action";
            // 
            // btHapus
            // 
            this.btHapus.Location = new System.Drawing.Point(16, 132);
            this.btHapus.Name = "btHapus";
            this.btHapus.Size = new System.Drawing.Size(163, 23);
            this.btHapus.TabIndex = 3;
            this.btHapus.Text = "Hapus";
            this.btHapus.UseVisualStyleBackColor = true;
            this.btHapus.Click += new System.EventHandler(this.btHapus_Click);
            // 
            // btUbah
            // 
            this.btUbah.Location = new System.Drawing.Point(16, 95);
            this.btUbah.Name = "btUbah";
            this.btUbah.Size = new System.Drawing.Size(163, 23);
            this.btUbah.TabIndex = 2;
            this.btUbah.Text = "Ubah";
            this.btUbah.UseVisualStyleBackColor = true;
            this.btUbah.Click += new System.EventHandler(this.btUbah_Click);
            // 
            // btSimpan
            // 
            this.btSimpan.Location = new System.Drawing.Point(16, 58);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(163, 23);
            this.btSimpan.TabIndex = 1;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseVisualStyleBackColor = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(16, 21);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(163, 23);
            this.btRefresh.TabIndex = 0;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // gbPencarian
            // 
            this.gbPencarian.Controls.Add(this.tbCari);
            this.gbPencarian.Controls.Add(this.lbCariData);
            this.gbPencarian.Location = new System.Drawing.Point(593, 256);
            this.gbPencarian.Name = "gbPencarian";
            this.gbPencarian.Size = new System.Drawing.Size(187, 76);
            this.gbPencarian.TabIndex = 15;
            this.gbPencarian.TabStop = false;
            this.gbPencarian.Text = "Pencarian";
            // 
            // tbCari
            // 
            this.tbCari.Location = new System.Drawing.Point(74, 29);
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(105, 20);
            this.tbCari.TabIndex = 1;
            this.tbCari.TextChanged += new System.EventHandler(this.tbCari_TextChanged);
            // 
            // lbCariData
            // 
            this.lbCariData.AutoSize = true;
            this.lbCariData.Location = new System.Drawing.Point(7, 32);
            this.lbCariData.Name = "lbCariData";
            this.lbCariData.Size = new System.Drawing.Size(51, 13);
            this.lbCariData.TabIndex = 0;
            this.lbCariData.Text = "Cari Data";
            // 
            // gbForm
            // 
            this.gbForm.Controls.Add(this.tbNama);
            this.gbForm.Controls.Add(this.cbMatkul);
            this.gbForm.Controls.Add(this.cbKategori);
            this.gbForm.Controls.Add(this.cbNPM);
            this.gbForm.Controls.Add(this.tbNilai);
            this.gbForm.Controls.Add(this.lbNilai);
            this.gbForm.Controls.Add(this.lbMatkul);
            this.gbForm.Controls.Add(this.lbKategori);
            this.gbForm.Controls.Add(this.lbNPM);
            this.gbForm.Location = new System.Drawing.Point(12, 253);
            this.gbForm.Name = "gbForm";
            this.gbForm.Size = new System.Drawing.Size(575, 164);
            this.gbForm.TabIndex = 14;
            this.gbForm.TabStop = false;
            this.gbForm.Text = "Form Input Nilai";
            // 
            // cbMatkul
            // 
            this.cbMatkul.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMatkul.FormattingEnabled = true;
            this.cbMatkul.Items.AddRange(new object[] {
            "Bahasa Indonesia",
            "Bahasa Inggris",
            "Pemrograman II",
            "General English I",
            "PKN"});
            this.cbMatkul.Location = new System.Drawing.Point(116, 25);
            this.cbMatkul.Name = "cbMatkul";
            this.cbMatkul.Size = new System.Drawing.Size(280, 21);
            this.cbMatkul.TabIndex = 13;
            // 
            // cbKategori
            // 
            this.cbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Items.AddRange(new object[] {
            "UTS",
            "UAS"});
            this.cbKategori.Location = new System.Drawing.Point(116, 59);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(280, 21);
            this.cbKategori.TabIndex = 12;
            // 
            // cbNPM
            // 
            this.cbNPM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNPM.FormattingEnabled = true;
            this.cbNPM.Items.AddRange(new object[] {
            "1214001",
            "1214002",
            "1214003",
            "1214081"});
            this.cbNPM.Location = new System.Drawing.Point(116, 93);
            this.cbNPM.Name = "cbNPM";
            this.cbNPM.Size = new System.Drawing.Size(280, 21);
            this.cbNPM.TabIndex = 11;
            this.cbNPM.SelectedIndexChanged += new System.EventHandler(this.cbNPM_SelectedIndexChanged);
            // 
            // tbNilai
            // 
            this.tbNilai.Location = new System.Drawing.Point(116, 127);
            this.tbNilai.Name = "tbNilai";
            this.tbNilai.Size = new System.Drawing.Size(280, 20);
            this.tbNilai.TabIndex = 7;
            // 
            // lbNilai
            // 
            this.lbNilai.AutoSize = true;
            this.lbNilai.Location = new System.Drawing.Point(6, 130);
            this.lbNilai.Name = "lbNilai";
            this.lbNilai.Size = new System.Drawing.Size(27, 13);
            this.lbNilai.TabIndex = 3;
            this.lbNilai.Text = "Nilai";
            // 
            // lbMatkul
            // 
            this.lbMatkul.AutoSize = true;
            this.lbMatkul.Location = new System.Drawing.Point(6, 28);
            this.lbMatkul.Name = "lbMatkul";
            this.lbMatkul.Size = new System.Drawing.Size(39, 13);
            this.lbMatkul.TabIndex = 2;
            this.lbMatkul.Text = "Matkul";
            // 
            // lbKategori
            // 
            this.lbKategori.AutoSize = true;
            this.lbKategori.Location = new System.Drawing.Point(6, 62);
            this.lbKategori.Name = "lbKategori";
            this.lbKategori.Size = new System.Drawing.Size(46, 13);
            this.lbKategori.TabIndex = 1;
            this.lbKategori.Text = "Kategori";
            // 
            // lbNPM
            // 
            this.lbNPM.AutoSize = true;
            this.lbNPM.Location = new System.Drawing.Point(6, 96);
            this.lbNPM.Name = "lbNPM";
            this.lbNPM.Size = new System.Drawing.Size(31, 13);
            this.lbNPM.TabIndex = 0;
            this.lbNPM.Text = "NPM";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(402, 93);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(167, 20);
            this.tbNama.TabIndex = 14;
            // 
            // formNilaiMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.gbTombol);
            this.Controls.Add(this.gbTabelNilai);
            this.Controls.Add(this.gbPencarian);
            this.Controls.Add(this.gbForm);
            this.Name = "formNilaiMahasiswa";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.gbTabelNilai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataNilai)).EndInit();
            this.gbTombol.ResumeLayout(false);
            this.gbPencarian.ResumeLayout(false);
            this.gbPencarian.PerformLayout();
            this.gbForm.ResumeLayout(false);
            this.gbForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTabelNilai;
        private System.Windows.Forms.DataGridView DataNilai;
        private System.Windows.Forms.GroupBox gbTombol;
        private System.Windows.Forms.Button btHapus;
        private System.Windows.Forms.Button btUbah;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.GroupBox gbPencarian;
        private System.Windows.Forms.TextBox tbCari;
        private System.Windows.Forms.Label lbCariData;
        private System.Windows.Forms.GroupBox gbForm;
        private System.Windows.Forms.ComboBox cbNPM;
        private System.Windows.Forms.TextBox tbNilai;
        private System.Windows.Forms.Label lbNilai;
        private System.Windows.Forms.Label lbMatkul;
        private System.Windows.Forms.Label lbKategori;
        private System.Windows.Forms.Label lbNPM;
        private System.Windows.Forms.ComboBox cbMatkul;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.TextBox tbNama;
    }
}