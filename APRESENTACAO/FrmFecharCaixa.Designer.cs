#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace APRESENTACAO
{
    partial class FrmFecharCaixa
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
            this.txtValorInicial = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.lblValorInicial = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.lblFecharCaixa = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.btnFecharCaixa = new Syncfusion.Windows.Forms.ButtonAdv();
            this.txtValorTotal = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.txtValorEmCaixa = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.gradientLabel2 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.txtValorSangria = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.gradientLabel3 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.txtValorDiferenca = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.gradientLabel4 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.btnSair = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorEmCaixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorSangria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorDiferenca)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValorInicial
            // 
            this.txtValorInicial.BackGroundColor = System.Drawing.SystemColors.Window;
            this.txtValorInicial.BeforeTouchSize = new System.Drawing.Size(543, 32);
            this.txtValorInicial.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txtValorInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorInicial.Location = new System.Drawing.Point(153, 55);
            this.txtValorInicial.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtValorInicial.Name = "txtValorInicial";
            this.txtValorInicial.NullString = "";
            this.txtValorInicial.ReadOnly = true;
            this.txtValorInicial.ReadOnlyBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtValorInicial.Size = new System.Drawing.Size(155, 35);
            this.txtValorInicial.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtValorInicial.TabIndex = 2;
            this.txtValorInicial.TabStop = false;
            this.txtValorInicial.Text = "R$ 0,00";
            // 
            // lblValorInicial
            // 
            this.lblValorInicial.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))));
            this.lblValorInicial.BeforeTouchSize = new System.Drawing.Size(155, 35);
            this.lblValorInicial.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.lblValorInicial.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblValorInicial.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.lblValorInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorInicial.ForeColor = System.Drawing.Color.White;
            this.lblValorInicial.Location = new System.Drawing.Point(-2, 55);
            this.lblValorInicial.Name = "lblValorInicial";
            this.lblValorInicial.Size = new System.Drawing.Size(155, 35);
            this.lblValorInicial.TabIndex = 1;
            this.lblValorInicial.Text = "Valor Inicial:";
            this.lblValorInicial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFecharCaixa
            // 
            this.lblFecharCaixa.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))));
            this.lblFecharCaixa.BeforeTouchSize = new System.Drawing.Size(334, 45);
            this.lblFecharCaixa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.lblFecharCaixa.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblFecharCaixa.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.lblFecharCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecharCaixa.ForeColor = System.Drawing.Color.White;
            this.lblFecharCaixa.Location = new System.Drawing.Point(-13, -3);
            this.lblFecharCaixa.Name = "lblFecharCaixa";
            this.lblFecharCaixa.Size = new System.Drawing.Size(334, 45);
            this.lblFecharCaixa.TabIndex = 0;
            this.lblFecharCaixa.Text = "Fechar Caixa";
            this.lblFecharCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFecharCaixa
            // 
            this.btnFecharCaixa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFecharCaixa.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnFecharCaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnFecharCaixa.BeforeTouchSize = new System.Drawing.Size(110, 33);
            this.btnFecharCaixa.Enabled = false;
            this.btnFecharCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharCaixa.ForeColor = System.Drawing.Color.White;
            this.btnFecharCaixa.IsBackStageButton = false;
            this.btnFecharCaixa.Location = new System.Drawing.Point(96, 298);
            this.btnFecharCaixa.Name = "btnFecharCaixa";
            this.btnFecharCaixa.Size = new System.Drawing.Size(110, 33);
            this.btnFecharCaixa.TabIndex = 11;
            this.btnFecharCaixa.Text = "&Fechar Caixa";
            this.btnFecharCaixa.UseVisualStyle = true;
            this.btnFecharCaixa.Click += new System.EventHandler(this.btnFecharCaixa_Click);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.BackGroundColor = System.Drawing.SystemColors.Window;
            this.txtValorTotal.BeforeTouchSize = new System.Drawing.Size(543, 32);
            this.txtValorTotal.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(153, 98);
            this.txtValorTotal.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.NullString = "";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.ReadOnlyBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtValorTotal.Size = new System.Drawing.Size(155, 35);
            this.txtValorTotal.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtValorTotal.TabIndex = 4;
            this.txtValorTotal.TabStop = false;
            this.txtValorTotal.Text = "R$ 0,00";
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))));
            this.gradientLabel1.BeforeTouchSize = new System.Drawing.Size(155, 35);
            this.gradientLabel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.gradientLabel1.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.gradientLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel1.ForeColor = System.Drawing.Color.White;
            this.gradientLabel1.Location = new System.Drawing.Point(-2, 98);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(155, 35);
            this.gradientLabel1.TabIndex = 3;
            this.gradientLabel1.Text = "Valor Total:";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtValorEmCaixa
            // 
            this.txtValorEmCaixa.BackGroundColor = System.Drawing.SystemColors.Window;
            this.txtValorEmCaixa.BeforeTouchSize = new System.Drawing.Size(543, 32);
            this.txtValorEmCaixa.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txtValorEmCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorEmCaixa.Location = new System.Drawing.Point(153, 141);
            this.txtValorEmCaixa.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtValorEmCaixa.Name = "txtValorEmCaixa";
            this.txtValorEmCaixa.NullString = "";
            this.txtValorEmCaixa.Size = new System.Drawing.Size(155, 35);
            this.txtValorEmCaixa.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtValorEmCaixa.TabIndex = 6;
            this.txtValorEmCaixa.Text = "R$ 0,00";
            this.txtValorEmCaixa.TextChanged += new System.EventHandler(this.txtValorEmCaixa_TextChanged);
            // 
            // gradientLabel2
            // 
            this.gradientLabel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))));
            this.gradientLabel2.BeforeTouchSize = new System.Drawing.Size(155, 35);
            this.gradientLabel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.gradientLabel2.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.gradientLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel2.ForeColor = System.Drawing.Color.White;
            this.gradientLabel2.Location = new System.Drawing.Point(-2, 141);
            this.gradientLabel2.Name = "gradientLabel2";
            this.gradientLabel2.Size = new System.Drawing.Size(155, 35);
            this.gradientLabel2.TabIndex = 5;
            this.gradientLabel2.Text = "Valor em Caixa:";
            this.gradientLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtValorSangria
            // 
            this.txtValorSangria.BackGroundColor = System.Drawing.SystemColors.Window;
            this.txtValorSangria.BeforeTouchSize = new System.Drawing.Size(543, 32);
            this.txtValorSangria.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txtValorSangria.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorSangria.Location = new System.Drawing.Point(153, 184);
            this.txtValorSangria.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtValorSangria.Name = "txtValorSangria";
            this.txtValorSangria.NullString = "";
            this.txtValorSangria.Size = new System.Drawing.Size(155, 35);
            this.txtValorSangria.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtValorSangria.TabIndex = 8;
            this.txtValorSangria.Text = "R$ 0,00";
            // 
            // gradientLabel3
            // 
            this.gradientLabel3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))));
            this.gradientLabel3.BeforeTouchSize = new System.Drawing.Size(155, 35);
            this.gradientLabel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.gradientLabel3.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.gradientLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel3.ForeColor = System.Drawing.Color.White;
            this.gradientLabel3.Location = new System.Drawing.Point(-2, 184);
            this.gradientLabel3.Name = "gradientLabel3";
            this.gradientLabel3.Size = new System.Drawing.Size(155, 35);
            this.gradientLabel3.TabIndex = 7;
            this.gradientLabel3.Text = "Valor de Sangria:";
            this.gradientLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtValorDiferenca
            // 
            this.txtValorDiferenca.BackGroundColor = System.Drawing.SystemColors.Window;
            this.txtValorDiferenca.BeforeTouchSize = new System.Drawing.Size(543, 32);
            this.txtValorDiferenca.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txtValorDiferenca.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDiferenca.ForeColor = System.Drawing.Color.DarkRed;
            this.txtValorDiferenca.Location = new System.Drawing.Point(-2, 257);
            this.txtValorDiferenca.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtValorDiferenca.Name = "txtValorDiferenca";
            this.txtValorDiferenca.NullString = "";
            this.txtValorDiferenca.PositiveColor = System.Drawing.Color.DarkRed;
            this.txtValorDiferenca.ReadOnly = true;
            this.txtValorDiferenca.ReadOnlyBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtValorDiferenca.Size = new System.Drawing.Size(310, 35);
            this.txtValorDiferenca.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtValorDiferenca.TabIndex = 10;
            this.txtValorDiferenca.TabStop = false;
            this.txtValorDiferenca.Text = "R$ 0,00";
            this.txtValorDiferenca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gradientLabel4
            // 
            this.gradientLabel4.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))));
            this.gradientLabel4.BeforeTouchSize = new System.Drawing.Size(310, 38);
            this.gradientLabel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.gradientLabel4.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel4.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.gradientLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel4.ForeColor = System.Drawing.Color.White;
            this.gradientLabel4.Location = new System.Drawing.Point(-2, 219);
            this.gradientLabel4.Name = "gradientLabel4";
            this.gradientLabel4.Size = new System.Drawing.Size(310, 38);
            this.gradientLabel4.TabIndex = 9;
            this.gradientLabel4.Text = "Diferença no Caixa";
            this.gradientLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSair.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnSair.BeforeTouchSize = new System.Drawing.Size(96, 33);
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.IsBackStageButton = false;
            this.btnSair.Location = new System.Drawing.Point(214, 298);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(96, 33);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyle = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmFecharCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(312, 334);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtValorDiferenca);
            this.Controls.Add(this.gradientLabel4);
            this.Controls.Add(this.txtValorSangria);
            this.Controls.Add(this.gradientLabel3);
            this.Controls.Add(this.txtValorEmCaixa);
            this.Controls.Add(this.gradientLabel2);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.gradientLabel1);
            this.Controls.Add(this.txtValorInicial);
            this.Controls.Add(this.lblValorInicial);
            this.Controls.Add(this.lblFecharCaixa);
            this.Controls.Add(this.btnFecharCaixa);
            this.EnableRibbonBorder = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmFecharCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fechar Caixa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmFecharCaixa_FormClosed);
            this.Load += new System.EventHandler(this.FrmFecharCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtValorInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorEmCaixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorSangria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorDiferenca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox txtValorInicial;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblValorInicial;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblFecharCaixa;
        private Syncfusion.Windows.Forms.ButtonAdv btnFecharCaixa;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox txtValorTotal;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel1;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox txtValorEmCaixa;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel2;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox txtValorSangria;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel3;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox txtValorDiferenca;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel4;
        private Syncfusion.Windows.Forms.ButtonAdv btnSair;
    }
}