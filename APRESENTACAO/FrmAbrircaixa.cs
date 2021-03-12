#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using TRANSFERENCIA;
using NEGOCIOS;

namespace APRESENTACAO
{
    public partial class FrmAbrircaixa : Syncfusion.Windows.Forms.Tools.RibbonForm
    {
        public FrmAbrircaixa()
        {
            InitializeComponent();
        }

        private void btnAbrirCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                Caixa caixa = new Caixa();

                caixa.valorInicial = Convert.ToDecimal(txtValorInicial.Text.Replace("R$", ""));
                caixa.IDUsuario = ControleSistema.getIdUsuarioLogado();
                caixa.Status = "A";

                CaixaNegocio caixaNegocio = new CaixaNegocio();

                string retorno = caixaNegocio.caixaAbrir(caixa);

                int IDCaixa;

                if (int.TryParse(retorno, out IDCaixa))
                {
                    MessageBox.Show("O caixa foi aberto com sucesso. ID do caixa: " + IDCaixa);

                    ControleSistema.atualizaCaixaAtual();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao abrir caixa. Detalhes: " + retorno);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao abrir caixa. Detalhes: " + ex.Message);
            }
            


        }

        private void FrmAbrircaixa_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ControleFormulario.frmAbrirCaixa != null)
            {
                ControleFormulario.frmAbrirCaixa = null;
            }
        }

        private void FrmAbrircaixa_Load(object sender, EventArgs e)
        {
            if (ControleSistema.getCaixaAtual().Status != "N")
            {
                MessageBox.Show("Já existe uma caixa aberto para esse usuário. É necessário encerrar o caixa atual para abrir um novo.");
                this.Close();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
