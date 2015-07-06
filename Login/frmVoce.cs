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
    public partial class frmVoce : Form
    {
        public frmVoce()
        {
            InitializeComponent();
        }

        private void Voce_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userLoginDataSet1.tbVoce' table. You can move, or remove it, as needed.
            this.tbVoceTableAdapter.Fill(this.userLoginDataSet1.tbVoce);

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

        private void picConjuge_Click(object sender, EventArgs e)
        {
            Form conj =  new frmConjuge();
            //' Seta o pai do form como sendo o mesmo pai do
            //' form que está em execução
            conj.MdiParent = this.MdiParent;
            conj.Show();
        }

        private void picFilho_Click(object sender, EventArgs e)
        {
            Form filhos = new frmFilhos();
            //' Seta o pai do form como sendo o mesmo pai do
            //' form que está em execução
            filhos.MdiParent = this.MdiParent;
            filhos.Show();
        }

        private void picMae_Click(object sender, EventArgs e)
        {
            Form mae = new frmMae();
            //' Seta o pai do form como sendo o mesmo pai do
            //' form que está em execução
            mae.MdiParent = this.MdiParent;
            mae.Show();
        }

        private void picPai_Click(object sender, EventArgs e)
        {
            Form pai =  new frmPai();
            //' Seta o pai do form como sendo o mesmo pai do
            //' form que está em execução
            pai.MdiParent = this.MdiParent;
            pai.Show();
        }
       
        private void picIrmao_Click(object sender, EventArgs e)
        {
            Form irmaos = new frmIrmaos();
            //' Seta o pai do form como sendo o mesmo pai do
            //' form que está em execução
            irmaos.MdiParent = this.MdiParent;
            irmaos.Show();
        }

        private void picProfissao_Click(object sender, EventArgs e)
        {
            Form prof = new frmProfissao();
            //' Seta o pai do form como sendo o mesmo pai do
            //' form que está em execução
            prof.MdiParent = this.MdiParent;
            prof.Show();
        }

        private void picPatrao_Click(object sender, EventArgs e)
        {
            Form pat = new frmPatrao();
            //' Seta o pai do form como sendo o mesmo pai do
            //' form que está em execução
            pat.MdiParent = this.MdiParent;
            pat.Show();
        }

        private void picColegas_Click(object sender, EventArgs e)
        {
            Form colegas = new frmColega();
            //' Seta o pai do form como sendo o mesmo pai do
            //' form que está em execução
            colegas.MdiParent = this.MdiParent;
            colegas.Show();

        }

        private void btnIdade_Click(object sender, EventArgs e)
        {
            txtIdade.Text = Convert.ToString(DateTime.Now.Subtract(dtpNascimento.Value).Days);

            int idade = DateTime.Now.Year - dtpNascimento.Value.Year;
            if (DateTime.Now.Month < dtpNascimento.Value.Month)
            {
                idade = idade - 1;
            }
            else
            {
                if (DateTime.Now.Month == dtpNascimento.Value.Month && DateTime.Now.Day < dtpNascimento.Value.Day)
                {
                    idade = idade - 1;
                }
            }
            txtIdade.Text = Convert.ToString(idade + " " + "ANOS");
        }

        private void dtpNascimento_ValueChanged(object sender, EventArgs e)
        {
            txtIdade.Text = Convert.ToString(DateTime.Now.Subtract(dtpNascimento.Value).Days);

            int idade = DateTime.Now.Year - dtpNascimento.Value.Year;
            if (DateTime.Now.Month < dtpNascimento.Value.Month)
            {
                idade = idade - 1;
            }
            else
            {
                if (DateTime.Now.Month == dtpNascimento.Value.Month && DateTime.Now.Day < dtpNascimento.Value.Day)
                {
                    idade = idade - 1;
                }
            }
            txtIdade.Text = Convert.ToString(idade + " " + "ANOS");
        }
    }
}
