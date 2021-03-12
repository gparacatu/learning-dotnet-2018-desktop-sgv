using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NEGOCIOS;

namespace APRESENTACAO
{
    public partial class FrmRelatorioComprasPreview : Form
    {
        DateTime dataInicialRecebida, dataFinalRecebida;
        public FrmRelatorioComprasPreview(DateTime DataInicial, DateTime DataFinal)
        {
            InitializeComponent();
            dataInicialRecebida = DataInicial;
            dataFinalRecebida = DataFinal;
        }

        private void FrmRelatorioComprasPreview_Load(object sender, EventArgs e)
        {         
            
            try
             {
                RelatoriosNegocio relatorioCompra = new RelatoriosNegocio();
                ReportDataSource Compra = new ReportDataSource("RelatorioCompras", relatorioCompra.RelatorioComprasData(dataInicialRecebida, dataFinalRecebida));
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(Compra);
                List<ReportParameter> parametros = new List<ReportParameter>();
                parametros.Add(new ReportParameter("DataInicial", dataInicialRecebida.ToString()));
                parametros.Add(new ReportParameter("DataFinal", dataFinalRecebida.ToString()));
                reportViewer1.LocalReport.SetParameters(parametros);
                reportViewer1.LocalReport.Refresh();
                this.reportViewer1.RefreshReport();
             }
             catch (Exception ex)
             {

                 MessageBox.Show("Erro ao gerar relatório. Detalhes: " + ex.Message);
             }
            
             
        }

        private void FrmRelatorioComprasPreview_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }
    }
}
