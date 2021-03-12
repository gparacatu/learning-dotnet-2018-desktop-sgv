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
    public class RelatorioPedidoNegocio
    {
        AcessoBancoSqlServer conexao = new AcessoBancoSqlServer();

        public DataTable Consultar(int IDCaixa)
        {
            try
            {
                RelatorioPedidosColecao relatorioPedido = new RelatorioPedidosColecao();
                conexao.LimparParametros();
                conexao.AdicionarParametros("@IDCAIXA", IDCaixa);

                DataTable dataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "uspCaixaFechamentoRelatorioPedidos");

                /*foreach (DataRow dataRow in dataTable.Rows)
                {
                    RelatorioPedidos pedido = new RelatorioPedidos();
                    pedido.DataHora = Convert.ToDateTime(dataRow["DataHora"]);
                    pedido.Destinatario = Convert.ToString(dataRow["Destinatario"]);
                    pedido.IDPedido = Convert.ToInt32(dataRow["IDPedido"]);
                    pedido.Emitente = Convert.ToString(dataRow["Emitente"]);
                    pedido.Pagamento = Convert.ToString(dataRow["Pagamento"]);
                    pedido.PorcentagemDesconto = Convert.ToDecimal(dataRow["PorcentagemDesconto"]);
                    pedido.ValorTotalComDesconto = Convert.ToDecimal(dataRow["ValorTotalComDesconto"]);
                    pedido.ValorTotal = Convert.ToDecimal(dataRow["ValorTotal"]);

                    relatorioPedido.Add(pedido);
                }*/

                return dataTable;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
