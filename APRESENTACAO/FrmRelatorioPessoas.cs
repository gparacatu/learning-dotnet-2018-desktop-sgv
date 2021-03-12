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
using Microsoft.Reporting.WinForms;
using NEGOCIOS;

namespace APRESENTACAO
{
    public partial class FrmRelatorioPessoas : Syncfusion.Windows.Forms.Tools.RibbonForm
    {
        public FrmRelatorioPessoas()
        {
            InitializeComponent();
        }

        private void FrmRelatorioPessoas_Load(object sender, EventArgs e)
        {
            

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRelatorioPessoas_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                RelatoriosNegocio negocio = new RelatoriosNegocio();
                ReportDataSource Pessoas = new ReportDataSource("Pessoas", negocio.RelatorioPessoasNome(txtNome.Text));
                rvPessoas.LocalReport.DataSources.Clear();
                rvPessoas.LocalReport.DataSources.Add(Pessoas);
                rvPessoas.LocalReport.Refresh();
                this.rvPessoas.RefreshReport();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao gerar relatório de pessoas. Detalhes: " + ex.Message);
            }
        }
    }
}
