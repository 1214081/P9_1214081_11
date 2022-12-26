using P9_1214081.controller;
using P9_1214081.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_1214081.view
{
    public partial class formBarang : Form
    {
        Koneksi koneksi = new Koneksi();
        M_Barang m_barang = new M_Barang();
        string id;
        public void tampil()
        {
            //Query Database
            DataBarang.DataSource = koneksi.ShowData("SELECT * FROM t_barang");

            //Mengubah nama header
            DataBarang.Columns[0].HeaderText = "Id";
            DataBarang.Columns[1].HeaderText = "Nama Barang";
            DataBarang.Columns[2].HeaderText = "Harga";
        }
        public formBarang()
        {
            InitializeComponent();
        }

        private void formBarang_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void DataBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNamaBarang.Text = DataBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbHarga.Text = DataBarang.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            tampil();
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            if (tbNamaBarang.Text == "" || tbHarga.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Tugas_Praktikum_11 conroller = new Tugas_Praktikum_11();
                m_barang.Nama = tbNamaBarang.Text;
                m_barang.Harga = tbHarga.Text;

                conroller.InsertBarang(m_barang);

                tbNamaBarang.Text = "";
                tbHarga.Text = "";
            }
        }

        private void btUbah_Click(object sender, EventArgs e)
        {
            if (tbNamaBarang.Text == "" || tbHarga.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Tugas_Praktikum_11 controller = new Tugas_Praktikum_11();
                m_barang.Nama = tbNamaBarang.Text;
                m_barang.Harga = tbHarga.Text;

                controller.UpdateBarang(m_barang, id);

                tbNamaBarang.Text = "";
                tbHarga.Text = "";
            }
        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah anda yakin ingin menghapus data", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Tugas_Praktikum_11 controller = new Tugas_Praktikum_11();
                controller.DeleteBarang(id);
            }
        }
    }
}
