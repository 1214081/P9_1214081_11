using P9_1214081.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_1214081.controller
{
    internal class Tugas_Praktikum_11
    {
        //Memanggik koneksi
        Koneksi koneksi = new Koneksi();

        //Method insert
        public bool InsertBarang(M_Barang barang)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_barang (nama_barang,harga) VALUES ('" + barang.Nama + "','" + barang.Harga + "')");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
        public bool InsertTransaksi(M_Transaksi transaksi)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_transaksi (id_barang,qty,total) VALUES ('" + transaksi.Id_barang + "','" + transaksi.QTY + "','" + transaksi.Total + "')");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
        //Method update
        public bool UpdateBarang(M_Barang barang, string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE t_barang SET nama_barang='" + barang.Nama + "'," +
                "harga='" + barang.Harga + "' WHERE id_barang='" + id + "'");
                status = true;
                MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
        //Method delete
        public bool DeleteBarang(string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM t_barang WHERE id_barang='" + id + "'");
                status = true;
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
        public bool DeleteTransaksi(string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM t_transaksi WHERE id_transaksi='" + id + "'");
                status = true;
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
