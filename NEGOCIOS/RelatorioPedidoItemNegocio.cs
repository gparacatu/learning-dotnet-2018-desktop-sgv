using DAO;
using System;
using System.Data;
using TRANSFERENCIA;

namespace NEGOCIOS
{
    public class RelatorioPedidoItemNegocio
    {
        AcessoBancoSqlServer conexao = new AcessoBancoSqlServer();

        public RelatorioPedidoItemColecao Consultar(int IDPedido)
        {
            try
            {
                RelatorioPedidoItemColecao relatorioPedidoItem = new RelatorioPedidoItemColecao();
                conexao.LimparParametros();
                conexao.AdicionarParametros("@IDPEDIDO", IDPedido);

                DataTable dataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "uspCaixaFechamentoRelatorioItensPedidos");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    RelatorioPedidoItem pedidoItem = new RelatorioPedidoItem();                   
                    pedidoItem.Quantidade = Convert.ToInt32(dataRow["Quantidade"]);
                    pedidoItem.Produto = Convert.ToString(dataRow["Produto"]);
                    pedidoItem.PercentualDesconto = Convert.ToDecimal(dataRow["PercentualDesconto"]);
                    pedidoItem.ValorTotalComDesconto = Convert.ToDecimal(dataRow["ValorTotalComDesconto"]);
                    pedidoItem.ValorTotal = Convert.ToDecimal(dataRow["ValorTotal"]);
                    pedidoItem.ValorDesconto = Convert.ToDecimal(dataRow["ValorDesconto"]);
                    pedidoItem.ValorUnitario = Convert.ToDecimal(dataRow["ValorUnitario"]);

                    relatorioPedidoItem.Add(pedidoItem);
                }

                return relatorioPedidoItem;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
