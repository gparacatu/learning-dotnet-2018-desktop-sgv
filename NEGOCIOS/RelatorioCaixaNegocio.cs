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
    public class RelatorioCaixaNegocio
    {
        AcessoBancoSqlServer conexao = new AcessoBancoSqlServer();

        public DataTable ConsultarFechamentoCaixa(int IDCaixa)
        {
            try
            {
                RelatorioCaixa relatorioCaixa = new RelatorioCaixa();
                conexao.LimparParametros();
                conexao.AdicionarParametros("@IDCAIXA", IDCaixa);

                DataTable dataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "uspCaixaFechamentoRelatorio");
                
                return dataTable;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public DataTable ConsultarRelatorioCaixaPorDataAbertura(DateTime DataInicial, DateTime DataFinal)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@DATAINICIAL", DataInicial);
                conexao.AdicionarParametros("@DATAFINAL", DataFinal);

                return conexao.ExecutarConsulta(CommandType.StoredProcedure, "uspCaixaRelatorioPorDataAbertura");               

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
