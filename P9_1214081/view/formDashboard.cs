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
    public partial class formDashboard : Form
    {
        public formDashboard()
        {
            InitializeComponent();
        }

        private void menuDataMahasiswa_Click(object sender, EventArgs e)
        {
            formDataMahasiswa form1 = new formDataMahasiswa();
            form1.MdiParent = this;
            form1.Show();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuAboutMe_Click(object sender, EventArgs e)
        {
            formAboutMe form4 = new formAboutMe();
            form4.MdiParent = this;
            form4.Show();
        }

        private void menuDataNilai_Click(object sender, EventArgs e)
        {
            
        }

        private void menuDataNilai_Click_1(object sender, EventArgs e)
        {
            formNilaiMahasiswa form5 = new formNilaiMahasiswa();
            form5.MdiParent = this;
            form5.Show();
        }
    }
}
