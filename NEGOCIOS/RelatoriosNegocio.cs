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
    public class RelatoriosNegocio
    {
        AcessoBancoSqlServer conexao = new AcessoBancoSqlServer();

        public DataTable RelatorioComprasData(DateTime DataInicial, DateTime DataFinal)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@DATAINICIAL", DataInicial);
                conexao.AdicionarParametros("@DATAFINAL", DataFinal);

                return conexao.ExecutarConsulta(CommandType.StoredProcedure, "uspRelatorioComprasData");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public DataTable RelatorioPessoasNome(string Nome)
        {
            try
            {

                conexao.LimparParametros();
                conexao.AdicionarParametros("@NOME", Nome);
                return conexao.ExecutarConsulta(CommandType.StoredProcedure, "uspRelatorioPessoasNome");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
