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
    public class EstoqueMovimentacaoNegocio
    {
        AcessoBancoSqlServer conexao = new AcessoBancoSqlServer();

        public EstoqueMovimentacaoColecao ConsultarPorFilial(int filial)
        {
            try
            {
                EstoqueMovimentacaoColecao estoqueMovimentacaoColecao = new EstoqueMovimentacaoColecao();
                conexao.LimparParametros();

                conexao.AdicionarParametros("@Filial", filial);

                DataTable dataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "uspEstoqueMovimentacaoConsultarPorFilial");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    EstoqueMovimentacao estoque = new EstoqueMovimentacao();
                    estoque.IDFilial = Convert.ToInt32(dataRow["IDFilial"]);
                    estoque.IDProduto = Convert.ToInt32(dataRow["IDProduto"]);
                    estoque.Quantidade =Convert.ToInt32(dataRow["Quantidade"]);
                    estoque.EntradaSaida = Convert.ToString(dataRow["EntradaSaida"]);
                    estoque.DataHora = Convert.ToDateTime(dataRow["DataHora"]);

                    estoqueMovimentacaoColecao.Add(estoque);
                }

                return estoqueMovimentacaoColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao consultar movimentação do estoque. Detalhes: "+ex.Message);
            }
        }
    }
}
