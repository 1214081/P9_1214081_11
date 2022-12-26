using MySql.Data.MySqlClient;
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
    public partial class formTransaksi : Form
    {
        Koneksi koneksi = new Koneksi();
        M_Transaksi m_transaksi = new M_Transaksi();
        M_Barang m_barang = new M_Barang();
        string id;
        public void tampil()
        {

            DataTransaksi.DataSource = koneksi.ShowData("SELECT " + " id_transaksi, t_transaksi.id_barang, nama_barang, harga, qty, total " +
                "FROM t_transaksi JOIN t_barang ON t_barang.id_barang = t_transaksi.id_barang");

            DataTransaksi.Columns[0].HeaderText = "ID";
            DataTransaksi.Columns[1].HeaderText = "ID Barang";
            DataTransaksi.Columns[2].HeaderText = "NamaBarang";
            DataTransaksi.Columns[3].HeaderText = "Harga";
            DataTransaksi.Columns[4].HeaderText = "Qty";
            DataTransaksi.Columns[5].HeaderText = "Total Harga";

        }
        public formTransaksi()
        {
            InitializeComponent();
        }
        public void GetDataBarang()
        {
            //ambil data ID Barang dari table (t_barang) untuk mengisi data pada combobox ID Barang
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.Reader("SELECT * FROM t_barang");
            while (reader.Read())
            {
                cbIDBarang.Items.Add(reader.GetString("id_barang"));
            }
            reader.Close();
            koneksi.CloseConnection();
        }
        private void formTransaksi_Load(object sender, EventArgs e)
        {
            tampil();
            GetDataBarang();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            tampil();
            GetDataBarang();
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            if (cbIDBarang.SelectedIndex == -1 || tbNamaBarang.Text == "" || tbHargaBarang.Text == "" || tbQuantity.Text == "" || tbTotal.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Tugas_Praktikum_11 controller = new Tugas_Praktikum_11();
                m_transaksi.Id_barang = cbIDBarang.Text;
                m_barang.Nama = tbNamaBarang.Text;
                m_barang.Harga = tbHargaBarang.Text;
                m_transaksi.QTY = tbQuantity.Text;
                m_transaksi.Total = tbTotal.Text;


                controller.InsertTransaksi(m_transaksi);

                cbIDBarang.SelectedIndex = -1;
                tbNamaBarang.Text = "";
                tbHargaBarang.Text = "";
                tbQuantity.Text = "";
                tbTotal.Text = "";
            }
        }

        private void DataTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = DataTransaksi.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbIDBarang.Text = DataTransaksi.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbNamaBarang.Text = DataTransaksi.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbHargaBarang.Text = DataTransaksi.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbQuantity.Text = DataTransaksi.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbTotal.Text = DataTransaksi.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
        public void GetNamaBrg()
        {
            //ambil data Nama Barang ketika combobox ID Barang dipilih
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.Reader("SELECT nama_barang FROM t_barang " + "WHERE id_barang = '" + cbIDBarang.Text + "'");
            while (reader.Read())
            {
                tbNamaBarang.Text = reader.GetString(0);
            }
            reader.Close();
            koneksi.CloseConnection();
        }
        public void GetHargaBrg()
        {
            //ambil data Harga Barang ketikan combobox ID Barang dipilih
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.Reader("SELECT harga FROM t_barang " + "WHERE id_barang = '" + cbIDBarang.Text + "'");
            while (reader.Read())
            {
                tbHargaBarang.Text = reader.GetString(0);
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        private void cbIDBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetNamaBrg();
            GetHargaBrg();
        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbTotal.Text = (float.Parse(tbHargaBarang.Text) * float.Parse(tbQuantity.Text)).ToString();
            }
            catch
            {

            }
        }
    }
}
