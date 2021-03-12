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
    public partial class FrmCadastrarPessoaJuridica : Form
    {
        AcaoTelaCRUD acaoSelecionada;
        PessoaJuridica pessoaRecebidaPublic;
        public FrmCadastrarPessoaJuridica(AcaoTelaCRUD acao, PessoaJuridica pessoaRecebida)
        {
            InitializeComponent();

            acaoSelecionada = acao;
            pessoaRecebidaPublic = pessoaRecebida;

            if (acaoSelecionada == AcaoTelaCRUD.Inserir)
            {
                this.Text = "SGV - Nova Pessoa Jurídica";
            }
            else if (acaoSelecionada == AcaoTelaCRUD.Alterar)
            {
                try
                {
                    this.Text = "SGV - Alterar Pessoa Juridíca";
                    txtBairro.Text = pessoaRecebida.Bairro;
                    txtCep.Text = pessoaRecebida.Cep;
                    txtCidade.Text = pessoaRecebida.Cidade;
                    txtCodigo.Text = Convert.ToString(pessoaRecebida.IDPessoa);
                    txtCnpj.Text = pessoaRecebida.Cnpj;
                    txtEmail.Text = pessoaRecebida.Email;
                    txtRazaoSocial.Text = pessoaRecebida.RazaoSocial;
                    txtNomeFantasia.Text = pessoaRecebida.NomeFantasia;
                    txtNumero.Text = pessoaRecebida.Numero.ToString();
                    txtInscricao.Text = pessoaRecebida.InscricaoEstadual;
                    txtRua.Text = pessoaRecebida.Rua;
                    txtTelefone.Text = pessoaRecebida.Telefone;
                    try
                    {
                        ptblogo.Image = new Bitmap(pessoaRecebida.Logo);
                    }
                    catch
                    {

                        MessageBox.Show("Não foi ppossível carregar a logo.");
                    }


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
                this.Text = "SGV - Consultar Pessoa Juridica";
                txtBairro.Text = pessoaRecebida.Bairro;
                txtBairro.Enabled = false;
                txtCep.Text = pessoaRecebida.Cep;
                txtCep.Enabled = false;
                txtCidade.Text = pessoaRecebida.Cidade;
                txtCidade.Enabled = false;
                txtCodigo.Text = Convert.ToString(pessoaRecebida.IDPessoa);
                txtCodigo.Enabled = false;
                txtCnpj.Text = pessoaRecebida.Cnpj;
                txtCnpj.Enabled = false;
                txtEmail.Text = pessoaRecebida.Email;
                txtEmail.Enabled = false;
                txtRazaoSocial.Text = pessoaRecebida.RazaoSocial;
                txtRazaoSocial.Enabled = false;
                txtNomeFantasia.Text = pessoaRecebida.NomeFantasia;
                txtNomeFantasia.Enabled = false;
                txtNumero.Text = pessoaRecebida.Numero.ToString();
                txtNumero.Enabled = false;
                txtInscricao.Text = pessoaRecebida.InscricaoEstadual;
                txtInscricao.Enabled = false;
                txtRua.Text = pessoaRecebida.Rua;
                txtRua.Enabled = false;
                txtTelefone.Text = pessoaRecebida.Telefone;
                txtTelefone.Enabled = false;
                try
                {
                    ptblogo.Image = new Bitmap(pessoaRecebida.Logo);
                }
                catch
                {

                    MessageBox.Show("Não foi possível carregar a logo.");
                }
                    
                                
                ptblogo.Enabled = false;

                grbClassificacao.Visible = false;
                btnSalvar.Visible = false;
                btnCancelar.Text = "Fechar";
            }
        }

        private void FrmCadastrarPessoaJuridica_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ControleFormulario.frmPessoaJuridicaCadastro != null)
                ControleFormulario.frmPessoaJuridicaCadastro = null;
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (acaoSelecionada == AcaoTelaCRUD.Inserir)
            {
                PessoaJuridica pessoa = new PessoaJuridica();
                pessoa.Bairro = txtBairro.Text;
                pessoa.Cep = txtCep.Text;
                pessoa.Cidade = txtCidade.Text;
                pessoa.Cnpj = txtCnpj.Text;
                pessoa.Email = txtEmail.Text;
                pessoa.NomeFantasia = txtNomeFantasia.Text;
                pessoa.RazaoSocial = txtRazaoSocial.Text;
                pessoa.Numero = Convert.ToInt32(txtNumero.Text);
                pessoa.InscricaoEstadual = txtInscricao.Text;
                pessoa.Rua = txtRua.Text;
                pessoa.Telefone = txtTelefone.Text;
                pessoa.Logo = ptblogo.ImageLocation;

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

                if ((ckbCliente.Checked == false) && (ckbFilial.Checked == false) && (ckbFornecedor.Checked == false))
                {
                    MessageBox.Show("É necessário selecionar uma classificação para a pessoa.");
                    grbClassificacao.Focus();
                    return;
                }


                PessoaJuridicaNegocio pessoaJuridicaNegocio = new PessoaJuridicaNegocio();

                string retorno = pessoaJuridicaNegocio.Inserir(pessoa);

                try
                {
                    int verifica = Convert.ToInt32(retorno);
                    MessageBox.Show("Pessoa jurídica inserida com sucesso. Código da pessoa: " + retorno);
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
                PessoaJuridica pessoa = new PessoaJuridica();
                pessoa.IDPessoa = Convert.ToInt32(txtCodigo.Text);
                pessoa.Bairro = txtBairro.Text;
                pessoa.Cep = txtCep.Text;
                pessoa.Cidade = txtCidade.Text;
                pessoa.Cnpj = txtCnpj.Text;
                pessoa.Email = txtEmail.Text;
                pessoa.NomeFantasia = txtNomeFantasia.Text;
                pessoa.RazaoSocial = txtRazaoSocial.Text;
                pessoa.Numero = Convert.ToInt32(txtNumero.Text);
                pessoa.InscricaoEstadual = txtInscricao.Text;
                pessoa.Rua = txtRua.Text;
                pessoa.Telefone = txtTelefone.Text;
                if (ptblogo.ImageLocation == null)
                {
                    pessoa.Logo = pessoaRecebidaPublic.Logo;
                }
                else
                {
                    pessoa.Logo = ptblogo.ImageLocation;
                }
                PessoaJuridicaNegocio pessoaJuridicaNegocio = new PessoaJuridicaNegocio();

                string retorno = pessoaJuridicaNegocio.Alterar(pessoa);

                try
                {
                    int verifica = Convert.ToInt32(retorno);
                    MessageBox.Show("Pessoa jurídica alterada com sucesso. Código da pessoa: " + retorno);
                    DialogResult = DialogResult.Yes;
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível alterar a pessoa. Detalhes: " + retorno);
                    DialogResult = DialogResult.No;
                }
            }

            if (acaoSelecionada == AcaoTelaCRUD.Consultar)
            {
            }
        }

        private void ptblogo_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ptblogo.Load(openFileDialog1.FileName);
                }
                }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao inserir a logo. Detalhes: {0}" + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            //ControleFormulario.abreFrmCadastrarUsu(null, pessoaRecebidaPublic);
        }

        private void FrmCadastrarPessoaJuridica_Load(object sender, EventArgs e)
        {

        }
    }
}
