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
    public partial class VidaPessoal : Form
    {
        public VidaPessoal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profissao profissao = new Profissao();
            profissao.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conjuge conjuge = new Conjuge();
            conjuge.ShowDialog();
        }
    }
}
