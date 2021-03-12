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
    public class ProdutoPrecoNegocio
    {
        AcessoBancoSqlServer conexao = new AcessoBancoSqlServer();

        public string Inserir(ProdutoPreco produtoPreco)
        {
            try
            {
                conexao.LimparParametros();

                conexao.AdicionarParametros("@IDPRODUTO", produtoPreco.Produto.IDProduto);
                conexao.AdicionarParametros("@PRECO", produtoPreco.Preco);
                conexao.AdicionarParametros("@IDTIPO", produtoPreco.PrecoTipo.IDTipo);

                string IDProduto = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspProdutoPrecoInserir").ToString();

                return IDProduto;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public ProdutoPrecoColecao ConsultarPorIdNome()
        {
            try
            {
                ProdutoPrecoColecao produtoPrecoColecao = new ProdutoPrecoColecao();

                conexao.LimparParametros();

                DataTable dataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "uspProdutoPrecoConsultarPorIdNome");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    ProdutoPreco preco = new ProdutoPreco();

                    preco.Produto = new Produto();
                    preco.Produto.IDProduto = Convert.ToInt32(dataRow["IDProduto"]);
                    preco.Produto.Nome = Convert.ToString(dataRow["Nome"]);
                    preco.Preco = Convert.ToDecimal(dataRow["Valor"]);
                    preco.PrecoTipo = new ProdutoPrecoTipo();
                    preco.PrecoTipo.IDTipo = Convert.ToInt32(dataRow["IDTipo"]);
                    preco.PrecoTipo.Descricao = Convert.ToString(dataRow["TipoPreco"]);

                    produtoPrecoColecao.Add(preco);

                }

                return produtoPrecoColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao consultar preço do produto. Detalhes: " + ex.Message);
            }
        }
    }
}
