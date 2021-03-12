using NEGOCIOS;
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
    public partial class FrmCategoriaCadastro : Form
    {
        AcaoTelaCRUD acaoSelecionada;

        public FrmCategoriaCadastro(AcaoTelaCRUD acaoTelaCRUD, ProdutoCategoria categoriaRecebida)
        {
            InitializeComponent();

            acaoSelecionada = acaoTelaCRUD;

            if(acaoSelecionada == AcaoTelaCRUD.Inserir)
            {
                this.Text = "SGV - Nova Categoria";
            }
            else if (acaoSelecionada == AcaoTelaCRUD.Alterar)
            {
                this.Text = "SGV - Alterar Categoria";
                txtCodigo.Text = categoriaRecebida.IDCategoria.ToString();
                txtDescricao.Text = categoriaRecebida.Descricao;
            }
            else if (acaoSelecionada == AcaoTelaCRUD.Excluir)
            {

            }
            else if (acaoSelecionada == AcaoTelaCRUD.Consultar)
            {
                this.Text = "SGV - Consultar Categoria";
                txtCodigo.Text = categoriaRecebida.IDCategoria.ToString();
                txtDescricao.Text = categoriaRecebida.Descricao;
                txtDescricao.Enabled = false;
                btnSalvar.Visible = false;
                btnCancelar.Text = "Fechar";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(acaoSelecionada == AcaoTelaCRUD.Inserir)
            {
                ProdutoCategoria categoria = new ProdutoCategoria();
                categoria.Descricao = txtDescricao.Text;

                ProdutoCategoriaNegocio categoriaNegocio = new ProdutoCategoriaNegocio();

                string retorno = categoriaNegocio.Inserir(categoria);

                try
                {
                    MessageBox.Show("Categoria inserida com sucesso. Código da nova categoria: " + retorno);
                    DialogResult = DialogResult.Yes;
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível inserir a nova categoria. Detalhes: " + retorno);
                    DialogResult = DialogResult.No;
                }
                
            }

            if(acaoSelecionada == AcaoTelaCRUD.Alterar)
            {
                ProdutoCategoria categoria = new ProdutoCategoria();

                categoria.IDCategoria = Convert.ToInt32(txtCodigo.Text);
                categoria.Descricao = txtDescricao.Text;

                ProdutoCategoriaNegocio categoriaNegocio = new ProdutoCategoriaNegocio();

                string retorno = categoriaNegocio.Alterar(categoria);

                try
                {
                    MessageBox.Show("Categoria alterada com sucesso. Código da categoria: " + retorno);
                    DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Erro ao alterar a categoria. Detalhes: " + retorno);
                    DialogResult = DialogResult.No;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCategoriaCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ControleFormulario.frmCategoriaCadastro != null)
            {
                ControleFormulario.frmCategoriaCadastro = null;
            }
            
        }
    }
}
