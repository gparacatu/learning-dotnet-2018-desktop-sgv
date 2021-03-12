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
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TRANSFERENCIA;
using NEGOCIOS;
namespace APRESENTACAO
{
    public partial class FrmVendaWindows : Syncfusion.Windows.Forms.Tools.RibbonForm
    {
        uvwPessoaFisicaJuridica clienteSelecionado;
        Produto produtoSelecionado;
        PessoaFilial filialLogada;
        Pedido pedido;
        PedidoItemColecao pedidoItens;
        PedidoItem pedidoItem;
        int contadorDescontoFinal = 0;
        decimal valorAnteriorComDesconto;

        public FrmVendaWindows(PessoaFilial filial)
        {
            InitializeComponent();

            filialLogada = filial;

        }

        public void recebeCliente(PessoaCliente cliente)
        {
            PessoaCliente clienteRecebido = cliente;
        }

        private void FrmVendaWindows_FormClosed(object sender, FormClosedEventArgs e)
        {
            gerenciaBotoesParaNovaVenda();
            if (ControleFormulario.frmCompraWindows != null)
            {
                ControleFormulario.frmCompraWindows = null;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            #region Deletar Itens do Estoque Reservado
            //Retira os itens da lista de estoque reservado, caso existam
            if (pedidoItens != null && pedidoItens.Count > 0)
            {
                try
                {                                            

                    
                        
                        //Retirar item do estoque reservado
                        try
                        {
                            EstoqueReservadoNegocio estoqueReservadoNegocio = new EstoqueReservadoNegocio();
                            EstoqueReservado estoqueReservado = new EstoqueReservado();

                            foreach (var itemPedido in pedidoItens)
                            {
                                estoqueReservado.IDFilial = filialLogada.IDFilial;
                                estoqueReservado.IDProduto = itemPedido.IDProduto;
                                estoqueReservado.Quantidade = itemPedido.Quantidade * (-1);

                                string retorno = estoqueReservadoNegocio.Inserir(estoqueReservado);

                                int IDProduto;
                                if (!int.TryParse(retorno, out IDProduto))
                            {

                            }
                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Erro ao remover produtos do estoque reservado. Detalhes: " + ex.Message);
                        }                   



                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao excluir item da lista. Detalhes: " + ex.Message);
                }
            }

            #endregion

            gerenciaBotoesParaNovaVenda();
            
            Close();
        }

        private void btnSelecionarCliente_Click(object sender, EventArgs e)
        {
            
            try
            {
                clienteSelecionado = ControleFormulario.abreFrmConsultaClienteVenda(AcaoTelaConsultaCadastros.ClienteConsultaVenda, filialLogada);
                txtCliente.Text = clienteSelecionado.Nome;
                btnProcurarProduto.Focus();
            }
            catch
            {
                MessageBox.Show("Não foi possível procurar um cliente.");
            }
            
        }

        private void btnProcurarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                produtoSelecionado = ControleFormulario.abreFrmConsultaProdutoVenda(AcaoTelaConsultaCadastros.ProdutoConsultaVenda, filialLogada);
                txtproduto.Text = produtoSelecionado.Nome;
                txtQuantidade.Focus();
            }
            catch 
            {

                MessageBox.Show("Não foi possível procurar um produto.");
            }
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            txtQuantidade.Text = (Convert.ToInt32(txtQuantidade.Text) + 1).ToString();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            txtQuantidade.Text = (Convert.ToInt32(txtQuantidade.Text) - 1).ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
                        
            if (txtCliente.Text != "" && txtproduto.Text != "")
            {
                #region Verifica Se Existe o Produto No Estoque Antes de Inserir na Lista
                try
                {
                    EstoqueDisponivel estoqueDisponivel = new EstoqueDisponivel();
                    EstoqueNegocio estoqueNegocio = new EstoqueNegocio();

                    estoqueDisponivel = estoqueNegocio.ConsultarEstoqueDisponivel(produtoSelecionado.IDProduto, filialLogada.IDFilial);

                    if (estoqueDisponivel.QuantidadeDisponivel < Convert.ToInt32(txtQuantidade.Text))
                    {
                        MessageBox.Show
                        ("Não existe a quantidade solicitada em estoque do produto "+estoqueDisponivel.NomeProduto+
                         ". Quantidade disponível: "+estoqueDisponivel.QuantidadeDisponivel+
                         " . Quantidade reservada: "+estoqueDisponivel.QuantidadeReservada);
                        return;
                    }
                    else
                    {
                        EstoqueReservadoNegocio estoqueReservadoNegocio = new EstoqueReservadoNegocio();
                        EstoqueReservado estoqueReservado = new EstoqueReservado();

                        estoqueReservado.IDFilial = filialLogada.IDFilial;
                        estoqueReservado.IDProduto = produtoSelecionado.IDProduto;
                        estoqueReservado.Quantidade = Convert.ToInt32(txtQuantidade.Text);
                        string retorno = estoqueReservadoNegocio.Inserir(estoqueReservado);

                        int IDProduto;
                        if (!int.TryParse(retorno, out IDProduto))
                        {
                            MessageBox.Show("Erro ao inserir produto no estoque reservado");
                            return;
                        }                        
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao consultar estoque disponível. Detalhes: " + ex.Message);
                    return;
                }

                #endregion


                #region Adicionar Produto Na Lista De Venda
                try
                {
                    if (pedido == null)
                    {
                        //Cria o pedido
                        pedido = new Pedido();
                        pedido.IDOperacao = 1;
                        pedido.IDPessoaDestinatario = clienteSelecionado.IDCliente;
                        pedido.IDPessoaEmitente = filialLogada.IDFilial;
                        pedido.IDSituacao = 1;
                    }
                    
                    //adiciono item no pedido
                    if (pedidoItens == null)
                    {
                        pedidoItens = new PedidoItemColecao();
                    }


                    if (pedidoItens.Exists(p => p.IDProduto == produtoSelecionado.IDProduto))
                    {
                        try
                        {
                            var pedidoItemExistente = pedidoItens.Single(p => p.IDProduto == produtoSelecionado.IDProduto);
                            pedidoItemExistente.Quantidade += Convert.ToInt32(txtQuantidade.Text);
                            pedidoItemExistente.ValorTotal += (produtoSelecionado.PrecoVenda * Convert.ToInt32(txtQuantidade.Text));
                            decimal valorDescontoItemExistente = ((produtoSelecionado.PrecoVenda * Convert.ToInt32(txtQuantidade.Text)) * Convert.ToDecimal(txtDescontoItem.Text.Replace("%", ""))) / 100;
                            pedidoItemExistente.ValorDesconto += decimal.Round(valorDescontoItemExistente,2);//45
                            decimal valorTotalItemComDesconto = (produtoSelecionado.PrecoVenda * Convert.ToInt32(txtQuantidade.Text)) - valorDescontoItemExistente;//22,5                        
                            pedidoItemExistente.ValorTotalComDesconto += decimal.Round(valorTotalItemComDesconto,2);
                            pedidoItemExistente.PercentualDesconto = decimal.Round((pedidoItemExistente.ValorDesconto * 100) / pedidoItemExistente.ValorTotal, 2);
                            pedidoItem = pedidoItemExistente;

                            //Adiciona valor total e total com desconto ao pedido
                            decimal valorTotalDoItemNovo = produtoSelecionado.PrecoVenda * Convert.ToInt32(txtQuantidade.Text);
                            pedido.ValorTotal += valorTotalDoItemNovo;
                            txtValorTotal.Text = pedido.ValorTotal.ToString();
                            decimal valorTotalDoitemNovoComDesconto = valorTotalDoItemNovo - valorDescontoItemExistente;
                            pedido.ValorTotalComDesconto += valorTotalDoitemNovoComDesconto;
                            txtValorFinal.Text = pedido.ValorTotalComDesconto.ToString();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Erro ao inserir produto. Detalhes: " + ex.Message);
                        }
                    }
                    else
                    {
                        pedidoItem = new PedidoItem();
                        pedidoItem.IDProduto = produtoSelecionado.IDProduto;
                        pedidoItem.ProdutoNome = produtoSelecionado.Nome;
                        pedidoItem.Quantidade = Convert.ToInt32(txtQuantidade.Text);
                        pedidoItem.ValorTotal = produtoSelecionado.PrecoVenda * Convert.ToInt32(txtQuantidade.Text);
                        decimal valorDescontoItem = ((produtoSelecionado.PrecoVenda * Convert.ToInt32(txtQuantidade.Text)) * Convert.ToDecimal(txtDescontoItem.Text.Replace("%", ""))) / 100;
                        pedidoItem.ValorDesconto = decimal.Round(valorDescontoItem, 2);
                        pedidoItem.ValorUnitario = produtoSelecionado.PrecoVenda;
                        pedidoItem.ValorTotalComDesconto = decimal.Round((produtoSelecionado.PrecoVenda * Convert.ToInt32(txtQuantidade.Text)) - valorDescontoItem, 2);
                        pedidoItem.PercentualDesconto = decimal.Round((pedidoItem.ValorDesconto * 100) / pedidoItem.ValorTotal,2);
                       
                        //Adiciona valor total e total com desconto ao pedido
                        pedido.ValorTotal += pedidoItem.ValorTotal;
                        txtValorTotal.Text = pedido.ValorTotal.ToString();
                        pedido.ValorTotalComDesconto += pedidoItem.ValorTotalComDesconto;
                        txtValorFinal.Text = pedido.ValorTotalComDesconto.ToString();

                        pedidoItens.Add(pedidoItem);

                    }



                    dbgListaProdutos.DataSource = null;
                    dbgListaProdutos.DataSource = pedidoItens;
                    dbgListaProdutos.Columns[0].Visible = false;
                    dbgListaProdutos.Columns[1].Visible = false;
                    dbgListaProdutos.Update();
                    dbgListaProdutos.Refresh();
                    txtproduto.Clear();
                    txtDescontoItem.Text = "0";
                    //txtQuantidade.Text = "1";
                    btnProcurarProduto.Focus();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao inserir produto no pedido. Detalhes: " + ex.Message);
                }
            }
            #endregion                             

            else
            {
                MessageBox.Show("É necesssário adicionar um cliente e selecionar um produto para inserir na venda.");
            }
            
        }

        private void btnSelecionarCliente_Click_1(object sender, EventArgs e)
        {
            try
            {
                clienteSelecionado = ControleFormulario.abreFrmConsultaClienteVenda(AcaoTelaConsultaCadastros.ClienteConsultaVenda, filialLogada);
                txtCliente.Text = clienteSelecionado.Nome;
                btnProcurarProduto.Focus();
            }
            catch
            {
                MessageBox.Show("Não foi possível procurar um cliente.");
            }
        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            try
            {
                grbDadosVenda.Enabled = true;
                grbListaProdutos.Enabled = true;
                btnSelecionarCliente.Enabled = true;
                btnProcurarProduto.Enabled = true;
                txtQuantidade.Enabled = true;
                btnMais.Enabled = true;
                btnMenos.Enabled = true;
                btnOk.Enabled = true;
                txtDescontoItem.Enabled = true;                
                btnNovaVenda.Enabled = false;
                txtDescontoItem.Text = "0";
                txtValorTotal.Text = "0";
                txtValorFinal.Text = "0";
                txtDesconto.Text = "0";                

                //inicializa objetos
                pedido = null;
                pedidoItens = null;
                pedidoItem = null;

                try
                {
                    clienteSelecionado = ControleFormulario.abreFrmConsultaClienteVenda(AcaoTelaConsultaCadastros.ClienteConsultaVenda, filialLogada);
                    txtCliente.Text = clienteSelecionado.Nome;
                    txtDescontoItem.Focus();
                }
                catch
                {
                    MessageBox.Show("Não foi possível procurar um cliente.");
                }

                try
                {
                    produtoSelecionado = ControleFormulario.abreFrmConsultaProdutoVenda(AcaoTelaConsultaCadastros.ProdutoConsultaVenda, filialLogada);
                    txtproduto.Text = produtoSelecionado.Nome;
                    txtQuantidade.Focus();
                }
                catch
                {

                    MessageBox.Show("Não foi possível procurar um produto.");
                }

            }
            catch
            {

                MessageBox.Show("Erro ao abrir uma nova venda. Entre em contato com o suporte.");
            }
            

        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            if ((pedidoItens != null && pedidoItens.Count > 0 ) && txtValorTotal.Text != "0,00")
            {
                if(txtValorFinal.Text == "0,00")
                {
                    if (DialogResult.No == MessageBox.Show("Valor final do produto está com DESCONTO de 100%. Deseja realmente continuar?", "Verificação!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        txtDesconto.Focus();
                        return;
                    }
                }
                if (DialogResult.Yes == MessageBox.Show("Deseja finalizar a venda?", "Verificação!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {                  

                    //inicia a gravação no banco

                    #region Finalizar Venda Gravação no banco

                    try
                    {
                        PedidoNegocio pedidoNegocio = new PedidoNegocio();

                        pedido.ValorTotal = Convert.ToDecimal(txtValorTotal.Text);

                        pedido.ValorTotalComDesconto = Convert.ToDecimal(txtValorFinal.Text);

                        pedido.PorcentagemDesconto = Convert.ToDecimal(txtDesconto.Text.Replace("%",""));

                        pedido.IDCaixa = ControleSistema.getCaixaAtual().IDCaixa;

                        pedido.IDPagamento = Convert.ToInt32(cbbFormaPagamento.SelectedValue);

                        string retorno = pedidoNegocio.Inserir(pedido);

                        int IDPedido;
                        if (!int.TryParse(retorno, out IDPedido))
                        {
                            MessageBox.Show("Erro ao inserir pedido. Entre em contato com o suporte técnico.");
                            return;
                        }
                        else
                        {
                            PedidoItemNegocio pedidoItemNegocio = new PedidoItemNegocio();
                            EstoqueReservadoNegocio estoqueReservadoNegocio = new EstoqueReservadoNegocio();
                            EstoqueReservado estoqueReservado = new EstoqueReservado();
                            EstoqueNegocio estoqueNegocio = new EstoqueNegocio();
                            Estoque estoque = new Estoque();


                            foreach (var item in pedidoItens)
                            {
                                item.IDPedido = IDPedido;
                                pedidoItemNegocio.Inserir(item);
                                estoqueReservado.IDFilial = filialLogada.IDFilial;
                                estoqueReservado.IDProduto = item.IDProduto;
                                estoqueReservado.Quantidade = item.Quantidade * (-1);

                                estoqueReservadoNegocio.Inserir(estoqueReservado);

                                estoque.IDFilial = filialLogada.IDFilial;
                                estoque.IDProduto = item.IDProduto;
                                estoque.Quantidade = item.Quantidade * (-1);

                                estoqueNegocio.Inserir(estoque);
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Erro ao inserir pedido. Detalhes: " + ex.Message);
                    }
                    #endregion

                    gerenciaBotoesParaNovaVenda();

                }
                else
                {
                    return;
                }

            }
            else
            {
                MessageBox.Show("Esta faltando dados na venda. Verifique se todos os campos estão preenchidos.");
            }
            
        }

        private void gerenciaBotoesParaNovaVenda()
        {
            #region Gerencia Botões Para Nova Venda
            //gerencia botoes
            btnFinalizarVenda.Enabled = false;
            grbDadosVenda.Enabled = false;
            dbgListaProdutos.DataSource = null;
            grbListaProdutos.Enabled = false;
            txtDesconto.Enabled = false;
            txtDesconto.Clear();
            txtValorTotal.Enabled = false;
            txtValorTotal.Clear();
            txtValorFinal.Enabled = false;
            txtValorFinal.Clear();
            btnNovaVenda.Enabled = true;
            txtCliente.Clear();
            txtproduto.Clear();
            txtDescontoItem.Clear();
            //txtQuantidade.Clear();
            cbbFormaPagamento.DataSource = null;
            cbbFormaPagamento.Enabled = false;
            btnFinalizarPedido.Text = "   Finalizar Pedido    F5";
            #endregion
        }

        private void deletarItem()
        {
            if (pedidoItens != null && pedidoItens.Count > 0)
            {
                try
                {
                    PedidoItem itemDeletado = dbgListaProdutos.SelectedRows[0].DataBoundItem as PedidoItem;

                    DialogResult resultado = MessageBox.Show("Deseja remover este item da lista de produtos? " + itemDeletado.ProdutoNome, "Remover Item!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                    if (resultado == DialogResult.Yes)
                    {
                        pedido.ValorTotal -= itemDeletado.ValorTotal;
                        pedido.ValorTotalComDesconto -= itemDeletado.ValorTotalComDesconto;
                        txtValorTotal.Text = pedido.ValorTotal.ToString();
                        txtValorFinal.Text = pedido.ValorTotalComDesconto.ToString();                                                                    

                        pedidoItens.Remove(itemDeletado);

                        dbgListaProdutos.DataSource = null;

                        dbgListaProdutos.DataSource = pedidoItens;

                        dbgListaProdutos.Update();
                        dbgListaProdutos.Refresh();

                        //Retirar item do estoque reservado
                        try
                        {
                            EstoqueReservadoNegocio estoqueReservadoNegocio = new EstoqueReservadoNegocio();
                            EstoqueReservado estoqueReservado = new EstoqueReservado();

                            estoqueReservado.IDFilial = filialLogada.IDFilial;
                            estoqueReservado.IDProduto = itemDeletado.IDProduto;
                            estoqueReservado.Quantidade = itemDeletado.Quantidade * (-1);

                            string retorno = estoqueReservadoNegocio.Inserir(estoqueReservado);

                            int IDProduto;
                            if (int.TryParse(retorno, out IDProduto))
                            {
                                return;
                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Erro ao remover produto do estoque reservado. Detalhes: " + ex.Message);
                        }
                    }
                    else
                    {
                        return;
                    }



                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao excluir item da lista. Detalhes: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Não existe produto na lista para ser removido.");
            }
            
        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            deletarItem();
        }

        private void FrmVendaWindows_Load(object sender, EventArgs e)
        {
            
        }

        private void dbgListaProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                deletarItem();
            }
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            if (pedido != null)
            {
                try
            {
                    
                
                    decimal calculaValorPedidoComDesconto = 0, valorDesconto = 0;

                    if (contadorDescontoFinal == 0)
                    {
                        valorAnteriorComDesconto = pedido.ValorTotalComDesconto;
                    }

                    pedido.ValorTotalComDesconto = valorAnteriorComDesconto;

                    valorDesconto = (pedido.ValorTotalComDesconto * Convert.ToDecimal(txtDesconto.Text.Replace("%", ""))) / 100;
                    calculaValorPedidoComDesconto = decimal.Round(pedido.ValorTotalComDesconto - valorDesconto, 2);

                    pedido.ValorTotalComDesconto = calculaValorPedidoComDesconto;

                    txtValorFinal.Text = pedido.ValorTotalComDesconto.ToString();

                    contadorDescontoFinal += 1;
                

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao calcular desconto no total da venda. Detalhes: " + ex.Message);
            }
            }
            else
            {
                MessageBox.Show("Não existem valores para receberem desconto!");
                txtDesconto.Text = "0";
                return;
            }
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            try
            {
                if ((pedidoItens != null && pedidoItens.Count > 0) && (btnFinalizarPedido.Text == "   Finalizar Pedido    F5"))
                {
                    btnSelecionarCliente.Enabled = false;
                    btnProcurarProduto.Enabled = false;
                    txtQuantidade.Enabled = false;
                    btnMais.Enabled = false;
                    btnMenos.Enabled = false;
                    btnOk.Enabled = false;
                    txtDescontoItem.Text = "0";
                    txtDescontoItem.Enabled = false;
                    grbListaProdutos.Enabled = false;
                    txtDesconto.Enabled = true;
                    txtDesconto.Focus();
                    btnFinalizarVenda.Enabled = true;
                    contadorDescontoFinal = 0;
                    txtproduto.Text = "";
                    cbbFormaPagamento.Enabled = true;
                    //Adiciona as formas de pagamento no combobox
                    try
                    {
                        FormaPagamentoColecao pagamentoColecao = new FormaPagamentoColecao();
                        FormaPagamentoNegocio pagamentoNegocio = new FormaPagamentoNegocio();

                        pagamentoColecao = pagamentoNegocio.ConsultarPorFilial(ControleSistema.getFilialLogada().IDFilial);

                        cbbFormaPagamento.DataSource = pagamentoColecao;
                        cbbFormaPagamento.DisplayMember = "Descricao";
                        cbbFormaPagamento.ValueMember = "IDPagamento";
                        
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Erro ao receber lista de formas de pagamento. Detalhes: " + ex.Message);
                    }
                    
                    //txtQuantidade.Clear();
                    btnFinalizarPedido.Text = "   Alterar Pedido    F5";
                }
                else if ((pedidoItens != null && pedidoItens.Count > 0) && (btnFinalizarPedido.Text == "   Alterar Pedido    F5"))
                {
                    btnSelecionarCliente.Enabled = true;
                    btnProcurarProduto.Enabled = true;
                    txtQuantidade.Enabled = true;
                    btnMais.Enabled = true;
                    btnMenos.Enabled = true;
                    btnOk.Enabled = true;
                    txtDescontoItem.Enabled = true;
                    grbListaProdutos.Enabled = true;
                    txtDesconto.Text = "0";
                    txtDesconto.Enabled = false;
                    btnProcurarProduto.Focus();
                    btnFinalizarVenda.Enabled = false;
                    //txtQuantidade.Text = "1";
                    btnFinalizarPedido.Text = "   Finalizar Pedido    F5";
                    cbbFormaPagamento.Enabled = false;
                    //Remove as formas de pagamento no combobox
                    try
                    {                        
                        cbbFormaPagamento.DataSource = null;
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Erro ao retrar lista de formas de pagamento. Detalhes: " + ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Não é possível finalizar o pedido sem itens. Adicione itens a lista de compras para finalizar o pedido.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao finalizar pedido. Detalhes: " + ex.Message);
            }
        }

        private void txtproduto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtproduto.Text == "")
                {
                    txtQuantidade.Clear();
                    txtQuantidade.Enabled = false;
                    btnMais.Enabled = false;
                    btnMenos.Enabled = false;
                }
                else
                {
                    txtQuantidade.Enabled = true;
                    btnMais.Enabled = true;
                    btnMenos.Enabled = true;
                    txtQuantidade.Text = "1";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao alterar quantidade. Detalhes: "+ex.Message);
            }
           
        }

        private void FrmVendaWindows_Load_1(object sender, EventArgs e)
        {
            if (ControleSistema.getCaixaAtual().Status != "N")
            {
                #region Gerencia Botões
                //gerencia botoes
                btnFinalizarVenda.Enabled = false;
                grbDadosVenda.Enabled = false;
                dbgListaProdutos.DataSource = null;
                grbListaProdutos.Enabled = false;
                txtDesconto.Enabled = false;
                txtDesconto.Clear();
                txtValorTotal.Enabled = false;
                txtValorTotal.Clear();
                txtValorFinal.Enabled = false;
                txtValorFinal.Clear();
                btnNovaVenda.Enabled = true;
                txtCliente.Clear();
                txtproduto.Clear();
                txtDescontoItem.Clear();
                //txtQuantidade.Clear();
                btnFinalizarPedido.Text = "   Finalizar Pedido    F5";
                #endregion
            }
            else
            {
                MessageBox.Show("Não existe um caixa aberto para esse usuário. Abra um caixa para realizar uma venda.");
                this.Close();

            }

            

        }

        private void FrmVendaWindows_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F3:
                    btnProcurarProduto_Click(sender, e);
                    break;
                case Keys.F5:
                    btnCalculadora_Click(sender, e);
                    break;
                case Keys.F8:
                    btnCancelar_Click(sender, e);
                    break;
                case Keys.F6:
                    btnFinalizarVenda_Click(sender, e);
                    break;
                case Keys.F1:
                    btnNovaVenda_Click(sender, e);
                    break;
                case Keys.F4:
                    btnOk_Click(sender, e);
                    break;
                case Keys.F12:
                    btnRemoverItem_Click(sender, e);
                    break;
                case Keys.F2:
                    btnSelecionarCliente_Click_1(sender, e);
                    break;
            }
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtQuantidade.Text == "")
                {
                    btnMais.Enabled = false;
                    btnMenos.Enabled = false;
                }
                else
                {
                    btnMais.Enabled = true;
                    btnMenos.Enabled = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }



 
}
