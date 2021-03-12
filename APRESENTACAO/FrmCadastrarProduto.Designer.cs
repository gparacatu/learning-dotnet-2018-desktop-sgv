namespace APRESENTACAO
{
    partial class FrmCadastrarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarProduto));
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblbNome = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbbCategoria = new System.Windows.Forms.ComboBox();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.grbFoto = new System.Windows.Forms.GroupBox();
            this.imgFoto = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblPrecoCusto = new System.Windows.Forms.Label();
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtPrecoCusto = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.txtPrecoVenda = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.grbFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecoCusto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecoVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(5, 5);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // lblbNome
            // 
            this.lblbNome.AutoSize = true;
            this.lblbNome.Location = new System.Drawing.Point(5, 44);
            this.lblbNome.Name = "lblbNome";
            this.lblbNome.Size = new System.Drawing.Size(39, 13);
            this.lblbNome.TabIndex = 2;
            this.lblbNome.Text = "*Nome";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(5, 83);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(56, 13);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "*Categoria";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(192, 83);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "*Status";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(8, 21);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(8, 60);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(342, 20);
            this.txtNome.TabIndex = 3;
            // 
            // cbbCategoria
            // 
            this.cbbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategoria.FormattingEnabled = true;
            this.cbbCategoria.Location = new System.Drawing.Point(8, 99);
            this.cbbCategoria.Name = "cbbCategoria";
            this.cbbCategoria.Size = new System.Drawing.Size(154, 21);
            this.cbbCategoria.TabIndex = 5;
            // 
            // cbbStatus
            // 
            this.cbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Location = new System.Drawing.Point(195, 99);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(154, 21);
            this.cbbStatus.TabIndex = 7;
            // 
            // grbFoto
            // 
            this.grbFoto.Controls.Add(this.imgFoto);
            this.grbFoto.Location = new System.Drawing.Point(356, 5);
            this.grbFoto.Name = "grbFoto";
            this.grbFoto.Size = new System.Drawing.Size(130, 156);
            this.grbFoto.TabIndex = 12;
            this.grbFoto.TabStop = false;
            this.grbFoto.Text = "Foto:";
            // 
            // imgFoto
            // 
            this.imgFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgFoto.Location = new System.Drawing.Point(3, 16);
            this.imgFoto.Name = "imgFoto";
            this.imgFoto.Size = new System.Drawing.Size(124, 137);
            this.imgFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFoto.TabIndex = 0;
            this.imgFoto.TabStop = false;
            this.imgFoto.Click += new System.EventHandler(this.imgFoto_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(257, 173);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Location = new System.Drawing.Point(158, 173);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblPrecoCusto
            // 
            this.lblPrecoCusto.AutoSize = true;
            this.lblPrecoCusto.Location = new System.Drawing.Point(5, 125);
            this.lblPrecoCusto.Name = "lblPrecoCusto";
            this.lblPrecoCusto.Size = new System.Drawing.Size(83, 13);
            this.lblPrecoCusto.TabIndex = 8;
            this.lblPrecoCusto.Text = "*Preço de custo";
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.Location = new System.Drawing.Point(192, 125);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(87, 13);
            this.lblPrecoVenda.TabIndex = 10;
            this.lblPrecoVenda.Text = "*Preço de venda";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtPrecoCusto
            // 
            this.txtPrecoCusto.BackGroundColor = System.Drawing.SystemColors.Window;
            this.txtPrecoCusto.BeforeTouchSize = new System.Drawing.Size(154, 20);
            this.txtPrecoCusto.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txtPrecoCusto.Enabled = false;
            this.txtPrecoCusto.Location = new System.Drawing.Point(8, 141);
            this.txtPrecoCusto.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtPrecoCusto.Name = "txtPrecoCusto";
            this.txtPrecoCusto.NullString = "";
            this.txtPrecoCusto.ReadOnly = true;
            this.txtPrecoCusto.Size = new System.Drawing.Size(154, 20);
            this.txtPrecoCusto.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtPrecoCusto.TabIndex = 9;
            this.txtPrecoCusto.Text = "R$ 0,00";
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.BackGroundColor = System.Drawing.SystemColors.Window;
            this.txtPrecoVenda.BeforeTouchSize = new System.Drawing.Size(154, 20);
            this.txtPrecoVenda.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txtPrecoVenda.Location = new System.Drawing.Point(195, 141);
            this.txtPrecoVenda.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.NullString = "";
            this.txtPrecoVenda.Size = new System.Drawing.Size(154, 20);
            this.txtPrecoVenda.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtPrecoVenda.TabIndex = 11;
            this.txtPrecoVenda.Text = "R$ 0,00";
            // 
            // FrmCadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(489, 201);
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(this.txtPrecoCusto);
            this.Controls.Add(this.lblPrecoVenda);
            this.Controls.Add(this.lblPrecoCusto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.grbFoto);
            this.Controls.Add(this.cbbStatus);
            this.Controls.Add(this.cbbCategoria);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblbNome);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastrarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGV - Cadastrar Produto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCadastrarProduto_FormClosed);
            this.grbFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecoCusto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecoVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblbNome;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cbbCategoria;
        private System.Windows.Forms.ComboBox cbbStatus;
        private System.Windows.Forms.GroupBox grbFoto;
        private System.Windows.Forms.PictureBox imgFoto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblPrecoCusto;
        private System.Windows.Forms.Label lblPrecoVenda;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox txtPrecoCusto;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox txtPrecoVenda;
    }
}