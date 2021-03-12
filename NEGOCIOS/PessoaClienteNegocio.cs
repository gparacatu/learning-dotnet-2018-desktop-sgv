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
    public class PessoaClienteNegocio
    {
        AcessoBancoSqlServer conexao = new AcessoBancoSqlServer();

        public string Inserir(int IDCliente)
        {
            try
            {
                conexao.LimparParametros();

                conexao.AdicionarParametros("@IDPessoaCliente", IDCliente);

                string IDClienteRetorno = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteInserir").ToString();

                return IDClienteRetorno;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Alterar(int IDCliente, int IDStatus)
        {
            try
            {
                conexao.LimparParametros();

                conexao.AdicionarParametros("@IDPessoaCliente", IDCliente);
                conexao.AdicionarParametros("@IDSTATUS", IDStatus);

                string IDClienteRetorno = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteAlterar").ToString();

                return IDClienteRetorno;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public uvwPessoaFisicaJuridicaColecao ConsultarIdNome(int IDPessoaCliente, string Nome)
        {
            try
            {
                uvwPessoaFisicaJuridicaColecao clientesConsultaColecao = new uvwPessoaFisicaJuridicaColecao();

                conexao.LimparParametros();

                conexao.AdicionarParametros("@IDPessoaCliente", IDPessoaCliente);
                conexao.AdicionarParametros("@Nome", Nome);

                DataTable dataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "uspClienteConsultarPorIdNome");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    uvwPessoaFisicaJuridica cliente = new uvwPessoaFisicaJuridica();

                    cliente.IDCliente = Convert.ToInt32(dataRow["IDCliente"]);
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

                    clientesConsultaColecao.Add(cliente);
                }

                return clientesConsultaColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao consultar cliente. Detalhes: " + ex.Message);
            }
        }

        public uvwPessoaFisicaJuridicaColecao ConsultarIdNomeVenda(int IDPessoaCliente, string Nome)
        {
            try
            {
                uvwPessoaFisicaJuridicaColecao clientesConsultaColecao = new uvwPessoaFisicaJuridicaColecao();

                conexao.LimparParametros();

                conexao.AdicionarParametros("@IDPessoaCliente", IDPessoaCliente);
                conexao.AdicionarParametros("@Nome", Nome);

                DataTable dataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "uspClienteConsultarPorIdNomeVenda");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    uvwPessoaFisicaJuridica cliente = new uvwPessoaFisicaJuridica();

                    cliente.IDCliente = Convert.ToInt32(dataRow["IDCliente"]);
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

                    clientesConsultaColecao.Add(cliente);
                }

                return clientesConsultaColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao consultar cliente. Detalhes: " + ex.Message);
            }
        }

    }
}
