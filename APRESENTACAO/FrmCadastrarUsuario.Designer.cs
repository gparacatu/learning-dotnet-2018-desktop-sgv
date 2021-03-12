#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace APRESENTACAO
{
    partial class FrmCadastrarUsuario
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
            this.txtSenha = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.btnCancelar = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnOk = new Syncfusion.Windows.Forms.ButtonAdv();
            this.txtUsuario = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblLogin = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.lblSenha = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.txtRepetirSenha = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblRepetirSenha = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.imgUsuario = new System.Windows.Forms.PictureBox();
            this.grbAcesso = new System.Windows.Forms.GroupBox();
            this.rdbFinanceiro = new System.Windows.Forms.RadioButton();
            this.rdbCompras = new System.Windows.Forms.RadioButton();
            this.rdbCaixa = new System.Windows.Forms.RadioButton();
            this.rdbAdministrador = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepetirSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).BeginInit();
            this.grbAcesso.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSenha
            // 
            this.txtSenha.BeforeTouchSize = new System.Drawing.Size(176, 20);
            this.txtSenha.Location = new System.Drawing.Point(138, 73);
            this.txtSenha.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(176, 20);
            this.txtSenha.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSenha.TabIndex = 3;
            this.txtSenha.ThemesEnabled = false;
            this.txtSenha.UseBorderColorOnFocus = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnCancelar.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IsBackStageButton = false;
            this.btnCancelar.Location = new System.Drawing.Point(239, 163);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyle = true;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnOk
            // 
            this.btnOk.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnOk.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.IsBackStageButton = false;
            this.btnOk.Location = new System.Drawing.Point(138, 163);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "&Cadastrar";
            this.btnOk.UseVisualStyle = true;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BeforeTouchSize = new System.Drawing.Size(176, 20);
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Location = new System.Drawing.Point(138, 30);
            this.txtUsuario.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(176, 20);
            this.txtUsuario.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.ThemesEnabled = false;
            this.txtUsuario.UseBorderColorOnFocus = true;
            // 
            // lblLogin
            // 
            this.lblLogin.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))), System.Drawing.Color.White);
            this.lblLogin.BeforeTouchSize = new System.Drawing.Size(176, 23);
            this.lblLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.lblLogin.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblLogin.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.lblLogin.Location = new System.Drawing.Point(138, 7);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(176, 23);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Digite um Usuário";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSenha
            // 
            this.lblSenha.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))), System.Drawing.Color.White);
            this.lblSenha.BeforeTouchSize = new System.Drawing.Size(176, 23);
            this.lblSenha.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblSenha.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.lblSenha.Location = new System.Drawing.Point(138, 50);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(176, 23);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Digite uma Senha";
            this.lblSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRepetirSenha
            // 
            this.txtRepetirSenha.BeforeTouchSize = new System.Drawing.Size(176, 20);
            this.txtRepetirSenha.Location = new System.Drawing.Point(138, 116);
            this.txtRepetirSenha.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtRepetirSenha.Name = "txtRepetirSenha";
            this.txtRepetirSenha.PasswordChar = '*';
            this.txtRepetirSenha.Size = new System.Drawing.Size(176, 20);
            this.txtRepetirSenha.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtRepetirSenha.TabIndex = 5;
            this.txtRepetirSenha.ThemesEnabled = false;
            this.txtRepetirSenha.UseBorderColorOnFocus = true;
            // 
            // lblRepetirSenha
            // 
            this.lblRepetirSenha.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))), System.Drawing.Color.White);
            this.lblRepetirSenha.BeforeTouchSize = new System.Drawing.Size(176, 23);
            this.lblRepetirSenha.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblRepetirSenha.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.lblRepetirSenha.Location = new System.Drawing.Point(138, 93);
            this.lblRepetirSenha.Name = "lblRepetirSenha";
            this.lblRepetirSenha.Size = new System.Drawing.Size(176, 23);
            this.lblRepetirSenha.TabIndex = 4;
            this.lblRepetirSenha.Text = "Repita a Senha";
            this.lblRepetirSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgUsuario
            // 
            this.imgUsuario.Image = global::APRESENTACAO.Properties.Resources.Office_Customer_Male_Light_icon;
            this.imgUsuario.Location = new System.Drawing.Point(4, 2);
            this.imgUsuario.Name = "imgUsuario";
            this.imgUsuario.Size = new System.Drawing.Size(128, 146);
            this.imgUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgUsuario.TabIndex = 19;
            this.imgUsuario.TabStop = false;
            // 
            // grbAcesso
            // 
            this.grbAcesso.Controls.Add(this.rdbFinanceiro);
            this.grbAcesso.Controls.Add(this.rdbCompras);
            this.grbAcesso.Controls.Add(this.rdbCaixa);
            this.grbAcesso.Controls.Add(this.rdbAdministrador);
            this.grbAcesso.Location = new System.Drawing.Point(320, 2);
            this.grbAcesso.Name = "grbAcesso";
            this.grbAcesso.Size = new System.Drawing.Size(137, 146);
            this.grbAcesso.TabIndex = 6;
            this.grbAcesso.TabStop = false;
            this.grbAcesso.Text = "Permissões de Acesso";
            // 
            // rdbFinanceiro
            // 
            this.rdbFinanceiro.AutoSize = true;
            this.rdbFinanceiro.Location = new System.Drawing.Point(24, 117);
            this.rdbFinanceiro.Name = "rdbFinanceiro";
            this.rdbFinanceiro.Size = new System.Drawing.Size(74, 17);
            this.rdbFinanceiro.TabIndex = 3;
            this.rdbFinanceiro.Text = "Financeiro";
            this.rdbFinanceiro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbFinanceiro.UseVisualStyleBackColor = true;
            // 
            // rdbCompras
            // 
            this.rdbCompras.AutoSize = true;
            this.rdbCompras.Location = new System.Drawing.Point(24, 84);
            this.rdbCompras.Name = "rdbCompras";
            this.rdbCompras.Size = new System.Drawing.Size(66, 17);
            this.rdbCompras.TabIndex = 2;
            this.rdbCompras.Text = "Compras";
            this.rdbCompras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbCompras.UseVisualStyleBackColor = true;
            // 
            // rdbCaixa
            // 
            this.rdbCaixa.AutoSize = true;
            this.rdbCaixa.Checked = true;
            this.rdbCaixa.Location = new System.Drawing.Point(24, 51);
            this.rdbCaixa.Name = "rdbCaixa";
            this.rdbCaixa.Size = new System.Drawing.Size(51, 17);
            this.rdbCaixa.TabIndex = 1;
            this.rdbCaixa.TabStop = true;
            this.rdbCaixa.Text = "Caixa";
            this.rdbCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbCaixa.UseVisualStyleBackColor = true;
            // 
            // rdbAdministrador
            // 
            this.rdbAdministrador.AutoSize = true;
            this.rdbAdministrador.Location = new System.Drawing.Point(24, 18);
            this.rdbAdministrador.Name = "rdbAdministrador";
            this.rdbAdministrador.Size = new System.Drawing.Size(88, 17);
            this.rdbAdministrador.TabIndex = 0;
            this.rdbAdministrador.Text = "Administrador";
            this.rdbAdministrador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbAdministrador.UseVisualStyleBackColor = true;
            // 
            // FrmCadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(461, 194);
            this.Controls.Add(this.grbAcesso);
            this.Controls.Add(this.txtRepetirSenha);
            this.Controls.Add(this.lblRepetirSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.imgUsuario);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastrarUsuario";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCadastrarUsuario_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepetirSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).EndInit();
            this.grbAcesso.ResumeLayout(false);
            this.grbAcesso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSenha;
        private Syncfusion.Windows.Forms.ButtonAdv btnCancelar;
        private Syncfusion.Windows.Forms.ButtonAdv btnOk;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtUsuario;
        private System.Windows.Forms.PictureBox imgUsuario;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblLogin;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblSenha;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtRepetirSenha;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblRepetirSenha;
        private System.Windows.Forms.GroupBox grbAcesso;
        private System.Windows.Forms.RadioButton rdbCompras;
        private System.Windows.Forms.RadioButton rdbCaixa;
        private System.Windows.Forms.RadioButton rdbAdministrador;
        private System.Windows.Forms.RadioButton rdbFinanceiro;
    }
}