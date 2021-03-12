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
    public class ProdutoCategoriaNegocio
    {
        AcessoBancoSqlServer conexao = new AcessoBancoSqlServer();

        public string Inserir(ProdutoCategoria produtoCategoria)
        {
            try
            {
                conexao.LimparParametros();

                conexao.AdicionarParametros("@DESCRICAO", produtoCategoria.Descricao);

                string IDCategoria = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspProdutoCategoriaInserir").ToString();

                return IDCategoria;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Alterar(ProdutoCategoria produtoCategoria)
        {
            try
            {
                conexao.LimparParametros();

                conexao.AdicionarParametros("@CODIGO", produtoCategoria.IDCategoria);
                conexao.AdicionarParametros("@DESCRICAO", produtoCategoria.Descricao);

                string retorno = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspProdutoCategoriaAlterar").ToString();

                return retorno;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
            
        }

        public string Excluir(ProdutoCategoria produtoCategoria)
        {
            try
            {
                conexao.LimparParametros();

                conexao.AdicionarParametros("@CODIGO", produtoCategoria.IDCategoria);

                string retorno = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspProdutoCategoriaExcluir").ToString();

                return retorno;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
            

        }

        public ProdutoCategoriaColecao ConsultarPorIdNomeCategoria(string Nome)
        {
            try
            {
                
                ProdutoCategoriaColecao produtoCategoriaColecao = new ProdutoCategoriaColecao();

                conexao.LimparParametros();

                conexao.AdicionarParametros("@NOME", Nome);
                                
                DataTable dataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "uspProdutoCategoriaConsultar");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    ProdutoCategoria categoria = new ProdutoCategoria();

                    categoria.IDCategoria = Convert.ToInt32(dataRow["IDCategoria"]);
                    categoria.Descricao = Convert.ToString(dataRow["Descricao"]);

                    produtoCategoriaColecao.Add(categoria);

                }

                return produtoCategoriaColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao consultar categoria. Detalhes: "+ex.Message);
            }
        }
    }
}
