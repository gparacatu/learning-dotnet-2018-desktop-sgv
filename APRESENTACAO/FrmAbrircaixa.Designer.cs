#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace APRESENTACAO
{
    partial class FrmAbrircaixa
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
            this.btnAbrirCaixa = new Syncfusion.Windows.Forms.ButtonAdv();
            this.lblAbrirCaixa = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.lblValorInicial = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.txtValorInicial = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.btnSair = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorInicial)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbrirCaixa
            // 
            this.btnAbrirCaixa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAbrirCaixa.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnAbrirCaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnAbrirCaixa.BeforeTouchSize = new System.Drawing.Size(96, 33);
            this.btnAbrirCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCaixa.ForeColor = System.Drawing.Color.White;
            this.btnAbrirCaixa.IsBackStageButton = false;
            this.btnAbrirCaixa.Location = new System.Drawing.Point(325, 118);
            this.btnAbrirCaixa.Name = "btnAbrirCaixa";
            this.btnAbrirCaixa.Size = new System.Drawing.Size(96, 33);
            this.btnAbrirCaixa.TabIndex = 3;
            this.btnAbrirCaixa.Text = "&Abrir Caixa";
            this.btnAbrirCaixa.UseVisualStyle = true;
            this.btnAbrirCaixa.Click += new System.EventHandler(this.btnAbrirCaixa_Click);
            // 
            // lblAbrirCaixa
            // 
            this.lblAbrirCaixa.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))));
            this.lblAbrirCaixa.BeforeTouchSize = new System.Drawing.Size(543, 38);
            this.lblAbrirCaixa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.lblAbrirCaixa.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblAbrirCaixa.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.lblAbrirCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbrirCaixa.ForeColor = System.Drawing.Color.White;
            this.lblAbrirCaixa.Location = new System.Drawing.Point(-10, 1);
            this.lblAbrirCaixa.Name = "lblAbrirCaixa";
            this.lblAbrirCaixa.Size = new System.Drawing.Size(543, 38);
            this.lblAbrirCaixa.TabIndex = 0;
            this.lblAbrirCaixa.Text = "Abrir Caixa";
            this.lblAbrirCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValorInicial
            // 
            this.lblValorInicial.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))));
            this.lblValorInicial.BeforeTouchSize = new System.Drawing.Size(543, 38);
            this.lblValorInicial.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.lblValorInicial.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblValorInicial.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.lblValorInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorInicial.ForeColor = System.Drawing.Color.White;
            this.lblValorInicial.Location = new System.Drawing.Point(-10, 44);
            this.lblValorInicial.Name = "lblValorInicial";
            this.lblValorInicial.Size = new System.Drawing.Size(543, 38);
            this.lblValorInicial.TabIndex = 1;
            this.lblValorInicial.Text = "Valor Inicial";
            this.lblValorInicial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtValorInicial
            // 
            this.txtValorInicial.BackGroundColor = System.Drawing.SystemColors.Window;
            this.txtValorInicial.BeforeTouchSize = new System.Drawing.Size(543, 35);
            this.txtValorInicial.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txtValorInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorInicial.Location = new System.Drawing.Point(-10, 82);
            this.txtValorInicial.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtValorInicial.Name = "txtValorInicial";
            this.txtValorInicial.NullString = "";
            this.txtValorInicial.Size = new System.Drawing.Size(543, 35);
            this.txtValorInicial.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtValorInicial.TabIndex = 2;
            this.txtValorInicial.Text = "R$ 0,00";
            this.txtValorInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnSair.Location = new System.Drawing.Point(427, 118);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(96, 33);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyle = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmAbrircaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Borders = new System.Windows.Forms.Padding(0);
            this.ClientSize = new System.Drawing.Size(520, 155);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtValorInicial);
            this.Controls.Add(this.lblValorInicial);
            this.Controls.Add(this.lblAbrirCaixa);
            this.Controls.Add(this.btnAbrirCaixa);
            this.EnableRibbonBorder = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbrircaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abrir Caixa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAbrircaixa_FormClosed);
            this.Load += new System.EventHandler(this.FrmAbrircaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtValorInicial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.ButtonAdv btnAbrirCaixa;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblAbrirCaixa;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblValorInicial;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox txtValorInicial;
        private Syncfusion.Windows.Forms.ButtonAdv btnSair;
    }
}