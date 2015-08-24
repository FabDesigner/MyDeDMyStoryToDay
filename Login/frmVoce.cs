using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;


namespace Login
{
    public partial class frmVoce : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=fabiano-pc\sqlexpress;Initial Catalog=UserLogin;Integrated Security=True");

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        int i = 0;
        string imgLoc = "";

        public frmVoce()
        {
            InitializeComponent();

        }

        private void Voce_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userLoginDataSet1.tbVoce' table. You can move, or remove it, as needed.
            this.tbVoceTableAdapter.Fill(this.userLoginDataSet1.tbVoce);
            

            string conn = @"Data Source=fabiano-pc\sqlexpress;Initial Catalog=UserLogin;Integrated Security=True";
            SqlConnection conexao = new SqlConnection(conn);
            SqlCommand cmm = new SqlCommand("SELECT * FROM tbVoce WHERE CodUser = tbLogando", conexao);
            
            dgvVoce.RowTemplate.Height = 180;
            showdata();
        }

        //=================Fazendo o cálculo da idade ao escolher uma data específica do calendário===========
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

        //===============Selecionando uma foto ou imagem da pasta minhas imagens====================
        private void picFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "JPG Files(*.jpg)|*.jpg|GIF Files(*.gif)|*.gif|All Files(*.*)|*.*";
                file.Title = "Select tbVocePicture";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = file.FileName.ToString();
                    picFoto.ImageLocation = imgLoc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void limpa_campos()
        {
            txtUsuario.Text = "";
            dtpNascimento.Text = "";
            txtIdade.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            dtpHoje.Text = "";
            mskTelefone.Text = "";
            cbCelular.Text = "";
            mskCelular.Text = "";
            rcbTexto.Text = "";
            picFoto.ImageLocation = "";
        }

        //===============Salvando dados=============================
        private void picSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                SqlCommand cmm = new SqlCommand("INSERT INTO tbVoce (CodUser, DtNascimento, IdadeVoce, NomeVoce, DtAtual, EnderecoVoce, TelFixo, Operadora, TelCel, Texto, FotoVoce) Values ( '"+Convert.ToInt16(txtUsuario.Text)+"', '"+ dtpNascimento.Text + "', '" + txtIdade.Text + "', '" + txtNome.Text + "', '" + dtpHoje.Text + "', '" + txtEndereco.Text + "', '" + mskTelefone.Text + "', '" + cbCelular.Text + "', '" + mskCelular.Text + "', '" + rcbTexto.Text+ "', @FotoVoce)", conn);
                MemoryStream stream = new MemoryStream();
                picFoto.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] pic = stream.ToArray();
                cmm.Parameters.AddWithValue("@FotoVoce", pic);
                i = cmm.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Dados salvos com sucesso!", "Salvando dados...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Infelizmente não foi possível salvar seus dados!", ex.Message);
                throw;
            }
            finally
            {
                conn.Close();
            }
            limpa_campos();
        }

        //============Fazendo um Retrieve no banco==================
        private void picPesquisar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tbVoce WHERE DtAtual BETWEEN '" + dtpInicio.Text + "' AND '" + dtpFim.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvVoce.DataSource = ds.Tables[0];
        }

        //================Comando para fazer alterações no banco de dados======================
        private void picAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                SqlCommand cmm = new SqlCommand("UPDATE tbVoce SET DtNascimento = '" + dtpNascimento.Text + "', IdadeVoce = '" + txtIdade.Text + "', NomeVoce = '" + txtNome.Text + "', DtAtual = '" + dtpHoje.Text + "', EnderecoVoce = '" + txtEndereco.Text + "', TelFixo = '" + mskTelefone.Text + "', Operadora = '" + cbCelular.Text + "', TelCel = '" + mskCelular.Text + "', Texto = '" + rcbTexto.Text + "', FotoVoce = @FotoVoce WHERE CodVoce = '" + dgvVoce.SelectedRows[0].Cells[0].Value.ToString() + "'", conn);
                MemoryStream stream = new MemoryStream();
                picFoto.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] pic = stream.ToArray();
                cmm.Parameters.AddWithValue("@FotoVoce", pic);
                i = cmm.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Seus dados foram alterados com sucesso!", "Alterando dados...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fazer alterações, tente novamente!", ex.Message);
            }
            finally
            {
                conn.Close();
                showdata();
                limpa_campos();
            }   
            
        }

        //================Excluindo dados==========================
        private void picExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                SqlCommand cmm = new SqlCommand("DELETE FROM tbVoce WHERE CodVoce =" + dgvVoce.SelectedRows[0].Cells[0].Value.ToString() + "", conn);
                i = cmm.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Dados excluídos com sucesso!", "Excluindo dados...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpa_campos();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
                showdata();
                limpa_campos();
            }
        }


        private void btnFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rcbTexto.SelectionFont = fontDialog1.Font;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rcbTexto.SelectionColor = colorDialog1.Color;
            }
        }

        void showdata()
        {
            conn.Open();
            SqlCommand cmm = new SqlCommand("SELECT * FROM tbVoce", conn);
            da.SelectCommand = cmm;
            dt.Clear();
            da.Fill(dt);
            dgvVoce.DataSource = dt;
            dgvVoce.Columns[5].Width = 150;
            for (int i = 0; i < dgvVoce.Columns.Count; i++)
                if (dgvVoce.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dgvVoce.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                }

        }

        //======================Preenchimento do campos através do DataGridView=================
        private void dgvVoce_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            txtUsuario.Text = dgvVoce.SelectedRows[0].Cells[1].Value.ToString();
            dtpNascimento.Text = dgvVoce.SelectedRows[0].Cells[2].Value.ToString();
            txtIdade.Text = dgvVoce.SelectedRows[0].Cells[3].Value.ToString();
            txtNome.Text = dgvVoce.SelectedRows[0].Cells[4].Value.ToString();
            dtpHoje.Text = dgvVoce.SelectedRows[0].Cells[5].Value.ToString();
            //picFoto.ImageLocation = dgvVoce.CurrentRow.Cells[6].Value.ToString();
            txtEndereco.Text = dgvVoce.SelectedRows[0].Cells[6].Value.ToString();
            mskTelefone.Text = dgvVoce.SelectedRows[0].Cells[7].Value.ToString();
            cbCelular.Text = dgvVoce.SelectedRows[0].Cells[8].Value.ToString();
            mskCelular.Text = dgvVoce.SelectedRows[0].Cells[9].Value.ToString();
            rcbTexto.Text = dgvVoce.SelectedRows[0].Cells[10].Value.ToString();

            SqlCommand cmm = new SqlCommand("SELECT FotoVoce FROM tbVoce WHERE CodVoce = " + dgvVoce.SelectedRows[0].Cells[0].Value.ToString() +"", conn);

                da.SelectCommand = cmm;
                DataSet ds = new DataSet();
                byte[] mydata = new byte[0];
                da.Fill(ds, "tbVoce");
                DataRow myrow;
                myrow = ds.Tables["tbVoce"].Rows[0];
                mydata = (byte[])myrow["FotoVoce"];
                MemoryStream stream = new MemoryStream(mydata);
                picFoto.Image = Image.FromStream(stream);


        }

        private void picImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Pixel);
            e.Graphics.DrawString("Usuário(a): ", font, Brushes.Black, 20, 70);
            e.Graphics.DrawString(txtUsuario.Text, font, Brushes.Black, 87, 70);
            e.Graphics.DrawString("Data de Nascimento: ", font, Brushes.Black, 100, 70);
            e.Graphics.DrawString(dtpNascimento.Text, font, Brushes.Black, 225, 70);
            e.Graphics.DrawString("Sua idade: ", font, Brushes.Black, 295, 70);
            e.Graphics.DrawString(txtIdade.Text, font, Brushes.Black, 360, 70);
            e.Graphics.DrawString("Seu nome: ", font, Brushes.Black, 20, 85);
            e.Graphics.DrawString(txtNome.Text, font, Brushes.Black, 85, 85);
            e.Graphics.DrawString("Data atual: ", font, Brushes.Black, 285, 85);
            e.Graphics.DrawString(dtpHoje.Text, font, Brushes.Black, 350, 85);
            e.Graphics.DrawString("Seu endereço: ", font, Brushes.Black, 20, 100);
            e.Graphics.DrawString(txtEndereco.Text, font, Brushes.Black, 110, 100);
            e.Graphics.DrawString("Telefone fixo: ", font, Brushes.Black, 20, 115);
            e.Graphics.DrawString(mskTelefone.Text, font, Brushes.Black, 105, 115);
            e.Graphics.DrawString("Operadora: ", font, Brushes.Black, 230, 115);
            e.Graphics.DrawString(cbCelular.Text, font, Brushes.Black, 300, 115);
            e.Graphics.DrawString("Celular: ", font, Brushes.Black, 320, 115);
            e.Graphics.DrawString(mskCelular.Text, font, Brushes.Black, 370, 115);
            e.Graphics.DrawString("Seu texto: ", font, Brushes.Black, 20, 130);
            e.Graphics.DrawString(rcbTexto.Text, font, Brushes.Black, 20, 145);
           
