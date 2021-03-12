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
    public class PedidoCompraNegocio
    {
        AcessoBancoSqlServer conexao = new AcessoBancoSqlServer();

        public string Inserir(PedidoCompra pedido)
        {
            try
            {
                conexao.LimparParametros();

                conexao.AdicionarParametros("@IDOperacao", pedido.IDOperacao);
                conexao.AdicionarParametros("@IDSituacao", pedido.IDSituacao);
                conexao.AdicionarParametros("@IDPessoaEmitente", pedido.IDPessoaEmitente);
                conexao.AdicionarParametros("@IDPessoaDestinatario", pedido.IDPessoaDestinatario);
                conexao.AdicionarParametros("@ValorTotalComDesconto", pedido.ValorTotalComDesconto);
                conexao.AdicionarParametros("@PorcentagemDesconto", pedido.PorcentagemDesconto);
                conexao.AdicionarParametros("@ValorTotal", pedido.ValorTotal);
                conexao.AdicionarParametros("@IDPAGAMENTO", pedido.IDPagamento);

                string IDPedidoRetorno = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspPedidoCompraInserir").ToString();

                return IDPedidoRetorno;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public PedidoCompraColecao ConsultarPorIdOperacaoSituacaoEmitenteDestinatario(int IDPedido, string NomeOperacao, string NomeSituacao, string NomePessoaEmitente, string NomePessoaDestinatario)
        {
            try
            {
                PedidoCompraColecao pedidoColecao = new PedidoCompraColecao();

                conexao.LimparParametros();

                conexao.AdicionarParametros("@IDPedido", IDPedido);
                conexao.AdicionarParametros("@NomeOperacao", NomeOperacao);
                conexao.AdicionarParametros("@NomeSituacao", NomeSituacao);
                conexao.AdicionarParametros("@NomePessoaEmitente", NomePessoaEmitente);
                conexao.AdicionarParametros("@NomePessoaDestinatario", NomePessoaDestinatario);

                DataTable dataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "uspPedidoCompraConsultarPorIdOperacaoSituacaoDataEmitenteDestinatario");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    PedidoCompra pedido = new PedidoCompra();

                    pedido.IDPedido = Convert.ToInt32(dataRow["IDPedido"]);

                    pedido.IDOperacao = Convert.ToInt32(dataRow["IDOperacao"]);

                    pedido.IDSituacao = Convert.ToInt32(dataRow["IDSituacao"]);

                    pedido.DataHora = Convert.ToDateTime(dataRow["DataHora"]);

                    pedido.IDPessoaEmitente = Convert.ToInt32(dataRow["IDPessoaEmitente"]);

                    pedido.IDPessoaDestinatario = Convert.ToInt32(dataRow["IDPessoaDestinatario"]);

                    pedidoColecao.Add(pedido);
                }

                return pedidoColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao consultar pedido. Detalhes: " + ex.Message);
            }
        }
    }
}
