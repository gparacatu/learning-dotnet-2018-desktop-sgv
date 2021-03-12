using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TRANSFERENCIA;

namespace APRESENTACAO
{
    public class ControleFormulario
    {
        #region FrmConsultas
        //CONSULTAS
        public static FrmConsultaCRUD frmConsultaCategoriaProdutoCRUD { get; set; }

        public static FrmConsultaCRUD frmConsultaClienteCRUD { get; set; }

        public static FrmConsultaCRUD frmConsultaFilialCRUD { get; set; }

        public static FrmConsultaCRUD frmConsultaFornecedorCRUD { get; set; }

        public static FrmConsultaCRUD frmConsultaPessoaFisicaCRUD { get; set; }

        public static FrmConsultaCRUD frmConsultaPessoaJuridicaCRUD { get; set; }

        public static FrmConsultaCRUD frmConsultaProdutoCRUD { get; set; }

        public static FrmCalculadora frmCalculadora { get; set; }

        public static FrmLogon frmLogon { get; set; }

        public static FrmMenu frmMenu { get; set; }

        public static FrmPrincipal frmPrincipal { get; set; }

        public static FrmConsultaCRUD frmConsultaClienteVenda { get; set; }

        public static FrmConsultaCRUD frmConsultaFornecedorCompra { get; set; }

        public static FrmConsultaCRUD frmConsultaProdutoVenda { get; set; }

        public static FrmConsultaCRUD frmConsultaFormaPagamento { get; set; }

        public static FrmConsultaCRUD frmConsultaUsuarios { get; set; }
        #endregion

        #region FrmCadastros
        //CADASTROS
        public static FrmCategoriaCadastro frmCategoriaCadastro { get; set; }
        public static FrmCadastrarPessoaFisica frmPessoaFisicaCadastro { get; set; }
        public static FrmCadastrarPessoaJuridica frmPessoaJuridicaCadastro { get; set; }
        public static FrmCadastrarProduto frmProdutoCadastro { get; set; }
        public static FrmCadastrarUsu frmCadastrarUsu { get; set; }
        public static FrmVendaWindows frmVendaWindows { get; set; }
        public static FrmCompraWindows frmCompraWindows { get; set; }
        public static FrmAbrircaixa frmAbrirCaixa { get; set; }
        public static FrmFecharCaixa frmFecharCaixa { get; set; }
        public static FrmFormaPagamento frmFormaPagamento { get; set; }
        #endregion

        #region AbreConsultas
        //CONSULTAS
        public static void abreFrmConsultaCategoriaProdutoCRUD(AcaoTelaConsultaCadastros acao, PessoaFilial filial)
        {
            if (frmConsultaCategoriaProdutoCRUD == null)
            {
                frmConsultaCategoriaProdutoCRUD = new FrmConsultaCRUD(acao, filial);
            }

            frmConsultaCategoriaProdutoCRUD.Show();
            frmConsultaCategoriaProdutoCRUD.Focus();
        }

        public static void abreFrmConsultaClienteCRUD(AcaoTelaConsultaCadastros acao, PessoaFilial filial)
        {
            if (frmConsultaClienteCRUD == null)
            {
                frmConsultaClienteCRUD = new FrmConsultaCRUD(acao, filial);
            }

            frmConsultaClienteCRUD.Show();
            frmConsultaClienteCRUD.Focus();
        }

        public static void abreFrmConsultaFilialCRUD(AcaoTelaConsultaCadastros acao, PessoaFilial filial)
        {
            if (frmConsultaFilialCRUD == null)
            {
                frmConsultaFilialCRUD = new FrmConsultaCRUD(acao, filial);
            }

            frmConsultaFilialCRUD.Show();
            frmConsultaFilialCRUD.Focus();
        }

        public static void abreFrmConsultaFornecedorCRUD(AcaoTelaConsultaCadastros acao, PessoaFilial filial)
        {
            if (frmConsultaFornecedorCRUD == null)
            {
                frmConsultaFornecedorCRUD = new FrmConsultaCRUD(acao, filial);
            }

            frmConsultaFornecedorCRUD.Show();
            frmConsultaFornecedorCRUD.Focus();
        }

