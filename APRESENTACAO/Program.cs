using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APRESENTACAO
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Verifica se o aplicativo já esta aberto, se estiver não abre novamente

            var identificadorMutex = string.Format("{0}_{1}", "A403A6EB-6472-4B42-B5C1-C0E06F9F2SGV", System.Security.Principal.WindowsIdentity.GetCurrent().User);
            using (var mutex = new System.Threading.Mutex(true, identificadorMutex))
            {
                var jaEstaRodando = !mutex.WaitOne(0, true);
                if (jaEstaRodando)
                {
                    MessageBox.Show("O aplicativo SGV - Sistema de Gestão em Vendas já está sendo executado. Feche o que está aberto para iniciar novamente, ou reinicie seu computador que o problema será resolvido.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                    return;
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);                
                Application.Run(new FrmSplash());

                mutex.ReleaseMutex();
            }
            
        }
    }
}
