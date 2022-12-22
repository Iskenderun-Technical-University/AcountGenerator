using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

using System.Net.NetworkInformation;
using System.Net;
using System.Threading;
using System.Text.RegularExpressions;

namespace MyWallet
{


    public partial class shop : Form
    {

   
        public shop()
        {
            InitializeComponent();
        }
        private async Task initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }
        public async void InitBrowser()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://www.youtube.com/playlist?list=PLaFgx6R3JNMaXIfWNfgVIiRgm83Qtjzip");
        }

        private void shop_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
