namespace CapaPresentacionn.Reportes
{
    partial class FrmGenerarFactura
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
            this.GenerarFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatasetPrestamo = new CapaPresentacionn.Reportes.DatasetPrestamo();
            this.GenerarFacturaTableAdapter = new CapaPresentacionn.Reportes.DatasetPrestamoTableAdapters.GenerarFacturaTableAdapter();
            this.ReportePrestamoPorCliente1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.GenerarFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasetPrestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportePrestamoPorCliente1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GenerarFacturaBindingSource
            // 
            this.GenerarFacturaBindingSource.DataMember = "GenerarFactura";
            this.GenerarFacturaBindingSource.DataSource = this.DatasetPrestamo;
            // 
            // DatasetPrestamo
            // 
            this.DatasetPrestamo.DataSetName = "DatasetPrestamo";
            this.DatasetPrestamo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GenerarFacturaTableAdapter
            // 
            this.GenerarFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // ReportePrestamoPorCliente1BindingSource
            // 
            this.ReportePrestamoPorCliente1BindingSource.DataMember = "GenerarFactura";
            this.ReportePrestamoPorCliente1BindingSource.DataSource = this.DatasetPrestamo;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GenerarFacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacionn.Reportes.ReportesGenerarFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(828, 526);
            this.reportViewer1.TabIndex = 0;
            // 
            // FrmGenerarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 526);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(844, 565);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(844, 565);
            this.Name = "FrmGenerarFactura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.FrmGenerarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GenerarFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasetPrestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportePrestamoPorCliente1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource GenerarFacturaBindingSource;
        private DatasetPrestamo DatasetPrestamo;
        private DatasetPrestamoTableAdapters.GenerarFacturaTableAdapter GenerarFacturaTableAdapter;
        private System.Windows.Forms.BindingSource ReportePrestamoPorCliente1BindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}