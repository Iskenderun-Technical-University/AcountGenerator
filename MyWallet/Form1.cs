using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Data.SqlClient;

namespace MyWallet
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
      
            IblTitle.Text = "Anasayfa";
            this.PnlFormLoader.Controls.Clear();
            Form2 f2 = new Form2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            f2.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(f2);
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            IblTitle.Text = "Kelime Ara";
            this.PnlFormLoader.Controls.Clear();
            keywords f3 = new keywords() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            f3.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(f3);
            f3.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con = new SqlConnection("server=DESKTOP-ASU836R;Initial Catalog=mywallet;Integrated Security=True;TrustServerCertificate=True");
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            

            IblTitle.Text = "Anasayfa";
            this.PnlFormLoader.Controls.Clear();
            Form2 f2 = new Form2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            f2.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(f2);
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            IblTitle.Text = "Kelime Ekle";
            this.PnlFormLoader.Controls.Clear();
            ayarlar f3 = new ayarlar() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            f3.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(f3);
            f3.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            IblTitle.Text = "Derslerim";
            this.PnlFormLoader.Controls.Clear();
            shop f5 = new shop() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            f5.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(f5);
            f5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }
    }
}
