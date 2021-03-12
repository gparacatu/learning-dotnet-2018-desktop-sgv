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
    public class SituacaoNegocio
    {
        AcessoBancoSqlServer conexao = new AcessoBancoSqlServer();

        public SituacaoColecao Consultar()
        {
            try
            {
                SituacaoColecao situacaoColecao = new SituacaoColecao();

                conexao.LimparParametros();

                DataTable dataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "uspSituacaoConsultar");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Situacao situacao = new Situacao();
                    situacao.IDSituacao = Convert.ToInt32(dataRow["IDSituacao"]);
                    situacao.Descricao = Convert.ToString(dataRow["Descricao"]);
                    situacao.Operacao = new Operacao();
                    situacao.Operacao.IDOperacao = Convert.ToInt32(dataRow["IDOperacao"]);
                    situacao.Operacao.Descricao = Convert.ToString(dataRow["Descricao"]);

                    situacaoColecao.Add(situacao);
                }

                return situacaoColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao consultar situação. Detalhes: "+ex.Message);
            }
        }
    }
}
