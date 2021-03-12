using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRANSFERENCIA;


namespace APRESENTACAO
{
    public partial class FrmPrincipal : Form
    {
        Usuario usuarioLogado;
        PessoaFilial filialLogada;
        public FrmPrincipal(Usuario usuario, PessoaFilial filial)
        {
            
                InitializeComponent();

            usuarioLogado = usuario;
            filialLogada = filial;
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoriaDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleFormulario.abreFrmConsultaCategoriaProdutoCRUD(AcaoTelaConsultaCadastros.CategoriaConsulta, filialLogada);
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleFormulario.abreFrmConsultaClienteCRUD(AcaoTelaConsultaCadastros.ClienteConsulta, filialLogada);
        }

        private void filialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleFormulario.abreFrmConsultaFilialCRUD(AcaoTelaConsultaCadastros.FilialConsulta, filialLogada);
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleFormulario.abreFrmConsultaFornecedorCRUD(AcaoTelaConsultaCadastros.FornecedorConsulta, filialLogada);
        }

        private void pessoaFísicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleFormulario.abreFrmConsultaPessoaFisicaCRUD(AcaoTelaConsultaCadastros.PessoaFisicaConsulta, filialLogada);
        }

        private void pessoaJurídicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleFormulario.abreFrmPessoaJuridicaCRUD(AcaoTelaConsultaCadastros.PessoaJuridicaConsulta, filialLogada);
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleFormulario.abreFrmConsultaProdutoCRUD(AcaoTelaConsultaCadastros.ProdutoConsulta, filialLogada);
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            stsUsuarioLogado.Text = stsUsuarioLogado.Text + usuarioLogado.Login;
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
