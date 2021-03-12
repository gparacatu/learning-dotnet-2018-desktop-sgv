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

namespace APRESENTACAO
{
    public partial class FrmRelatorioVendas : Form
    {
        DataTable pedidosRecebidos;
        DateTime dataInicialRecebida, dataFinalRecebida;
        public FrmRelatorioVendas(DataTable Pedidos, DateTime dataInicial, DateTime dataFinal)
        {
            InitializeComponent();

            pedidosRecebidos = Pedidos;
            dataInicialRecebida = dataInicial;
            dataFinalRecebida = dataFinal;
        }

        private void FrmRelatorioVendas_Load(object sender, EventArgs e)
        {
            try
            {
                ReportDataSource Venda = new ReportDataSource("Vendas", pedidosRecebidos);
                rvVendas.LocalReport.DataSources.Clear();
                rvVendas.LocalReport.DataSources.Add(Venda);
                List<ReportParameter> parametros = new List<ReportParameter>();
                parametros.Add(new ReportParameter("DataInicial", dataInicialRecebida.ToString()));
                parametros.Add(new ReportParameter("DataFinal", dataFinalRecebida.ToString()));
                rvVendas.LocalReport.SetParameters(parametros);
                rvVendas.LocalReport.Refresh();
                this.rvVendas.RefreshReport();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao abrir o relatório. Detalhes: " + ex.Message);
            }
            
        }

        private void FrmRelatorioVendas_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }
    }
}
