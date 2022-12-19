using MySql.Data.MySqlClient;
using P9_1214081.controller;
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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }
        
        string connectionString = "datasource=127.0.0.1;username=root;password=;database=ulbi;";
        public void login()
        {
            string query = "SELECT * FROM user WHERE username='" + tbUsername.Text + "' AND password='" + tbPassword.Text + "'";
            // Prepare the connection
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;


            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        formDashboard form3 = new formDashboard();
                        form3.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Username dan password tidak valid");
                }
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Username dan Password tidak boleh kosong !!!!");
            }
            else
            {
                string username = tbUsername.Text;
                string password = tbPassword.Text;
                Cek_Login login = new Cek_Login();

                bool status = login.cekLogin(username, password);
                if (status)
                {
                    MessageBox.Show("Login Berhasil", "Berhasil");
                    formDashboard form3 = new formDashboard();
                    form3.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Gagal Login", "Gagal");
                }
            }
        }
    }
}
