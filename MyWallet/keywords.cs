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
        SqlConnection con = new SqlConnection("server=DESKTOP-ASU836R;Initial Catalog=mywallet;Integrated Security=True;TrustServerCertificate=True");

        private void keywords_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from keyword",con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;

            radioButton1.Checked = true;
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked) { 
            SqlCommand komut = new SqlCommand("select * from keyword where turkce like '"+textBox1.Text+"%'", con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            }
            else
            {
                SqlCommand komut = new SqlCommand("select * from keyword where ingilizce like '" + textBox1.Text + "%'", con);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
