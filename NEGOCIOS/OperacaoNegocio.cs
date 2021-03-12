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
    public class OperacaoNegocio
    {
        AcessoBancoSqlServer conexao = new AcessoBancoSqlServer();

        public OperacaoColecao Consultar()
        {
            try
            {
                conexao.LimparParametros();
                OperacaoColecao operacaoColecao = new OperacaoColecao();

                DataTable dataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "uspOperacaoConsultar");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Operacao operacao = new Operacao();

                    operacao.IDOperacao = Convert.ToInt32(dataRow["IDOperacao"]);
                    operacao.Descricao = Convert.ToString(dataRow["Descricao"]);

                    operacaoColecao.Add(operacao);
                }

                return operacaoColecao;

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao consultar operação. Detalhes: "+ex.Message);
            }
        }
    }
}