//            int largura = picFoto.Width/4;
//            int altura = picFoto.Height/ 4;
//            e.Graphics.DrawImage(Image.FromStream,
//, 
//                                            new Rectangle (100, 100, largura, altura),
//                                            new Rectangle (0, 0, picFoto.Width, picFoto.Height),
//                                            GraphicsUnit, PixelFormat);

        }

        //==============Corretor ortográfico para RichTextBox=================================
        private void picCorretor_Click(object sender, EventArgs e)
        {
            Word.Application app = new Word.Application();

            int errors = 0;
            if (rcbTexto.Text.Length > 0)
            {
                app.Visible = false;

                // Setting these variables is comparable to passing null to the function.
                // This is necessary because the C# null cannot be passed by reference.
                object template = Missing.Value;
                object newTemplate = Missing.Value;
                object documentType = Missing.Value;
                object visible = true;

                Word._Document doc1 = app.Documents.Add(ref template, ref newTemplate, ref documentType, ref visible);
                doc1.Words.First.InsertBefore(rcbTexto.Text);
                Word.ProofreadingErrors spellErrorsColl = doc1.SpellingErrors;
                errors = spellErrorsColl.Count;

                object optional = Missing.Value;

                doc1.CheckSpelling(
                    ref optional, ref optional, ref optional, ref optional, ref optional, ref optional,
                    ref optional, ref optional, ref optional, ref optional, ref optional, ref optional);

                object first = 0;
                object last = doc1.Characters.Count - 1;
                rcbTexto.Text = doc1.Range(ref first, ref last).Text;
            }

            object saveChanges = false;
            object originalFormat = Missing.Value;
            object routeDocument = Missing.Value;

            app.Quit(ref saveChanges, ref originalFormat, ref routeDocument);
        }

        private void picConjuge_Click_1(object sender, EventArgs e)
        {
            Form conj = new frmConjuge();
            //' Seta o pai do form como sendo o mesmo pai do
            //' form que está em execução
            conj.MdiParent = this.MdiParent;
            conj.Show();
        }

        private void picFilho_Click_1(object sender, EventArgs e)
        {
            Form filho = new frmFilhos();
            //' Seta o pai do form como sendo o mesmo pai do
            //' form que está em execução
            filho.MdiParent = this.MdiParent;
            filho.Show();
        }

        private void picMae_Click_1(object sender, EventArgs e)
        {
            Form mae = new frmMae();
            //' Seta o pai do form como sendo o mesmo pai do
            //' form que está em execução
            mae.MdiParent = this.MdiParent;
            mae.Show();
        }

        private void picPai_Click_1(object sender, EventArgs e)
        {
            Form pai = new frmPai();
            //' Seta o pai do form como sendo o mesmo pai do
            //' form que está em execução
            pai.MdiParent = this.MdiParent;
            pai.Show();
        }

        private void picIrmao_Click_1(object sender, EventArgs e)
        {
            Form irmao = new frmIrmaos();
            //' Seta o pai do form como sendo o mesmo pai do
            //' form que está em execução
            irmao.MdiParent = this.MdiParent;
            irmao.Show();
        }

        private void picProfissao_Click_1(object sender, EventArgs e)
        {
            Form prof = new frmProfissao();
            //' Seta o pai do form como sendo o mesmo pai do
            //' form que está em execução
            prof.MdiParent = this.MdiParent;
            prof.Show();
        }

        private void picPatrao_Click_1(object sender, EventArgs e)
        {
            Form pat = new frmPatrao();
            //' Seta o pai do form como sendo o mesmo pai do
            //' form que está em execução
            pat.MdiParent = this.MdiParent;
            pat.Show();
        }

        private void picColegas_Click_1(object sender, EventArgs e)
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

        private void picReitor_Click(object sender, EventArgs e)
        {
            Form reitor = new frmReitor();
            //' Seta o pai do form como sendo o mesmo pai do
            //' form que está em execução
            reitor.MdiParent = this.MdiParent;
            reitor.Show();
        }

    }
}