        public static void abreFrmConsultaPessoaFisicaCRUD(AcaoTelaConsultaCadastros acao, PessoaFilial filial)
        {
            if (frmConsultaPessoaFisicaCRUD == null)
            {
                frmConsultaPessoaFisicaCRUD = new FrmConsultaCRUD(acao, filial);
            }

            frmConsultaPessoaFisicaCRUD.Show();
            frmConsultaPessoaFisicaCRUD.Focus();
        }

        public static void abreFrmPessoaJuridicaCRUD(AcaoTelaConsultaCadastros acao, PessoaFilial filial)
        {
            if (frmConsultaPessoaJuridicaCRUD == null)
            {
                frmConsultaPessoaJuridicaCRUD = new FrmConsultaCRUD(acao, filial);
            }

            frmConsultaPessoaJuridicaCRUD.Show();
            frmConsultaPessoaJuridicaCRUD.Focus();
        }

        public static void abreFrmConsultaProdutoCRUD(AcaoTelaConsultaCadastros acao, PessoaFilial filialLogada)
        {
            if (frmConsultaProdutoCRUD == null)
            {
                frmConsultaProdutoCRUD = new FrmConsultaCRUD(acao, filialLogada);
            }

            frmConsultaProdutoCRUD.Show();
            frmConsultaProdutoCRUD.Focus();
        }

        public static void abreFrmCalculadora()
        {
            if (frmCalculadora == null)
            {
                frmCalculadora = new FrmCalculadora();
            }

            frmCalculadora.Show();
            frmCalculadora.Focus();
        }

        public static void abreFrmLogon()
        {
            if (frmLogon == null)
            {
                frmLogon = new FrmLogon();
            }

            frmLogon.Show();
            frmLogon.Focus();
        }

        public static void abreFrmPrincipal(Usuario usuario, PessoaFilial filial)
        {
            if (frmPrincipal == null)
            {
                frmPrincipal = new FrmPrincipal(usuario, filial);
            }

            frmPrincipal.Show();
            frmPrincipal.Focus();
        }

        public static void abreFrmMenu(Usuario usuario, PessoaFilial filial)
        {
            if (frmMenu == null)
            {
                frmMenu = new FrmMenu(usuario, filial);
            }

            frmMenu.Show();
            frmMenu.Focus();
        }

        public static uvwPessoaFisicaJuridica abreFrmConsultaClienteVenda(AcaoTelaConsultaCadastros acao, PessoaFilial filial)
        {
            if (frmConsultaClienteVenda == null)
            {
                frmConsultaClienteVenda = new FrmConsultaCRUD(acao, filial);
            }

            frmConsultaClienteVenda.ShowDialog();
            frmConsultaClienteVenda.Focus();
            uvwPessoaFisicaJuridica clienteSelecionado = frmConsultaClienteVenda.pegaPessoa;
            return clienteSelecionado;
        }

        public static uvwPessoaFisicaJuridica abreFrmConsultaFornecedorCompra(AcaoTelaConsultaCadastros acao, PessoaFilial filial)
        {
            if (frmConsultaFornecedorCompra == null)
            {
                frmConsultaFornecedorCompra = new FrmConsultaCRUD(acao, filial);
            }

            frmConsultaFornecedorCompra.ShowDialog();
            frmConsultaFornecedorCompra.Focus();
            uvwPessoaFisicaJuridica clienteSelecionado = frmConsultaFornecedorCompra.pegaPessoa;
            return clienteSelecionado;
        }

        public static Produto abreFrmConsultaProdutoVenda(AcaoTelaConsultaCadastros acao, PessoaFilial filial)
        {
            if (frmConsultaProdutoVenda == null)
            {
                frmConsultaProdutoVenda = new FrmConsultaCRUD(acao, filial);
            }

            frmConsultaProdutoVenda.ShowDialog();
            frmConsultaProdutoVenda.Focus();
            Produto produtoSelecionado = frmConsultaProdutoVenda.pegaProduto;
            return produtoSelecionado;
        }

        public static void abreFrmConsultaFormaPagamentoCRUD(AcaoTelaConsultaCadastros acao, PessoaFilial filial)
        {
            if (frmConsultaFormaPagamento == null)
            {
                frmConsultaFormaPagamento = new FrmConsultaCRUD(acao, filial);
            }

            frmConsultaFormaPagamento.ShowDialog();
            frmConsultaFormaPagamento.Focus();          
        }

