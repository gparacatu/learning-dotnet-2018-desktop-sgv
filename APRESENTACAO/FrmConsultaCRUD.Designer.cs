namespace APRESENTACAO
{
    partial class FrmConsultaCRUD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaCRUD));
            this.dgvConsultaCRUD = new System.Windows.Forms.DataGridView();
            this.grpConsulta = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblTipoPesquisa = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSelecionarCliente = new System.Windows.Forms.Button();
            this.btnTornarFilial = new System.Windows.Forms.Button();
            this.btnTornarFornecedor = new System.Windows.Forms.Button();
            this.btnTornarCliente = new System.Windows.Forms.Button();
            this.btnDesativar = new System.Windows.Forms.Button();
            this.btnAtivar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCRUD)).BeginInit();
            this.grpConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsultaCRUD
            // 
            this.dgvConsultaCRUD.AllowUserToAddRows = false;
            this.dgvConsultaCRUD.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvConsultaCRUD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultaCRUD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConsultaCRUD.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultaCRUD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsultaCRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsultaCRUD.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvConsultaCRUD.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvConsultaCRUD.Location = new System.Drawing.Point(4, 47);
            this.dgvConsultaCRUD.MultiSelect = false;
            this.dgvConsultaCRUD.Name = "dgvConsultaCRUD";
            this.dgvConsultaCRUD.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultaCRUD.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgvConsultaCRUD.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvConsultaCRUD.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvConsultaCRUD.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvConsultaCRUD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaCRUD.Size = new System.Drawing.Size(776, 372);
            this.dgvConsultaCRUD.TabIndex = 1;
            this.dgvConsultaCRUD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaCRUD_CellDoubleClick);
            this.dgvConsultaCRUD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvConsultaCRUD_KeyDown);
            // 
            // grpConsulta
            // 
            this.grpConsulta.Controls.Add(this.btnPesquisar);
            this.grpConsulta.Controls.Add(this.txtPesquisar);
            this.grpConsulta.Controls.Add(this.lblTipoPesquisa);
            this.grpConsulta.Location = new System.Drawing.Point(4, 3);
            this.grpConsulta.Name = "grpConsulta";
            this.grpConsulta.Size = new System.Drawing.Size(776, 42);
            this.grpConsulta.TabIndex = 0;
            this.grpConsulta.TabStop = false;
            this.grpConsulta.Text = "Pesquise por nome ou código da categoria:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPesquisar.Location = new System.Drawing.Point(686, 16);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(84, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(82, 18);
            this.txtPesquisar.MaxLength = 50;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(598, 20);
            this.txtPesquisar.TabIndex = 1;
            this.txtPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisar_KeyDown);
            // 
            // lblTipoPesquisa
            // 
            this.lblTipoPesquisa.AutoSize = true;
            this.lblTipoPesquisa.Location = new System.Drawing.Point(4, 21);
            this.lblTipoPesquisa.Name = "lblTipoPesquisa";
            this.lblTipoPesquisa.Size = new System.Drawing.Size(79, 13);
            this.lblTipoPesquisa.TabIndex = 0;
            this.lblTipoPesquisa.Text = "Nome | Código:";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFechar.Location = new System.Drawing.Point(705, 451);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultar.Location = new System.Drawing.Point(622, 451);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcluir.Location = new System.Drawing.Point(539, 451);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.AutoSize = true;
            this.btnAlterar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlterar.Location = new System.Drawing.Point(456, 451);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNovo.Location = new System.Drawing.Point(373, 451);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSelecionarCliente
            // 
            this.btnSelecionarCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelecionarCliente.Location = new System.Drawing.Point(330, 451);
            this.btnSelecionarCliente.Name = "btnSelecionarCliente";
            this.btnSelecionarCliente.Size = new System.Drawing.Size(125, 23);
            this.btnSelecionarCliente.TabIndex = 7;
            this.btnSelecionarCliente.Text = "Selecionar Cliente";
            this.btnSelecionarCliente.UseVisualStyleBackColor = false;
            this.btnSelecionarCliente.Visible = false;
            this.btnSelecionarCliente.Click += new System.EventHandler(this.btnSelecionarCliente_Click);
            // 
            // btnTornarFilial
            // 
            this.btnTornarFilial.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTornarFilial.Location = new System.Drawing.Point(4, 451);
            this.btnTornarFilial.Name = "btnTornarFilial";
            this.btnTornarFilial.Size = new System.Drawing.Size(106, 23);
            this.btnTornarFilial.TabIndex = 8;
            this.btnTornarFilial.Text = "Tornar Filial";
            this.btnTornarFilial.UseVisualStyleBackColor = false;
            this.btnTornarFilial.Visible = false;
            this.btnTornarFilial.Click += new System.EventHandler(this.btnTornarFilial_Click);
            // 
            // btnTornarFornecedor
            // 
            this.btnTornarFornecedor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTornarFornecedor.Location = new System.Drawing.Point(118, 451);
            this.btnTornarFornecedor.Name = "btnTornarFornecedor";
            this.btnTornarFornecedor.Size = new System.Drawing.Size(106, 23);
            this.btnTornarFornecedor.TabIndex = 9;
            this.btnTornarFornecedor.Text = "Tornar Fornecedor";
            this.btnTornarFornecedor.UseVisualStyleBackColor = false;
            this.btnTornarFornecedor.Visible = false;
            this.btnTornarFornecedor.Click += new System.EventHandler(this.btnTornarFornecedor_Click);
            // 
            // btnTornarCliente
            // 
            this.btnTornarCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTornarCliente.Location = new System.Drawing.Point(232, 451);
            this.btnTornarCliente.Name = "btnTornarCliente";
            this.btnTornarCliente.Size = new System.Drawing.Size(106, 23);
            this.btnTornarCliente.TabIndex = 10;
            this.btnTornarCliente.Text = "Tornar Cliente";
            this.btnTornarCliente.UseVisualStyleBackColor = false;
            this.btnTornarCliente.Visible = false;
            this.btnTornarCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDesativar
            // 
            this.btnDesativar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDesativar.Location = new System.Drawing.Point(4, 425);
            this.btnDesativar.Name = "btnDesativar";
            this.btnDesativar.Size = new System.Drawing.Size(106, 23);
            this.btnDesativar.TabIndex = 11;
            this.btnDesativar.Text = "Desativar";
            this.btnDesativar.UseVisualStyleBackColor = false;
            this.btnDesativar.Visible = false;
            this.btnDesativar.Click += new System.EventHandler(this.btnDesativar_Click);
            // 
            // btnAtivar
            // 
            this.btnAtivar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAtivar.Location = new System.Drawing.Point(118, 425);
            this.btnAtivar.Name = "btnAtivar";
            this.btnAtivar.Size = new System.Drawing.Size(106, 23);
            this.btnAtivar.TabIndex = 12;
            this.btnAtivar.Text = "Ativar";
            this.btnAtivar.UseVisualStyleBackColor = false;
            this.btnAtivar.Visible = false;
            this.btnAtivar.Click += new System.EventHandler(this.btnAtivar_Click);
            // 
            // FrmConsultaCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 480);
            this.Controls.Add(this.btnAtivar);
            this.Controls.Add(this.btnDesativar);
            this.Controls.Add(this.btnTornarCliente);
            this.Controls.Add(this.btnTornarFornecedor);
            this.Controls.Add(this.btnTornarFilial);
            this.Controls.Add(this.btnSelecionarCliente);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.grpConsulta);
            this.Controls.Add(this.dgvConsultaCRUD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmConsultaCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD Categoria de Produtos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmConsultaCRUD_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCRUD)).EndInit();
            this.grpConsulta.ResumeLayout(false);
            this.grpConsulta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaCRUD;
        private System.Windows.Forms.GroupBox grpConsulta;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblTipoPesquisa;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSelecionarCliente;
        private System.Windows.Forms.Button btnTornarFilial;
        private System.Windows.Forms.Button btnTornarFornecedor;
        private System.Windows.Forms.Button btnTornarCliente;
        private System.Windows.Forms.Button btnDesativar;
        private System.Windows.Forms.Button btnAtivar;
    }
}