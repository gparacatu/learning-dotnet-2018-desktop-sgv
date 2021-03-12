using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NEGOCIOS;
using TRANSFERENCIA;
using System.Reflection;

namespace APRESENTACAO

{
    public partial class FrmConsultaCRUD : Form
    {
        uvwPessoaFisicaJuridica clienteEnviado;
        Produto produtoEnviado;

        public Produto pegaProduto
        {
            get { return produtoEnviado; }
        }
        public uvwPessoaFisicaJuridica pegaPessoa
        {
            get { return clienteEnviado; }
        }
        AcaoTelaConsultaCadastros acaoSelecionada;
        //Variáveis fixas de textos que serão utilizados no formulario de consulta
        string grpConsultaCategoria = "Pesquise por nome ou código da categoria:",
               lblTipoPesquisaCategoria = "Nome | Código:",
               consultaCRUDCategoria = "CRUD Categoria de Produtos",

               grpConsultaCliente = "Pesquise por nome ou código do cliente:",
               lblTipoPesquisaCliente = "Nome | Código:",
               consultaCRUDCliente = "Clientes",

               grpConsultaFilial = "Pesquise por nome ou código da filial:",
               lblTipoPesquisaFilial = "Nome | Código:",
               consultaCRUDFilial = "Filiais",

               grpConsultaFornecedor = "Pesquise por nome ou código do fornecedor:",
               lblTipoPesquisaFornecedor = "Nome | Código:",
               consultaCRUDFornecedor = "Fornecedores",

               grpConsultaPessoaFisica = "Pesquise por nome ou cpf da pessoa física:",
               lblTipoPesquisaPessoaFisica = "Nome | Cpf:",
               consultaCRUDPessoaFisica = "Pessoas Físicas",

               grpConsultaPessoaJuridica = "Pesquise por nome ou cnpj da pessoa jurídica:",
               lblTipoPesquisaPessoaJuridica = "Nome | Cnpj:",
               consultaCRUDPessoaJuridica = "Pessoas Jurídicas",

               grpConsultaProduto = "Pesquise por nome, código ou categoria do produto:",
               lblTipoPesquisaProduto = "Nome | Código | Categoria:",
               consultaCRUDProduto = "Produtos",

               grpConsultaPagamento = "Pesquise por ID da filial:",
               lblTipoPesquisaPagamento = "Digite o ID:",
               consultaCRUDPagamento = "Pagamentos",