        public static void abreFrmConsultaUsuariosCRUD(AcaoTelaConsultaCadastros acao, PessoaFilial filial)
        {
            if (frmConsultaUsuarios == null)
            {
                frmConsultaUsuarios = new FrmConsultaCRUD(acao, filial);
            }

            frmConsultaUsuarios.ShowDialog();
            frmConsultaUsuarios.Focus();
        }
        #endregion

        #region AbreCadastros
        //CADASTROS
        public static DialogResult abreFrmCategoriaCadastro(AcaoTelaCRUD acao, ProdutoCategoria categoria, PessoaFilial filial)
        {
            if (frmCategoriaCadastro == null)
            {
                frmCategoriaCadastro = new FrmCategoriaCadastro(acao, categoria);
            }

            DialogResult retorno = frmCategoriaCadastro.ShowDialog();

            return retorno;
        }

        public static DialogResult abreFrmPessoaFisicaCadastro(AcaoTelaCRUD acao, PessoaFisica pessoa, PessoaFilial filial)
        {
            if (frmPessoaFisicaCadastro == null)
            {
                frmPessoaFisicaCadastro = new FrmCadastrarPessoaFisica(acao, pessoa);
            }

            DialogResult retorno = frmPessoaFisicaCadastro.ShowDialog();

            return retorno;
        }

        public static DialogResult abreFrmPessoaJuridicaCadastro(AcaoTelaCRUD acao, PessoaJuridica pessoa, PessoaFilial filial)
        {
            if (frmPessoaJuridicaCadastro == null)
            {
                frmPessoaJuridicaCadastro = new FrmCadastrarPessoaJuridica(acao, pessoa);
            }

            DialogResult retorno = frmPessoaJuridicaCadastro.ShowDialog();

            return retorno;
        }

        public static DialogResult abreFrmProdutoCadastro(AcaoTelaCRUD acao, Produto produto, PessoaFilial filial)
        {
            if (frmProdutoCadastro == null)
            {
                frmProdutoCadastro = new FrmCadastrarProduto(acao, produto, filial);
            }

            DialogResult retorno = frmProdutoCadastro.ShowDialog();

            return retorno;
        }

        public static DialogResult abreFrmVendaWindows(PessoaFilial filial)
        {
            if (frmVendaWindows == null)
            {
                frmVendaWindows = new FrmVendaWindows(filial);
            }

            DialogResult retorno = frmVendaWindows.ShowDialog();

            return retorno;
        }

        public static DialogResult abreFrmCompraWindows(PessoaFilial filial)
        {
            if (frmCompraWindows == null)
            {
                frmCompraWindows = new FrmCompraWindows(filial);
            }

            DialogResult retorno = frmCompraWindows.ShowDialog();

            return retorno;
        }

        public static DialogResult abreFrmCadastrarUsu(AcaoTelaCRUD acao, PessoaFisica pessoaFisica, Usuario usuario)
        {
            if (frmCadastrarUsu == null)
            {
                frmCadastrarUsu = new FrmCadastrarUsu(acao, pessoaFisica, usuario);
            }

            DialogResult retorno = frmCadastrarUsu.ShowDialog();

            return retorno;
        }

        public static DialogResult abreFrmAbrirCaixa()
        {
            if (frmAbrirCaixa == null)
            {
                frmAbrirCaixa = new FrmAbrircaixa();
            }

            DialogResult retorno = frmAbrirCaixa.ShowDialog();

            return retorno;
        }

        public static DialogResult abreFrmFecharCaixa()
        {
            if (frmFecharCaixa == null)
            {
                frmFecharCaixa = new FrmFecharCaixa();
            }

            DialogResult retorno = frmFecharCaixa.ShowDialog();

            return retorno;
        }

        public static DialogResult abreFrmFormaPagamento()
        {
            if (frmFormaPagamento == null)
            {
                frmFormaPagamento = new FrmFormaPagamento();
            }

            DialogResult retorno = frmFormaPagamento.ShowDialog();

            return retorno;
        }
        #endregion


    }
}
