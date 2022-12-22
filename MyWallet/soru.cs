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
        int sayac = 0; // soru sayıları için yerel sayaç değişkenimizi oluşturduk
        int puan = 0; // yerel puan değişkenimizi oluşturduk


        private void soru_Load(object sender, EventArgs e)
        {
            lblSayac.Text = sayac.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            sayac++;
            lblSayac.Text= sayac.ToString();
            button5.Text = "Sonraki";

                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from quest order by NEWID()", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read()) // veri tabanındaki verileri araçlarımıza çektirelim
                {
                    textBox1.Text = (oku["soru"].ToString());
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    lblSonuc.Text = (oku["dogru"].ToString());
                }
              
                baglanti.Close();
            if(puan ==60) // 60 puan şartına ulaşırsa
            {
                button5.Text = "Oyun Bitti"; // butona Oyun Bitti Yazar.
                button5.Enabled = false; // butonun kullanılabilirliğini false ettik çünkü oyun bitti.
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text==lblSonuc.Text)
            {
                puan = puan + 10;
                lblPuan.Text=puan.ToString();
                MessageBox.Show("Doğru Cevap,İlerleyiniz.");
            }
            else
            {
                MessageBox.Show("Bu seçim yanlıştı,bir sonraki soruya geçiniz.");
            }
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == lblSonuc.Text)
            {
                puan = puan + 10;
                lblPuan.Text = puan.ToString();
                MessageBox.Show("Doğru Cevap,İlerleyiniz.");
            }
            else
            {
                MessageBox.Show("Bu seçim yanlıştı,bir sonraki soruya geçiniz.");
            }
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == lblSonuc.Text)
            {
                puan = puan + 10;
                lblPuan.Text = puan.ToString();
                MessageBox.Show("Doğru Cevap,İlerleyiniz.");
            }
            else
            {
                MessageBox.Show("Bu seçim yanlıştı,bir sonraki soruya geçiniz.");
            }
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == lblSonuc.Text)
            {
                puan = puan + 10;
                lblPuan.Text = puan.ToString();
                MessageBox.Show("Doğru Cevap,İlerleyiniz.");
            }
            else
            {
                MessageBox.Show("Bu seçim yanlıştı,bir sonraki soruya geçiniz.");
            }
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

    }
}
