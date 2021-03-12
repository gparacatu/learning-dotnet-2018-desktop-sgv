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

namespace APRESENTACAO
{
    public partial class FrmCadastrarPessoaFisica : Form
    {
        AcaoTelaCRUD acaoSelecionada;
        PessoaFisica pessoaRecebida;
        public FrmCadastrarPessoaFisica(AcaoTelaCRUD acao, PessoaFisica pessoa)
        {
            InitializeComponent();

            acaoSelecionada = acao;
            pessoaRecebida = pessoa;

            if (acaoSelecionada == AcaoTelaCRUD.Inserir)
            {
                this.Text = "SGV - Nova Pessoa Física";
            }
            else if (acaoSelecionada == AcaoTelaCRUD.Alterar)
            {
                try
                {
                    this.Text = "SGV - Alterar Pessoa Física";
                    txtBairro.Text = pessoa.Bairro;
                    txtCep.Text = pessoa.Cep;
                    txtCidade.Text = pessoa.Cidade;
                    txtCodigo.Text = Convert.ToString(pessoa.IDPessoa);
                    txtCpf.Text = pessoa.Cpf;
                    txtEmail.Text = pessoa.Email;
                    txtNome.Text = pessoa.Nome;
                    txtNumero.Text = pessoa.Numero.ToString();
                    txtRg.Text = pessoa.Rg;
                    txtRua.Text = pessoa.Rua;
                    txtTelefone.Text = pessoa.Telefone;
                    dtpDataNascimento.Value = pessoa.DataNascimento;

                    grbClassificacao.Visible = false;
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
                

            }
            else if (acaoSelecionada == AcaoTelaCRUD.Excluir)
            {

            }
            else if (acaoSelecionada == AcaoTelaCRUD.Consultar)
            {
                this.Text = "SGV - Consultar Pessoa Física";
                txtBairro.Text = pessoa.Bairro;
                txtBairro.Enabled = false;
                txtCep.Text = pessoa.Cep;
                txtCep.Enabled = false;
                txtCidade.Text = pessoa.Cidade;
                txtCidade.Enabled = false;
                txtCodigo.Text = Convert.ToString(pessoa.IDPessoa);
                txtCodigo.Enabled = false;
                txtCpf.Text = pessoa.Cpf;
                txtCpf.Enabled = false;
                txtEmail.Text = pessoa.Email;
                txtEmail.Enabled = false;
                txtNome.Text = pessoa.Nome;
                txtNome.Enabled = false;
                txtNumero.Text = pessoa.Numero.ToString();
                txtNumero.Enabled = false;
                txtRg.Text = pessoa.Rg;
                txtRg.Enabled = false;
                txtRua.Text = pessoa.Rua;
                txtRua.Enabled = false;
                txtTelefone.Text = pessoa.Telefone;
                txtTelefone.Enabled = false;
                dtpDataNascimento.Value = pessoa.DataNascimento;
                dtpDataNascimento.Enabled = false;

                grbClassificacao.Visible = false;
                btnSalvar.Visible = false;
                btnCancelar.Text = "Fechar";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (acaoSelecionada == AcaoTelaCRUD.Inserir)
            {
                PessoaFisica pessoa = new PessoaFisica();
                pessoa.Bairro = txtBairro.Text;
                pessoa.Cep = txtCep.Text;
                pessoa.Cidade = txtCidade.Text;
                pessoa.Cpf = txtCpf.Text;
                pessoa.DataNascimento = dtpDataNascimento.Value;
                pessoa.Email = txtEmail.Text;
                pessoa.Nome = txtNome.Text;
                pessoa.Numero = Convert.ToInt32(txtNumero.Text);
                pessoa.Rg = txtRg.Text;
                pessoa.Rua = txtRua.Text;
                pessoa.Telefone = txtTelefone.Text;

                if (ckbCliente.Checked == true)
                {
                    pessoa.TipoCliente = "Cliente";
                }
                if (ckbFilial.Checked == true)
                {
                    pessoa.TipoFilial = "Filial";
                }
                if (ckbFornecedor.Checked == true)
                {
                    pessoa.TipoFornecedor = "Fornecedor";
                }

                if((ckbCliente.Checked == false) && (ckbFilial.Checked == false) && (ckbFornecedor.Checked == false))
                 {
                    MessageBox.Show("É necessário selecionar uma classificação para a pessoa.");
                    grbClassificacao.Focus();
                    return;
                 }


                PessoaFisicaNegocio pessoaFisicaNegocio = new PessoaFisicaNegocio();

                string retorno = pessoaFisicaNegocio.Inserir(pessoa);

                try
                {
                    int verifica = Convert.ToInt32(retorno);
                    MessageBox.Show("Pessoa física inserida com sucesso. Código da pessoa: " + retorno);
                    DialogResult = DialogResult.Yes;
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível inserir a pessoa. Detalhes: " + retorno);
                    DialogResult = DialogResult.No;
                }

            }

            if (acaoSelecionada == AcaoTelaCRUD.Alterar)
            {
                PessoaFisica pessoa = new PessoaFisica();
                pessoa.IDPessoa = Convert.ToInt32(txtCodigo.Text);
                pessoa.Bairro = txtBairro.Text;
                pessoa.Cep = txtCep.Text;
                pessoa.Cidade = txtCidade.Text;
                pessoa.Cpf = txtCpf.Text;
                pessoa.DataNascimento = dtpDataNascimento.Value;
                pessoa.Email = txtEmail.Text;
                pessoa.Nome = txtNome.Text;
                pessoa.Numero = Convert.ToInt32(txtNumero.Text);
                pessoa.Rg = txtRg.Text;
                pessoa.Rua = txtRua.Text;
                pessoa.Telefone = txtTelefone.Text;

                PessoaFisicaNegocio pessoaFisicaNegocio = new PessoaFisicaNegocio();

                string retorno = pessoaFisicaNegocio.Alterar(pessoa);

                try
                {
                    int verifica = Convert.ToInt32(retorno);
                    MessageBox.Show("Pessoa física alterada com sucesso. Código da pessoa: " + retorno);
                    DialogResult = DialogResult.Yes;
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível alterar a pessoa. Detalhes: " + retorno);
                    DialogResult = DialogResult.No;
                }
            }
        }

        private void FrmCadastrarPessoaFisica_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(ControleFormulario.frmPessoaFisicaCadastro != null)
            {
                ControleFormulario.frmPessoaFisicaCadastro = null;
            }
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            //Consulta cep direto nos correios

            try
            {
                //cria o objeto correioWS
                var correioWS = new WSCorreio.AtendeClienteClient();
                //Recebe os dados do cep digitado na textbox
                var cep = correioWS.consultaCEP(txtCep.Text);
                //coloca os dados recebidos do correio nos campos da tela
                txtRua.Text = cep.end;
                txtBairro.Text = cep.bairro;
                txtCidade.Text = cep.cidade;
                txtNumero.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao consultar CEP. Detalhes: {0}" + ex.Message);
                
            }
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            ControleFormulario.abreFrmCadastrarUsu(AcaoTelaCRUD.Inserir, pessoaRecebida, null);
        }

        private void FrmCadastrarPessoaFisica_Load(object sender, EventArgs e)
        {
            if (acaoSelecionada == AcaoTelaCRUD.Alterar)
            {
                try
                {
                    UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

                    UsuarioColecao usuarioColecao = new UsuarioColecao();

                    usuarioColecao = usuarioNegocio.ConsultarPorIdDaPessoa(pessoaRecebida.IDPessoa, ControleSistema.getFilialLogada().IDFilial);

                    if (usuarioColecao.Count == 0 && ControleSistema.getUsuario().Acesso > 4)
                    {
                        btnCadastrarUsuario.Visible = true;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ocorreu um erro ao consultar se a pessoa tem um usuário criado. Detalhes: " + ex.Message);
                }
            }
                   
        }
    }
}
