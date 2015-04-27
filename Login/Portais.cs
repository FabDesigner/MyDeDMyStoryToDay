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
    public partial class Portais : Form
    {
        public Portais()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Voce voce = new Voce();
            voce.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VidaPessoal vida = new VidaPessoal();
            vida.ShowDialog();
        }
    }
}
