namespace APRESENTACAO
{
    partial class FrmRelatorioVendas
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
            this.RelatorioVendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rvVendas = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioVendasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RelatorioVendasBindingSource
            // 
            this.RelatorioVendasBindingSource.DataSource = typeof(TRANSFERENCIA.RelatorioVendas);
            // 
            // rvVendas
            // 
            this.rvVendas.AutoSize = true;
            this.rvVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvVendas.LocalReport.EnableExternalImages = true;
            this.rvVendas.LocalReport.EnableHyperlinks = true;
            this.rvVendas.LocalReport.ReportEmbeddedResource = "APRESENTACAO.RelatorioVendasPorData1.rdlc";
            this.rvVendas.Location = new System.Drawing.Point(0, 0);
            this.rvVendas.Name = "rvVendas";
            this.rvVendas.ServerReport.BearerToken = null;
            this.rvVendas.Size = new System.Drawing.Size(821, 539);
            this.rvVendas.TabIndex = 0;
            // 
            // FrmRelatorioVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(821, 539);
            this.Controls.Add(this.rvVendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRelatorioVendas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Vendas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRelatorioVendas_FormClosed);
            this.Load += new System.EventHandler(this.FrmRelatorioVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioVendasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvVendas;
        private System.Windows.Forms.BindingSource RelatorioVendasBindingSource;
    }
}