using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    partial class abInicializacao : Form
    {
        public abInicializacao()
        {
            InitializeComponent();
            this.Text = String.Format("");
            this.labelProductName.Text = "MyDeD-Desk";
            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = "Todos os direitos reservados.";
            this.labelCompanyName.Text = "WorkFlow - web e desk";
            this.textBoxDescription.Text = "MyDeD-Desk: É um produto cujo objetivo é induzir o(a) usuário(a) ter a arte de escrever." + " " +
                "Contando sua história diariamente. MyDeD tem vários temas da vida cotidiana  como:" + " " +
                "Você, onde ali será escrito tudo sobre a sua história. Tudo o que você usuario(a) quiser comentar desde assuntos mais simples até seus segredos." + " " + 
                "Também tem formulários para cada membro de sua família, sua vida profissional, saúde, relacionamentos e assim por diante." + " " +
                "Em MyDeD existe um Banco de Dados para cada formulário, onde estará contida todas as suas informações de forma sigilosa." + " " +
                "Também existirá um relatório para cada formulário, onde caso tenha interesse em escrever um livro falando sobre a sua história ou sobre qualquer tema relacionado, se tornará acessível para impressão.";
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
            Form log = new frmLogin();
            log.Show();
            
        }
    }
}
