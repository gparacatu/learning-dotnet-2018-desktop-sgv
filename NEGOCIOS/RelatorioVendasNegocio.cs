using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRANSFERENCIA;
using DAO;
using System.Data;
namespace NEGOCIOS
{
    public class RelatorioVendasNegocio
    {
        AcessoBancoSqlServer conexao = new AcessoBancoSqlServer();

        public DataTable ConsultarPorData(DateTime inicial, DateTime final)
        {
            try
            {                
                conexao.LimparParametros();
                conexao.AdicionarParametros("@DATAINICIAL", inicial);
                conexao.AdicionarParametros("@DATAFINAL", final);

                DataTable dataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "uspRelatorioVendasData");
                            

                return dataTable;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
