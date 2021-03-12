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
    public partial class FrmFecharCaixa : Syncfusion.Windows.Forms.Tools.RibbonForm
    {
        Caixa caixa = ControleSistema.getCaixaAtual();
        public FrmFecharCaixa()
        {
            InitializeComponent();
        }

        private void verificaValores()
        {
            if (txtValorEmCaixa.Text != "R$0,00")
            {
                btnFecharCaixa.Enabled = true;
            }
            else
            {
                btnFecharCaixa.Enabled = false;
            }
        }

        private void FrmFecharCaixa_Load(object sender, EventArgs e)
        {
            try
            {                                
                if (caixa.Status == "A")
                {
                    txtValorInicial.Text = caixa.valorInicial.ToString();
                    txtValorTotal.Text = caixa.valorTotal.ToString();
                    txtValorEmCaixa.Text = "0";
                    txtValorSangria.Text = "0";
                    txtValorDiferenca.Text = "0";
                }
                else
                {               
                    MessageBox.Show("Não existem caixas abertos para esse usuário.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao abrir tela de fechamento de caixa. Detalhes: "+ex.Message);
            }
        }

        private void txtValorEmCaixa_TextChanged(object sender, EventArgs e)
        {            
            decimal diferenca = caixa.valorTotal - Convert.ToDecimal(txtValorEmCaixa.Text.Replace("R$",""));
            txtValorDiferenca.Text = diferenca.ToString();
            verificaValores();
        }

        private void btnFecharCaixa_Click(object sender, EventArgs e)
        {
            #region VerificaValorEmCaixa
            //Verifica se o valor em caixa é menor que o valor inicial do caixa
            Decimal valorInicial = Convert.ToDecimal(txtValorInicial.Text.Replace("R$", "")), valorFechamento = Convert.ToDecimal(txtValorEmCaixa.Text.Replace("R$", ""));
            if (valorFechamento < valorInicial)
            {
                DialogResult resultadoFechamento = MessageBox.Show("O valor digitado em caixa é menor que o valor inicial do caixa, deseja prosseguir mesmo assim?", "Atenção: ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultadoFechamento == DialogResult.No)
                {
                    return;
                }
            }
            #endregion

            #region VerificaDiferencaCaixa
            Decimal valorDiferenca = Convert.ToDecimal(txtValorDiferenca.Text.Replace("R$", ""));
            if (valorDiferenca > 0)
            {
                DialogResult resultadoFechamento = MessageBox.Show("Existe diferença entre o valor total e o valor em caixa, deseja prosseguir mesmo assim?", "Atenção: ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultadoFechamento == DialogResult.No)
                {
                    return;
                }
            }
            #endregion

            #region VerificaValorSangria
            //Verifica se o valor da sangria é maior que o total do caixa
            Decimal valorCaixa = Convert.ToDecimal(txtValorEmCaixa.Text.Replace("R$", "")), valorSangria = Convert.ToDecimal(txtValorSangria.Text.Replace("R$", ""));
            if (valorSangria > valorCaixa)
            {
                MessageBox.Show("O valor digitado para sangria é maior que o valor do caixa atual. Digite um valor correto para sangria.", "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            #region ConfirmacaoFechamento
            DialogResult resultado = MessageBox.Show("Deseja realmente realizar o fechamento de caixa?", "Pergunta: ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    caixa.valorFechamento = Convert.ToDecimal(txtValorEmCaixa.Text.Replace("R$", ""));
                    caixa.valorSangria = Convert.ToDecimal(txtValorSangria.Text.Replace("R$", ""));

                    CaixaNegocio caixaNegocio = new CaixaNegocio();

                    string retorno = caixaNegocio.caixaFechar(caixa, ControleSistema.getIdUsuarioLogado());

                    int IDCaixa;
                    if (int.TryParse(retorno, out IDCaixa))
                    {
                        MessageBox.Show("O caixa atual foi fechado com sucesso. ID do Caixa: " + IDCaixa);
                        #region Gera Relatorio
                        try
                        {
                            DataTable relatorioCaixa = new DataTable();
                            RelatorioCaixaNegocio relatorioCaixaNegocio = new RelatorioCaixaNegocio();
                            DataTable relatorioPedidos = new DataTable();
                            RelatorioPedidoNegocio relatorioPedidosNegocio = new RelatorioPedidoNegocio();
                            DataTable relatorioFilial = new DataTable();
                            PessoaJuridicaNegocio pessoaNegocio = new PessoaJuridicaNegocio();
                            relatorioFilial = pessoaNegocio.ConsultarPorNomeFantasiaPorIDPessoa(ControleSistema.getFilialLogada().IDFilial);

                            relatorioCaixa = relatorioCaixaNegocio.ConsultarFechamentoCaixa(IDCaixa);

                            relatorioPedidos = relatorioPedidosNegocio.Consultar(IDCaixa);
            
                            FrmRelatorioFechamentoCaixa frmRelatorioFechamentoCaixa = new FrmRelatorioFechamentoCaixa(relatorioCaixa, relatorioPedidos, relatorioFilial);
                            DialogResult retornoForm = frmRelatorioFechamentoCaixa.ShowDialog();
                            if (retornoForm == DialogResult.Yes)
                            {
                                frmRelatorioFechamentoCaixa = null;
                            }
                            
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Erro ao gerar relatório de fechamento de caixa. Detalhes: " + ex.Message);
                        }


                        #endregion
                        ControleSistema.atualizaCaixaAtual();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao fechar caixa. Detalhes: " + ex.Message);
                }
            }
            #endregion

           

        }
     

        private void FrmFecharCaixa_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ControleFormulario.frmFecharCaixa != null)
            {
                ControleFormulario.frmFecharCaixa = null;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
