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
    public class PessoaTipoNegocio
    {
        AcessoBancoSqlServer conexao = new AcessoBancoSqlServer();

        public PessoaTipoColecao Consultar()
        {
            try
            {
                conexao.LimparParametros();
                PessoaTipoColecao pessoaTipoColecao = new PessoaTipoColecao();

                DataTable dataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "uspPessoaTipoConsultar");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    PessoaTipo pessoa = new PessoaTipo();

                    pessoa.IDPessoaTipo = Convert.ToInt32(dataRow["IDPessoaTipo"]);
                    pessoa.Descricao = Convert.ToString(dataRow["Descricao"]);

                    pessoaTipoColecao.Add(pessoa);
                }

                return pessoaTipoColecao;

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao consultar tipo de pessoa. Detalhes: " + ex.Message);
            }
        }
    }
}
