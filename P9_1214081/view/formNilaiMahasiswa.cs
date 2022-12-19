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
    public partial class formNilaiMahasiswa : Form
    {
        Koneksi koneksi = new Koneksi();
        N_Nilai n_nilai = new N_Nilai();
        string id;
        public formNilaiMahasiswa()
        {
            InitializeComponent();
        }
        public void tampil()
        {
            //Query Database
            DataNilai.DataSource = koneksi.ShowData("SELECT id_nilai, matkul, kategori, t_nilai.npm, nama, nilai FROM t_nilai JOIN t_mahasiswa on t_mahasiswa.npm = t_nilai.npm");

            //Mengubah nama header
            DataNilai.Columns[0].HeaderText = "No";
            DataNilai.Columns[1].HeaderText = "Mata Kuliah";
            DataNilai.Columns[2].HeaderText = "Kategori";
            DataNilai.Columns[3].HeaderText = "NPM";
            DataNilai.Columns[4].HeaderText = "Nama";
            DataNilai.Columns[5].HeaderText = "Nilai";
        }

        public void GetDataMhs()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.Reader("SELECT * FROM t_mahasiswa");
            while (reader.Read())
            {
                cbNPM.Items.Add(reader.GetString("npm"));
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        public void GetNamaMhs()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.Reader("SELECT nama FROM t_mahasiswa WHERE npm = '" + cbNPM.Text + "'");
            while (reader.Read())
            {
                tbNama.Text = reader.GetString(0);
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            tampil();
            GetDataMhs();
        }

        private void DataNilai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = DataNilai.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbMatkul.Text = DataNilai.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbKategori.Text = DataNilai.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbNPM.Text = DataNilai.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbNilai.Text = DataNilai.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            cbMatkul.SelectedIndex = -1;
            cbKategori.SelectedIndex = -1;
            cbNPM.SelectedIndex = -1;
            tbNama.Text = "";
            tbNilai.Text = "";


            tampil();
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            if (cbMatkul.SelectedIndex == -1 || cbKategori.SelectedIndex == -1 || cbNPM.SelectedIndex == -1 || tbNilai.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Nilai nilai = new Nilai();
                n_nilai.Matkul = cbMatkul.Text;
                n_nilai.Kategori = cbKategori.Text;
                n_nilai.Npm = cbNPM.Text;
                n_nilai.Nilai = tbNilai.Text;

                nilai.Insert(n_nilai);

                cbMatkul.SelectedIndex = -1;
                cbKategori.SelectedIndex = -1;
                cbMatkul.SelectedIndex = -1;
                cbNPM.SelectedIndex = -1;
                tbNilai.Text = "";
            }
        }

        private void btUbah_Click(object sender, EventArgs e)
        {
            if (cbMatkul.SelectedIndex == -1 || cbKategori.SelectedIndex == -1 || cbNPM.SelectedIndex == -1 || tbNilai.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Nilai nilai = new Nilai();
                n_nilai.Matkul = cbMatkul.Text;
                n_nilai.Kategori = cbKategori.Text;
                n_nilai.Npm = cbNPM.Text;
                n_nilai.Nilai = tbNilai.Text;

                nilai.Update(n_nilai, id);

                cbMatkul.SelectedIndex = -1;
                cbKategori.SelectedIndex = -1;
                cbMatkul.SelectedIndex = -1;
                cbNPM.SelectedIndex = -1;
                tbNilai.Text = "";
            }
        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah anda yakin ingin menghapus data", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Nilai nilai = new Nilai();
                nilai.Delete(id);
            }
        }

        private void tbCari_TextChanged(object sender, EventArgs e)
        {
            DataNilai.DataSource = koneksi.ShowData("SELECT* FROM t_nilai WHERE npm LIKE '%' '" + tbCari.Text + "' '%' OR matkul LIKE '%' '" + tbCari.Text + "' '%' OR kategori LIKE '%' '" + tbCari.Text + "' '%' OR npm LIKE '%' '" + tbCari.Text + "' '%' OR nilai LIKE '%' '" + tbCari.Text + "' '%'");
        }

        private void cbNPM_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetNamaMhs();
        }
    }
}
