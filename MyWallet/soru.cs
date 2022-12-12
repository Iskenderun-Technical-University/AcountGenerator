using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace MyWallet
{
    public partial class soru : Form
    {
        public soru()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server=DESKTOP-ASU836R;Initial Catalog=mywallet;Integrated Security=True;TrustServerCertificate=True");
        private void soru_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from quest order by NEWID()",baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                textBox1.Text= (oku["soru"].ToString());
                button1.Text = (oku["a"].ToString());
                button2.Text = (oku["b"].ToString());
                button3.Text = (oku["c"].ToString());
                button4.Text = (oku["d"].ToString());
                label2.Text= (oku["dogru"].ToString());
            }
        }
    }
}
