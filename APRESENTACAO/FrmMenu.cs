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
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using TRANSFERENCIA;
using NEGOCIOS;

namespace APRESENTACAO
{
    public partial class FrmMenu : Syncfusion.Windows.Forms.Tools.RibbonForm
    {
        Usuario usuarioLogado;
        PessoaFilial filialLogada;
        public FrmMenu(Usuario usuario, PessoaFilial filial)
        {
            InitializeComponent();
            usuarioLogado = usuario;
            filialLogada = filial;
        }

        //metodo para adicionar e configurar tooltip no evendo MouseHover

        private void abreToolTip(Component component)
        {
            this.superToolTip1 = new SuperToolTip(this);
            ToolTipInfo toolTipInfo1 = new ToolTipInfo();
            this.superToolTip1.SetToolTip(component, toolTipInfo1);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            controleIniciar();
        }

        private void controleIniciar()
        {
            if (panPrincipal.Visible == true)
            {
                panPrincipal.Visible = false;
                panCadastros.Visible = false;
                panProcessos.Visible = false;
                panRelatorios.Visible = false;
            }
            else
            {
                panPrincipal.Visible = true;
                panCadastros.Visible = false;
                panProcessos.Visible = false;
                panRelatorios.Visible = false;
            }
        }

        private void btnCadastros_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void grpItens_GroupBarItemSelected(object sender, EventArgs e)
        {

        }

        private void buttonAdv7_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdv7_Click(object sender, EventArgs e)
        {
            if (panCadastros.Visible == true)
            {
                panCadastros.Visible = false;
            }
            else
            {
                panCadastros.Visible = true;
                panProcessos.Visible = false;
                panRelatorios.Visible = false;
            }
        }

        private void buttonAdv6_Click(object sender, EventArgs e)
        {
            if (panProcessos.Visible == true)
            {
                panProcessos.Visible = false;
            }
            else
            {
                panCadastros.Visible = false;
                panProcessos.Visible = true;
                panRelatorios.Visible = false;
            }
        }

        private void buttonAdv5_Click(object sender, EventArgs e)
        {
            if (panRelatorios.Visible == true)
            {
                panRelatorios.Visible = false;
            }
            else
            {
                panCadastros.Visible = false;
                panProcessos.Visible = false;
                panRelatorios.Visible = true;
            }
        }

        private void toggleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            string url = "www.google.com.br";
            Process.Start(url);
        }

        private void buttonAdv2_MouseHover(object sender, EventArgs e)
        {
            abreToolTip(btnInternet);
        }

        private void btnIniciar_MouseHover(object sender, EventArgs e)
        {
            abreToolTip(btnIniciar);
        }

        private void btnCalculadora_MouseHover(object sender, EventArgs e)
        {
            abreToolTip(btnCalculadora);
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            ControleFormulario.abreFrmCalculadora();
        }

        private void toggleButton1_MouseHover(object sender, EventArgs e)
        {
            abreToolTip(btnFecharCima);
        }

        private void buttonAdv2_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void buttonAdv2_Click_1(object sender, EventArgs e)
        {
            string url = "http://www.buscacep.correios.com.br/sistemas/buscacep/buscaLogBairro.cfm";
            Process.Start(url);
        }

        private void btnFecharIniciar_MouseHover(object sender, EventArgs e)
        {
            abreToolTip(btnFecharIniciar);
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            defineAcesso(ControleSistema.getUsuario().Acesso);
            if (usuarioLogado.PapelParede != "")
            {
                pictureBox1.Image = new Bitmap(usuarioLogado.PapelParede);
            }
            btnUsuarioLogado.Text = btnUsuarioLogado.Text + usuarioLogado.Login;
        }

        private void buttonAdv22_Click(object sender, EventArgs e)
        {
            ControleFormulario.abreFrmConsultaCategoriaProdutoCRUD(AcaoTelaConsultaCadastros.CategoriaConsulta, filialLogada);
            controleIniciar();
        }

        private void buttonAdv21_Click(object sender, EventArgs e)
        {
            ControleFormulario.abreFrmConsultaClienteCRUD(AcaoTelaConsultaCadastros.ClienteConsulta, filialLogada);
            controleIniciar();
        }

        private void btnFilial_Click(object sender, EventArgs e)
        {
            ControleFormulario.abreFrmConsultaFilialCRUD(AcaoTelaConsultaCadastros.FilialConsulta, filialLogada);
            controleIniciar();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            ControleFormulario.abreFrmConsultaFornecedorCRUD(AcaoTelaConsultaCadastros.FornecedorConsulta, filialLogada);
            controleIniciar();
        }

        private void btnFisica_Click(object sender, EventArgs e)
        {
            ControleFormulario.abreFrmConsultaPessoaFisicaCRUD(AcaoTelaConsultaCadastros.PessoaFisicaConsulta, filialLogada);
            controleIniciar();
        }

        private void btnJuridica_Click(object sender, EventArgs e)
        {
            ControleFormulario.abreFrmPessoaJuridicaCRUD(AcaoTelaConsultaCadastros.PessoaJuridicaConsulta, filialLogada);
            controleIniciar();

        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            ControleFormulario.abreFrmConsultaProdutoCRUD(AcaoTelaConsultaCadastros.ProdutoConsulta, filialLogada);
            controleIniciar();
        }

        private void buttonAdv8_Click(object sender, EventArgs e)
        {
            controleIniciar();
            ControleFormulario.abreFrmVendaWindows(filialLogada);
            
        }

