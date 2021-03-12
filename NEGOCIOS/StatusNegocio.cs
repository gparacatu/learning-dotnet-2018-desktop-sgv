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
    public class StatusNegocio
    {
        AcessoBancoSqlServer conexao = new AcessoBancoSqlServer();

        public StatusColecao Consultar()
        {
            try
            {
                StatusColecao statusColecao = new StatusColecao();
                conexao.LimparParametros();

                DataTable dataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "uspStatusConsultar");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Status status = new Status();

                    status.IDStatus = Convert.ToInt32(dataRow["IDStatus"]);
                    status.Descricao = Convert.ToString(dataRow["Descricao"]);

                    statusColecao.Add(status);
                }

                return statusColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao consultar status. Detalhes: "+ex.Message);
            }
        }
    }
}
