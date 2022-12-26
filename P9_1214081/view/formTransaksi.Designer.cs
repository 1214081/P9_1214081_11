namespace P9_1214081.view
{
    partial class formTransaksi
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
            this.gbTabelTansaksi = new System.Windows.Forms.GroupBox();
            this.DataTransaksi = new System.Windows.Forms.DataGridView();
            this.gbForm = new System.Windows.Forms.GroupBox();
            this.cbIDBarang = new System.Windows.Forms.ComboBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.lbIDBarang = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.gbPencarian = new System.Windows.Forms.GroupBox();
            this.tbCari = new System.Windows.Forms.TextBox();
            this.lbCariData = new System.Windows.Forms.Label();
            this.gbTombol = new System.Windows.Forms.GroupBox();
            this.btHapus = new System.Windows.Forms.Button();
            this.btUbah = new System.Windows.Forms.Button();
            this.btSimpan = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbNama = new System.Windows.Forms.Label();
            this.tbNamaBarang = new System.Windows.Forms.TextBox();
            this.tbHargaBarang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbTabelTansaksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTransaksi)).BeginInit();
            this.gbForm.SuspendLayout();
            this.gbPencarian.SuspendLayout();
            this.gbTombol.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTabelTansaksi
            // 
            this.gbTabelTansaksi.Controls.Add(this.DataTransaksi);
            this.gbTabelTansaksi.Location = new System.Drawing.Point(13, 12);
            this.gbTabelTansaksi.Name = "gbTabelTansaksi";
            this.gbTabelTansaksi.Size = new System.Drawing.Size(775, 224);
            this.gbTabelTansaksi.TabIndex = 3;
            this.gbTabelTansaksi.TabStop = false;
            this.gbTabelTansaksi.Text = "Tabel Transaksi";
            // 
            // DataTransaksi
            // 
            this.DataTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTransaksi.Location = new System.Drawing.Point(6, 26);
            this.DataTransaksi.Name = "DataTransaksi";
            this.DataTransaksi.Size = new System.Drawing.Size(762, 198);
            this.DataTransaksi.TabIndex = 0;
            this.DataTransaksi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTransaksi_CellClick);
            // 
            // gbForm
            // 
            this.gbForm.Controls.Add(this.label3);
            this.gbForm.Controls.Add(this.tbTotal);
            this.gbForm.Controls.Add(this.groupBox1);
            this.gbForm.Controls.Add(this.tbQuantity);
            this.gbForm.Controls.Add(this.lbIDBarang);
            this.gbForm.Controls.Add(this.lbQuantity);
            this.gbForm.Controls.Add(this.lbTotal);
            this.gbForm.Location = new System.Drawing.Point(13, 242);
            this.gbForm.Name = "gbForm";
            this.gbForm.Size = new System.Drawing.Size(575, 259);
            this.gbForm.TabIndex = 15;
            this.gbForm.TabStop = false;
            this.gbForm.Text = "Form Input Nilai";
            // 
            // cbIDBarang
            // 
            this.cbIDBarang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIDBarang.FormattingEnabled = true;
            this.cbIDBarang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbIDBarang.Location = new System.Drawing.Point(6, 19);
            this.cbIDBarang.Name = "cbIDBarang";
            this.cbIDBarang.Size = new System.Drawing.Size(255, 21);
            this.cbIDBarang.TabIndex = 13;
            this.cbIDBarang.SelectedIndexChanged += new System.EventHandler(this.cbIDBarang_SelectedIndexChanged);
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(124, 110);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(255, 20);
            this.tbQuantity.TabIndex = 7;
            this.tbQuantity.TextChanged += new System.EventHandler(this.tbQuantity_TextChanged);
            // 
            // lbIDBarang
            // 
            this.lbIDBarang.AutoSize = true;
            this.lbIDBarang.Location = new System.Drawing.Point(8, 41);
            this.lbIDBarang.Name = "lbIDBarang";
            this.lbIDBarang.Size = new System.Drawing.Size(55, 13);
            this.lbIDBarang.TabIndex = 2;
            this.lbIDBarang.Text = "ID Barang";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(8, 113);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(46, 13);
            this.lbQuantity.TabIndex = 1;
            this.lbQuantity.Text = "Quantity";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(8, 146);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(31, 13);
            this.lbTotal.TabIndex = 0;
            this.lbTotal.Text = "Total";
            // 
            // gbPencarian
            // 
            this.gbPencarian.Controls.Add(this.tbCari);
            this.gbPencarian.Controls.Add(this.lbCariData);
            this.gbPencarian.Location = new System.Drawing.Point(601, 242);
            this.gbPencarian.Name = "gbPencarian";
            this.gbPencarian.Size = new System.Drawing.Size(187, 76);
            this.gbPencarian.TabIndex = 16;
            this.gbPencarian.TabStop = false;
            this.gbPencarian.Text = "Pencarian";
            // 
            // tbCari
            // 
            this.tbCari.Location = new System.Drawing.Point(74, 29);
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(105, 20);
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
            // gbTombol
            // 
            this.gbTombol.Controls.Add(this.btHapus);
            this.gbTombol.Controls.Add(this.btUbah);
            this.gbTombol.Controls.Add(this.btSimpan);
            this.gbTombol.Controls.Add(this.btRefresh);
            this.gbTombol.Location = new System.Drawing.Point(601, 324);
            this.gbTombol.Name = "gbTombol";
            this.gbTombol.Size = new System.Drawing.Size(194, 177);
            this.gbTombol.TabIndex = 17;
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
            // 
            // btUbah
            // 
            this.btUbah.Location = new System.Drawing.Point(16, 95);
            this.btUbah.Name = "btUbah";
            this.btUbah.Size = new System.Drawing.Size(163, 23);
            this.btUbah.TabIndex = 2;
            this.btUbah.Text = "Ubah";
            this.btUbah.UseVisualStyleBackColor = true;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbHargaBarang);
            this.groupBox1.Controls.Add(this.tbNamaBarang);
            this.groupBox1.Controls.Add(this.lbNama);
            this.groupBox1.Controls.Add(this.cbIDBarang);
            this.groupBox1.Location = new System.Drawing.Point(118, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 85);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.Location = new System.Drawing.Point(3, 43);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(35, 13);
            this.lbNama.TabIndex = 15;
            this.lbNama.Text = "Nama";
            // 
            // tbNamaBarang
            // 
            this.tbNamaBarang.Location = new System.Drawing.Point(6, 59);
            this.tbNamaBarang.Name = "tbNamaBarang";
            this.tbNamaBarang.Size = new System.Drawing.Size(255, 20);
            this.tbNamaBarang.TabIndex = 16;
            // 
            // tbHargaBarang
            // 
            this.tbHargaBarang.Location = new System.Drawing.Point(286, 59);
            this.tbHargaBarang.Name = "tbHargaBarang";
            this.tbHargaBarang.Size = new System.Drawing.Size(167, 20);
            this.tbHargaBarang.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(262, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Rp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Harga Barang";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(124, 143);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(255, 20);
            this.tbTotal.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(99, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Rp";
            // 
            // formTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.gbTombol);
            this.Controls.Add(this.gbPencarian);
            this.Controls.Add(this.gbForm);
            this.Controls.Add(this.gbTabelTansaksi);
            this.Name = "formTransaksi";
            this.Text = "Form Transaksi";
            this.Load += new System.EventHandler(this.formTransaksi_Load);
            this.gbTabelTansaksi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTransaksi)).EndInit();
            this.gbForm.ResumeLayout(false);
            this.gbForm.PerformLayout();
            this.gbPencarian.ResumeLayout(false);
            this.gbPencarian.PerformLayout();
            this.gbTombol.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTabelTansaksi;
        private System.Windows.Forms.DataGridView DataTransaksi;
        private System.Windows.Forms.GroupBox gbForm;
        private System.Windows.Forms.ComboBox cbIDBarang;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label lbIDBarang;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.GroupBox gbPencarian;
        private System.Windows.Forms.TextBox tbCari;
        private System.Windows.Forms.Label lbCariData;
        private System.Windows.Forms.GroupBox gbTombol;
        private System.Windows.Forms.Button btHapus;
        private System.Windows.Forms.Button btUbah;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNamaBarang;
        private System.Windows.Forms.Label lbNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHargaBarang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTotal;
    }
}