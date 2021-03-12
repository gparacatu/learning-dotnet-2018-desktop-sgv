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
    public class EstoqueNegocio
    {
        AcessoBancoSqlServer conexao = new AcessoBancoSqlServer();

        public string Inserir(Estoque estoque)
        {
            try
            {
                conexao.LimparParametros();

                conexao.AdicionarParametros("@IDProduto", estoque.IDProduto);
                conexao.AdicionarParametros("@IDPessoaFilial", estoque.IDFilial);
                conexao.AdicionarParametros("@Quantidade", estoque.Quantidade);

                string IdProduto = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspEstoqueManter").ToString();
                return IdProduto;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public EstoqueColecao ConsultarPorIdprodutoNomeprodutoIdfilial(int IDPessoaFilial, int IDProduto, string Nome)
        {
            try
            {
                conexao.LimparParametros();
                EstoqueColecao estoqueColecao = new EstoqueColecao();

                conexao.AdicionarParametros("@IDPessoaFilial", IDPessoaFilial);
                conexao.AdicionarParametros("@IDProduto", IDProduto);
                conexao.AdicionarParametros("@Nome", Nome);

                DataTable dataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "uspEstoqueConsultarPorNomeCodigoProduto");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Estoque estoque = new Estoque();                    
                    estoque.IDProduto = Convert.ToInt32(dataRow["IDProduto"]);                    
                    estoque.IDFilial = Convert.ToInt32(dataRow["IDFilial"]);
                    estoque.Quantidade = Convert.ToInt32(dataRow["Quantidade"]);

                    estoqueColecao.Add(estoque);
                }

                return estoqueColecao;

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao consultar estoque. Detalhes: "+ex.Message);
            }
        }

        public EstoqueDisponivel ConsultarEstoqueDisponivel(int IDProduto, int IDFilial)
        {
            try
            {
                EstoqueDisponivel estoqueDisponivel = new EstoqueDisponivel();

                conexao.LimparParametros();
                conexao.AdicionarParametros("@IDProduto", IDProduto);
                conexao.AdicionarParametros("@IDFilial", IDFilial);

                DataTable dataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "uspEstoqueDisponivel");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    estoqueDisponivel.Filial = Convert.ToString(dataRow["Filial"]);
                    estoqueDisponivel.FilialTipo = Convert.ToString(dataRow["TipoFilial"]);
                    estoqueDisponivel.NomeProduto = Convert.ToString(dataRow["Produto"]);
                    estoqueDisponivel.QuantidadeDisponivel = Convert.ToInt32(dataRow["QuantidadeDisponivel"]);
                    estoqueDisponivel.QuantidadeEstoque = Convert.ToInt32(dataRow["QuantidadeEstoque"]);
                    estoqueDisponivel.QuantidadeReservada = Convert.ToInt32(dataRow["QuantidadeReservada"]);
                }

                return estoqueDisponivel;
            }
            catch (Exception)
            {
                throw new Exception("Estoque disponível está apresentando divergência nos dados. Provavelmente a quantidade está negativa.");
            }
            
        }
    }
}
