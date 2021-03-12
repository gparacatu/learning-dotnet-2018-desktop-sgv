namespace APRESENTACAO
{
    partial class FrmCadastrarPessoaJuridica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarPessoaJuridica));
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ckbFilial = new System.Windows.Forms.CheckBox();
            this.ckbFornecedor = new System.Windows.Forms.CheckBox();
            this.ckbCliente = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.grbClassificacao = new System.Windows.Forms.GroupBox();
            this.txtNumero = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtInscricao = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.lblInscricao = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.grbLogo = new System.Windows.Forms.GroupBox();
            this.ptblogo = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnCadastrarUsuario = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.grbClassificacao.SuspendLayout();
            this.grbLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptblogo)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(270, 17);
            this.toolStripStatusLabel1.Text = "Obs.: Campos marcados com (*) são obrigatórios.";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripStatusLabel1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // ckbFilial
            // 
            this.ckbFilial.AutoSize = true;
            this.ckbFilial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbFilial.ForeColor = System.Drawing.Color.DarkRed;
            this.ckbFilial.Location = new System.Drawing.Point(361, 14);
            this.ckbFilial.Name = "ckbFilial";
            this.ckbFilial.Size = new System.Drawing.Size(59, 24);
            this.ckbFilial.TabIndex = 33;
            this.ckbFilial.Text = "Filial";
            this.ckbFilial.UseVisualStyleBackColor = true;
            // 
            // ckbFornecedor
            // 
            this.ckbFornecedor.AutoSize = true;
            this.ckbFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbFornecedor.ForeColor = System.Drawing.Color.DarkRed;
            this.ckbFornecedor.Location = new System.Drawing.Point(171, 14);
            this.ckbFornecedor.Name = "ckbFornecedor";
            this.ckbFornecedor.Size = new System.Drawing.Size(110, 24);
            this.ckbFornecedor.TabIndex = 32;
            this.ckbFornecedor.Text = "Fornecedor";
            this.ckbFornecedor.UseVisualStyleBackColor = true;
            // 
            // ckbCliente
            // 
            this.ckbCliente.AutoSize = true;
            this.ckbCliente.Checked = true;
            this.ckbCliente.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCliente.ForeColor = System.Drawing.Color.DarkRed;
            this.ckbCliente.Location = new System.Drawing.Point(14, 14);
            this.ckbCliente.Name = "ckbCliente";
            this.ckbCliente.Size = new System.Drawing.Size(77, 24);
            this.ckbCliente.TabIndex = 31;
            this.ckbCliente.Text = "Cliente";
            this.ckbCliente.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 255);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(557, 22);
            this.statusStrip1.TabIndex = 55;
            // 
            // grbClassificacao
            // 
            this.grbClassificacao.Controls.Add(this.ckbFilial);
            this.grbClassificacao.Controls.Add(this.ckbFornecedor);
            this.grbClassificacao.Controls.Add(this.ckbCliente);
            this.grbClassificacao.Location = new System.Drawing.Point(113, 2);
            this.grbClassificacao.Name = "grbClassificacao";
            this.grbClassificacao.Size = new System.Drawing.Size(435, 45);
            this.grbClassificacao.TabIndex = 30;
            this.grbClassificacao.TabStop = false;
            this.grbClassificacao.Text = "*Classificação";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(342, 149);
            this.txtNumero.Mask = "00000";
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 42;
            this.txtNumero.ValidatingType = typeof(int);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(113, 197);
            this.txtTelefone.Mask = "(999) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 48;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(7, 149);
            this.txtCep.Mask = "00000-999";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 20);
            this.txtCep.TabIndex = 38;
            this.txtCep.Leave += new System.EventHandler(this.txtCep_Leave);
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(342, 66);
            this.txtCnpj.Mask = "00000000000";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(100, 20);
            this.txtCnpj.TabIndex = 34;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(473, 225);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 54;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Location = new System.Drawing.Point(374, 225);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 53;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(4, 133);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(32, 13);
            this.lblCep.TabIndex = 37;
            this.lblCep.Text = "*CEP";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazaoSocial.Location = new System.Drawing.Point(7, 66);
            this.txtRazaoSocial.MaxLength = 50;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(329, 20);
            this.txtRazaoSocial.TabIndex = 32;
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Location = new System.Drawing.Point(219, 197);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(329, 20);
            this.txtEmail.TabIndex = 50;
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Location = new System.Drawing.Point(7, 197);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(100, 20);
            this.txtCidade.TabIndex = 46;
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Location = new System.Drawing.Point(449, 149);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(100, 20);
            this.txtBairro.TabIndex = 44;
            // 
            // txtRua
            // 
            this.txtRua.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRua.Location = new System.Drawing.Point(113, 149);
            this.txtRua.MaxLength = 50;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(223, 20);
            this.txtRua.TabIndex = 40;
            // 
            // txtInscricao
            // 
            this.txtInscricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInscricao.Location = new System.Drawing.Point(342, 107);
            this.txtInscricao.MaxLength = 50;
            this.txtInscricao.Name = "txtInscricao";
            this.txtInscricao.Size = new System.Drawing.Size(100, 20);
            this.txtInscricao.TabIndex = 36;
            // 
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(7, 18);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 29;
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Location = new System.Drawing.Point(4, 50);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(74, 13);
            this.lblRazaoSocial.TabIndex = 31;
            this.lblRazaoSocial.Text = "*Razão Social";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(216, 181);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 49;
            this.lblEmail.Text = "Email";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(110, 181);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(53, 13);
            this.lblTelefone.TabIndex = 47;
            this.lblTelefone.Text = "*Telefone";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(4, 181);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(44, 13);
            this.lblCidade.TabIndex = 45;
            this.lblCidade.Text = "*Cidade";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(446, 133);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(38, 13);
            this.lblBairro.TabIndex = 43;
            this.lblBairro.Text = "*Bairro";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(339, 133);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(48, 13);
            this.lblNumero.TabIndex = 41;
            this.lblNumero.Text = "*Numero";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(110, 133);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(157, 13);
            this.lblRua.TabIndex = 39;
            this.lblRua.Text = "*Logradouro (Rua, Avenida etc)";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Location = new System.Drawing.Point(339, 50);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(32, 13);
            this.lblCnpj.TabIndex = 33;
            this.lblCnpj.Text = "*Cnpj";
            // 
            // lblInscricao
            // 
            this.lblInscricao.AutoSize = true;
            this.lblInscricao.Location = new System.Drawing.Point(339, 91);
            this.lblInscricao.Name = "lblInscricao";
            this.lblInscricao.Size = new System.Drawing.Size(77, 13);
            this.lblInscricao.TabIndex = 35;
            this.lblInscricao.Text = "Inscr. Estadual";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(4, 2);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 28;
            this.lblCodigo.Text = "Código";
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeFantasia.Location = new System.Drawing.Point(7, 107);
            this.txtNomeFantasia.MaxLength = 50;
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(329, 20);
            this.txtNomeFantasia.TabIndex = 57;
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Location = new System.Drawing.Point(4, 91);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(82, 13);
            this.lblNomeFantasia.TabIndex = 56;
            this.lblNomeFantasia.Text = "*Nome Fantasia";
            // 
            // grbLogo
            // 
            this.grbLogo.Controls.Add(this.ptblogo);
            this.grbLogo.Location = new System.Drawing.Point(448, 46);
            this.grbLogo.Name = "grbLogo";
            this.grbLogo.Size = new System.Drawing.Size(101, 84);
            this.grbLogo.TabIndex = 58;
            this.grbLogo.TabStop = false;
            this.grbLogo.Text = "Logo";
            // 
            // ptblogo
            // 
            this.ptblogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptblogo.Location = new System.Drawing.Point(3, 16);
            this.ptblogo.Name = "ptblogo";
            this.ptblogo.Size = new System.Drawing.Size(95, 65);
            this.ptblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptblogo.TabIndex = 59;
            this.ptblogo.TabStop = false;
            this.ptblogo.Click += new System.EventHandler(this.ptblogo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(7, 225);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(192, 23);
            this.btnCadastrarUsuario.TabIndex = 59;
            this.btnCadastrarUsuario.Text = "Cadastrar como usuário do sistema...";
            this.btnCadastrarUsuario.UseVisualStyleBackColor = false;
            this.btnCadastrarUsuario.Visible = false;
            this.btnCadastrarUsuario.Click += new System.EventHandler(this.btnCadastrarUsuario_Click);
            // 
            // FrmCadastrarPessoaJuridica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(557, 277);
            this.Controls.Add(this.btnCadastrarUsuario);
            this.Controls.Add(this.grbLogo);
            this.Controls.Add(this.txtNomeFantasia);
            this.Controls.Add(this.lblNomeFantasia);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grbClassificacao);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.txtRazaoSocial);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.txtInscricao);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblRazaoSocial);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.lblInscricao);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastrarPessoaJuridica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGV - Cadastro de pessoa jurídica";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCadastrarPessoaJuridica_FormClosed);
            this.Load += new System.EventHandler(this.FrmCadastrarPessoaJuridica_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grbClassificacao.ResumeLayout(false);
            this.grbClassificacao.PerformLayout();
            this.grbLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptblogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.CheckBox ckbFilial;
        private System.Windows.Forms.CheckBox ckbFornecedor;
        private System.Windows.Forms.CheckBox ckbCliente;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox grbClassificacao;
        private System.Windows.Forms.MaskedTextBox txtNumero;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtInscricao;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Label lblInscricao;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.GroupBox grbLogo;
        private System.Windows.Forms.PictureBox ptblogo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnCadastrarUsuario;
    }
}