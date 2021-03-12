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
    public class PedidoItemNegocio
    {
        AcessoBancoSqlServer conexao = new AcessoBancoSqlServer();

        public string Inserir(PedidoItem pedidoItem)
        {
            try
            {
                conexao.LimparParametros();

                conexao.AdicionarParametros("@IDPedido", pedidoItem.IDPedido);
                conexao.AdicionarParametros("@IDProduto", pedidoItem.IDProduto);
                conexao.AdicionarParametros("@Quantidade", pedidoItem.Quantidade);
                conexao.AdicionarParametros("@ValorUnitario", pedidoItem.ValorUnitario);
                conexao.AdicionarParametros("@PercentualDesconto", pedidoItem.PercentualDesconto);
                conexao.AdicionarParametros("@ValorDesconto", pedidoItem.ValorDesconto);
                conexao.AdicionarParametros("@ValorTotal", pedidoItem.ValorTotal);
                conexao.AdicionarParametros("@ValorTotalComDesconto", pedidoItem.ValorTotalComDesconto);

                string IDPedido = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspPedidoItemInserir").ToString();

                return IDPedido;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
