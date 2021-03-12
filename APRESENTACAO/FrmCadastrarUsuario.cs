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
using TRANSFERENCIA;
using NEGOCIOS;

namespace APRESENTACAO
{
    public partial class FrmCadastrarUsuario : Syncfusion.Windows.Forms.MetroForm
    {
        PessoaFisica pessoaFisicaSelecionada;
        PessoaJuridica pessoaJuridicaSelecionada;
        public FrmCadastrarUsuario()
        {
            InitializeComponent();
        }

        public FrmCadastrarUsuario(PessoaFisica pessoaFisica, PessoaJuridica pessoaJuridica)
        {            
            pessoaFisicaSelecionada = pessoaFisica;

            pessoaJuridicaSelecionada = pessoaJuridica;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCadastrarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ControleFormulario.frmCadastrarUsu != null)
            {
                ControleFormulario.frmCadastrarUsu = null;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtSenha.Text != "" && txtRepetirSenha.Text != "")
            {
                if (txtSenha.Text == txtRepetirSenha.Text)
                {
                    try
                    {
                        Usuario novoUsuario = new Usuario();
                        if (rdbAdministrador.Checked)
                        {
                            novoUsuario.Acesso = 5;
                        }
                        else if (rdbCaixa.Checked)
                        {
                            novoUsuario.Acesso = 1;
                        }
                        else if (rdbCompras.Checked)
                        {
                            novoUsuario.Acesso = 2;
                        }
                        else if (rdbFinanceiro.Checked)
                        {
                            novoUsuario.Acesso = 3;
                        }

                        novoUsuario.IDFilial = ControleSistema.getFilialLogada().IDFilial;
                        if (pessoaFisicaSelecionada != null)
                        {
                            novoUsuario.IDPessoa = pessoaFisicaSelecionada.IDPessoa;
                        }
                        else
                        {
                            novoUsuario.IDPessoa = pessoaJuridicaSelecionada.IDPessoa;
                        }

                        novoUsuario.IDStatus = 1;
                        novoUsuario.Login = txtUsuario.Text;
                        novoUsuario.Senha = txtSenha.Text;

                        UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

                        string retorno = usuarioNegocio.Inserir(novoUsuario);

                        int IDUsuario;
                        if (!int.TryParse(retorno, out IDUsuario))
                        {
                            MessageBox.Show("Erro ao inserir novo usuário. Detalhes: " + retorno);                            
                            return;                            
                        }
                        else
                        {
                            MessageBox.Show("Usuário inserido com sucesso. ID do no usuário: " + retorno);
                            Close();
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Erro ao inserir usuário. Detalhes: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("As senhas são diferentes.");
                    txtSenha.Clear();
                    txtRepetirSenha.Clear();
                    txtSenha.Focus();
                }
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.");
                txtUsuario.Focus();
            }
        }
    }
}
