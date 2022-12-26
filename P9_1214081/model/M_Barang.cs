using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_1214081.model
{
    internal class M_Barang
    {
        string id, nama_barang, harga;
        public M_Barang()
        {

        }

        public M_Barang(string id, string nama_barang, string harga)
        {
            this.Id = id;
            this.Nama = nama_barang;
            this.Harga = harga;
        }

        public string Id { get => id; set => id = value; }
        public string Nama { get => nama_barang; set => nama_barang = value; }
        public string Harga { get => harga; set => harga = value; }
    }
}
