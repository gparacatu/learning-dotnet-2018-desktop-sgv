using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using TRANSFERENCIA;
using DAO;

namespace NEGOCIOS
{
    public class UsuarioNegocio
    {
        AcessoBancoSqlServer conexao = new AcessoBancoSqlServer();

        public string Inserir(Usuario usuario)
        {
            try
            {
                conexao.LimparParametros();

                conexao.AdicionarParametros("@LOGIN", usuario.Login);
                conexao.AdicionarParametros("@SENHA", usuario.Senha);
                conexao.AdicionarParametros("@IDPESSOA", usuario.IDPessoa);
                conexao.AdicionarParametros("@ACESSO", usuario.Acesso);
                conexao.AdicionarParametros("@IDSTATUS", usuario.IDStatus);
                conexao.AdicionarParametros("@IDPESSOAFILIAL", usuario.IDFilial);

                string retorno = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspUsuarioInserir").ToString();
                
                return retorno;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
            
        }

        public string Alterar(Usuario usuario)
        {
            try
            {
                conexao.LimparParametros();

                conexao.AdicionarParametros("@IDPessoa", usuario.IDPessoa);
                conexao.AdicionarParametros("@SENHA", usuario.Senha);
                conexao.AdicionarParametros("@ACESSO", usuario.Acesso);
                conexao.AdicionarParametros("@IDSTATUS", usuario.IDStatus);
                conexao.AdicionarParametros("@IDPESSOAFILIAL", usuario.IDFilial);

                string retorno = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspUsuarioAlterar").ToString();

                return retorno;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public UsuarioColecao ConsultarPorIdDaPessoa(int idpessoa, int filial)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@IDPessoa", idpessoa);
                conexao.AdicionarParametros("@IDFILIAL", filial);

                DataTable dataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "uspUsuarioConsultar");

                UsuarioColecao usuarioColecao = new UsuarioColecao();

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Usuario usuario = new Usuario();

                    usuario.Acesso = Convert.ToInt32(dataRow["Acesso"]);
                    usuario.IDPessoa = Convert.ToInt32(dataRow["IDPessoa"]);
                    usuario.IDStatus = Convert.ToInt32(dataRow["IDStatus"]);
                    usuario.IDUsuario = Convert.ToInt32(dataRow["IDUsuario"]);
                    //usuario.Layout = Convert.ToInt32(dataRow["Layout"]);
                    usuario.Login = Convert.ToString(dataRow["Login"]);
                    usuario.PapelParede = Convert.ToString(dataRow["PapelParede"]);
                    usuario.Senha = Convert.ToString(dataRow["Senha"]);
                    usuario.StatusDescricao = Convert.ToString(dataRow["StatusDescricao"]);
                    usuario.IDFilial = Convert.ToInt32(dataRow["IDPessoaFilial"]);

                    usuarioColecao.Add(usuario);
                }

                return usuarioColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao consultar usuários. Detalhes: "+ex.Message);
            }
        }

        public Usuario ConsultarPorUsuarioSenha(string usuario, string senha)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@USUARIO", usuario);
                conexao.AdicionarParametros("@SENHA", senha);

                DataTable dataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "uspLoginConsulta");
                
                Usuario usuarioLogado = new Usuario();


                foreach (DataRow dataRow in dataTable.Rows)
                {                    
                    usuarioLogado.Acesso = Convert.ToInt32(dataRow["Acesso"]);
                    usuarioLogado.IDPessoa = Convert.ToInt32(dataRow["IDPessoa"]);
                    usuarioLogado.IDStatus = Convert.ToInt32(dataRow["IDStatus"]);
                    usuarioLogado.IDUsuario = Convert.ToInt32(dataRow["IDUsuario"]);
                    //usuarioLogado.Layout = Convert.ToInt32(dataRow["Layout"]);
                    usuarioLogado.Login = Convert.ToString(dataRow["Login"]);
                    usuarioLogado.PapelParede = Convert.ToString(dataRow["PapelParede"]);
                    usuarioLogado.Senha = Convert.ToString(dataRow["Senha"]);
                    usuarioLogado.IDFilial = Convert.ToInt32(dataRow["IDPessoaFilial"]);
                }

                return usuarioLogado;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao consultar usuário. Detalhes: " + ex.Message);
            }
        }

        public string AlterarStatus(int IDUsuario, int Status)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@IDUSUARIO", IDUsuario);
                conexao.AdicionarParametros("@STATUS", Status);

                string retorno = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspUsuarioAlterarStatus").ToString();

                return retorno;
            }
            catch (Exception ex)
            {

                return ex.Message;

            }

        }

        public String setarPapelDeParede (int usuario, string papel)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@IDUSUARIO", usuario);
                conexao.AdicionarParametros("@PAPELDEPAREDE", papel);

                string retorno = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspUsuarioAlterarImagemFundo").ToString();

                return retorno;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public String pegarPapelDeParede(int usuario)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@IDUSUARIO", usuario);

                string retorno = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspUsuarioBuscarImagemFundo").ToString();

                return retorno;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }


    }
}
