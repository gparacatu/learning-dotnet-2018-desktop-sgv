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
    public class FormaPagamentoNegocio
    {
        AcessoBancoSqlServer conexao = new AcessoBancoSqlServer();

        public string Inserir(FormaPagamento pagamento)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@DESCRICAO", pagamento.Descricao);
                conexao.AdicionarParametros("@IDFILIAL", pagamento.IDFilial);

                string retorno = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspFormaPagamentoInserir").ToString();

                return retorno;
            }
            catch (Exception ex)
            {

                return ex.Message;

            }
            
        }

        public string AlterarStatus(string Descricao, int IDFilial, int Status)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@DESCRICAO", Descricao);
                conexao.AdicionarParametros("@IDFILIAL", IDFilial);
                conexao.AdicionarParametros("@STATUS", Status);

                string retorno = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspFormaPagamentoAlterarStatus").ToString();

                return retorno;
            }
            catch (Exception ex)
            {

                return ex.Message;

            }

        }

        public FormaPagamentoColecao ConsultarPorFilial(int IDFilial)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@IDFILIAL", IDFilial);

                DataTable dataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "uspFormaPagamentoConsultarPorFilial");

                FormaPagamentoColecao pagamentoColecao = new FormaPagamentoColecao();

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    FormaPagamento pagamento = new FormaPagamento();
                    pagamento.Descricao = Convert.ToString(dataRow["Descricao"]);
                    pagamento.IDFilial = Convert.ToInt32(dataRow["IDFilial"]);
                    pagamento.IDPagamento = Convert.ToInt32(dataRow["IDPagamento"]);
                    pagamento.IDStatus = Convert.ToInt32(dataRow["IDStatus"]);

                    pagamentoColecao.Add(pagamento);
                }

                return pagamentoColecao;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
