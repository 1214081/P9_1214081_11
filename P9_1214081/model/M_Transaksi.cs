using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_1214081.model
{
    internal class M_Transaksi
    {
        string id_barang, qty, total;
        public M_Transaksi()
        {

        }

        public M_Transaksi(string id_barang, string qty, string total)
        {
            this.Id_barang = id_barang;
            this.QTY = qty;
            this.Total = total;
        }

        public string Id_barang { get => id_barang; set => id_barang = value; }
        public string QTY { get => qty; set => qty = value; }
        public string Total { get => total; set => total = value; }
    }
}
