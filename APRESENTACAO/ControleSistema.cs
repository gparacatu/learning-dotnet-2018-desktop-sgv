using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRANSFERENCIA;
using NEGOCIOS;
using System.Windows.Forms;

namespace APRESENTACAO
{
    public static class ControleSistema
    {
        private static PessoaFilial filialLogada;
        private static Usuario usuarioLogado;
        private static Caixa caixaAtual;

        public static void setFilialUsuario(PessoaFilial filial, Usuario usuario)
        {
            filialLogada = new PessoaFilial();
            filialLogada = filial;

            usuarioLogado = new Usuario();
            usuarioLogado = usuario;
        }

        public static void atualizaCaixaAtual()
        {
            //Verifica se existe caixa aberto para o funcionario logado.
            CaixaNegocio caixaNegocio = new CaixaNegocio();
            Caixa caixa = new Caixa();
            caixa = caixaNegocio.caixaConsultarPorUsuarioLogado(usuarioLogado.IDUsuario);
            if (caixa.Status != "A")
            {
                caixa.IDUsuario = usuarioLogado.IDUsuario;
                caixa.Status = "N";
            }

            caixaAtual = caixa;                       
            
        }

        public static PessoaFilial getFilialLogada()
        {
            return filialLogada;
        }

        public static Usuario getUsuario()
        {
            return usuarioLogado;
        }

        public static int getIdUsuarioLogado()
        {
            return usuarioLogado.IDUsuario;
        }

        public static Caixa getCaixaAtual()
        {
            atualizaCaixaAtual();
            return caixaAtual;
        }
    }
}
