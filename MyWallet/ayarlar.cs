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
    public partial class ayarlar : Form
    {
        public ayarlar()
        {
            InitializeComponent();
        }
        SqlConnection con =new SqlConnection("server=DESKTOP-ASU836R;Initial Catalog=mywallet;Integrated Security=True;TrustServerCertificate=True");


        private void ayarlar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string turkce = textBox1.Text;
            string ing=textBox2.Text;
            SqlCommand komut = new SqlCommand("insert into keyword values ('"+turkce+"','"+ing+"')",con);
            con.Open();
            komut.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kelime basari ile veritabanina eklendi!,","Tebrikler!");
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
