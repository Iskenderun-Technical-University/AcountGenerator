using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWallet
{
    public partial class keywords : Form
    {
        public keywords()
        {
            InitializeComponent();
        }
        // Veri Tabanımıza Bağlandık
        SqlConnection con = new SqlConnection("server=DESKTOP-ASU836R;Initial Catalog=mywallet;Integrated Security=True;TrustServerCertificate=True");

        private void keywords_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from keyword",con); // keyword de komut verip verilere ulaşalım.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();   // Sanal bir DataTable Oluşturduk
            da.Fill(tablo); //keyword içindeki verileri  DataTablemize çektik
            dataGridView1.DataSource = tablo; // veri tablosuna çektiğimiz verileri datagridView e yazdırdık.

            radioButton1.Checked = true;
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked) { // Eğer radiobuton 1 seçiliyse
            SqlCommand komut = new SqlCommand("select * from keyword where turkce like '"+textBox1.Text+"%'", con); //veri tabanındaki keyword verisinin içindeki turkce sutununu textboxa çektirdik. 
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo; // veri tablosuna çektiğimiz verileri datagridView e yazdırdık.

            }
            else
            {
                SqlCommand komut = new SqlCommand("select * from keyword where ingilizce like '" + textBox1.Text + "%'", con); // veri tabanındaki keyword verisinin içindeki turkce sutununu textboxa çektirdik. 
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo; // veri tablosuna çektiğimiz verileri datagridView e yazdırdık.
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