        private void btnCaixaRelatorio_Click(object sender, EventArgs e)
        {
            controleIniciar();
            try
            {
                FrmRelatorioCaixas frmRelatorioCaixas = new FrmRelatorioCaixas();
                frmRelatorioCaixas.ShowDialog();
                if (DialogResult == DialogResult.Yes)
                {
                    frmRelatorioCaixas = null;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao abrir formulário de relatório de caixas. Detalhes: " + ex.Message);
            }
        }

        private void btnCompraRelatorio_Click(object sender, EventArgs e)
        {
            controleIniciar();
            try
            {
                FrmRelatorioCompras frmRelatorioCompras = new FrmRelatorioCompras();
                frmRelatorioCompras.ShowDialog();
                if (DialogResult == DialogResult.Yes)
                {
                    frmRelatorioCompras = null;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao abrir relatório de compras. Detalhes: " + ex.Message);
            }
        }

        private void btnPessoaRelatorio_Click(object sender, EventArgs e)
        {
            controleIniciar();
            try
            {
                FrmRelatorioPessoas frmRelatorioPessoas = new FrmRelatorioPessoas();
                DialogResult retorno = frmRelatorioPessoas.ShowDialog();
                if (retorno == DialogResult.Yes)
                {
                    frmRelatorioPessoas = null;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao abrir formulário de relatório de pessoas. Detalhes: " + ex.Message);
            }
        }

        private void btnVendaRelatorio_Click(object sender, EventArgs e)
        {
            controleIniciar();
            try
            {
                FrmRelatorioVenda frmRelatorioVenda = new FrmRelatorioVenda();
                frmRelatorioVenda.ShowDialog();
                if (DialogResult == DialogResult.Yes)
                {
                    frmRelatorioVenda = null;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao abrir relatório de vendas. Detalhes: " + ex.Message);
            }
            
        }

        private void btnAbrirCaixa_Click(object sender, EventArgs e)
        {
            controleIniciar();
            ControleFormulario.abreFrmAbrirCaixa();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            controleIniciar();
            ControleFormulario.abreFrmCompraWindows(filialLogada);
            
        }

        private void btnFecharCaixa_Click(object sender, EventArgs e)
        {
            controleIniciar();
            ControleFormulario.abreFrmFecharCaixa();
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            controleIniciar();
            try
            {
                FrmSobre frmSobre = new FrmSobre();
                DialogResult retorno = frmSobre.ShowDialog();
                if (retorno == DialogResult.Yes)
                {
                    frmSobre = null;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ControleFormulario.abreFrmConsultaUsuariosCRUD(AcaoTelaConsultaCadastros.UsuarioConsulta, filialLogada);
            controleIniciar();
        }

        private void FrmMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.LWin)
            {
                btnIniciar_Click(sender, e);
            }
        }

        private void btnCliente_MouseHover(object sender, EventArgs e)
        {
            abreToolTip(btnCliente);
        }

        private void btnVendas_MouseHover(object sender, EventArgs e)
        {
            abreToolTip(btnVendas);
        }

        private void btnCompras_MouseHover(object sender, EventArgs e)
        {
            abreToolTip(btnCompras);
        }

        private void btnFilial_MouseHover(object sender, EventArgs e)
        {
            abreToolTip(btnFilial);
        }

        private void btnFornecedor_MouseHover(object sender, EventArgs e)
        {
            abreToolTip(btnFornecedor);
        }

        private void btnProduto_MouseHover(object sender, EventArgs e)
        {
            abreToolTip(btnProduto);
        }

        private void btnUsuarios_MouseHover(object sender, EventArgs e)
        {
            abreToolTip(btnUsuarios);
        }

        private void btnFormaPagamento_Click(object sender, EventArgs e)
        {
            ControleFormulario.abreFrmConsultaFormaPagamentoCRUD(AcaoTelaConsultaCadastros.FormaPagamento, filialLogada);
            controleIniciar();
        }

        private void defineAcesso(int acesso)
        {
            switch (acesso)
            {
                case 1:
                    btnUsuarios.Enabled = false;
                    btnProduto.Enabled = false;
                    btnFornecedor.Enabled = false;
                    btnFormaPagamento.Enabled = false;
                    btnFilial.Enabled = false;
                    btnCategoria.Enabled = false;
                    btnCompras.Enabled = false;
                    btnPessoaRelatorio.Enabled = false;
                    btnCompraRelatorio.Enabled = false;
                    break;
                case 2:
                    btnUsuarios.Enabled = false;
                    btnFilial.Enabled = false;
                    btnCliente.Enabled = false;
                    btnVendas.Enabled = false;
                    btnFecharCaixa.Enabled = false;
                    btnAbrirCaixa.Enabled = false;
                    btnVendaRelatorio.Enabled = false;
                    btnPessoaRelatorio.Enabled = false;
                    btnCaixaRelatorio.Enabled = false;
                    break;
                case 3:
                    btnUsuarios.Enabled = false;
                    btnVendas.Enabled = false;
                    btnFecharCaixa.Enabled = false;
                    btnAbrirCaixa.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void alterarPapelDeParedeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pictureBox1.Load(openFileDialog1.FileName);

                    UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
                    string retorno = usuarioNegocio.setarPapelDeParede(ControleSistema.getUsuario().IDUsuario, pictureBox1.ImageLocation);

                    int ID;
                    if (int.TryParse(retorno, out ID))
                    {
                        MessageBox.Show("O novo papel de parede foi salvo em seu usuário.");
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

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            abreToolTip(pictureBox1);
        }
    }
}
