namespace APRESENTACAO
{
    partial class FrmRelatorioCaixasPreview
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
            this.rvCaixasPorData = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvCaixasPorData
            // 
            this.rvCaixasPorData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvCaixasPorData.LocalReport.EnableExternalImages = true;
            this.rvCaixasPorData.LocalReport.EnableHyperlinks = true;
            this.rvCaixasPorData.LocalReport.ReportEmbeddedResource = "APRESENTACAO.RelatorioCaixasPorData.rdlc";
            this.rvCaixasPorData.Location = new System.Drawing.Point(0, 0);
            this.rvCaixasPorData.Name = "rvCaixasPorData";
            this.rvCaixasPorData.ServerReport.BearerToken = null;
            this.rvCaixasPorData.Size = new System.Drawing.Size(757, 591);
            this.rvCaixasPorData.TabIndex = 0;
            this.rvCaixasPorData.Load += new System.EventHandler(this.rvCaixasPorData_Load);
            // 
            // FrmRelatorioCaixasPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(757, 591);
            this.Controls.Add(this.rvCaixasPorData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRelatorioCaixasPreview";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Caixas";
            this.Load += new System.EventHandler(this.FrmRelatorioCaixasPreview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvCaixasPorData;
    }
}