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
    public partial class Patrao : Form
    {
        public Patrao()
        {
            InitializeComponent();
        }

        private void btnColega_Click(object sender, EventArgs e)
        {
            Colega colega = new Colega();
            colega.ShowDialog();
        }
    }
}
