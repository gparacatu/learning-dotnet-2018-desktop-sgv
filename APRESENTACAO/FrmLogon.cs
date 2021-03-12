#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using NEGOCIOS;
using TRANSFERENCIA;

namespace APRESENTACAO
{
    public partial class FrmLogon : Syncfusion.Windows.Forms.MetroForm
    {
        public FrmLogon()
        {
            InitializeComponent();
        }

        private void FrmLogon_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ControleFormulario.frmLogon != null)
                ControleFormulario.frmLogon = null;
            Application.Exit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
                                                                                                                                                                                                            try
            {
                UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
                Usuario usuarioLogado = new Usuario();
                usuarioLogado = usuarioNegocio.ConsultarPorUsuarioSenha(txtUsuario.Text, txtSenha.Text);

                if (usuarioLogado.IDStatus == 2)
                {
                    MessageBox.Show("Esse usuário foi desativado. Entre em contato com o administrador.");
                    this.Close();
                }
               
                PessoaFilial filial = new PessoaFilial();
                PessoaFilialNegocio filialNegocio = new PessoaFilialNegocio();

                filial = filialNegocio.ConsultarIdNomeLogon(usuarioLogado.IDFilial, null);

                ControleSistema.setFilialUsuario(filial, usuarioLogado);

                ControleSistema.atualizaCaixaAtual();

                //abre o formulario atual
                ControleFormulario.abreFrmMenu(usuarioLogado, filial);       
                              

                this.Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                txtUsuario.Focus();
            }
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmLogon_Load(object sender, EventArgs e)
        {
            //cbbLayout.SelectedIndex = 0;
        }

        private void FrmLogon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar_Click(sender, e);
            }
        }
    }
}
