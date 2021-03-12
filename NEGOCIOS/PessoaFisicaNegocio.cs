using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAO;
using TRANSFERENCIA;
using System.Data;

namespace NEGOCIOS
{
    public class PessoaFisicaNegocio
    {
        AcessoBancoSqlServer conexao = new AcessoBancoSqlServer();

        public string Inserir(PessoaFisica pessoa)
        {
            try
            {
                conexao.LimparParametros();

                conexao.AdicionarParametros("@Nome", pessoa.Nome);
                conexao.AdicionarParametros("@Cpf", pessoa.Cpf);
                conexao.AdicionarParametros("@Rg", pessoa.Rg);
                conexao.AdicionarParametros("@Rua", pessoa.Rua);
                conexao.AdicionarParametros("@Numero", pessoa.Numero);
                conexao.AdicionarParametros("@Bairro", pessoa.Bairro);
                conexao.AdicionarParametros("@Cidade", pessoa.Cidade);
                conexao.AdicionarParametros("@Telefone", pessoa.Telefone);
                conexao.AdicionarParametros("@Email", pessoa.Email);
                conexao.AdicionarParametros("@DataNascimento", pessoa.DataNascimento);
                conexao.AdicionarParametros("@CEP", pessoa.Cep);
                conexao.AdicionarParametros("@TIPOCLIENTE", pessoa.TipoCliente);
                conexao.AdicionarParametros("@TIPOFORNECEDOR", pessoa.TipoFornecedor);
                conexao.AdicionarParametros("@TIPOFILIAL", pessoa.TipoFilial);

                string IDPessoa = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspPessoaFisicaInserir").ToString();

                return IDPessoa;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Alterar(PessoaFisica pessoa)
        {
            try
            {
                conexao.LimparParametros();

                conexao.AdicionarParametros("@IDPessoa", pessoa.IDPessoa);
                conexao.AdicionarParametros("@Nome", pessoa.Nome);
                conexao.AdicionarParametros("@Cpf", pessoa.Cpf);
                conexao.AdicionarParametros("@Rg", pessoa.Rg);
                conexao.AdicionarParametros("@Rua", pessoa.Rua);
                conexao.AdicionarParametros("@Numero", pessoa.Numero);
                conexao.AdicionarParametros("@Bairro", pessoa.Bairro);
                conexao.AdicionarParametros("@Cidade", pessoa.Cidade);
                conexao.AdicionarParametros("@Telefone", pessoa.Telefone);
                conexao.AdicionarParametros("@Email", pessoa.Email);
                conexao.AdicionarParametros("@DataNascimento", pessoa.DataNascimento);
                conexao.AdicionarParametros("@CEP", pessoa.Cep);

                string IDPessoa = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspPessoaFisicaAlterar").ToString();

                return IDPessoa;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public PessoaFisicaColecao ConsultarPorNomeCpf(string nomecpf)
        {
            try
            {
                PessoaFisicaColecao pessoaFisicaColecao = new PessoaFisicaColecao();

                conexao.LimparParametros();

                conexao.AdicionarParametros("@NOMECPF", nomecpf);
                

                DataTable dataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "uspPessoaFisicaConsultarPorCpfNome");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    PessoaFisica pessoaFisica = new PessoaFisica();

                    //pessoaFisica.Pessoa = new Pessoa();
                    pessoaFisica.IDPessoa = Convert.ToInt32(dataRow["IDPessoaFisica"]);
                    pessoaFisica.Nome = Convert.ToString(dataRow["Nome"]);
                    pessoaFisica.Cpf = Convert.ToString(dataRow["Cpf"]);
                    pessoaFisica.Rg = Convert.ToString(dataRow["Rg"]);
                    pessoaFisica.Rua = Convert.ToString(dataRow["Rua"]);
                    pessoaFisica.Numero = Convert.ToInt32(dataRow["Numero"]);
                    pessoaFisica.Bairro = Convert.ToString(dataRow["Bairro"]);
                    pessoaFisica.Cidade = Convert.ToString(dataRow["Cidade"]);
                    pessoaFisica.Telefone = Convert.ToString(dataRow["Telefone"]);
                    pessoaFisica.Email = Convert.ToString(dataRow["Email"]);
                    pessoaFisica.Cep = Convert.ToString(dataRow["Cep"]);
                    pessoaFisica.DataNascimento = Convert.ToDateTime(dataRow["DataNascimento"]);
                    

                    pessoaFisicaColecao.Add(pessoaFisica);

                }

                return pessoaFisicaColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao consultar pessoa física. Detalhes: "+ex.Message);
            }
        }
    }
}
