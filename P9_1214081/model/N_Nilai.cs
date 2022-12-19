using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_1214081.model
{
    internal class N_Nilai
    {
        string id, matkul, kategori, npm, nilai;
        public N_Nilai()
        {

        }

        public N_Nilai(string id, string makul, string kategori, string npm, string nilai)
        {
            this.Id = id;
            this.Matkul = makul;
            this.Kategori = kategori;
            this.Npm = npm;
            this.Nilai = nilai;
        }

        public string Id { get => id; set => id = value; }
        public string Matkul { get => matkul; set => matkul = value; }
        public string Kategori { get => kategori; set => kategori = value; }
        public string Npm { get => npm; set => npm = value; }
        public string Nilai { get => nilai; set => nilai = value; }
    }
}
