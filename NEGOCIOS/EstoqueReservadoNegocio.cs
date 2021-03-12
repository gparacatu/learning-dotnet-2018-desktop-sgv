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
    public class EstoqueReservadoNegocio
    {
        AcessoBancoSqlServer conexao = new AcessoBancoSqlServer();

        public string Inserir(EstoqueReservado estoque)
        {
            try
            {
                conexao.LimparParametros();

                conexao.AdicionarParametros("@IDProduto", estoque.IDProduto);
                conexao.AdicionarParametros("@IDPessoaFilial", estoque.IDFilial);
                conexao.AdicionarParametros("@Quantidade", estoque.Quantidade);

                string IDProdutoRetorno = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspEstoqueManterReservado").ToString();

                return IDProdutoRetorno;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public EstoqueReservadoColecao ConsultarPorFilial(int filial)
        {
            try
            {
                EstoqueReservadoColecao estoqueReservadoColecao = new EstoqueReservadoColecao();
                conexao.LimparParametros();

                conexao.AdicionarParametros("@Filial", filial);

                DataTable dataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "uspEstoqueReservadoConsulta");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    EstoqueReservado estoque = new EstoqueReservado();                    
                    estoque.IDProduto = Convert.ToInt32(dataRow["IDProduto"]);                    
                    estoque.IDFilial = Convert.ToInt32(dataRow["IDFilial"]);
                    estoque.Quantidade = Convert.ToInt32(dataRow["Quantidade"]);

                    estoqueReservadoColecao.Add(estoque);
                }

                return estoqueReservadoColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao consultar estoque reservado. Detalhes: "+ ex.Message);
            }
        }

    }
}
