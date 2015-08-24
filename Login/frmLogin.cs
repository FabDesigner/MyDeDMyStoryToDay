using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userLoginDataSet.tbLogando' table. You can move, or remove it, as needed.
            this.tbLogandoTableAdapter.Fill(this.userLoginDataSet.tbLogando);
   
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            //string conexoes = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=UserLogin;Integrated Security=True";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.UserLoginConnectionString;
            SqlCommand comando = new SqlCommand("SELECT COUNT (*) FROM tbLogando WHERE NomeUser = @user AND SenhaUser = @senha", conn);

            comando.Parameters.Add("@codigo", SqlDbType.Int).Value = txtCodigo.Text;
            comando.Parameters.Add("@user", SqlDbType.VarChar).Value = txtUsuarios.Text;
            comando.Parameters.Add("@senha", SqlDbType.VarChar).Value = txtSenha.Text;

            conn.Open();
            int i = (int)comando.ExecuteScalar();
            if (i > 0)
            {
                MessageBox.Show("Usuário(a) e Senha encontrados com sucesso!");
                Form mdi = new MDIMyDeD();
                mdi.Show();
            }
            else
            {
                MessageBox.Show("Erro ao efetuar Login! Faço o seu cadastro.", "Cadastre-se!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            conn.Close();
            
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=UserLogin;Integrated Security=True";
            conn.ConnectionString = Properties.Settings.Default.UserLoginConnectionString;
            {
                try
                {
                    conn.Open();
                    SqlCommand cmm = new SqlCommand();
                    cmm.CommandText = "INSERT INTO tbLogando(NomeUser, SenhaUser) VALUES ('"+txtUsuarios.Text+"', '"+txtSenha.Text+"')";
                    cmm.CommandType = CommandType.Text;
                    cmm.Connection = conn;
                    cmm.ExecuteNonQuery();
                    MessageBox.Show("Usuário(a) cadastrado(a) com sucesso!");
                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format("Não foi possível efetuar o seu cadastro: {0} ", ex.Message));
                }
            }
        }

        private void picLocalizar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Impossível fazer a localização. Insira um código válido.", "Localzação realizada sem sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=UserLogin;Integrated Security=True";
            conn.ConnectionString = Properties.Settings.Default.UserLoginConnectionString;
            try
            {
                conn.Open();

                SqlCommand cmm = new SqlCommand();
                cmm.CommandText = "SELECT NomeUser FROM tbLogando WHERE CodUser = " + txtCodigo.Text;
                cmm.CommandType = CommandType.Text;
                cmm.Connection = conn;

                SqlDataReader dr;
                dr = cmm.ExecuteReader();
                dr.Read();

                txtUsuarios.Text = dr.GetString(0);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossível localizar seu registro. Vereifique seu código, ou faça o seu cadastro.", ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form web = new wbMyDeDNav();
            web.Show();
        }

        private void dgvLogin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = Convert.ToString(dgvLogin.CurrentRow.Cells[0].Value);
            txtUsuarios.Text = Convert.ToString(dgvLogin.CurrentRow.Cells[1].Value);
        
        }
    }
}

