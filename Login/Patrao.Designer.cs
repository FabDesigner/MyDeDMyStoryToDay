﻿namespace Login
{
    partial class Patrao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnColega = new System.Windows.Forms.Button();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.cbServico = new System.Windows.Forms.ComboBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.rcbTexto = new System.Windows.Forms.RichTextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblFoto = new System.Windows.Forms.Label();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.cbCelular = new System.Windows.Forms.ComboBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskAdmissao = new System.Windows.Forms.MaskedTextBox();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Login.Properties.Resources.patrao;
            this.panel1.Controls.Add(this.btnColega);
            this.panel1.Controls.Add(this.picFoto);
            this.panel1.Controls.Add(this.cbServico);
            this.panel1.Controls.Add(this.btnConectar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnAtualizar);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnInserir);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rcbTexto);
            this.panel1.Controls.Add(this.lblTexto);
            this.panel1.Controls.Add(this.lblFoto);
            this.panel1.Controls.Add(this.mskCelular);
            this.panel1.Controls.Add(this.cbCelular);
            this.panel1.Controls.Add(this.mskTelefone);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblEndereco);
            this.panel1.Controls.Add(this.txtEndereco);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.mskAdmissao);
            this.panel1.Controls.Add(this.lblNascimento);
            this.panel1.Controls.Add(this.lblCelular);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 516);
            this.panel1.TabIndex = 0;
            // 
            // btnColega
            // 
            this.btnColega.BackColor = System.Drawing.Color.Silver;
            this.btnColega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColega.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnColega.Location = new System.Drawing.Point(248, 119);
            this.btnColega.Name = "btnColega";
            this.btnColega.Size = new System.Drawing.Size(132, 36);
            this.btnColega.TabIndex = 128;
            this.btnColega.Text = "Colega";
            this.btnColega.UseVisualStyleBackColor = false;
            this.btnColega.Click += new System.EventHandler(this.btnColega_Click);
            // 
            // picFoto
            // 
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFoto.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.picFoto.Image = global::Login.Properties.Resources.profissao049;
            this.picFoto.Location = new System.Drawing.Point(679, 15);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(160, 217);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 125;
            this.picFoto.TabStop = false;
            // 
            // cbServico
            // 
            this.cbServico.FormattingEnabled = true;
            this.cbServico.Items.AddRange(new object[] {
            "1 ANO",
            "2 ANOS",
            "3 ANOS",
            "4 ANOS",
            "5 ANOS",
            "6 ANOS",
            "7 ANOS",
            "8 ANOS",
            "9 ANOS",
            "10 ANOS",
            "11 ANOS",
            "12 ANOS",
            "13 ANOS",
            "14 ANOS",
            "15 ANOS",
            "16 ANOS",
            "17 ANOS",
            "18 ANOS",
            "19 ANOS",
            "20 ANOS",
            "21 ANOS",
            "22 ANOS",
            "23 ANOS",
            "24 ANOS",
            "25 ANOS",
            "26 ANOS",
            "27 ANOS",
            "28 ANOS",
            "29 ANOS",
            "30 ANOS",
            "31 ANOS",
            "32 ANOS",
            "33 ANOS",
            "34 ANOS",
            "35 ANOS",
            "36 ANOS",
            "37 ANOS",
            "38 ANOS",
            "39 ANOS",
            "40 ANOS",
            "41 ANOS",
            "42 ANOS",
            "43 ANOS",
            "44 ANOS",
            "45 ANOS",
            "46 ANOS",
            "47 ANOS",
            "48 ANOS",
            "49 ANOS",
            "50 ANOS",
            "51 ANOS",
            "52 ANOS",
            "53 ANOS",
            "54 ANOS",
            "55 ANOS",
            "56 ANOS",
            "57 ANOS",
            "58 ANOS",
            "59 ANOS",
            "60 ANOS"});
            this.cbServico.Location = new System.Drawing.Point(591, 15);
            this.cbServico.Name = "cbServico";
            this.cbServico.Size = new System.Drawing.Size(67, 21);
            this.cbServico.TabIndex = 124;
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.Green;
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConectar.Location = new System.Drawing.Point(525, 94);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(133, 56);
            this.btnConectar.TabIndex = 123;
            this.btnConectar.Text = "Conectar Banco";
            this.btnConectar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluir.Location = new System.Drawing.Point(679, 463);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(160, 40);
            this.btnExcluir.TabIndex = 121;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Blue;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtualizar.Location = new System.Drawing.Point(679, 418);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(160, 39);
            this.btnAtualizar.TabIndex = 120;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Fuchsia;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPesquisar.Location = new System.Drawing.Point(679, 372);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(160, 40);
            this.btnPesquisar.TabIndex = 119;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Lime;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvar.Location = new System.Drawing.Point(679, 281);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(160, 40);
            this.btnSalvar.TabIndex = 118;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInserir.Location = new System.Drawing.Point(679, 327);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(160, 39);
            this.btnInserir.TabIndex = 117;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 353);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(611, 150);
            this.dataGridView1.TabIndex = 116;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 115;
            this.label2.Text = "Banco de dados:";
            // 
            // rcbTexto
            // 
            this.rcbTexto.Location = new System.Drawing.Point(41, 158);
            this.rcbTexto.Name = "rcbTexto";
            this.rcbTexto.Size = new System.Drawing.Size(615, 160);
            this.rcbTexto.TabIndex = 114;
            this.rcbTexto.Text = "";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(43, 135);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(58, 20);
            this.lblTexto.TabIndex = 113;
            this.lblTexto.Text = "Texto:";
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.Location = new System.Drawing.Point(702, 235);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(121, 20);
            this.lblFoto.TabIndex = 112;
            this.lblFoto.Text = "Clique na foto";
            // 
            // mskCelular
            // 
            this.mskCelular.Location = new System.Drawing.Point(377, 94);
            this.mskCelular.Mask = "+55 (99) 99999-9999";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(130, 20);
            this.mskCelular.TabIndex = 111;
            // 
            // cbCelular
            // 
            this.cbCelular.FormattingEnabled = true;
            this.cbCelular.Items.AddRange(new object[] {
            "CLARO",
            "OI",
            "TIM",
            "VIVO"});
            this.cbCelular.Location = new System.Drawing.Point(318, 93);
            this.cbCelular.Name = "cbCelular";
            this.cbCelular.Size = new System.Drawing.Size(53, 21);
            this.cbCelular.TabIndex = 110;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(105, 93);
            this.mskTelefone.Mask = "+55 (99) 99999-9999";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(130, 20);
            this.mskTelefone.TabIndex = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 107;
            this.label1.Text = "Telef.:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(39, 67);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(190, 20);
            this.lblEndereco.TabIndex = 106;
            this.lblEndereco.Text = "Endereço da empresa:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(230, 67);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(428, 20);
            this.txtEndereco.TabIndex = 105;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(114, 41);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(542, 20);
            this.txtNome.TabIndex = 104;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(40, 41);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 20);
            this.lblNome.TabIndex = 103;
            this.lblNome.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(428, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 122;
            this.label3.Text = "Tempo de serviço:";
            // 
            // mskAdmissao
            // 
            this.mskAdmissao.Location = new System.Drawing.Point(351, 15);
            this.mskAdmissao.Mask = "00/00/0000";
            this.mskAdmissao.Name = "mskAdmissao";
            this.mskAdmissao.Size = new System.Drawing.Size(71, 20);
            this.mskAdmissao.TabIndex = 102;
            this.mskAdmissao.ValidatingType = typeof(System.DateTime);
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimento.Location = new System.Drawing.Point(242, 15);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(103, 20);
            this.lblNascimento.TabIndex = 101;
            this.lblNascimento.Text = "Aniversário:";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(244, 94);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(70, 20);
            this.lblCelular.TabIndex = 109;
            this.lblCelular.Text = "Celular:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(114, 15);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(81, 20);
            this.txtCodigo.TabIndex = 100;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(37, 15);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(70, 20);
            this.lblCodigo.TabIndex = 99;
            this.lblCodigo.Text = "Código:";
            // 
            // Patrao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 516);
            this.Controls.Add(this.panel1);
            this.Name = "Patrao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patrao";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.ComboBox cbServico;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rcbTexto;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.ComboBox cbCelular;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskAdmissao;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnColega;
    }
}