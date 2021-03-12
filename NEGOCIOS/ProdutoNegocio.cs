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
    public class ProdutoNegocio
    {
        AcessoBancoSqlServer conexao = new AcessoBancoSqlServer();

        public string Inserir(Produto produto)
        {
            try
            {
                conexao.LimparParametros();

                conexao.AdicionarParametros("@Nome", produto.Nome);
                conexao.AdicionarParametros("@IDCategoria", produto.Categoria);
                conexao.AdicionarParametros("@IDStatus", produto.IDStatus);
                conexao.AdicionarParametros("@PrecoCusto", produto.PrecoCusto);
                conexao.AdicionarParametros("@PrecoVenda", produto.PrecoVenda);
                conexao.AdicionarParametros("@Foto", produto.Foto);
                conexao.AdicionarParametros("@IDFilial", produto.IDFilial);


                string IDProduto = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspProdutoInserir").ToString();

                return IDProduto;

                
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Alterar(Produto produto)
        {
            try
            {
                conexao.LimparParametros();

                conexao.AdicionarParametros("IDProduto", produto.IDProduto);
                conexao.AdicionarParametros("@IDCategoria", produto.Categoria);
                conexao.AdicionarParametros("@IDStatus", produto.IDStatus);
                conexao.AdicionarParametros("@PrecoCusto", produto.PrecoCusto);
                conexao.AdicionarParametros("@PrecoVenda", produto.PrecoVenda);
                conexao.AdicionarParametros("@Foto", produto.Foto);
                conexao.AdicionarParametros("@IDFilial", produto.IDFilial);


                string IDProduto = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspProdutoAlterar").ToString();

                return IDProduto;


            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string AlterarCusto(int idProduto, decimal valorCusto)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@IDPRODUTO", idProduto);
                conexao.AdicionarParametros("@VALORCUSTO", valorCusto);

                string retorno = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspProdutoAtualizaCusto").ToString();

                return retorno;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public ProdutoColecao ConsultarPorIdNomeCategoria(int IDProduto, string NomeCategoria, int IDFilial)
        {
            try
            {
                ProdutoColecao produtoColecao = new ProdutoColecao();

                conexao.LimparParametros();

                conexao.AdicionarParametros("@IDProduto", IDProduto);
                conexao.AdicionarParametros("@NomeCategoria", NomeCategoria);
                conexao.AdicionarParametros("@IDFilial", IDFilial);

                DataTable dataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "uspProdutoConsultarPorIdNomeFilial");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Produto produto = new Produto();
                    produto.IDProduto = Convert.ToInt32(dataRow["IDProduto"]);
                    produto.Nome = Convert.ToString(dataRow["Nome"]);
                    produto.Categoria = Convert.ToInt32(dataRow["IDCategoria"]);
                    produto.CategoriaDescricao = Convert.ToString(dataRow["Categoria"]);
                    produto.PrecoVenda = Convert.ToDecimal(dataRow["PrecoVenda"]);
                    produto.PrecoCusto = Convert.ToDecimal(dataRow["PrecoCusto"]);                    
                    produto.Estoque = Convert.ToInt32(dataRow["Quantidade"]);                                        
                    produto.Foto = Convert.ToString(dataRow["Foto"]);
                    produto.IDStatus = Convert.ToInt32(dataRow["IDStatus"]);
                    produto.StatusDescricao = Convert.ToString(dataRow["Status"]);
                    produto.IDFilial = Convert.ToInt32(dataRow["Filial"]);

                    produtoColecao.Add(produto);
                }

                return produtoColecao;

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao consultar produto. Detalhes: "+ex.Message);
            }
        }

        public string Excluir(Produto produto)
        {
            try
            {
                conexao.LimparParametros();

                conexao.AdicionarParametros("@CODIGO", produto.IDProduto);

                string retorno = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspProdutoExcluir").ToString();

                return retorno;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }


        }
    }
}
