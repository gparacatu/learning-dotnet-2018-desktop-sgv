using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using TRANSFERENCIA;
namespace NEGOCIOS
{
    public class PessoaJuridicaNegocio
    {
        AcessoBancoSqlServer conexao = new AcessoBancoSqlServer();

        public string Inserir(PessoaJuridica pessoa)
        {
            try
            {
                conexao.LimparParametros();

                conexao.AdicionarParametros("@NomeFantasia", pessoa.NomeFantasia);
                conexao.AdicionarParametros("@RazaoSocial", pessoa.RazaoSocial);
                conexao.AdicionarParametros("@Cnpj", pessoa.Cnpj);
                conexao.AdicionarParametros("@Rua", pessoa.Rua);
                conexao.AdicionarParametros("@Numero", pessoa.Numero);
                conexao.AdicionarParametros("@Bairro", pessoa.Bairro);
                conexao.AdicionarParametros("@Cidade", pessoa.Cidade);
                conexao.AdicionarParametros("@Telefone", pessoa.Telefone);
                conexao.AdicionarParametros("@Email", pessoa.Email);
                conexao.AdicionarParametros("@InscricaoEstadual", pessoa.InscricaoEstadual);
                conexao.AdicionarParametros("@Logo", pessoa.Logo);
                conexao.AdicionarParametros("@CEP", pessoa.Cep);
                conexao.AdicionarParametros("@TIPOCLIENTE", pessoa.TipoCliente);
                conexao.AdicionarParametros("@TIPOFORNECEDOR", pessoa.TipoFornecedor);
                conexao.AdicionarParametros("@TIPOFILIAL", pessoa.TipoFilial);
                

                string IDPessoaJurdica = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspPessoaJuridicaInserir").ToString();

                return IDPessoaJurdica;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public string Alterar(PessoaJuridica pessoa)
        {
            try
            {
                conexao.LimparParametros();

                conexao.AdicionarParametros("@IDPessoa", pessoa.IDPessoa);
                conexao.AdicionarParametros("@NomeFantasia", pessoa.NomeFantasia);
                conexao.AdicionarParametros("@RazaoSocial", pessoa.RazaoSocial);
                conexao.AdicionarParametros("@Cnpj", pessoa.Cnpj);
                conexao.AdicionarParametros("@Rua", pessoa.Rua);
                conexao.AdicionarParametros("@Numero", pessoa.Numero);
                conexao.AdicionarParametros("@Bairro", pessoa.Bairro);
                conexao.AdicionarParametros("@Cidade", pessoa.Cidade);
                conexao.AdicionarParametros("@Telefone", pessoa.Telefone);
                conexao.AdicionarParametros("@Email", pessoa.Email);
                conexao.AdicionarParametros("@InscricaoEstadual", pessoa.InscricaoEstadual);
                conexao.AdicionarParametros("@Logo", pessoa.Logo);
                conexao.AdicionarParametros("CEP", pessoa.Cep);


                string IDPessoaJurdica = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspPessoaJuridicaAlterar").ToString();

                return IDPessoaJurdica;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public PessoaJuridicaColecao ConsultarPorNomeFantasiaCnpj(string NomeCnpj)
        {
            try
            {
                PessoaJuridicaColecao pessoaJuridicaColecao = new PessoaJuridicaColecao();

                conexao.LimparParametros();

                conexao.AdicionarParametros("@NOMECNPJ", NomeCnpj);

                DataTable dataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "uspPessoaJuridicaConsultarPorCnpjNomeFantasia");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    PessoaJuridica pessoaJuridica = new PessoaJuridica();

                    //pessoaJuridica.Pessoa = new Pessoa();
                    pessoaJuridica.IDPessoa = Convert.ToInt32(dataRow["IDPessoaJuridica"]);
                    pessoaJuridica.NomeFantasia = Convert.ToString(dataRow["NomeFantasia"]);
                    pessoaJuridica.RazaoSocial = Convert.ToString(dataRow["RazaoSocial"]);
                    pessoaJuridica.Cnpj = Convert.ToString(dataRow["Cnpj"]);
                    pessoaJuridica.Rua = Convert.ToString(dataRow["Rua"]);
                    pessoaJuridica.Numero = Convert.ToInt32(dataRow["Numero"]);
                    pessoaJuridica.Bairro = Convert.ToString(dataRow["Bairro"]);
                    pessoaJuridica.Cidade = Convert.ToString(dataRow["Cidade"]);
                    pessoaJuridica.Telefone = Convert.ToString(dataRow["Telefone"]);
                    pessoaJuridica.Email = Convert.ToString(dataRow["Email"]);
                    pessoaJuridica.InscricaoEstadual = Convert.ToString(dataRow["InscricaoEstadual"]);
                    pessoaJuridica.Logo = Convert.ToString(dataRow["Logo"]);
                    pessoaJuridica.Cep = Convert.ToString(dataRow["Cep"]);
                    
                    pessoaJuridicaColecao.Add(pessoaJuridica);
                }
                return pessoaJuridicaColecao;

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao consultar Pessoa Jurídica. Detalhes: "+ex.Message);
            }
        }

        public DataTable ConsultarPorNomeFantasiaPorIDPessoa(int IDPessoa)
        {
            try
            {
                PessoaJuridica pessoaJuridica = new PessoaJuridica();

                conexao.LimparParametros();

                conexao.AdicionarParametros("@IDPESSOA", IDPessoa);

                DataTable dataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "uspPessoaJuridicaConsultarPorIDPessoa");

                return dataTable;

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao consultar Pessoa Jurídica. Detalhes: " + ex.Message);
            }
        }
    }
}
