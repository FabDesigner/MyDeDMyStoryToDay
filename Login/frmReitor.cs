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
    public partial class frmReitor : Form
    {
        public frmReitor()
        {
            InitializeComponent();
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
            Form conj = new frmConjuge();
            //' Seta o pai do form como sendo o mesmo pai do
            //' form que está em execução
            conj.MdiParent = this.MdiParent;
            conj.Show();
        }

        private void picFilho_Click(object sender, EventArgs e)
        {
            Form filho = new frmFilhos();
            //' Seta o pai do form como sendo o mesmo pai do
            //' form que está em execução
            filho.MdiParent = this.MdiParent;
            filho.Show();
        }

        private void picMae_Click(object sender, EventArgs e)
        {
            Form mae = new frmMae();
            //' Seta o pai do form como sendo o mesmo pai do
            //' form que está em execução
            mae.MdiParent = this.MdiParent;
            mae.Show();
        }

        private void picIrmao_Click(object sender, EventArgs e)
        {
            Form irmao = new frmIrmaos();
            //' Seta o pai do form como sendo o mesmo pai do
            //' form que está em execução
            irmao.MdiParent = this.MdiParent;
            irmao.Show();
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
            Form colega = new frmColega();
            //' Seta o pai do form como sendo o mesmo pai do
            //' form que está em execução
            colega.MdiParent = this.MdiParent;
            colega.Show();
        }

        private void picLocalFormacao_Click(object sender, EventArgs e)
        {
            Form local = new frmLocalFormacao();
            //' Seta o pai do form como sendo o mesmo pai do
            //' form que está em execução
            local.MdiParent = this.MdiParent;
            local.Show();
        }

        private void picCurso_Click(object sender, EventArgs e)
        {
            Form curso = new frmCurso();
            //' Seta o pai do form como sendo o mesmo pai do
            //' form que está em execução
            curso.MdiParent = this.MdiParent;
            curso.Show();
        }

        private void picMateria_Click(object sender, EventArgs e)
        {
            Form mat = new frmMateria();
            //' Seta o pai do form como sendo o mesmo pai do
            //' form que está em execução
            mat.MdiParent = this.MdiParent;
            mat.Show();
        }

        private void picProfessor_Click(object sender, EventArgs e)
        {
            Form professor = new frmProfessor();
            //' Seta o pai do form como sendo o mesmo pai do
            //' form que está em execução
            professor.MdiParent = this.MdiParent;
            professor.Show();
        }

        private void picPai_Click(object sender, EventArgs e)
        {
            Form pai = new frmPai();
            //' Seta o pai do form como sendo o mesmo pai do
            //' form que está em execução
            pai.MdiParent = this.MdiParent;
            pai.Show();
        }

        private void picVoce_Click(object sender, EventArgs e)
        { 
            Form voce = new frmVoce();
            //' Seta o pai do form como sendo o mesmo pai do
            //' form que está em execução
            voce.MdiParent = this.MdiParent;
            voce.Show();
        }

        private void picSegredo_Click(object sender, EventArgs e)
        {
            Form seg = new frmSegredo();
            //' Seta o pai do form como sendo o mesmo pai do
            //' form que está em execução
            seg.MdiParent = this.MdiParent;
            seg.Show();
        }
        
    }
}