               grpConsultaUsuarios = "Pesquise por ID ou ID da filial:",
               lblTipoPesquisaUsuarios = "Digite o ID:",
               consultaCRUDUsuarios = "Usuários";

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                atualizaGrid();
                dgvConsultaCRUD.Focus();

            }
        }

        private void dgvConsultaCRUD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                selecionaGrid();
            }
        }

        private void btnTornarFilial_Click(object sender, EventArgs e)
        {
            if (acaoSelecionada == AcaoTelaConsultaCadastros.PessoaJuridicaConsulta)
            {
                try
                {
                    if (dgvConsultaCRUD.SelectedRows.Count > 0)
                    {
                        PessoaJuridica pessoaFilial = new PessoaJuridica();

                        pessoaFilial = (dgvConsultaCRUD.SelectedRows[0].DataBoundItem as PessoaJuridica);

                        PessoaFilialNegocio filialNegocio = new PessoaFilialNegocio();

                        string retorno = filialNegocio.Inserir(pessoaFilial.IDPessoa);

                        int IDFilial;

                        if (!int.TryParse(retorno, out IDFilial))
                        {
                            MessageBox.Show(retorno);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("A pessoa " + pessoaFilial.RazaoSocial + " agora é uma Filial.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Nenhuma pessoa foi selecionada. Selecione uma pessoa no grid para converter em Filial");
                        return;
                    }



                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao tornar a pessoa selecionada em Filial. Detalhes: " + ex.Message);
                }
            }

            if (acaoSelecionada == AcaoTelaConsultaCadastros.PessoaFisicaConsulta)
            {
                try
                {
                    if (dgvConsultaCRUD.SelectedRows.Count > 0)
                    {
                        PessoaFisica pessoaFisica = new PessoaFisica();

                        pessoaFisica = (dgvConsultaCRUD.SelectedRows[0].DataBoundItem as PessoaFisica);

                        PessoaFilialNegocio filialNegocio = new PessoaFilialNegocio();

                        string retorno = filialNegocio.Inserir(pessoaFisica.IDPessoa);

                        int IDFilial;

                        if (!int.TryParse(retorno, out IDFilial))
                        {
                            MessageBox.Show(retorno);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("A pessoa " + pessoaFisica.Nome + " agora é uma Filial.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Nenhuma pessoa foi selecionada. Selecione uma pessoa no grid para converter em Filial");
                        return;
                    }



                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao tornar a pessoa selecionada em Filial. Detalhes: " + ex.Message);
                }
            }
        }

        private void btnTornarFornecedor_Click(object sender, EventArgs e)
        {
            if (acaoSelecionada == AcaoTelaConsultaCadastros.PessoaJuridicaConsulta)
            {
                    try
                    {
                        if (dgvConsultaCRUD.SelectedRows.Count > 0)
                        {
                            PessoaJuridica pessoaFornecedor = new PessoaJuridica();

                            pessoaFornecedor = (dgvConsultaCRUD.SelectedRows[0].DataBoundItem as PessoaJuridica);

                            uvwPessoaFisicaJuridicaNegocio fornecedorNegocio = new uvwPessoaFisicaJuridicaNegocio();

                            string retorno = fornecedorNegocio.Inserir(pessoaFornecedor.IDPessoa);

                            int IDFornecedor;

                            if (!int.TryParse(retorno, out IDFornecedor))
                            {
                                MessageBox.Show(retorno);
                                return;
                            }
                            else
                            {
                                MessageBox.Show("A pessoa " + pessoaFornecedor.RazaoSocial + " agora é um Fornecedor.");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Nenhuma pessoa foi selecionada. Selecione uma pessoa no grid para converter em Fornecedor");
                            return;
                        }



                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Erro ao tornar a pessoa selecionada em Fornecedor. Detalhes: " + ex.Message);
                    }
                
            }

            if (acaoSelecionada == AcaoTelaConsultaCadastros.PessoaFisicaConsulta)
            {
                try
                {
                    if (dgvConsultaCRUD.SelectedRows.Count > 0)
                    {
                        PessoaFisica pessoaFisica = new PessoaFisica();

                        pessoaFisica = (dgvConsultaCRUD.SelectedRows[0].DataBoundItem as PessoaFisica);

                        uvwPessoaFisicaJuridicaNegocio fornecedorNegocio = new uvwPessoaFisicaJuridicaNegocio();

                        string retorno = fornecedorNegocio.Inserir(pessoaFisica.IDPessoa);

                        int IDFornecedor;

                        if (!int.TryParse(retorno, out IDFornecedor))
                        {
                            MessageBox.Show(retorno);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("A pessoa " + pessoaFisica.Nome + " agora é um Fornecedor.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Nenhuma pessoa foi selecionada. Selecione uma pessoa no grid para converter em Fornecedor");
                        return;
                    }



                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao tornar a pessoa selecionada em Fornecedor. Detalhes: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (acaoSelecionada == AcaoTelaConsultaCadastros.PessoaJuridicaConsulta)
            {
                try
                {
                    if (dgvConsultaCRUD.SelectedRows.Count > 0)
                    {
                        PessoaJuridica pessoaCliente = new PessoaJuridica();

                        pessoaCliente = (dgvConsultaCRUD.SelectedRows[0].DataBoundItem as PessoaJuridica);

                        PessoaClienteNegocio clienteNegocio = new PessoaClienteNegocio();

                        string retorno = clienteNegocio.Inserir(pessoaCliente.IDPessoa);

                        int IDCliente;

                        if (!int.TryParse(retorno, out IDCliente))
                        {
                            MessageBox.Show(retorno);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("A pessoa " + pessoaCliente.RazaoSocial + " agora é um Cliente.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Nenhuma pessoa foi selecionada. Selecione uma pessoa no grid para converter em Cliente");
                        return;
                    }



                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao tornar a pessoa selecionada em Cliente. Detalhes: " + ex.Message);
                }

            }

            if (acaoSelecionada == AcaoTelaConsultaCadastros.PessoaFisicaConsulta)
            {
                try
                {
                    if (dgvConsultaCRUD.SelectedRows.Count > 0)
                    {
                        PessoaFisica pessoaFisica = new PessoaFisica();

                        pessoaFisica = (dgvConsultaCRUD.SelectedRows[0].DataBoundItem as PessoaFisica);

                        PessoaClienteNegocio clienteNegocio = new PessoaClienteNegocio();

                        string retorno = clienteNegocio.Inserir(pessoaFisica.IDPessoa);

                        int IDCliente;

                        if (!int.TryParse(retorno, out IDCliente))
                        {
                            MessageBox.Show(retorno);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("A pessoa " + pessoaFisica.Nome + " agora é um Cliente.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Nenhuma pessoa foi selecionada. Selecione uma pessoa no grid para converter em Cliente");
                        return;
                    }



                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao tornar a pessoa selecionada em Cliente. Detalhes: " + ex.Message);
                }
            }
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            ativaDesativa(2, "desativar", "Inativo(a)");
        }

        private void ativaDesativa(int status, string descricaoStatus, string descricaoStatusFinal)
        {
            if (acaoSelecionada == AcaoTelaConsultaCadastros.ClienteConsulta)
            {
                try
                {
                    if (dgvConsultaCRUD.SelectedRows.Count > 0)
                    {
                        uvwPessoaFisicaJuridica pessoaCliente = new uvwPessoaFisicaJuridica();

                        pessoaCliente = (dgvConsultaCRUD.SelectedRows[0].DataBoundItem as uvwPessoaFisicaJuridica);

                        if (MessageBox.Show("Deseja "+descricaoStatus+" o cliente " + pessoaCliente.Nome + "?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {

                            PessoaClienteNegocio clienteNegocio = new PessoaClienteNegocio();

                            string retorno = clienteNegocio.Alterar(pessoaCliente.IDCliente, status);

                            int IDCliente;

                            if (!int.TryParse(retorno, out IDCliente))
                            {
                                MessageBox.Show(retorno);
                                return;
                            }
                            else
                            {
                                MessageBox.Show("A pessoa " + pessoaCliente.Nome + " agora é um Cliente "+ descricaoStatusFinal+".");
                                atualizaGrid();
                            }

                        }

                    }
                    else
                    {
                        MessageBox.Show("Nenhuma pessoa foi selecionada. Selecione uma pessoa no grid para desativar");
                        return;
                    }



                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao desativar a pessoa selecionada. Detalhes: " + ex.Message);
                }

            }

            if (acaoSelecionada == AcaoTelaConsultaCadastros.FilialConsulta)
            {
                try
                {
                    if (dgvConsultaCRUD.SelectedRows.Count > 0)
                    {
                        uvwPessoaFisicaJuridica pessoaFilial = new uvwPessoaFisicaJuridica();

                        pessoaFilial = (dgvConsultaCRUD.SelectedRows[0].DataBoundItem as uvwPessoaFisicaJuridica);
                        if (MessageBox.Show("Deseja " + descricaoStatus + " a filial " + pessoaFilial.Nome + "?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            PessoaFilialNegocio filialNegocio = new PessoaFilialNegocio();

                            string retorno = filialNegocio.Alterar(pessoaFilial.IDCliente, status);

                            int IDCliente;

                            if (!int.TryParse(retorno, out IDCliente))
                            {
                                MessageBox.Show(retorno);
                                return;
                            }
                            else
                            {
                                MessageBox.Show("A pessoa " + pessoaFilial.Nome + " agora é uma Filial " + descricaoStatusFinal + ".");
                                atualizaGrid();
                            }
                        }
                        else
                        {
                            return;
                        }
                    }

                    else
                    {
                        MessageBox.Show("Nenhuma pessoa foi selecionada. Selecione uma pessoa no grid para desativar");
                        return;
                    }



                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao desativar a pessoa selecionada. Detalhes: " + ex.Message);
                }

            }

            if (acaoSelecionada == AcaoTelaConsultaCadastros.FornecedorConsulta)
            {
                try
                {
                    if (dgvConsultaCRUD.SelectedRows.Count > 0)
                    {

                        uvwPessoaFisicaJuridica pessoaFornecedor = new uvwPessoaFisicaJuridica();

                        pessoaFornecedor = (dgvConsultaCRUD.SelectedRows[0].DataBoundItem as uvwPessoaFisicaJuridica);
                        if (MessageBox.Show("Deseja "+ descricaoStatus + " o fornecedor " + pessoaFornecedor.Nome + "?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            uvwPessoaFisicaJuridicaNegocio fornecedorNegocio = new uvwPessoaFisicaJuridicaNegocio();

                            string retorno = fornecedorNegocio.Alterar(pessoaFornecedor.IDCliente, status);

                            int IDCliente;

                            if (!int.TryParse(retorno, out IDCliente))
                            {
                                MessageBox.Show(retorno);
                                return;
                            }
                            else
                            {
                                MessageBox.Show("A pessoa " + pessoaFornecedor.Nome + " agora é um Fornecedor " + descricaoStatusFinal + ".");
                                atualizaGrid();
                            }

                        }
                        else
                        {
                            return;
                        }
                    }

                    else
                    {
                        MessageBox.Show("Nenhuma pessoa foi selecionada. Selecione uma pessoa no grid para desativar");
                        return;
                    }



                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao desativar a pessoa selecionada. Detalhes: " + ex.Message);
                }

            }

            if (acaoSelecionada == AcaoTelaConsultaCadastros.FormaPagamento)
            {
                try
                {
                    if (dgvConsultaCRUD.SelectedRows.Count > 0)
                    {

                        FormaPagamento pessoaFornecedor = new FormaPagamento();

                        pessoaFornecedor = (dgvConsultaCRUD.SelectedRows[0].DataBoundItem as FormaPagamento);
                        if (MessageBox.Show("Deseja " + descricaoStatus + " a forma de pagamento " + pessoaFornecedor.Descricao + "?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            FormaPagamentoNegocio fornecedorNegocio = new FormaPagamentoNegocio();

                            string retorno = fornecedorNegocio.AlterarStatus(pessoaFornecedor.Descricao, filialLogada.IDFilial ,status);

                            int IDCliente;

                            if (!int.TryParse(retorno, out IDCliente))
                            {
                                MessageBox.Show(retorno);
                                return;
                            }
                            else
                            {
                                MessageBox.Show("A forma de pagamento " + pessoaFornecedor.Descricao + " agora é um pagamento " + descricaoStatusFinal + ".");
                                atualizaGrid();
                            }

                        }
                        else
                        {
                            return;
                        }
                    }

                    else
                    {
                        MessageBox.Show("Nenhuma forma de pagamento foi selecionada. Selecione uma forma no grid para desativar");
                        return;
                    }



                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao desativar a forma de pagamento selecionada. Detalhes: " + ex.Message);
                }

            }

            if (acaoSelecionada == AcaoTelaConsultaCadastros.UsuarioConsulta)
            {
                try
                {
                    if (dgvConsultaCRUD.SelectedRows.Count > 0)
                    {

                        Usuario usuario = new Usuario();

                        usuario = (dgvConsultaCRUD.SelectedRows[0].DataBoundItem as Usuario);
                        if (MessageBox.Show("Deseja " + descricaoStatus + " o usuário " + usuario.Login + "?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            UsuarioNegocio UsuarioNegocio = new UsuarioNegocio();

                            string retorno = UsuarioNegocio.AlterarStatus(usuario.IDUsuario, status);

                            int IDCliente;

                            if (!int.TryParse(retorno, out IDCliente))
                            {
                                MessageBox.Show(retorno);
                                return;
                            }
                            else
                            {
                                MessageBox.Show("O usuário " + usuario.Login + " agora é um usuário " + descricaoStatusFinal + ".");
                                atualizaGrid();
                            }

                        }
                        else
                        {
                            return;
                        }
                    }

                    else
                    {
                        MessageBox.Show("Nenhum usuário foi selecionado. Selecione um usuário no grid para desativar");
                        return;
                    }



                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao desativar o usuário selecionado. Detalhes: " + ex.Message);
                }

            }

        }

        private void btnAtivar_Click(object sender, EventArgs e)
        {
            ativaDesativa(1, "ativar", "Ativo(a)");
        }

        private void dgvConsultaCRUD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(acaoSelecionada == AcaoTelaConsultaCadastros.ClienteConsultaVenda || acaoSelecionada == AcaoTelaConsultaCadastros.ProdutoConsultaVenda)
            {
                selecionaGrid();
            }
        }

        private void btnSelecionarCliente_Click(object sender, EventArgs e)
        {
            selecionaGrid();
        }


        //FIM DAS VARIAVEIS GLOBAIS

        PessoaFilial filialLogada;
        public FrmConsultaCRUD(AcaoTelaConsultaCadastros acaoTelaConsultaCadastros, PessoaFilial filial)
        {
            InitializeComponent();

            acaoSelecionada = acaoTelaConsultaCadastros;
            filialLogada = filial;

            //Inicia mudanças dos textos conforme tipo de cadastro
            modificaTextos();
        }

        private void selecionaGrid()
        {
            if (acaoSelecionada == AcaoTelaConsultaCadastros.ClienteConsultaVenda)
            {
                try
                {
                    if (dgvConsultaCRUD.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Nenhum cliente foi selecionado.");
                        return;
                    }

                    clienteEnviado = (dgvConsultaCRUD.SelectedRows[0].DataBoundItem as uvwPessoaFisicaJuridica);

                    Close();

                }
                catch
                {
                    MessageBox.Show("Não foi possivel selecionar o cliente.");
                }
            }
            else if (acaoSelecionada == AcaoTelaConsultaCadastros.FornecedorConsultaCompra)
            {
                try
                {
                    if (dgvConsultaCRUD.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Nenhum fornecedor foi selecionado.");
                        return;
                    }

                    clienteEnviado = (dgvConsultaCRUD.SelectedRows[0].DataBoundItem as uvwPessoaFisicaJuridica);

                    Close();

                }
                catch
                {
                    MessageBox.Show("Não foi possivel selecionar o fornecedor.");
                }
            }

            else if (acaoSelecionada == AcaoTelaConsultaCadastros.ProdutoConsultaVenda)
            {
                try
                {
                    if (dgvConsultaCRUD.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Nenhum produto foi selecionado.");
                        return;
                    }

                    produtoEnviado = (dgvConsultaCRUD.SelectedRows[0].DataBoundItem as Produto);

                    Close();

                }
                catch
                {
                    MessageBox.Show("Não foi possivel selecionar o produto.");
                }
            }

            
        }

        private void FrmConsultaCRUD_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ControleFormulario.frmConsultaCategoriaProdutoCRUD != null)
                ControleFormulario.frmConsultaCategoriaProdutoCRUD = null;

            if (ControleFormulario.frmConsultaClienteCRUD != null)
                ControleFormulario.frmConsultaClienteCRUD = null;

            if (ControleFormulario.frmConsultaFilialCRUD != null)
                ControleFormulario.frmConsultaFilialCRUD = null;

            if (ControleFormulario.frmConsultaFornecedorCRUD != null)
                ControleFormulario.frmConsultaFornecedorCRUD = null;

            if (ControleFormulario.frmConsultaPessoaFisicaCRUD != null)
                ControleFormulario.frmConsultaPessoaFisicaCRUD = null;

            if (ControleFormulario.frmConsultaPessoaJuridicaCRUD != null)
                ControleFormulario.frmConsultaPessoaJuridicaCRUD = null;

            if (ControleFormulario.frmConsultaProdutoCRUD != null)
                ControleFormulario.frmConsultaProdutoCRUD = null;
        }

        //(NAO ESTA SENDO UTILIZADO)Metodo que trata as propriedades do grid quando existem objetos dentro de objetos Ex. PessoaFisica.Pessoa.PessoaID
        private object CarregarPropriedade(object propriedade, string nomeDaPropriedade)
        {
            try
            {
                object retorno = "";
                if (nomeDaPropriedade.Contains("."))
                {
                    PropertyInfo[] propertyInfoArray;
                    string propriedadeAntesDoPonto;
                    propriedadeAntesDoPonto = nomeDaPropriedade.Substring(0, nomeDaPropriedade.IndexOf("."));

                    if (propriedade != null)
                    {
                        propertyInfoArray = propriedade.GetType().GetProperties();

                        foreach (PropertyInfo propertyInfo in propertyInfoArray)
                        {
                            if (propertyInfo.Name == propriedadeAntesDoPonto)
                            {
                                retorno = CarregarPropriedade
                                    (propertyInfo.GetValue(propriedade, null),
                                    nomeDaPropriedade.Substring(nomeDaPropriedade.IndexOf(".")));
                            }

                        }
                    }
                }
                else
                {
                    Type tpyPropertyType;
                    PropertyInfo pfoPropertyInfo;

                    if (propriedade != null)
                    {
                        tpyPropertyType = propriedade.GetType();
                        pfoPropertyInfo = tpyPropertyType.GetProperty(nomeDaPropriedade);
                        retorno = pfoPropertyInfo.GetValue(propriedade, null);
                    }
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        //Modificar textos conforme acao na tela
        private void modificaTextos()
        {
            if (acaoSelecionada == AcaoTelaConsultaCadastros.CategoriaConsulta)
            {

                this.grpConsulta.Text = grpConsultaCategoria;
                this.lblTipoPesquisa.Text = lblTipoPesquisaCategoria;
                this.Text = consultaCRUDCategoria;
            }

            if (acaoSelecionada == AcaoTelaConsultaCadastros.ClienteConsulta)
            {
                this.grpConsulta.Text = grpConsultaCliente;
                this.lblTipoPesquisa.Text = lblTipoPesquisaCliente;
                this.Text = consultaCRUDCliente;
                btnAlterar.Visible = false;
                btnExcluir.Visible = false;
                btnFechar.Visible = false;
                btnNovo.Visible = false;
                btnConsultar.Visible = false;
                btnAtivar.Visible = true;
                btnDesativar.Visible = true;

            }

            if (acaoSelecionada == AcaoTelaConsultaCadastros.ClienteConsultaVenda)
            {
                this.grpConsulta.Text = grpConsultaCliente;
                this.lblTipoPesquisa.Text = lblTipoPesquisaCliente;
                this.Text = consultaCRUDCliente;
                btnAlterar.Visible = false;
                btnConsultar.Visible = false;
                btnExcluir.Visible = false;
                btnFechar.Visible = false;
                btnNovo.Visible = false;
                btnSelecionarCliente.Visible = true;
            }

            if (acaoSelecionada == AcaoTelaConsultaCadastros.FilialConsulta)
            {
                this.grpConsulta.Text = grpConsultaFilial;
                this.lblTipoPesquisa.Text = lblTipoPesquisaFilial;
                this.Text = consultaCRUDFilial;
                btnAlterar.Visible = false;                
                btnExcluir.Visible = false;
                btnFechar.Visible = false;
                btnNovo.Visible = false;
                btnConsultar.Visible = false;
                btnAtivar.Visible = true;
                btnDesativar.Visible = true;                
            }

            if (acaoSelecionada == AcaoTelaConsultaCadastros.FornecedorConsulta)
            {
                this.grpConsulta.Text = grpConsultaFornecedor;
                this.lblTipoPesquisa.Text = lblTipoPesquisaFornecedor;
                this.Text = consultaCRUDFornecedor;
                btnAlterar.Visible = false;
                btnExcluir.Visible = false;
                btnFechar.Visible = false;
                btnNovo.Visible = false;
                btnConsultar.Visible = false;
                btnAtivar.Visible = true;
                btnDesativar.Visible = true;
            }
            if (acaoSelecionada == AcaoTelaConsultaCadastros.FornecedorConsultaCompra)
            {
                this.grpConsulta.Text = grpConsultaFornecedor;
                this.lblTipoPesquisa.Text = lblTipoPesquisaFornecedor;
                this.Text = consultaCRUDFornecedor;
                btnAlterar.Visible = false;
                btnExcluir.Visible = false;
                btnFechar.Visible = false;
                btnNovo.Visible = false;
                btnConsultar.Visible = false;
                btnAtivar.Visible = false;
                btnDesativar.Visible = false;
                btnSelecionarCliente.Text = "Selecionar";
                btnSelecionarCliente.Visible = true;
            }

            if (acaoSelecionada == AcaoTelaConsultaCadastros.PessoaFisicaConsulta)
            {
                this.grpConsulta.Text = grpConsultaPessoaFisica;
                this.lblTipoPesquisa.Text = lblTipoPesquisaPessoaFisica;
                this.Text = consultaCRUDPessoaFisica;
                this.btnExcluir.Enabled = false;
                if (ControleSistema.getUsuario().Acesso >= 3)
                {
                    this.btnTornarFilial.Visible = true;
                }
                if (ControleSistema.getUsuario().Acesso >= 2)
                {
                    this.btnTornarFornecedor.Visible = true;
                }
                this.btnTornarCliente.Visible = true;
                txtPesquisar.Width = 615;
                txtPesquisar.Location = new Point(65, 18);
            }

            if (acaoSelecionada == AcaoTelaConsultaCadastros.PessoaJuridicaConsulta)
            {
                this.grpConsulta.Text = grpConsultaPessoaJuridica;
                this.lblTipoPesquisa.Text = lblTipoPesquisaPessoaJuridica;
                this.Text = consultaCRUDPessoaJuridica;
                this.btnExcluir.Enabled = false;
                if (ControleSistema.getUsuario().Acesso >= 3)
                {
                    this.btnTornarFilial.Visible = true;
                }
                if (ControleSistema.getUsuario().Acesso >= 2)
                {
                    this.btnTornarFornecedor.Visible = true;
                }
                this.btnTornarCliente.Visible = true;
                txtPesquisar.Width = 610;
                txtPesquisar.Location = new Point(70, 18);
            }

            if (acaoSelecionada == AcaoTelaConsultaCadastros.ProdutoConsulta)
            {
                this.grpConsulta.Text = grpConsultaProduto;
                this.lblTipoPesquisa.Text = lblTipoPesquisaProduto;
                this.Text = consultaCRUDProduto;
                txtPesquisar.Width = 545;
                txtPesquisar.Location = new Point(135, 18);
            }

            if (acaoSelecionada == AcaoTelaConsultaCadastros.ProdutoConsultaVenda)
            {
                this.grpConsulta.Text = grpConsultaProduto;
                this.lblTipoPesquisa.Text = lblTipoPesquisaProduto;
                this.Text = consultaCRUDProduto;
                txtPesquisar.Width = 545;
                txtPesquisar.Location = new Point(135, 18);

                btnAlterar.Visible = false;
                btnConsultar.Visible = false;
                btnExcluir.Visible = false;
                btnFechar.Visible = false;
                btnNovo.Visible = false;
                btnSelecionarCliente.Text = "Selecionar Produto";
                btnSelecionarCliente.Visible = true;
            }

            if (acaoSelecionada == AcaoTelaConsultaCadastros.FormaPagamento)
            {
                this.grpConsulta.Text = grpConsultaPagamento;
                this.lblTipoPesquisa.Text = lblTipoPesquisaPagamento;
                this.Text = consultaCRUDPagamento;
                btnAtivar.Visible = true;
                btnDesativar.Visible = true;
                btnAlterar.Visible = false;
                btnConsultar.Visible = false;
                btnExcluir.Visible = false;
                txtPesquisar.Width = 545;
                txtPesquisar.Location = new Point(135, 18);
            }

            if (acaoSelecionada == AcaoTelaConsultaCadastros.UsuarioConsulta)
            {
                this.grpConsulta.Text = grpConsultaUsuarios;
                this.lblTipoPesquisa.Text = lblTipoPesquisaUsuarios;
                this.Text = consultaCRUDUsuarios;
                btnAtivar.Visible = true;
                btnDesativar.Visible = true;
                btnExcluir.Visible = false;
                btnNovo.Visible = false;
                txtPesquisar.Width = 545;
                txtPesquisar.Location = new Point(135, 18);
            }



        }

        //Metodos para controle dos botoes
        private void atualizaGrid()
        {
            if (acaoSelecionada == AcaoTelaConsultaCadastros.CategoriaConsulta)
            {
                try
                {
                    ProdutoCategoriaNegocio produtoCategoriaNegocio = new ProdutoCategoriaNegocio();

                    ProdutoCategoriaColecao produtoCategoriaColecao = new ProdutoCategoriaColecao();

                    
                        produtoCategoriaColecao = produtoCategoriaNegocio.ConsultarPorIdNomeCategoria(txtPesquisar.Text);

                        dgvConsultaCRUD.DataSource = produtoCategoriaColecao;

                        dgvConsultaCRUD.Update();
                        dgvConsultaCRUD.Refresh();
                   
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

            if (acaoSelecionada == AcaoTelaConsultaCadastros.ClienteConsulta)
            {
                try
                {
                    PessoaClienteNegocio pessoaClienteNegocio = new PessoaClienteNegocio();

                    uvwPessoaFisicaJuridicaColecao pessoaClienteColecao = new uvwPessoaFisicaJuridicaColecao();

                    //verifica se o texto digitado é um inteiro ou uma string
                    int IDPesquisa;
                    //int.TryParse pede um texto e tenta converter para inteiro, caso consiga joga o valor da conversão na variavel
                    if (int.TryParse(txtPesquisar.Text, out IDPesquisa) == true)
                    {
                        pessoaClienteColecao = pessoaClienteNegocio.ConsultarIdNome(IDPesquisa, null);

                        dgvConsultaCRUD.DataSource = pessoaClienteColecao;

                        dgvConsultaCRUD.Update();
                        dgvConsultaCRUD.Refresh();
                    }
                    else
                    {
                        pessoaClienteColecao = pessoaClienteNegocio.ConsultarIdNome(-1, txtPesquisar.Text);

                        dgvConsultaCRUD.DataSource = pessoaClienteColecao;

                        dgvConsultaCRUD.Update();
                        dgvConsultaCRUD.Refresh();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

            if (acaoSelecionada == AcaoTelaConsultaCadastros.ClienteConsultaVenda)
            {
                try
                {
                    PessoaClienteNegocio pessoaClienteNegocio = new PessoaClienteNegocio();

                    uvwPessoaFisicaJuridicaColecao pessoaClienteColecao = new uvwPessoaFisicaJuridicaColecao();

                    //verifica se o texto digitado é um inteiro ou uma string
                    int IDPesquisa;
                    //int.TryParse pede um texto e tenta converter para inteiro, caso consiga joga o valor da conversão na variavel
                    if (int.TryParse(txtPesquisar.Text, out IDPesquisa) == true)
                    {
                        pessoaClienteColecao = pessoaClienteNegocio.ConsultarIdNomeVenda(IDPesquisa, null);

                        dgvConsultaCRUD.DataSource = pessoaClienteColecao;

                        dgvConsultaCRUD.Update();
                        dgvConsultaCRUD.Refresh();
                    }
                    else
                    {
                        pessoaClienteColecao = pessoaClienteNegocio.ConsultarIdNomeVenda(-1, txtPesquisar.Text);

                        dgvConsultaCRUD.DataSource = pessoaClienteColecao;

                        dgvConsultaCRUD.Update();
                        dgvConsultaCRUD.Refresh();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

            if (acaoSelecionada == AcaoTelaConsultaCadastros.FilialConsulta)
            {
                try
                {
                    PessoaFilialNegocio pessoaFilialNegocio = new PessoaFilialNegocio();

                    PessoaFilialColecao pessoaFilialColecao = new PessoaFilialColecao();

                    //verifica se o texto digitado é um inteiro ou uma string
                    int IDPesquisa;
                    //int.TryParse pede um texto e tenta converter para inteiro, caso consiga joga o valor da conversão na variavel
                    if (int.TryParse(txtPesquisar.Text, out IDPesquisa) == true)
                    {
                        pessoaFilialColecao = pessoaFilialNegocio.ConsultarIdNome(IDPesquisa, null);

                        dgvConsultaCRUD.DataSource = pessoaFilialColecao;

                        dgvConsultaCRUD.Update();
                        dgvConsultaCRUD.Refresh();
                    }
                    else
                    {
                        pessoaFilialColecao = pessoaFilialNegocio.ConsultarIdNome(-1, txtPesquisar.Text);

                        dgvConsultaCRUD.DataSource = pessoaFilialColecao;

                        dgvConsultaCRUD.Update();
                        dgvConsultaCRUD.Refresh();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

            if (acaoSelecionada == AcaoTelaConsultaCadastros.FornecedorConsulta || acaoSelecionada == AcaoTelaConsultaCadastros.FornecedorConsultaCompra)
            {
                try
                {
                    uvwPessoaFisicaJuridicaNegocio pessoaFornecedorNegocio = new uvwPessoaFisicaJuridicaNegocio();

                    uvwPessoaFisicaJuridicaColecao pessoaFornecedorColecao = new uvwPessoaFisicaJuridicaColecao();

                    //verifica se o texto digitado é um inteiro ou uma string
                    int IDPesquisa;
                    //int.TryParse pede um texto e tenta converter para inteiro, caso consiga joga o valor da conversão na variavel
                    if (int.TryParse(txtPesquisar.Text, out IDPesquisa) == true)
                    {
                        pessoaFornecedorColecao = pessoaFornecedorNegocio.ConsultarIdNome(IDPesquisa, null);

                        dgvConsultaCRUD.DataSource = pessoaFornecedorColecao;

                        dgvConsultaCRUD.Update();
                        dgvConsultaCRUD.Refresh();
                    }
                    else
                    {
                        pessoaFornecedorColecao = pessoaFornecedorNegocio.ConsultarIdNome(-1, txtPesquisar.Text);

                        dgvConsultaCRUD.DataSource = pessoaFornecedorColecao;

                        dgvConsultaCRUD.Update();
                        dgvConsultaCRUD.Refresh();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

            if (acaoSelecionada == AcaoTelaConsultaCadastros.PessoaFisicaConsulta)
            {
                try
                {
                    PessoaFisicaNegocio pessoaFisicaNegocio = new PessoaFisicaNegocio();

                    PessoaFisicaColecao pessoaFisicaColecao = new PessoaFisicaColecao();

                    //DataTable dataTable = pessoaFisicaNegocio.ConsultarPorNomeCpf(txtPesquisar.Text);
                    pessoaFisicaColecao = pessoaFisicaNegocio.ConsultarPorNomeCpf(txtPesquisar.Text);

                    dgvConsultaCRUD.DataSource = pessoaFisicaColecao;

                    dgvConsultaCRUD.Columns[9].Visible = false;
                    dgvConsultaCRUD.Columns[12].Visible = false;
                    dgvConsultaCRUD.Columns[13].Visible = false;
                    dgvConsultaCRUD.Columns[14].Visible = false;
                    //dgvConsultaCRUD.Columns[13].Visible = false;


                    dgvConsultaCRUD.Update();
                    dgvConsultaCRUD.Refresh();
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
            }

            if (acaoSelecionada == AcaoTelaConsultaCadastros.PessoaJuridicaConsulta)
            {
                try
                {
                    PessoaJuridicaColecao pessoaJuridicaColecao = new PessoaJuridicaColecao();

                    PessoaJuridicaNegocio pessoaJuridicaNegocio = new PessoaJuridicaNegocio();

                    pessoaJuridicaColecao = pessoaJuridicaNegocio.ConsultarPorNomeFantasiaCnpj(txtPesquisar.Text);

                    dgvConsultaCRUD.DataSource = pessoaJuridicaColecao;

                    dgvConsultaCRUD.Columns[13].Visible = false;
                    dgvConsultaCRUD.Columns[14].Visible = false;
                    dgvConsultaCRUD.Columns[15].Visible = false;


                    dgvConsultaCRUD.Update();
                    dgvConsultaCRUD.Refresh();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

            if (acaoSelecionada == AcaoTelaConsultaCadastros.ProdutoConsulta || acaoSelecionada == AcaoTelaConsultaCadastros.ProdutoConsultaVenda) 
            {
                try
                {
                    ProdutoColecao produtoColecao = new ProdutoColecao();

                    ProdutoNegocio produtoNegocio = new ProdutoNegocio();

                    int IDProduto;
                    if (int.TryParse(txtPesquisar.Text, out IDProduto) == true)
                    {
                        produtoColecao = produtoNegocio.ConsultarPorIdNomeCategoria(IDProduto, null, filialLogada.IDFilial);
                    }
                    else
                    {
                        produtoColecao = produtoNegocio.ConsultarPorIdNomeCategoria(-1, txtPesquisar.Text, filialLogada.IDFilial);
                    }

                    dgvConsultaCRUD.DataSource = produtoColecao;

                    dgvConsultaCRUD.Columns[2].Visible = false;
                    dgvConsultaCRUD.Columns[3].Visible = false;
                    dgvConsultaCRUD.Columns[5].Visible = false;
                    dgvConsultaCRUD.Columns[6].Visible = false;
                    dgvConsultaCRUD.Columns[7].Visible = false;
                    dgvConsultaCRUD.Update();
                    dgvConsultaCRUD.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (acaoSelecionada == AcaoTelaConsultaCadastros.FormaPagamento)
            {
                try
                {
                    FormaPagamentoNegocio formaPagamentoNegocio = new FormaPagamentoNegocio();

                    FormaPagamentoColecao formaPagamentoColecao = new FormaPagamentoColecao();

                    if (txtPesquisar.Text == "")
                    {                        
                        try
                        {
                            int ID;
                            if (int.TryParse(txtPesquisar.Text, out ID))
                            {
                                formaPagamentoColecao = formaPagamentoNegocio.ConsultarPorFilial(ID);

                                dgvConsultaCRUD.DataSource = formaPagamentoColecao;

                                dgvConsultaCRUD.Update();
                                dgvConsultaCRUD.Refresh();
                            }
                            else
                            {
                                formaPagamentoColecao = formaPagamentoNegocio.ConsultarPorFilial(-1);

                                dgvConsultaCRUD.DataSource = formaPagamentoColecao;

                                dgvConsultaCRUD.Update();
                                dgvConsultaCRUD.Refresh();
                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Erro. Detalhes: "+ex.Message);
                        }
                        
                    }
                    

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

            if (acaoSelecionada == AcaoTelaConsultaCadastros.UsuarioConsulta)
            {
                try
                {
                    UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

                    UsuarioColecao usuarioColecao = new UsuarioColecao();

                    if (txtPesquisar.Text == "")
                    {
                        try
                        {
                            int ID;
                            if (int.TryParse(txtPesquisar.Text, out ID))
                            {
                                usuarioColecao = usuarioNegocio.ConsultarPorIdDaPessoa(ID, filialLogada.IDFilial);

                                dgvConsultaCRUD.DataSource = usuarioColecao;

                                dgvConsultaCRUD.Update();
                                dgvConsultaCRUD.Refresh();
                            }
                            else
                            {
                                usuarioColecao = usuarioNegocio.ConsultarPorIdDaPessoa(-1, filialLogada.IDFilial);

                                dgvConsultaCRUD.DataSource = usuarioColecao;

                                dgvConsultaCRUD.Update();
                                dgvConsultaCRUD.Refresh();
                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Erro. Detalhes: " + ex.Message);
                        }

                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Metodos para Inserir, Alterar, Excluir, Consultar

        private void cadastrarNovo(string tela)
        {
            if (tela == "categoria")
            {
                DialogResult retorno = ControleFormulario.abreFrmCategoriaCadastro(AcaoTelaCRUD.Inserir, null, filialLogada);
                if (retorno == DialogResult.Yes)
                {
                    atualizaGrid();
                }
            }

            if (tela == "fisica")
            {
                DialogResult retorno = ControleFormulario.abreFrmPessoaFisicaCadastro(AcaoTelaCRUD.Inserir, null,  filialLogada);
                if (retorno == DialogResult.Yes)
                {
                    atualizaGrid();
                }
            }

            if (tela == "juridica")
            {
                DialogResult retorno = ControleFormulario.abreFrmPessoaJuridicaCadastro(AcaoTelaCRUD.Inserir, null, filialLogada);
                if (retorno == DialogResult.Yes)
                {
                    atualizaGrid();
                }
            }

            if (tela == "produto")
            {
                DialogResult retorno = ControleFormulario.abreFrmProdutoCadastro(AcaoTelaCRUD.Inserir, null, filialLogada);
                if (retorno == DialogResult.Yes)
                {
                    atualizaGrid();
                }
            }

            if (tela == "pagamento")
            {
                DialogResult retorno = ControleFormulario.abreFrmFormaPagamento();
                if (retorno == DialogResult.Yes)
                {
                    atualizaGrid();
                }
            }
        }

        private void cadastrarAlterar(string tela)
        {
            if (tela == "categoria")
            {
                if (dgvConsultaCRUD.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhuma categoria foi selecionada.");
                    return;
                }

                ProdutoCategoria categoriaSelecionada = new ProdutoCategoria();

                categoriaSelecionada = (dgvConsultaCRUD.SelectedRows[0].DataBoundItem as ProdutoCategoria);

                DialogResult retorno = ControleFormulario.abreFrmCategoriaCadastro(AcaoTelaCRUD.Alterar, categoriaSelecionada, filialLogada);
                if (retorno == DialogResult.Yes)
                {
                    atualizaGrid();
                }
            }

            if (tela == "fisica")
            {
                if (dgvConsultaCRUD.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhuma categoria foi selecionada.");
                    return;
                }

                PessoaFisica pessoaFisicaSelecionada = new PessoaFisica();

                pessoaFisicaSelecionada = (dgvConsultaCRUD.SelectedRows[0].DataBoundItem as PessoaFisica);

                DialogResult retorno = ControleFormulario.abreFrmPessoaFisicaCadastro(AcaoTelaCRUD.Alterar, pessoaFisicaSelecionada, filialLogada);
                if (retorno == DialogResult.Yes)
                {
                    atualizaGrid();
                }
            }

            if (tela == "juridica")
            {
                if (dgvConsultaCRUD.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhuma pessoa foi selecionada.");
                    return;
                }

                PessoaJuridica pessoaJuridicaSelecionada = new PessoaJuridica();

                pessoaJuridicaSelecionada = (dgvConsultaCRUD.SelectedRows[0].DataBoundItem as PessoaJuridica);

                DialogResult retorno = ControleFormulario.abreFrmPessoaJuridicaCadastro(AcaoTelaCRUD.Alterar, pessoaJuridicaSelecionada, filialLogada);
                if (retorno == DialogResult.Yes)
                {
                    atualizaGrid();
                }
            }

            if (tela == "produto")
            {
                if (dgvConsultaCRUD.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum produto foi selecionado.");
                    return;
                }

                Produto produtoSelecionado = new Produto();

                produtoSelecionado = (dgvConsultaCRUD.SelectedRows[0].DataBoundItem as Produto);

                DialogResult retorno = ControleFormulario.abreFrmProdutoCadastro(AcaoTelaCRUD.Alterar, produtoSelecionado, filialLogada);
                if (retorno == DialogResult.Yes)
                {
                    atualizaGrid();
                }
            }

            if (tela == "usuario")
            {
                if (dgvConsultaCRUD.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum usuário foi selecionado.");
                    return;
                }

                Usuario usuarioSelecionado = new Usuario();

                usuarioSelecionado = (dgvConsultaCRUD.SelectedRows[0].DataBoundItem as Usuario);

                DialogResult retorno = ControleFormulario.abreFrmCadastrarUsu(AcaoTelaCRUD.Alterar, null, usuarioSelecionado);
                if (retorno == DialogResult.Yes)
                {
                    atualizaGrid();
                }
            }
        }

        private void cadastrarConsultar(string tela)
        {
            if (tela == "categoria")
            {
                ProdutoCategoria categoria = new ProdutoCategoria();

                if (dgvConsultaCRUD.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione uma categoria no grid para consultar.");
                    txtPesquisar.Focus();
                    return;
                }

                categoria = dgvConsultaCRUD.SelectedRows[0].DataBoundItem as ProdutoCategoria;

                DialogResult retorno = ControleFormulario.abreFrmCategoriaCadastro(AcaoTelaCRUD.Consultar, categoria, filialLogada);
            }

            if (tela == "fisica")
            {
                PessoaFisica pessoa = new PessoaFisica();

                if (dgvConsultaCRUD.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione uma categoria no grid para consultar.");
                    txtPesquisar.Focus();
                    return;
                }

                pessoa = dgvConsultaCRUD.SelectedRows[0].DataBoundItem as PessoaFisica;

                DialogResult retorno = ControleFormulario.abreFrmPessoaFisicaCadastro(AcaoTelaCRUD.Consultar, pessoa, filialLogada);
            }

            if (tela == "juridica")
            {
                PessoaJuridica pessoa = new PessoaJuridica();

                if (dgvConsultaCRUD.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione uma pessoa no grid para consultar.");
                    txtPesquisar.Focus();
                    return;
                }

                pessoa = dgvConsultaCRUD.SelectedRows[0].DataBoundItem as PessoaJuridica;

                DialogResult retorno = ControleFormulario.abreFrmPessoaJuridicaCadastro(AcaoTelaCRUD.Consultar, pessoa, filialLogada);
            }

            if (tela == "produto")
            {
                Produto produto = new Produto();

                if (dgvConsultaCRUD.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione um produto no grid para consultar.");
                    txtPesquisar.Focus();
                    return;
                }

                produto = dgvConsultaCRUD.SelectedRows[0].DataBoundItem as Produto;

                DialogResult retorno = ControleFormulario.abreFrmProdutoCadastro(AcaoTelaCRUD.Consultar, produto, filialLogada);
            }

            if (tela == "usuario")
            {
                if (dgvConsultaCRUD.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum usuário foi selecionado.");
                    return;
                }

                Usuario usuarioSelecionado = new Usuario();

                usuarioSelecionado = (dgvConsultaCRUD.SelectedRows[0].DataBoundItem as Usuario);

                DialogResult retorno = ControleFormulario.abreFrmCadastrarUsu(AcaoTelaCRUD.Consultar, null, usuarioSelecionado);
                if (retorno == DialogResult.Yes)
                {
                    atualizaGrid();
                }
            }
        }

        private void cadastrarExcluir(string tela)
        {
            if (tela == "categoria")
            {
                if (dgvConsultaCRUD.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione uma categoria no grid para excluir.");
                    txtPesquisar.Focus();
                    return;
                }

                ProdutoCategoria categoria = new ProdutoCategoria();

                categoria = dgvConsultaCRUD.SelectedRows[0].DataBoundItem as ProdutoCategoria;

                ProdutoCategoriaNegocio categoriaNegocio = new ProdutoCategoriaNegocio();

                DialogResult resultado = MessageBox.Show("Deseja realmente excluir a categoria " + categoria.Descricao + "?", "Exclusão de Categoria!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.No)
                {
                    return;
                }

                string retorno = categoriaNegocio.Excluir(categoria);

                try
                {
                    int verificaSeRetornoInt = Convert.ToInt32(retorno);

                    MessageBox.Show("A categoria " + categoria.Descricao + " foi excluída com sucesso.");
                    atualizaGrid();
                }
                catch
                {

                    MessageBox.Show("Não foi possível excluir a categoria " + categoria.Descricao + ". Detalhes: " + retorno);

                }
            }

            if (tela == "produto")
            {
                if (dgvConsultaCRUD.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione um produto no grid para excluir.");
                    txtPesquisar.Focus();
                    return;
                }

                Produto produto = new Produto();

                produto = dgvConsultaCRUD.SelectedRows[0].DataBoundItem as Produto;

                ProdutoNegocio produtoNegocio = new ProdutoNegocio();

                DialogResult resultado = MessageBox.Show("Deseja realmente excluir o produto " + produto.Nome + "?", "Exclusão de Produto!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.No)
                {
                    return;
                }

                string retorno = produtoNegocio.Excluir(produto);

                try
                {
                    int verificaSeRetornoInt = Convert.ToInt32(retorno);

                    MessageBox.Show("O produto "+ produto.Nome+" foi excluída com sucesso.");
                    atualizaGrid();
                }
                catch
                {

                    MessageBox.Show("Não foi possível excluir o produto " + produto.Nome+". Detalhes: " + retorno);

                }
            }

        }    

        private void btnExcluir_Click(object sender, EventArgs e)
            {
                if (acaoSelecionada == AcaoTelaConsultaCadastros.CategoriaConsulta)
                {
                    cadastrarExcluir("categoria");
                }

                if (acaoSelecionada == AcaoTelaConsultaCadastros.ProdutoConsulta)
                {
                    cadastrarExcluir("produto");
                }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
            {
                if (acaoSelecionada == AcaoTelaConsultaCadastros.CategoriaConsulta)
                {
                    cadastrarAlterar("categoria");
                }

                if (acaoSelecionada == AcaoTelaConsultaCadastros.PessoaFisicaConsulta)
                {
                    cadastrarAlterar("fisica");
                }

                if (acaoSelecionada == AcaoTelaConsultaCadastros.PessoaJuridicaConsulta)
                {
                    cadastrarAlterar("juridica");
                }

                if (acaoSelecionada == AcaoTelaConsultaCadastros.ProdutoConsulta)
                {
                    cadastrarAlterar("produto");
                }

                if (acaoSelecionada == AcaoTelaConsultaCadastros.UsuarioConsulta)
                    {
                         cadastrarAlterar("usuario");
                    }

        }

        private void btnNovo_Click(object sender, EventArgs e)
            {
                if (acaoSelecionada == AcaoTelaConsultaCadastros.CategoriaConsulta)
                {
                    cadastrarNovo("categoria");
                }

                if (acaoSelecionada == AcaoTelaConsultaCadastros.PessoaFisicaConsulta)
                {
                    cadastrarNovo("fisica");
                }
                if (acaoSelecionada == AcaoTelaConsultaCadastros.PessoaJuridicaConsulta)
                {
                    cadastrarNovo("juridica");
                }
                if (acaoSelecionada == AcaoTelaConsultaCadastros.ProdutoConsulta)
                {
                    cadastrarNovo("produto");
                }

                if (acaoSelecionada == AcaoTelaConsultaCadastros.FormaPagamento)
                {
                    cadastrarNovo("pagamento");
                }
        }



        private void dgvConsultaCRUD_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
            {

            }

        private void btnConsultar_Click(object sender, EventArgs e)
            {
                if (acaoSelecionada == AcaoTelaConsultaCadastros.CategoriaConsulta)
                {
                    cadastrarConsultar("categoria");
                }

                if (acaoSelecionada == AcaoTelaConsultaCadastros.PessoaFisicaConsulta)
                {
                    cadastrarConsultar("fisica");
                }

                if (acaoSelecionada == AcaoTelaConsultaCadastros.PessoaJuridicaConsulta)
                {
                    cadastrarConsultar("juridica");
                }

                if (acaoSelecionada == AcaoTelaConsultaCadastros.ProdutoConsulta)
                {
                    cadastrarConsultar("produto");
                }

                if (acaoSelecionada == AcaoTelaConsultaCadastros.UsuarioConsulta)
                {
                    cadastrarConsultar("usuario");
                }
        }

        private void btnFechar_Click(object sender, EventArgs e)
            {
                Close();
            }

        private void btnPesquisar_Click(object sender, EventArgs e)
            {

                atualizaGrid();
            }
        }
    }


