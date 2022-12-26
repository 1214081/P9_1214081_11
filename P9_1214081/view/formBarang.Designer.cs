namespace P9_1214081.view
{
    partial class formBarang
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
            this.gbTabelBarang = new System.Windows.Forms.GroupBox();
            this.DataBarang = new System.Windows.Forms.DataGridView();
            this.gbForm = new System.Windows.Forms.GroupBox();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.tbNamaBarang = new System.Windows.Forms.TextBox();
            this.lbHarga = new System.Windows.Forms.Label();
            this.lbNamaBarang = new System.Windows.Forms.Label();
            this.gbTombol = new System.Windows.Forms.GroupBox();
            this.btHapus = new System.Windows.Forms.Button();
            this.btUbah = new System.Windows.Forms.Button();
            this.btSimpan = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.gbPencarian = new System.Windows.Forms.GroupBox();
            this.tbCari = new System.Windows.Forms.TextBox();
            this.lbCariData = new System.Windows.Forms.Label();
            this.gbTabelBarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataBarang)).BeginInit();
            this.gbForm.SuspendLayout();
            this.gbTombol.SuspendLayout();
            this.gbPencarian.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTabelBarang
            // 
            this.gbTabelBarang.Controls.Add(this.DataBarang);
            this.gbTabelBarang.Location = new System.Drawing.Point(12, 12);
            this.gbTabelBarang.Name = "gbTabelBarang";
            this.gbTabelBarang.Size = new System.Drawing.Size(775, 224);
            this.gbTabelBarang.TabIndex = 2;
            this.gbTabelBarang.TabStop = false;
            this.gbTabelBarang.Text = "Tabel Barang";
            // 
            // DataBarang
            // 
            this.DataBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBarang.Location = new System.Drawing.Point(6, 26);
            this.DataBarang.Name = "DataBarang";
            this.DataBarang.Size = new System.Drawing.Size(762, 198);
            this.DataBarang.TabIndex = 0;
            this.DataBarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataBarang_CellClick);
            // 
            // gbForm
            // 
            this.gbForm.Controls.Add(this.tbHarga);
            this.gbForm.Controls.Add(this.tbNamaBarang);
            this.gbForm.Controls.Add(this.lbHarga);
            this.gbForm.Controls.Add(this.lbNamaBarang);
            this.gbForm.Location = new System.Drawing.Point(12, 253);
            this.gbForm.Name = "gbForm";
            this.gbForm.Size = new System.Drawing.Size(471, 97);
            this.gbForm.TabIndex = 6;
            this.gbForm.TabStop = false;
            this.gbForm.Text = "Form Input Barang";
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(116, 59);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(280, 20);
            this.tbHarga.TabIndex = 7;
            // 
            // tbNamaBarang
            // 
            this.tbNamaBarang.Location = new System.Drawing.Point(116, 25);
            this.tbNamaBarang.Name = "tbNamaBarang";
            this.tbNamaBarang.Size = new System.Drawing.Size(280, 20);
            this.tbNamaBarang.TabIndex = 6;
            // 
            // lbHarga
            // 
            this.lbHarga.AutoSize = true;
            this.lbHarga.Location = new System.Drawing.Point(6, 62);
            this.lbHarga.Name = "lbHarga";
            this.lbHarga.Size = new System.Drawing.Size(36, 13);
            this.lbHarga.TabIndex = 1;
            this.lbHarga.Text = "Harga";
            // 
            // lbNamaBarang
            // 
            this.lbNamaBarang.AutoSize = true;
            this.lbNamaBarang.Location = new System.Drawing.Point(6, 28);
            this.lbNamaBarang.Name = "lbNamaBarang";
            this.lbNamaBarang.Size = new System.Drawing.Size(72, 13);
            this.lbNamaBarang.TabIndex = 0;
            this.lbNamaBarang.Text = "Nama Barang";
            // 
            // gbTombol
            // 
            this.gbTombol.Controls.Add(this.btHapus);
            this.gbTombol.Controls.Add(this.btUbah);
            this.gbTombol.Controls.Add(this.btSimpan);
            this.gbTombol.Controls.Add(this.btRefresh);
            this.gbTombol.Location = new System.Drawing.Point(516, 253);
            this.gbTombol.Name = "gbTombol";
            this.gbTombol.Size = new System.Drawing.Size(271, 177);
            this.gbTombol.TabIndex = 14;
            this.gbTombol.TabStop = false;
            this.gbTombol.Text = "Tombol Action";
            // 
            // btHapus
            // 
            this.btHapus.Location = new System.Drawing.Point(6, 139);
            this.btHapus.Name = "btHapus";
            this.btHapus.Size = new System.Drawing.Size(252, 23);
            this.btHapus.TabIndex = 3;
            this.btHapus.Text = "Hapus";
            this.btHapus.UseVisualStyleBackColor = true;
            this.btHapus.Click += new System.EventHandler(this.btHapus_Click);
            // 
            // btUbah
            // 
            this.btUbah.Location = new System.Drawing.Point(6, 102);
            this.btUbah.Name = "btUbah";
            this.btUbah.Size = new System.Drawing.Size(252, 23);
            this.btUbah.TabIndex = 2;
            this.btUbah.Text = "Ubah";
            this.btUbah.UseVisualStyleBackColor = true;
            this.btUbah.Click += new System.EventHandler(this.btUbah_Click);
            // 
            // btSimpan
            // 
            this.btSimpan.Location = new System.Drawing.Point(6, 65);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(252, 23);
            this.btSimpan.TabIndex = 1;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseVisualStyleBackColor = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(6, 28);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(252, 23);
            this.btRefresh.TabIndex = 0;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // gbPencarian
            // 
            this.gbPencarian.Controls.Add(this.tbCari);
            this.gbPencarian.Controls.Add(this.lbCariData);
            this.gbPencarian.Location = new System.Drawing.Point(12, 356);
            this.gbPencarian.Name = "gbPencarian";
            this.gbPencarian.Size = new System.Drawing.Size(471, 76);
            this.gbPencarian.TabIndex = 7;
            this.gbPencarian.TabStop = false;
            this.gbPencarian.Text = "Pencarian";
            // 
            // tbCari
            // 
            this.tbCari.Location = new System.Drawing.Point(116, 29);
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(280, 20);
            this.tbCari.TabIndex = 1;
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
            // formBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.gbPencarian);
            this.Controls.Add(this.gbTombol);
            this.Controls.Add(this.gbForm);
            this.Controls.Add(this.gbTabelBarang);
            this.Name = "formBarang";
            this.Text = "Form Transaksi";
            this.Load += new System.EventHandler(this.formBarang_Load);
            this.gbTabelBarang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataBarang)).EndInit();
            this.gbForm.ResumeLayout(false);
            this.gbForm.PerformLayout();
            this.gbTombol.ResumeLayout(false);
            this.gbPencarian.ResumeLayout(false);
            this.gbPencarian.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTabelBarang;
        private System.Windows.Forms.DataGridView DataBarang;
        private System.Windows.Forms.GroupBox gbForm;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.TextBox tbNamaBarang;
        private System.Windows.Forms.Label lbHarga;
        private System.Windows.Forms.Label lbNamaBarang;
        private System.Windows.Forms.GroupBox gbTombol;
        private System.Windows.Forms.Button btHapus;
        private System.Windows.Forms.Button btUbah;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.GroupBox gbPencarian;
        private System.Windows.Forms.TextBox tbCari;
        private System.Windows.Forms.Label lbCariData;
    }
}