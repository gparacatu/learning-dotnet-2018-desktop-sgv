#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace APRESENTACAO
{
    partial class FrmRelatorioCompras
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
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.btnSair = new Syncfusion.Windows.Forms.ButtonAdv();
            this.lblDatas = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.lblDescricao = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.btnGerar = new Syncfusion.Windows.Forms.ButtonAdv();
            this.SuspendLayout();
            // 
            // dtpFinal
            // 
            this.dtpFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(272, 82);
            this.dtpFinal.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(250, 32);
            this.dtpFinal.TabIndex = 17;
            // 
            // dtpInicial
            // 
            this.dtpInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicial.Location = new System.Drawing.Point(14, 82);
            this.dtpInicial.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(250, 32);
            this.dtpInicial.TabIndex = 16;
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
            this.btnSair.Location = new System.Drawing.Point(438, 132);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(96, 33);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyle = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblDatas
            // 
            this.lblDatas.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))));
            this.lblDatas.BeforeTouchSize = new System.Drawing.Size(548, 38);
            this.lblDatas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.lblDatas.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblDatas.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.lblDatas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatas.ForeColor = System.Drawing.Color.White;
            this.lblDatas.Location = new System.Drawing.Point(-6, 42);
            this.lblDatas.Name = "lblDatas";
            this.lblDatas.Size = new System.Drawing.Size(548, 38);
            this.lblDatas.TabIndex = 13;
            this.lblDatas.Text = "                  Data Inicial                                   Data Final";
            this.lblDatas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescricao
            // 
            this.lblDescricao.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))));
            this.lblDescricao.BeforeTouchSize = new System.Drawing.Size(543, 38);
            this.lblDescricao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.lblDescricao.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblDescricao.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.White;
            this.lblDescricao.Location = new System.Drawing.Point(-6, -1);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(543, 38);
            this.lblDescricao.TabIndex = 12;
            this.lblDescricao.Text = "Relatório de Compras";
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGerar
            // 
            this.btnGerar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGerar.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnGerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnGerar.BeforeTouchSize = new System.Drawing.Size(96, 33);
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.ForeColor = System.Drawing.Color.White;
            this.btnGerar.IsBackStageButton = false;
            this.btnGerar.Location = new System.Drawing.Point(336, 132);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(96, 33);
            this.btnGerar.TabIndex = 14;
            this.btnGerar.Text = "&Gerar";
            this.btnGerar.UseVisualStyle = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // FrmRelatorioCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Borders = new System.Windows.Forms.Padding(0);
            this.ClientSize = new System.Drawing.Size(536, 175);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.dtpInicial);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblDatas);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.btnGerar);
            this.EnableRibbonBorder = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRelatorioCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Compras";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRelatorioCompras_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private Syncfusion.Windows.Forms.ButtonAdv btnSair;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblDatas;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblDescricao;
        private Syncfusion.Windows.Forms.ButtonAdv btnGerar;
    }
}