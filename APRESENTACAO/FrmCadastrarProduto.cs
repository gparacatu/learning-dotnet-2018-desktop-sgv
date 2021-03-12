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
using NEGOCIOS;
namespace APRESENTACAO
{
    public partial class FrmCadastrarProduto : Form
    {
        AcaoTelaCRUD acaoSelecionada;
        Produto produtoRecebidoPublic;
        PessoaFilial filialLogada;
        public FrmCadastrarProduto(AcaoTelaCRUD acao, Produto produto, PessoaFilial filial)
        {
            InitializeComponent();

            acaoSelecionada = acao;
            produtoRecebidoPublic = produto;
            filialLogada = filial;

            if (acaoSelecionada == AcaoTelaCRUD.Inserir)
            {
                this.Text = "SGV - Novo Produto";
                try
                {
                    ProdutoCategoriaColecao produtoCategoriaColecao = new ProdutoCategoriaColecao();
                    ProdutoCategoriaNegocio produtoCategoriaNegocio = new ProdutoCategoriaNegocio();

                    produtoCategoriaColecao = produtoCategoriaNegocio.ConsultarPorIdNomeCategoria(null);

                    cbbCategoria.DataSource = produtoCategoriaColecao;
                    cbbCategoria.ValueMember = "IDCategoria";
                    cbbCategoria.DisplayMember = "Descricao";
                    //cbbCategoria.SelectedIndex = cbbCategoria.FindString(produto.CategoriaDescricao);
                    cbbCategoria.Refresh();
                }
                catch
                {

                    MessageBox.Show("Não foi possível recuperar a lista de categorias.");
                }
                try
                {
                    StatusColecao statusColecao = new StatusColecao();
                    StatusNegocio statusNegocio = new StatusNegocio();

                    statusColecao = statusNegocio.Consultar();

                    cbbStatus.DataSource = statusColecao;
                    cbbStatus.ValueMember = "IDStatus";
                    cbbStatus.DisplayMember = "Descricao";
                    //cbbStatus.SelectedIndex = cbbStatus.FindString(produto.StatusDescricao);
                    cbbStatus.Refresh();
                }
                catch
                {

                    MessageBox.Show("Não foi possível recuperar a lista de status.");
                }
            }
            else if (acaoSelecionada == AcaoTelaCRUD.Alterar)
            {
                this.Text = "SGV - Alterar Preço/Foto/Status/Categoria do Produto";
                txtCodigo.Text = produto.IDProduto.ToString();
                txtCodigo.Enabled = false;
                txtNome.Text = produto.Nome;
                txtNome.Enabled = false;
                txtPrecoCusto.Text = produto.PrecoCusto.ToString();
                txtPrecoVenda.Text = produto.PrecoVenda.ToString();
                try
                {
                    imgFoto.Image = new Bitmap(produto.Foto);
                }
                catch
                {

                    MessageBox.Show("Não foi possível carregar a foto do produto.");
                }
                
                try
                {
                    ProdutoCategoriaColecao produtoCategoriaColecao = new ProdutoCategoriaColecao();
                    ProdutoCategoriaNegocio produtoCategoriaNegocio = new ProdutoCategoriaNegocio();

                    produtoCategoriaColecao = produtoCategoriaNegocio.ConsultarPorIdNomeCategoria(null);

                    cbbCategoria.DataSource = produtoCategoriaColecao;
                    cbbCategoria.ValueMember = "IDCategoria";
                    cbbCategoria.DisplayMember = "Descricao";
                    cbbCategoria.SelectedIndex = cbbCategoria.FindString(produto.CategoriaDescricao);
                    cbbCategoria.Refresh();
                }
                catch
                {

                    MessageBox.Show("Não foi possível recuperar a lista de categorias.");
                }
                try
                {
                    StatusColecao statusColecao = new StatusColecao();
                    StatusNegocio statusNegocio = new StatusNegocio();

                    statusColecao = statusNegocio.Consultar();

                    cbbStatus.DataSource = statusColecao;
                    cbbStatus.ValueMember = "IDStatus";
                    cbbStatus.DisplayMember = "Descricao";
                    cbbStatus.SelectedIndex = cbbStatus.FindString(produto.StatusDescricao);
                    cbbStatus.Refresh();
                }
                catch
                {

                    MessageBox.Show("Não foi possível recuperar a lista de status.");
                }



            }
            else if (acaoSelecionada == AcaoTelaCRUD.Excluir)
            {

            }
            else if (acaoSelecionada == AcaoTelaCRUD.Consultar)
            {
                this.Text = "SGV - Consultar Produto";
                txtCodigo.Text = produto.IDProduto.ToString();
                txtCodigo.Enabled = false;
                txtNome.Text = produto.Nome;
                txtNome.Enabled = false;
                txtPrecoCusto.Text = produto.PrecoCusto.ToString();
                txtPrecoCusto.Enabled = false;
                txtPrecoVenda.Text = produto.PrecoVenda.ToString();
                txtPrecoVenda.Enabled = false;
                try
                {
                    imgFoto.Image = new Bitmap(produto.Foto);
                }
                catch
                {

                    MessageBox.Show("Não foi possível carregar a foto do produto.");
                }
                
                imgFoto.Enabled = false;
                cbbCategoria.Items.Add(produto.CategoriaDescricao);
                cbbCategoria.SelectedIndex = 0;
                cbbCategoria.Enabled = false;
                cbbStatus.Items.Add(produto.StatusDescricao);
                cbbStatus.SelectedIndex = 0;
                cbbStatus.Enabled = false;
                btnSalvar.Visible = false;
                btnCancelar.Text = "Fechar";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (acaoSelecionada == AcaoTelaCRUD.Inserir)
            {
                Produto produto = new Produto();
                produto.Nome = txtNome.Text;
                produto.IDStatus = Convert.ToInt32(cbbStatus.SelectedValue);
                produto.PrecoCusto = Convert.ToDecimal(txtPrecoCusto.Text.Replace("R$", ""));
                produto.PrecoVenda = Convert.ToDecimal(txtPrecoVenda.Text.Replace("R$", ""));               
                produto.Categoria = Convert.ToInt32(cbbCategoria.SelectedValue);      
                produto.Foto = imgFoto.ImageLocation;
                produto.IDFilial = filialLogada.IDFilial;

                ProdutoNegocio produtoNegocio = new ProdutoNegocio();

                string retorno = produtoNegocio.Inserir(produto);

                try
                {
                    int verifica = Convert.ToInt32(retorno);
                    MessageBox.Show("Produto inserido com sucesso. Código do produto: " + retorno);
                    DialogResult = DialogResult.Yes;
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível inserir o produto. Detalhes: " + retorno);
                    DialogResult = DialogResult.No;
                }

            }

            if (acaoSelecionada == AcaoTelaCRUD.Alterar)
            {
                Produto produto = new Produto();
                produto.IDProduto = Convert.ToInt32(txtCodigo.Text);
                produto.Nome = txtNome.Text;
                produto.IDStatus = Convert.ToInt32(cbbStatus.SelectedValue);
                produto.PrecoCusto = Convert.ToDecimal(txtPrecoCusto.Text.Replace("R$", ""));
                produto.PrecoVenda = Convert.ToDecimal(txtPrecoVenda.Text.Replace("R$", ""));
                produto.Categoria = Convert.ToInt32(cbbCategoria.SelectedValue);
                produto.IDFilial = filialLogada.IDFilial;
                
                if (imgFoto.ImageLocation == null)
                {
                    produto.Foto = produtoRecebidoPublic.Foto;
                }
                else
                {
                    produto.Foto = imgFoto.ImageLocation;
                }

                ProdutoNegocio produtoNegocio = new ProdutoNegocio();

                string retorno = produtoNegocio.Alterar(produto);

                try
                {
                    int verifica = Convert.ToInt32(retorno);
                    MessageBox.Show("Produto alterado com sucesso. Código do produto: " + retorno);
                    DialogResult = DialogResult.Yes;
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível alterar o produto. Detalhes: " + retorno);
                    DialogResult = DialogResult.No;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPrecoCusto_Leave(object sender, EventArgs e)
        {
            
            //txtPrecoCusto.Text=Convert.ToDouble(txtPrecoCusto.Text).ToString("C");
        }

        private void txtPrecoCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtPrecoCusto.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txtPrecoCusto_Enter(object sender, EventArgs e)
        {
            String x = "";
            for (int i = 0; i <= txtPrecoCusto.Text.Length - 1; i++)
            {
                if ((txtPrecoCusto.Text[i] >= '0' &&
                    txtPrecoCusto.Text[i] <= '9') ||
                    txtPrecoCusto.Text[i] == ',')
                {
                    x += txtPrecoCusto.Text[i];
                }
            }
            txtPrecoCusto.Text = x;
            txtPrecoCusto.SelectAll();
        }

        private void txtPrecoVenda_Leave(object sender, EventArgs e)
        {
            txtPrecoVenda.Text = Convert.ToDouble(txtPrecoVenda.Text).ToString("C");
        }

        private void txtPrecoVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtPrecoVenda.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txtPrecoVenda_Enter(object sender, EventArgs e)
        {
            String x = "";
            for (int i = 0; i <= txtPrecoVenda.Text.Length - 1; i++)
            {
                if ((txtPrecoVenda.Text[i] >= '0' &&
                    txtPrecoVenda.Text[i] <= '9') ||
                    txtPrecoVenda.Text[i] == ',')
                {
                    x += txtPrecoVenda.Text[i];
                }
            }
            txtPrecoVenda.Text = x;
            txtPrecoVenda.SelectAll();
        }

        private void FrmCadastrarProduto_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ControleFormulario.frmProdutoCadastro != null)
                ControleFormulario.frmProdutoCadastro = null;
        }

        private void imgFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imgFoto.Load(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao inserir a logo. Detalhes: {0}",ex.Message);
            }
        }
    }
}
