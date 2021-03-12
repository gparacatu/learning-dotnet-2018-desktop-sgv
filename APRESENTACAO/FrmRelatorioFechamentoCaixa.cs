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
using TRANSFERENCIA;

namespace APRESENTACAO
{
    public partial class FrmRelatorioFechamentoCaixa : Form
    {
        DataTable caixaRecebido;
        DataTable pedidoRecebido;
        DataTable filialRecebida;
        public FrmRelatorioFechamentoCaixa(DataTable caixa, DataTable pedidos, DataTable filial)
        {
            InitializeComponent();
            caixaRecebido = caixa;
            pedidoRecebido = pedidos;
            filialRecebida = filial;
        }

        private void FrmRelatorioFechamentoCaixa_Load(object sender, EventArgs e)
        {
            ReportDataSource caixa = new ReportDataSource("Caixa", caixaRecebido);
            ReportDataSource pedidos = new ReportDataSource("Pedidos", pedidoRecebido);
            ReportDataSource filialRecebidaReport = new ReportDataSource("Filial", filialRecebida);
            rvCaixaFechamento.LocalReport.DataSources.Clear();
            rvCaixaFechamento.LocalReport.DataSources.Add(caixa);
            rvCaixaFechamento.LocalReport.DataSources.Add(pedidos);
            rvCaixaFechamento.LocalReport.DataSources.Add(filialRecebidaReport);
            rvCaixaFechamento.LocalReport.Refresh();
            this.rvCaixaFechamento.RefreshReport();
        }

        private void FrmRelatorioFechamentoCaixa_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }
    }
}
