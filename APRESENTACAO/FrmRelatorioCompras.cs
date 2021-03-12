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

namespace APRESENTACAO
{
    public partial class FrmRelatorioCompras : Syncfusion.Windows.Forms.Tools.RibbonForm
    {
        public FrmRelatorioCompras()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dataInicial = new DateTime();
                DateTime dataFinal = new DateTime();

                dataInicial = dtpInicial.Value;
                dataFinal = dtpFinal.Value;

                //RelatorioVendasNegocio vendasNegocio = new RelatorioVendasNegocio();

                //DataTable Pedidos = vendasNegocio.ConsultarPorData(dtpInicial.Value, dtpFinal.Value);

                FrmRelatorioComprasPreview frmRelatorioComprasPreview = new FrmRelatorioComprasPreview(dataInicial, dataFinal);

                frmRelatorioComprasPreview.ShowDialog();
                if (DialogResult == DialogResult.Yes)
                {
                    frmRelatorioComprasPreview = null;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao abrir relatório. Detalhes: " + ex.Message);

            }
        }

        private void FrmRelatorioCompras_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }
    }
}
