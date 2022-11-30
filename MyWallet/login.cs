using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace MyWallet
{
    public partial class login : Form
    {

        public login()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        bool test;


       private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }


        private void login_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("server=DESKTOP-ASU836R;Initial Catalog=mywallet;Integrated Security=True;TrustServerCertificate=True");
            toolStripStatusLabel2.Text = "Baglanti Basarili!";
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            string user = userText.Text;
            string pass = passText.Text;
            con = new SqlConnection("server=DESKTOP-ASU836R;Initial Catalog=mywallet;Integrated Security=True;TrustServerCertificate=True");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Users where name='" + userText.Text + "' AND pass='" + passText.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız. Anasayfaya Yönlendiriliyorsunuz..");
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
            else
            {
                toolStripStatusLabel2.Text = "Kullanıcı adını ve şifrenizi kontrol ediniz.";
                toolStripStatusLabel2.ForeColor = Color.Red;
            }
            con.Close();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

               

        }
    }
}
