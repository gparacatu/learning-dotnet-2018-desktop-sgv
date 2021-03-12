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
    public class PessoaFilialNegocio
    {
        AcessoBancoSqlServer conexao = new AcessoBancoSqlServer();

        public string Inserir(int IDFilial)
        {
            try
            {
                conexao.LimparParametros();

                conexao.AdicionarParametros("@IDPessoaFilial", IDFilial);

                string IDFilialInserida = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspFilialInserir").ToString();

                return IDFilialInserida;

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Alterar(int IDFilial, int IDStatus)
        {
            try
            {
                conexao.LimparParametros();

                conexao.AdicionarParametros("@IDPessoaFilial", IDFilial);
                conexao.AdicionarParametros("@IDSTATUS", IDStatus);

                string IDFilialInserida = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspFilialAlterar").ToString();

                return IDFilialInserida;

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }


        public PessoaFilialColecao ConsultarIdNome(int IDPessoaCliente, string Nome)
        {
            try
            {
                PessoaFilialColecao filialConsultaColecao = new PessoaFilialColecao();

                conexao.LimparParametros();

                conexao.AdicionarParametros("@IDPessoaFilial", IDPessoaCliente);
                conexao.AdicionarParametros("@Nome", Nome);

                DataTable dataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "uspFilialConsultaPorNomeCodigo");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    PessoaFilial filialConsulta = new PessoaFilial();

                    filialConsulta.IDFilial = Convert.ToInt32(dataRow["IDFilial"]);
                    filialConsulta.Nome = Convert.ToString(dataRow["Nome"]);
                    filialConsulta.Tipo = Convert.ToString(dataRow["Tipo"]);
                    filialConsulta.CPFCNPJ = Convert.ToString(dataRow["CPFCNPJ"]);
                    filialConsulta.DataCadastro = Convert.ToDateTime(dataRow["DataCadastro"]);
                    filialConsulta.Rua = Convert.ToString(dataRow["Rua"]);
                    filialConsulta.Numero = Convert.ToInt32(dataRow["Numero"]);
                    filialConsulta.Bairro = Convert.ToString(dataRow["Bairro"]);
                    filialConsulta.Cidade = Convert.ToString(dataRow["Cidade"]);
                    filialConsulta.Telefone = Convert.ToString(dataRow["Telefone"]);
                    filialConsulta.Email = Convert.ToString(dataRow["Email"]);
                    filialConsulta.Status = Convert.ToString(dataRow["Status"]);

                    filialConsultaColecao.Add(filialConsulta);
                }

                return filialConsultaColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao consultar filial. Detalhes: " + ex.Message);
            }
        }

        public PessoaFilial ConsultarIdNomeLogon(int IDPessoaCliente, string Nome)
        {
            try
            {
                
                conexao.LimparParametros();
                PessoaFilial filial = new PessoaFilial();
                conexao.AdicionarParametros("@IDPessoaFilial", IDPessoaCliente);
                conexao.AdicionarParametros("@Nome", Nome);

                DataTable dataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "uspFilialConsultaPorNomeCodigo");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    filial.IDFilial = Convert.ToInt32(dataRow["IDFilial"]);
                    filial.Nome = Convert.ToString(dataRow["Nome"]);
                    filial.Tipo = Convert.ToString(dataRow["Tipo"]);
                    filial.CPFCNPJ = Convert.ToString(dataRow["CPFCNPJ"]);
                    filial.DataCadastro = Convert.ToDateTime(dataRow["DataCadastro"]);
                    filial.Rua = Convert.ToString(dataRow["Rua"]);
                    filial.Numero = Convert.ToInt32(dataRow["Numero"]);
                    filial.Bairro = Convert.ToString(dataRow["Bairro"]);
                    filial.Cidade = Convert.ToString(dataRow["Cidade"]);
                    filial.Telefone = Convert.ToString(dataRow["Telefone"]);
                    filial.Email = Convert.ToString(dataRow["Email"]);
                    filial.Status = Convert.ToString(dataRow["Status"]);

                }

                return filial;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao consultar filial. Detalhes: " + ex.Message);
            }
        }
    }
}
