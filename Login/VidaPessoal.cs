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

        private void button6_Click(object sender, EventArgs e)
        {
            Irmaos irmaos = new Irmaos();
            irmaos.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Filhos filho = new Filhos();
            filho.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pai pai = new Pai();
            pai.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mae mae = new Mae();
            mae.ShowDialog();
        }
    }
}
