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
    public partial class frmProfissao : Form
    {
        public frmProfissao()
        {
            InitializeComponent();
        }

        private void btnPatrao_Click(object sender, EventArgs e)
        {
            frmPatrao patrao = new frmPatrao();
            patrao.ShowDialog();
        }

        private void btnColega_Click(object sender, EventArgs e)
        {
            frmColega colega = new frmColega();
            colega.ShowDialog();
        }

        private void Profissao_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmpresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void lblNascimento_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rcbTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPatrao_Click_1(object sender, EventArgs e)
        {
            Form pat = new frmPatrao();
            pat.Show();
        }

        private void btnItalico_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "jpg|*.jpg";
            if (file.ShowDialog() == DialogResult.OK)
            {
                picFoto.ImageLocation = file.FileName;
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIdade_Click(object sender, EventArgs e)
        {
            txtTempoServico.Text = Convert.ToString(DateTime.Now.Subtract(dtpAdmissao.Value).Days);

            int idade = DateTime.Now.Year - dtpAdmissao.Value.Year;
            if (DateTime.Now.Month < dtpAdmissao.Value.Month)
            {
                idade = idade - 1;
            }
            else
            {
                if (DateTime.Now.Month == dtpAdmissao.Value.Month && DateTime.Now.Day < dtpAdmissao.Value.Day)
                {
                    idade = idade - 1;
                }
            }
            txtTempoServico.Text = Convert.ToString(idade + " " + "ANOS");
        }

        private void picFoto_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "jpg|*.jpg";
            if (file.ShowDialog() == DialogResult.OK)
            {
                picFoto.ImageLocation = file.FileName;
            }
        }
    }
}
