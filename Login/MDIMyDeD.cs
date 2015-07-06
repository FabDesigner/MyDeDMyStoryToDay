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
    public partial class MDIMyDeD : Form
    {
        private int childFormNumber = 0;

        public MDIMyDeD()
        {
            InitializeComponent();
        }

        private void filhosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form filhos = new frmFilhos();
            filhos.MdiParent = this;
            filhos.Show();
        }

        private void voceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form voce = new frmVoce();
            voce.MdiParent = this;
            voce.Show();
        }

        private void conjugeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form conj = new frmConjuge();
            conj.MdiParent = this;
            conj.Show();
        }

        private void maeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form mae = new frmMae();
            mae.MdiParent = this;
            mae.Show();
        }
 
        private void paiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form pai = new frmPai();
            pai.MdiParent = this;
            pai.Show();
        }
        private void irmaosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form irmao = new frmIrmaos();
            irmao.MdiParent = this;
            irmao.Show();
        }

        private void profissaoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form prof = new frmProfissao();
            prof.MdiParent = this;
            prof.Show();
        }

        private void patraoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form pat = new frmPatrao();
            pat.MdiParent = this;
            pat.Show();
        }

        private void colegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form colega = new frmColega();
            colega.MdiParent = this;
            colega.Show();
        }

        private void localFormacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form local = new frmLocalFormacao();
            local.MdiParent = this;
            local.Show();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form curso = new frmCurso();
            curso.MdiParent = this;
            curso.Show();
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form mat = new frmMateria();
            mat.MdiParent = this;
            mat.Show();
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form professor = new frmProfessor();
            professor.MdiParent = this;
            professor.Show();
        }

        private void reitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form reitor = new frmReitor();
            reitor.MdiParent = this;
            reitor.Show();
        }

        private void segredoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form seg = new frmSegredo();
            seg.MdiParent = this;
            seg.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MDIMyDeD_Load(object sender, EventArgs e)
        {

        }
    }
}
