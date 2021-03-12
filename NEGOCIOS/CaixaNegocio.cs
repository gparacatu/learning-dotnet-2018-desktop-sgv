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
    public class CaixaNegocio
    {
        AcessoBancoSqlServer conexao = new AcessoBancoSqlServer();

        public string caixaAbrir(Caixa caixa)
        {
            try
            {            

                conexao.LimparParametros();
                conexao.AdicionarParametros("@IDUSUARIO", caixa.IDUsuario);
                conexao.AdicionarParametros("@VALORINICIAL", caixa.valorInicial);

                string retorno = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspCaixaAbrir").ToString();

                return retorno;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            

        }

        public string caixaFechar(Caixa caixa,int IDUsuario)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@IDUSUARIO", IDUsuario);
                conexao.AdicionarParametros("@IDCAIXA", caixa.IDCaixa);
                conexao.AdicionarParametros("@VALORSANGRIA", caixa.valorSangria);
                conexao.AdicionarParametros("@VALORFECHAMENTO", caixa.valorFechamento);

                string retorno = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspCaixaFechar").ToString();

                return retorno;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public string caixaRetirar( CaixaRetirada caixaRetirada,int IDUsuario)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@IDUSUARIO", IDUsuario);
                conexao.AdicionarParametros("@IDCAIXA", caixaRetirada.IDCaixa);
                conexao.AdicionarParametros("@VALORRETIRADA", caixaRetirada.valorRetirada);
                conexao.AdicionarParametros("@DESCRICAORETIRADA", caixaRetirada.Descricao);

                string retorno = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspCaixaRetirar").ToString();

                return retorno;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public string caixaSuprimento(CaixaSuprimento caixaSuprimento, int IDUsuario)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@IDUSUARIO", IDUsuario);
                conexao.AdicionarParametros("@IDCAIXA", caixaSuprimento.IDCaixa);
                conexao.AdicionarParametros("@VALORSUPRIMENTO", caixaSuprimento.valorSuprimento);
                conexao.AdicionarParametros("@DESCRICAOSUPRIMENTO", caixaSuprimento.Descricao);

                string retorno = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspCaixaSuprimento").ToString();

                return retorno;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Caixa caixaConsultarPorUsuarioLogado(int IDUsuario)
        {
            try
            {
                Caixa caixaAtual = new Caixa();

                conexao.LimparParametros();
                conexao.AdicionarParametros("@IDUSUARIO", IDUsuario);

                DataTable dataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "uspCaixaAbertoConsultarPorUsuario");


                foreach (DataRow dataRow in dataTable.Rows)
                {

                    caixaAtual.IDCaixa = Convert.ToInt32(dataRow["IDCaixa"]);
                    caixaAtual.IDUsuario = Convert.ToInt32(dataRow["IDUsuario"]);
                    caixaAtual.Status = Convert.ToString(dataRow["Status"]);
                    caixaAtual.valorFechamento = Convert.ToDecimal(dataRow["valorFechamento"]);
                    caixaAtual.valorInicial = Convert.ToDecimal(dataRow["valorInicial"]);
                    caixaAtual.valorSangria = Convert.ToDecimal(dataRow["valorSangria"]);
                    caixaAtual.valorTotal = Convert.ToDecimal(dataRow["valorTotal"]);
                    caixaAtual.dataAbertura = Convert.ToDateTime(dataRow["dataAbertura"]);
                    caixaAtual.dataFechamento = Convert.ToDateTime(dataRow["dataFechamento"]);

                }
                    return caixaAtual;              

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
