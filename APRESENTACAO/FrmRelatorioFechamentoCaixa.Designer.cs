namespace APRESENTACAO
{
    partial class FrmRelatorioFechamentoCaixa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RelatorioCaixaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RelatorioPedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rvCaixaFechamento = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioCaixaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioPedidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RelatorioCaixaBindingSource
            // 
            this.RelatorioCaixaBindingSource.DataSource = typeof(TRANSFERENCIA.RelatorioCaixa);
            // 
            // RelatorioPedidosBindingSource
            // 
            this.RelatorioPedidosBindingSource.DataSource = typeof(TRANSFERENCIA.RelatorioPedidos);
            // 
            // rvCaixaFechamento
            // 
            this.rvCaixaFechamento.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Caixa";
            reportDataSource1.Value = this.RelatorioCaixaBindingSource;
            reportDataSource2.Name = "Pedidos";
            reportDataSource2.Value = this.RelatorioPedidosBindingSource;
            this.rvCaixaFechamento.LocalReport.DataSources.Add(reportDataSource1);
            this.rvCaixaFechamento.LocalReport.DataSources.Add(reportDataSource2);
            this.rvCaixaFechamento.LocalReport.EnableExternalImages = true;
            this.rvCaixaFechamento.LocalReport.EnableHyperlinks = true;
            this.rvCaixaFechamento.LocalReport.ReportEmbeddedResource = "APRESENTACAO.RelatorioFechamentoCaixa.rdlc";
            this.rvCaixaFechamento.Location = new System.Drawing.Point(0, 0);
            this.rvCaixaFechamento.Name = "rvCaixaFechamento";
            this.rvCaixaFechamento.ServerReport.BearerToken = null;
            this.rvCaixaFechamento.Size = new System.Drawing.Size(871, 554);
            this.rvCaixaFechamento.TabIndex = 0;
            // 
            // FrmRelatorioFechamentoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(871, 554);
            this.Controls.Add(this.rvCaixaFechamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRelatorioFechamentoCaixa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fechamento de Caixa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRelatorioFechamentoCaixa_FormClosed);
            this.Load += new System.EventHandler(this.FrmRelatorioFechamentoCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioCaixaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioPedidosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvCaixaFechamento;
        private System.Windows.Forms.BindingSource RelatorioCaixaBindingSource;
        private System.Windows.Forms.BindingSource RelatorioPedidosBindingSource;
    }
}