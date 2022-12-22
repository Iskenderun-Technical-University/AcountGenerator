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

        private void button1_Click(object sender, EventArgs e)
        {
            string turkce = textBox1.Text; // string verilerimizi tutması için değer tanımladık
            string ing=textBox2.Text;
            SqlCommand komut = new SqlCommand("insert into keyword values ('"+turkce+"','"+ing+"')",con);  // veri tabanındaki sütunlara gittik ve textboxlara gelen verileri istenilen sütunlara kaydettirdik.
            con.Open(); // bağlantıyı açtık
            komut.ExecuteNonQuery(); // komutumuzu çalıştıralım..
            con.Close(); // bağlantıyı kapattık
            MessageBox.Show("Kelime basari ile eklendi!,","Tebrikler!");// işlem başarılı olunca mesaj ver.
            textBox1.Text = ""; // ilk başta textboxun içi boş olsun.
            textBox2.Text = "";
        }
    }
}
