using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using NEGOCIOS;

namespace APRESENTACAO
{
    public partial class FrmRelatorioCaixasPreview : Form
    {
        DateTime dataInicialRecebida, dataFinalRecebida;
        public FrmRelatorioCaixasPreview(DateTime DataInicial, DateTime DataFinal)
        {
            InitializeComponent();
            dataInicialRecebida = DataInicial;
            dataFinalRecebida = DataFinal;
        }

        private void rvCaixasPorData_Load(object sender, EventArgs e)
        {

        }

        private void FrmRelatorioCaixasPreview_Load(object sender, EventArgs e)
        {
            try
            {
                RelatorioCaixaNegocio caixaNegocio = new RelatorioCaixaNegocio();
                ReportDataSource Caixas = new ReportDataSource("CaixasPorData", caixaNegocio.ConsultarRelatorioCaixaPorDataAbertura(dataInicialRecebida, dataFinalRecebida));
                rvCaixasPorData.LocalReport.DataSources.Clear();
                rvCaixasPorData.LocalReport.DataSources.Add(Caixas);
                List<ReportParameter> parametros = new List<ReportParameter>();
                parametros.Add(new ReportParameter("DataInicial", dataInicialRecebida.ToString()));
                parametros.Add(new ReportParameter("DataFinal", dataFinalRecebida.ToString()));
                rvCaixasPorData.LocalReport.SetParameters(parametros);
                rvCaixasPorData.LocalReport.Refresh();
                this.rvCaixasPorData.RefreshReport();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao abrir preview do relatório de caixa. Detalhes: " + ex.Message);
            }
            
        }
    }
}
