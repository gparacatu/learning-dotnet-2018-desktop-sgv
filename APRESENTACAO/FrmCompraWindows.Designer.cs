#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace APRESENTACAO
{
    partial class FrmCompraWindows
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompraWindows));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbListaProdutos = new System.Windows.Forms.GroupBox();
            this.btnRemoverItem = new Syncfusion.Windows.Forms.ButtonAdv();
            this.dbgListaProdutos = new System.Windows.Forms.DataGridView();
            this.btnNovaVenda = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnCancelar = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnFinalizarVenda = new Syncfusion.Windows.Forms.ButtonAdv();
            this.txtDescontoItem = new Syncfusion.Windows.Forms.Tools.PercentTextBox();
            this.gradientLabel4 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.btnFinalizarPedido = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnSelecionarCliente = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnOk = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnMenos = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnMais = new Syncfusion.Windows.Forms.ButtonAdv();
            this.gradientLabel3 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.gradientLabel2 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.txtQuantidade = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblQuantidade = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.btnProcurarProduto = new Syncfusion.Windows.Forms.ButtonAdv();
            this.txtproduto = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtCliente = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.grbDadosVenda = new System.Windows.Forms.GroupBox();
            this.txtValorUnitario = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.lblValorUnitario = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.lblLogin = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.txtDesconto = new Syncfusion.Windows.Forms.Tools.PercentTextBox();
            this.txtValorFinal = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.txtValorTotal = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.lblValorFinal = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.lblDesconto = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.lblValorTotal = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.grbFinalizaVenda = new System.Windows.Forms.GroupBox();
            this.cbbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.lblFormaPagamento = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.grbListaProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgListaProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescontoItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtproduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente)).BeginInit();
            this.grbDadosVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorUnitario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorTotal)).BeginInit();
            this.grbFinalizaVenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbListaProdutos
            // 
            this.grbListaProdutos.Controls.Add(this.btnRemoverItem);
            this.grbListaProdutos.Controls.Add(this.dbgListaProdutos);
            this.grbListaProdutos.Enabled = false;
            this.grbListaProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListaProdutos.ForeColor = System.Drawing.Color.White;
            this.grbListaProdutos.Location = new System.Drawing.Point(11, 203);
            this.grbListaProdutos.Name = "grbListaProdutos";
            this.grbListaProdutos.Size = new System.Drawing.Size(1077, 262);
            this.grbListaProdutos.TabIndex = 2;
            this.grbListaProdutos.TabStop = false;
            this.grbListaProdutos.Text = "Produtos do Pedido:";
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2010;
            this.btnRemoverItem.BackColor = System.Drawing.Color.Black;
            this.btnRemoverItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoverItem.BackgroundImage")));
            this.btnRemoverItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoverItem.BeforeTouchSize = new System.Drawing.Size(79, 21);
            this.btnRemoverItem.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.None;
            this.btnRemoverItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverItem.IsBackStageButton = false;
            this.btnRemoverItem.Location = new System.Drawing.Point(994, 235);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(79, 21);
            this.btnRemoverItem.TabIndex = 1;
            this.btnRemoverItem.TabStop = false;
            this.btnRemoverItem.Text = "Remover F12";
            this.btnRemoverItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemoverItem.UseVisualStyle = true;
            this.btnRemoverItem.UseVisualStyleBackColor = true;
            this.btnRemoverItem.Click += new System.EventHandler(this.btnRemoverItem_Click);
            // 
            // dbgListaProdutos
            // 
            this.dbgListaProdutos.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dbgListaProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dbgListaProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dbgListaProdutos.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbgListaProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dbgListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbgListaProdutos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dbgListaProdutos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dbgListaProdutos.Location = new System.Drawing.Point(5, 34);
            this.dbgListaProdutos.MultiSelect = false;
            this.dbgListaProdutos.Name = "dbgListaProdutos";
            this.dbgListaProdutos.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbgListaProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.dbgListaProdutos.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dbgListaProdutos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dbgListaProdutos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.dbgListaProdutos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbgListaProdutos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dbgListaProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dbgListaProdutos.Size = new System.Drawing.Size(1065, 195);
            this.dbgListaProdutos.TabIndex = 0;
            this.dbgListaProdutos.TabStop = false;
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2010;
            this.btnNovaVenda.BackColor = System.Drawing.Color.Black;
            this.btnNovaVenda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovaVenda.BackgroundImage")));
            this.btnNovaVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovaVenda.BeforeTouchSize = new System.Drawing.Size(150, 68);
            this.btnNovaVenda.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.None;
            this.btnNovaVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaVenda.IsBackStageButton = false;
            this.btnNovaVenda.Location = new System.Drawing.Point(923, 34);
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Size = new System.Drawing.Size(150, 68);
            this.btnNovaVenda.TabIndex = 0;
            this.btnNovaVenda.TabStop = false;
            this.btnNovaVenda.Text = "  Nova Compra    F1";
            this.btnNovaVenda.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovaVenda.UseVisualStyle = true;
            this.btnNovaVenda.UseVisualStyleBackColor = true;
            this.btnNovaVenda.Click += new System.EventHandler(this.btnNovaVenda_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2010;
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.BeforeTouchSize = new System.Drawing.Size(150, 68);
            this.btnCancelar.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.None;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.IsBackStageButton = false;
            this.btnCancelar.Location = new System.Drawing.Point(768, 34);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 68);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "     Cancelar        F8";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.UseVisualStyle = true;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2010;
            this.btnFinalizarVenda.BackColor = System.Drawing.Color.Black;
            this.btnFinalizarVenda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFinalizarVenda.BackgroundImage")));
            this.btnFinalizarVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFinalizarVenda.BeforeTouchSize = new System.Drawing.Size(150, 68);
            this.btnFinalizarVenda.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.None;
            this.btnFinalizarVenda.Enabled = false;
            this.btnFinalizarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarVenda.IsBackStageButton = false;
            this.btnFinalizarVenda.Location = new System.Drawing.Point(613, 34);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(150, 68);
            this.btnFinalizarVenda.TabIndex = 9;
            this.btnFinalizarVenda.TabStop = false;
            this.btnFinalizarVenda.Text = "Finalizar Compra F6";
            this.btnFinalizarVenda.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFinalizarVenda.UseVisualStyle = true;
            this.btnFinalizarVenda.UseVisualStyleBackColor = true;
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
            // 
            // txtDescontoItem
            // 
            this.txtDescontoItem.BackGroundColor = System.Drawing.SystemColors.Window;
            this.txtDescontoItem.BeforeTouchSize = new System.Drawing.Size(111, 35);
            this.txtDescontoItem.ClipMode = Syncfusion.Windows.Forms.Tools.CurrencyClipModes.ExcludeFormatting;
            this.txtDescontoItem.DoubleValue = 0D;
            this.txtDescontoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescontoItem.Location = new System.Drawing.Point(705, 148);
            this.txtDescontoItem.MaxValue = 100D;
            this.txtDescontoItem.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDescontoItem.MinValue = 0D;
            this.txtDescontoItem.Name = "txtDescontoItem";
            this.txtDescontoItem.NullString = "";
            this.txtDescontoItem.Size = new System.Drawing.Size(91, 40);
            this.txtDescontoItem.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDescontoItem.TabIndex = 14;
            this.txtDescontoItem.TabStop = false;
            this.txtDescontoItem.Text = "0,00%";
            this.txtDescontoItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gradientLabel4
            // 
            this.gradientLabel4.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))), System.Drawing.Color.White);
            this.gradientLabel4.BeforeTouchSize = new System.Drawing.Size(91, 38);
            this.gradientLabel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.gradientLabel4.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel4.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.gradientLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel4.Location = new System.Drawing.Point(705, 110);
            this.gradientLabel4.Name = "gradientLabel4";
            this.gradientLabel4.Size = new System.Drawing.Size(91, 38);
            this.gradientLabel4.TabIndex = 13;
            this.gradientLabel4.Text = "% Desc.";
            this.gradientLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFinalizarPedido
            // 
            this.btnFinalizarPedido.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2010;
            this.btnFinalizarPedido.BackColor = System.Drawing.Color.Black;
            this.btnFinalizarPedido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFinalizarPedido.BackgroundImage")));
            this.btnFinalizarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFinalizarPedido.BeforeTouchSize = new System.Drawing.Size(206, 78);
            this.btnFinalizarPedido.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.None;
            this.btnFinalizarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarPedido.IsBackStageButton = false;
            this.btnFinalizarPedido.Location = new System.Drawing.Point(864, 110);
            this.btnFinalizarPedido.Name = "btnFinalizarPedido";
            this.btnFinalizarPedido.Size = new System.Drawing.Size(206, 78);
            this.btnFinalizarPedido.TabIndex = 17;
            this.btnFinalizarPedido.TabStop = false;
            this.btnFinalizarPedido.Text = "   Finalizar Pedido    F5";
            this.btnFinalizarPedido.UseVisualStyle = true;
            this.btnFinalizarPedido.UseVisualStyleBackColor = true;
            this.btnFinalizarPedido.Click += new System.EventHandler(this.btnFinalizarPedido_Click);
            // 
            // btnSelecionarCliente
            // 
            this.btnSelecionarCliente.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2010;
            this.btnSelecionarCliente.BackColor = System.Drawing.Color.Black;
            this.btnSelecionarCliente.BackgroundImage = global::APRESENTACAO.Properties.Resources.FundoBotaoWIndows2;
            this.btnSelecionarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelecionarCliente.BeforeTouchSize = new System.Drawing.Size(206, 76);
            this.btnSelecionarCliente.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.None;
            this.btnSelecionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarCliente.IsBackStageButton = false;
            this.btnSelecionarCliente.Location = new System.Drawing.Point(864, 31);
            this.btnSelecionarCliente.Name = "btnSelecionarCliente";
            this.btnSelecionarCliente.Size = new System.Drawing.Size(206, 76);
            this.btnSelecionarCliente.TabIndex = 0;
            this.btnSelecionarCliente.TabStop = false;
            this.btnSelecionarCliente.Text = "Selecionar Fornecedor F2";
            this.btnSelecionarCliente.UseVisualStyle = true;
            this.btnSelecionarCliente.UseVisualStyleBackColor = true;
            this.btnSelecionarCliente.Click += new System.EventHandler(this.btnSelecionarCliente_Click);
            // 
            // btnOk
            // 
            this.btnOk.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnOk.BackgroundImage = global::APRESENTACAO.Properties.Resources.FundoBotaoWIndows;
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOk.BeforeTouchSize = new System.Drawing.Size(59, 40);
            this.btnOk.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.None;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.IsBackStageButton = false;
            this.btnOk.Location = new System.Drawing.Point(799, 148);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(59, 40);
            this.btnOk.TabIndex = 16;
            this.btnOk.TabStop = false;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyle = true;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnMenos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnMenos.BackgroundImage = global::APRESENTACAO.Properties.Resources.FundoBotaoWIndows;
            this.btnMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenos.BeforeTouchSize = new System.Drawing.Size(27, 40);
            this.btnMenos.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.None;
            this.btnMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.ForeColor = System.Drawing.Color.White;
            this.btnMenos.IsBackStageButton = false;
            this.btnMenos.Location = new System.Drawing.Point(563, 148);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(27, 40);
            this.btnMenos.TabIndex = 10;
            this.btnMenos.TabStop = false;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyle = true;
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnMais
            // 
            this.btnMais.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnMais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnMais.BackgroundImage = global::APRESENTACAO.Properties.Resources.FundoBotaoWIndows;
            this.btnMais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMais.BeforeTouchSize = new System.Drawing.Size(27, 40);
            this.btnMais.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.None;
            this.btnMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMais.ForeColor = System.Drawing.Color.White;
            this.btnMais.IsBackStageButton = false;
            this.btnMais.Location = new System.Drawing.Point(536, 148);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(27, 40);
            this.btnMais.TabIndex = 9;
            this.btnMais.TabStop = false;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyle = true;
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // gradientLabel3
            // 
            this.gradientLabel3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))), System.Drawing.Color.White);
            this.gradientLabel3.BeforeTouchSize = new System.Drawing.Size(58, 38);
            this.gradientLabel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.gradientLabel3.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.gradientLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel3.Location = new System.Drawing.Point(799, 110);
            this.gradientLabel3.Name = "gradientLabel3";
            this.gradientLabel3.Size = new System.Drawing.Size(58, 38);
            this.gradientLabel3.TabIndex = 15;
            this.gradientLabel3.Text = "F4";
            this.gradientLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel2
            // 
            this.gradientLabel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))), System.Drawing.Color.White);
            this.gradientLabel2.BeforeTouchSize = new System.Drawing.Size(53, 38);
            this.gradientLabel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.gradientLabel2.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.gradientLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel2.Location = new System.Drawing.Point(536, 110);
            this.gradientLabel2.Name = "gradientLabel2";
            this.gradientLabel2.Size = new System.Drawing.Size(53, 38);
            this.gradientLabel2.TabIndex = 8;
            this.gradientLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackGroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtQuantidade.BeforeTouchSize = new System.Drawing.Size(111, 35);
            this.txtQuantidade.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.IntegerValue = ((long)(1));
            this.txtQuantidade.Location = new System.Drawing.Point(464, 148);
            this.txtQuantidade.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQuantidade.MinValue = ((long)(1));
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.NullString = "";
            this.txtQuantidade.Size = new System.Drawing.Size(69, 40);
            this.txtQuantidade.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.txtQuantidade.TabIndex = 7;
            this.txtQuantidade.Text = "1";
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantidade.WordWrap = false;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))), System.Drawing.Color.White);
            this.lblQuantidade.BeforeTouchSize = new System.Drawing.Size(69, 38);
            this.lblQuantidade.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.lblQuantidade.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblQuantidade.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(464, 110);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(69, 38);
            this.lblQuantidade.TabIndex = 6;
            this.lblQuantidade.Text = "Qtd.";
            this.lblQuantidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProcurarProduto
            // 
            this.btnProcurarProduto.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnProcurarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnProcurarProduto.BackgroundImage = global::APRESENTACAO.Properties.Resources.FundoBotaoWIndows;
            this.btnProcurarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProcurarProduto.BeforeTouchSize = new System.Drawing.Size(89, 78);
            this.btnProcurarProduto.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.None;
            this.btnProcurarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurarProduto.ForeColor = System.Drawing.Color.White;
            this.btnProcurarProduto.IsBackStageButton = false;
            this.btnProcurarProduto.Location = new System.Drawing.Point(4, 110);
            this.btnProcurarProduto.Name = "btnProcurarProduto";
            this.btnProcurarProduto.Size = new System.Drawing.Size(89, 78);
            this.btnProcurarProduto.TabIndex = 3;
            this.btnProcurarProduto.TabStop = false;
            this.btnProcurarProduto.Text = "Procurar F3";
            this.btnProcurarProduto.UseVisualStyle = true;
            this.btnProcurarProduto.UseVisualStyleBackColor = true;
            this.btnProcurarProduto.Click += new System.EventHandler(this.btnProcurarProduto_Click);
            // 
            // txtproduto
            // 
            this.txtproduto.BeforeTouchSize = new System.Drawing.Size(111, 35);
            this.txtproduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtproduto.Enabled = false;
            this.txtproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproduto.Location = new System.Drawing.Point(94, 148);
            this.txtproduto.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtproduto.Name = "txtproduto";
            this.txtproduto.ReadOnly = true;
            this.txtproduto.Size = new System.Drawing.Size(367, 40);
            this.txtproduto.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtproduto.TabIndex = 5;
            this.txtproduto.TabStop = false;
            this.txtproduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtproduto.ThemesEnabled = false;
            this.txtproduto.UseBorderColorOnFocus = true;
            this.txtproduto.TextChanged += new System.EventHandler(this.txtproduto_TextChanged);
            // 
            // txtCliente
            // 
            this.txtCliente.BeforeTouchSize = new System.Drawing.Size(111, 35);
            this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCliente.Enabled = false;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(4, 67);
            this.txtCliente.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(854, 40);
            this.txtCliente.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCliente.TabIndex = 2;
            this.txtCliente.TabStop = false;
            this.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCliente.ThemesEnabled = false;
            this.txtCliente.UseBorderColorOnFocus = true;
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))), System.Drawing.Color.White);
            this.gradientLabel1.BeforeTouchSize = new System.Drawing.Size(366, 38);
            this.gradientLabel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.gradientLabel1.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.gradientLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel1.Location = new System.Drawing.Point(95, 110);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(366, 38);
            this.gradientLabel1.TabIndex = 4;
            this.gradientLabel1.Text = "Produto";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbDadosVenda
            // 
            this.grbDadosVenda.Controls.Add(this.txtValorUnitario);
            this.grbDadosVenda.Controls.Add(this.lblValorUnitario);
            this.grbDadosVenda.Controls.Add(this.txtDescontoItem);
            this.grbDadosVenda.Controls.Add(this.gradientLabel4);
            this.grbDadosVenda.Controls.Add(this.btnFinalizarPedido);
            this.grbDadosVenda.Controls.Add(this.btnSelecionarCliente);
            this.grbDadosVenda.Controls.Add(this.btnOk);
            this.grbDadosVenda.Controls.Add(this.btnMenos);
            this.grbDadosVenda.Controls.Add(this.btnMais);
            this.grbDadosVenda.Controls.Add(this.gradientLabel3);
            this.grbDadosVenda.Controls.Add(this.gradientLabel2);
            this.grbDadosVenda.Controls.Add(this.txtQuantidade);
            this.grbDadosVenda.Controls.Add(this.lblQuantidade);
            this.grbDadosVenda.Controls.Add(this.btnProcurarProduto);
            this.grbDadosVenda.Controls.Add(this.txtproduto);
            this.grbDadosVenda.Controls.Add(this.txtCliente);
            this.grbDadosVenda.Controls.Add(this.gradientLabel1);
            this.grbDadosVenda.Controls.Add(this.lblLogin);
            this.grbDadosVenda.Enabled = false;
            this.grbDadosVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDadosVenda.ForeColor = System.Drawing.Color.White;
            this.grbDadosVenda.Location = new System.Drawing.Point(11, 3);
            this.grbDadosVenda.Name = "grbDadosVenda";
            this.grbDadosVenda.Size = new System.Drawing.Size(1074, 195);
            this.grbDadosVenda.TabIndex = 1;
            this.grbDadosVenda.TabStop = false;
            this.grbDadosVenda.Text = "Dados do Pedido:";
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.BackGroundColor = System.Drawing.SystemColors.Window;
            this.txtValorUnitario.BeforeTouchSize = new System.Drawing.Size(111, 35);
            this.txtValorUnitario.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txtValorUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorUnitario.Location = new System.Drawing.Point(592, 148);
            this.txtValorUnitario.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.NullString = "";
            this.txtValorUnitario.Size = new System.Drawing.Size(110, 40);
            this.txtValorUnitario.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtValorUnitario.TabIndex = 12;
            this.txtValorUnitario.Text = "R$ 0,00";
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))), System.Drawing.Color.White);
            this.lblValorUnitario.BeforeTouchSize = new System.Drawing.Size(110, 38);
            this.lblValorUnitario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.lblValorUnitario.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblValorUnitario.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.lblValorUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorUnitario.Location = new System.Drawing.Point(592, 110);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(110, 38);
            this.lblValorUnitario.TabIndex = 11;
            this.lblValorUnitario.Text = "R$ Unt.";
            this.lblValorUnitario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogin
            // 
            this.lblLogin.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))), System.Drawing.Color.White);
            this.lblLogin.BeforeTouchSize = new System.Drawing.Size(853, 38);
            this.lblLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.lblLogin.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblLogin.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(5, 31);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(853, 38);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Fornecedor";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDesconto
            // 
            this.txtDesconto.BackGroundColor = System.Drawing.SystemColors.Window;
            this.txtDesconto.BeforeTouchSize = new System.Drawing.Size(111, 35);
            this.txtDesconto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesconto.DoubleValue = 0D;
            this.txtDesconto.Enabled = false;
            this.txtDesconto.Location = new System.Drawing.Point(124, 67);
            this.txtDesconto.MaxValue = 100D;
            this.txtDesconto.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDesconto.MinValue = 0D;
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.NullString = "";
            this.txtDesconto.Size = new System.Drawing.Size(111, 35);
            this.txtDesconto.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.txtDesconto.TabIndex = 4;
            this.txtDesconto.Text = "0,00%";
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDesconto.TextChanged += new System.EventHandler(this.txtDesconto_Leave);
            this.txtDesconto.Leave += new System.EventHandler(this.txtDesconto_Leave);
            // 
            // txtValorFinal
            // 
            this.txtValorFinal.BackGroundColor = System.Drawing.SystemColors.Window;
            this.txtValorFinal.BeforeTouchSize = new System.Drawing.Size(111, 35);
            this.txtValorFinal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtValorFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorFinal.ClipMode = Syncfusion.Windows.Forms.Tools.CurrencyClipModes.ExcludeFormatting;
            this.txtValorFinal.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txtValorFinal.Enabled = false;
            this.txtValorFinal.Location = new System.Drawing.Point(243, 67);
            this.txtValorFinal.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtValorFinal.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtValorFinal.Name = "txtValorFinal";
            this.txtValorFinal.NullString = "";
            this.txtValorFinal.ReadOnly = true;
            this.txtValorFinal.ReadOnlyBackColor = System.Drawing.Color.White;
            this.txtValorFinal.Size = new System.Drawing.Size(111, 35);
            this.txtValorFinal.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.txtValorFinal.TabIndex = 6;
            this.txtValorFinal.TabStop = false;
            this.txtValorFinal.Text = "0,00";
            this.txtValorFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValorFinal.ZeroColor = System.Drawing.Color.DarkRed;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.BackGroundColor = System.Drawing.SystemColors.Window;
            this.txtValorTotal.BeforeTouchSize = new System.Drawing.Size(111, 35);
            this.txtValorTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorTotal.ClipMode = Syncfusion.Windows.Forms.Tools.CurrencyClipModes.ExcludeFormatting;
            this.txtValorTotal.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(5, 67);
            this.txtValorTotal.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtValorTotal.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.NullString = "";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.ReadOnlyBackColor = System.Drawing.Color.White;
            this.txtValorTotal.Size = new System.Drawing.Size(111, 35);
            this.txtValorTotal.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.txtValorTotal.TabIndex = 2;
            this.txtValorTotal.TabStop = false;
            this.txtValorTotal.Text = "0,00";
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValorTotal.ZeroColor = System.Drawing.Color.DarkRed;
            // 
            // lblValorFinal
            // 
            this.lblValorFinal.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))), System.Drawing.Color.White);
            this.lblValorFinal.BeforeTouchSize = new System.Drawing.Size(111, 33);
            this.lblValorFinal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.lblValorFinal.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblValorFinal.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.lblValorFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorFinal.Location = new System.Drawing.Point(243, 34);
            this.lblValorFinal.Name = "lblValorFinal";
            this.lblValorFinal.Size = new System.Drawing.Size(111, 33);
            this.lblValorFinal.TabIndex = 5;
            this.lblValorFinal.Text = "Valor Final";
            this.lblValorFinal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDesconto
            // 
            this.lblDesconto.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))), System.Drawing.Color.White);
            this.lblDesconto.BeforeTouchSize = new System.Drawing.Size(111, 33);
            this.lblDesconto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.lblDesconto.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblDesconto.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.lblDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesconto.Location = new System.Drawing.Point(124, 34);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(111, 33);
            this.lblDesconto.TabIndex = 3;
            this.lblDesconto.Text = "% Desconto";
            this.lblDesconto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))), System.Drawing.Color.White);
            this.lblValorTotal.BeforeTouchSize = new System.Drawing.Size(111, 33);
            this.lblValorTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.lblValorTotal.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblValorTotal.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(5, 34);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(111, 33);
            this.lblValorTotal.TabIndex = 1;
            this.lblValorTotal.Text = "Valor Total";
            this.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grbFinalizaVenda
            // 
            this.grbFinalizaVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grbFinalizaVenda.Controls.Add(this.cbbFormaPagamento);
            this.grbFinalizaVenda.Controls.Add(this.lblFormaPagamento);
            this.grbFinalizaVenda.Controls.Add(this.txtDesconto);
            this.grbFinalizaVenda.Controls.Add(this.txtValorFinal);
            this.grbFinalizaVenda.Controls.Add(this.txtValorTotal);
            this.grbFinalizaVenda.Controls.Add(this.btnNovaVenda);
            this.grbFinalizaVenda.Controls.Add(this.btnCancelar);
            this.grbFinalizaVenda.Controls.Add(this.btnFinalizarVenda);
            this.grbFinalizaVenda.Controls.Add(this.lblValorFinal);
            this.grbFinalizaVenda.Controls.Add(this.lblDesconto);
            this.grbFinalizaVenda.Controls.Add(this.lblValorTotal);
            this.grbFinalizaVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFinalizaVenda.ForeColor = System.Drawing.Color.White;
            this.grbFinalizaVenda.Location = new System.Drawing.Point(11, 470);
            this.grbFinalizaVenda.Name = "grbFinalizaVenda";
            this.grbFinalizaVenda.Size = new System.Drawing.Size(1077, 111);
            this.grbFinalizaVenda.TabIndex = 0;
            this.grbFinalizaVenda.TabStop = false;
            this.grbFinalizaVenda.Text = "Finalização da Compra:";
            // 
            // cbbFormaPagamento
            // 
            this.cbbFormaPagamento.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbbFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFormaPagamento.Enabled = false;
            this.cbbFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFormaPagamento.FormattingEnabled = true;
            this.cbbFormaPagamento.Location = new System.Drawing.Point(361, 70);
            this.cbbFormaPagamento.Name = "cbbFormaPagamento";
            this.cbbFormaPagamento.Size = new System.Drawing.Size(244, 32);
            this.cbbFormaPagamento.TabIndex = 8;
            // 
            // lblFormaPagamento
            // 
            this.lblFormaPagamento.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))), System.Drawing.Color.White);
            this.lblFormaPagamento.BeforeTouchSize = new System.Drawing.Size(244, 33);
            this.lblFormaPagamento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.lblFormaPagamento.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblFormaPagamento.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.lblFormaPagamento.Enabled = false;
            this.lblFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaPagamento.Location = new System.Drawing.Point(361, 34);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(244, 33);
            this.lblFormaPagamento.TabIndex = 7;
            this.lblFormaPagamento.Text = "Forma de Pagamento";
            this.lblFormaPagamento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmCompraWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Borders = new System.Windows.Forms.Padding(0);
            this.ClientSize = new System.Drawing.Size(1097, 588);
            this.Controls.Add(this.grbListaProdutos);
            this.Controls.Add(this.grbDadosVenda);
            this.Controls.Add(this.grbFinalizaVenda);
            this.EnableRibbonBorder = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCompraWindows";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido de Compra";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCompraWindows_FormClosed);
            this.Load += new System.EventHandler(this.FrmCompraWindows_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCompraWindows_KeyDown);
            this.grbListaProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbgListaProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescontoItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtproduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente)).EndInit();
            this.grbDadosVenda.ResumeLayout(false);
            this.grbDadosVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorUnitario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorTotal)).EndInit();
            this.grbFinalizaVenda.ResumeLayout(false);
            this.grbFinalizaVenda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbListaProdutos;
        private Syncfusion.Windows.Forms.ButtonAdv btnRemoverItem;
        private System.Windows.Forms.DataGridView dbgListaProdutos;
        private Syncfusion.Windows.Forms.ButtonAdv btnNovaVenda;
        private Syncfusion.Windows.Forms.ButtonAdv btnCancelar;
        private Syncfusion.Windows.Forms.ButtonAdv btnFinalizarVenda;
        private Syncfusion.Windows.Forms.Tools.PercentTextBox txtDescontoItem;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel4;
        private Syncfusion.Windows.Forms.ButtonAdv btnFinalizarPedido;
        private Syncfusion.Windows.Forms.ButtonAdv btnSelecionarCliente;
        private Syncfusion.Windows.Forms.ButtonAdv btnOk;
        private Syncfusion.Windows.Forms.ButtonAdv btnMenos;
        private Syncfusion.Windows.Forms.ButtonAdv btnMais;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel3;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel2;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox txtQuantidade;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblQuantidade;
        private Syncfusion.Windows.Forms.ButtonAdv btnProcurarProduto;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtproduto;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt txtCliente;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel1;
        private System.Windows.Forms.GroupBox grbDadosVenda;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblLogin;
        private Syncfusion.Windows.Forms.Tools.PercentTextBox txtDesconto;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox txtValorFinal;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox txtValorTotal;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblValorFinal;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblDesconto;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblValorTotal;
        private System.Windows.Forms.GroupBox grbFinalizaVenda;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox txtValorUnitario;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblValorUnitario;
        private System.Windows.Forms.ComboBox cbbFormaPagamento;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblFormaPagamento;
    }
}