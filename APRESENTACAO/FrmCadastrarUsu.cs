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
    public partial class FrmCadastrarUsu : Syncfusion.Windows.Forms.Tools.RibbonForm
    {
        PessoaFisica pessoaFisicaSelecionada;
        Usuario usuarioSelecionado;
        AcaoTelaCRUD acaoSelecionada;
        public FrmCadastrarUsu(AcaoTelaCRUD acao, PessoaFisica pessoaFisica, Usuario usuario)
        {
            InitializeComponent();
            pessoaFisicaSelecionada = pessoaFisica;
            usuarioSelecionado = usuario;
            acaoSelecionada = acao;

            if (acao == AcaoTelaCRUD.Inserir)
            {
                btnOk.Text = "Cadastrar";
                txtUsuario.Clear();
                txtSenha.Clear();
                txtRepetirSenha.Clear();               
            }
            if (acao == AcaoTelaCRUD.Consultar)
            {
                btnOk.Visible = false;
                txtUsuario.Text = usuario.Login;
                txtUsuario.Enabled = false;
                txtSenha.Text = usuario.Senha;
                txtSenha.Enabled = false;
                txtRepetirSenha.Text = usuario.Senha;
                txtRepetirSenha.Enabled = false;
                txtUsuario.Enabled = false;
                switch (usuario.Acesso)
                {
                    case 1:
                        rdbCaixa.Checked = true;
                        rdbCompras.Checked = false;
                        rdbFinanceiro.Checked = false;
                        rdbAdministrador.Checked = false;
                        break;
                    case 2:
                        rdbCaixa.Checked = false;
                        rdbCompras.Checked = true;
                        rdbFinanceiro.Checked = false;
                        rdbAdministrador.Checked = false;
                        break;
                    case 3:
                        rdbCaixa.Checked = false;
                        rdbCompras.Checked = false;
                        rdbFinanceiro.Checked = true;
                        rdbAdministrador.Checked = false;
                        break;

                    case 5:
                        rdbCaixa.Checked = false;
                        rdbCompras.Checked = false;
                        rdbFinanceiro.Checked = false;
                        rdbAdministrador.Checked = true;
                        break;

                    default:
                        break;
                }
                grbAcesso.Enabled = false;
            }
            if (acao == AcaoTelaCRUD.Alterar)
            {
                btnOk.Text = "Alterar";
                txtUsuario.Text = usuario.Login;
                txtSenha.Text = usuario.Senha;
                txtRepetirSenha.Text = usuario.Senha;
                txtUsuario.Enabled = false;
                switch (usuario.Acesso)
                {
                    case 1:
                        rdbCaixa.Checked = true;
                        rdbCompras.Checked = false;
                        rdbFinanceiro.Checked = false;
                        rdbAdministrador.Checked = false;
                        break;
                    case 2:
                        rdbCaixa.Checked = false;
                        rdbCompras.Checked = true;
                        rdbFinanceiro.Checked = false;
                        rdbAdministrador.Checked = false;
                        break;
                    case 3:
                        rdbCaixa.Checked = false;
                        rdbCompras.Checked = false;
                        rdbFinanceiro.Checked = true;
                        rdbAdministrador.Checked = false;
                        break;

                    case 5:
                        rdbCaixa.Checked = false;
                        rdbCompras.Checked = false;
                        rdbFinanceiro.Checked = false;
                        rdbAdministrador.Checked = true;
                        break;

                    default:
                        break;
                }
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (acaoSelecionada == AcaoTelaCRUD.Inserir)
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
                                MessageBox.Show("Erro ao definir ID da pessoa física ao usuário");
                                return;
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

            if (acaoSelecionada == AcaoTelaCRUD.Alterar)
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
                            if (usuarioSelecionado != null)
                            {
                                novoUsuario.IDPessoa = usuarioSelecionado.IDPessoa;
                            }
                            else
                            {
                                MessageBox.Show("Erro ao definir ID da pessoa física ao usuário");
                                return;
                            }

                            novoUsuario.IDStatus = 1;
                            novoUsuario.Login = txtUsuario.Text;
                            novoUsuario.Senha = txtSenha.Text;

                            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

                            string retorno = usuarioNegocio.Alterar(novoUsuario);

                            int IDUsuario;
                            if (!int.TryParse(retorno, out IDUsuario))
                            {
                                MessageBox.Show("Erro ao alterar usuário. Detalhes: " + retorno);
                                DialogResult = DialogResult.No;
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Usuário alterado com sucesso. ID do no usuário: " + retorno);
                                DialogResult = DialogResult.Yes;
                                Close();
                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Erro ao alterar usuário. Detalhes: " + ex.Message);
                            DialogResult = DialogResult.No;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCadastrarUsu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ControleFormulario.frmCadastrarUsu != null)
            {
                ControleFormulario.frmCadastrarUsu = null;
            }
        }

        private void btnAlterarPapelparede_Click(object sender, EventArgs e)
        {
            alterarPapelParede();
        }

        private void alterarPapelParede()
        {
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
                    string retorno = usuarioNegocio.setarPapelDeParede(usuarioSelecionado.IDUsuario, openFileDialog1.FileName);

                    int ID;
                    if (int.TryParse(retorno, out ID))
                    {
                        MessageBox.Show("O novo papel de parede foi salvo para o usuário: "+usuarioSelecionado.Login+". As alterações só poderão ser visualizadas no próximo login do usuário. DICA: Para alterar o seu próprio papel de parede clique com o botão direito do mouse no papel de parede principal e selecione => Ferramentas => Alterar papel de parede.");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao alterar papel de parede");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao inserir a imagem. Detalhes: {0}" + ex.Message);
            }
            
        }

        private void FrmCadastrarUsu_Load(object sender, EventArgs e)
        {
            if (acaoSelecionada == AcaoTelaCRUD.Inserir)
            {
                btnAlterarPapelparede.Visible = false;
            }
        }
    }
}
