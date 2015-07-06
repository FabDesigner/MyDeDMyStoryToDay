using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class wbMyDeDNav : Form
    {
        public wbMyDeDNav()
        {
            InitializeComponent();
        }

        private void picGlobo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.globo.com");
            textBox1.Text = "www.globo.com";
        }

        private void picFace_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.faceboo.com");
            textBox1.Text = "www.facebook.com";
        }

        private void picMsn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.msn.com.br");
            textBox1.Text = "www.msn.com.br";
        }

        private void picYahoo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.yahoo.com.br");
            textBox1.Text = "www.yahoo.com.br";
        }

        private void picYouTube_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.youtube.com.br");
            textBox1.Text = "www.youtube.com";
        }

        private void picIr_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void picAtualizar_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
    }
}
