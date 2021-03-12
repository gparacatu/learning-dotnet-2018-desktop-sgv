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
    public class uvwPessoaFisicaJuridicaNegocio
    {
        AcessoBancoSqlServer conexao = new AcessoBancoSqlServer();

        public string Inserir(int IDFornecedor)
        {
            try
            {
                conexao.LimparParametros();

                conexao.AdicionarParametros("@IDPessoaFornecedor", IDFornecedor);

                string IDFornecedorRetorno = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspFornecedorInserir").ToString();

                return IDFornecedorRetorno;

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Alterar(int IDFornecedor, int IDStatus)
        {
            try
            {
                conexao.LimparParametros();

                conexao.AdicionarParametros("@IDPessoaFornecedor", IDFornecedor);
                conexao.AdicionarParametros("@IDSTATUS", IDStatus);

                string IDFornecedorRetorno = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspFornecedorAlterar").ToString();

                return IDFornecedorRetorno;

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public uvwPessoaFisicaJuridicaColecao ConsultarIdNome(int IDPessoa, string Nome)
        {
            try
            {
                uvwPessoaFisicaJuridicaColecao fornecedorConsultaColecao = new uvwPessoaFisicaJuridicaColecao();

                conexao.LimparParametros();

                conexao.AdicionarParametros("@IDPessoaFornecedor", IDPessoa);
                conexao.AdicionarParametros("@Nome", Nome);

                DataTable dataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "uspFornecedorConsultarPorIdNome");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    uvwPessoaFisicaJuridica cliente = new uvwPessoaFisicaJuridica();

                    cliente.IDCliente = Convert.ToInt32(dataRow["IDFornecedor"]);
                    cliente.Nome = Convert.ToString(dataRow["Nome"]);
                    cliente.Tipo = Convert.ToString(dataRow["Tipo"]);
                    cliente.CPFCNPJ = Convert.ToString(dataRow["CPFCNPJ"]);
                    cliente.DataCadastro = Convert.ToDateTime(dataRow["DataCadastro"]);
                    cliente.Rua = Convert.ToString(dataRow["Rua"]);
                    cliente.Numero = Convert.ToInt32(dataRow["Numero"]);
                    cliente.Bairro = Convert.ToString(dataRow["Bairro"]);
                    cliente.Cidade = Convert.ToString(dataRow["Cidade"]);
                    cliente.Telefone = Convert.ToString(dataRow["Telefone"]);
                    cliente.Email = Convert.ToString(dataRow["Email"]);
                    cliente.Status = Convert.ToString(dataRow["Status"]);

                    fornecedorConsultaColecao.Add(cliente);
                }

                return fornecedorConsultaColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao consultar filial. Detalhes: " + ex.Message);
            }
        }

    }
}
