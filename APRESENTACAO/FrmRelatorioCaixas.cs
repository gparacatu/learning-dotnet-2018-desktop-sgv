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
    public partial class FrmRelatorioCaixas : Syncfusion.Windows.Forms.Tools.RibbonForm
    {
        public FrmRelatorioCaixas()
        {
            InitializeComponent();
        }

        private void FrmRelatorioCaixas_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmRelatorioCaixasPreview caixasPreview = new FrmRelatorioCaixasPreview(dtpInicial.Value, dtpFinal.Value);
                caixasPreview.ShowDialog();
                if (DialogResult == DialogResult.Yes)
                {
                    caixasPreview = null;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao abrir o relatório de caixas. Detalhes: " + ex.Message);
            }
        }
    }
}
