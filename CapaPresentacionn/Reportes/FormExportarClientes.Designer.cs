namespace CapaPresentacionn.Reportes
{
    partial class FormExportarClientes
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
            this.ExportarClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatasetPrestamo = new CapaPresentacionn.Reportes.DatasetPrestamo();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ExportarClientesTableAdapter = new CapaPresentacionn.Reportes.DatasetPrestamoTableAdapters.ExportarClientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ExportarClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasetPrestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // ExportarClientesBindingSource
            // 
            this.ExportarClientesBindingSource.DataMember = "ExportarClientes";
            this.ExportarClientesBindingSource.DataSource = this.DatasetPrestamo;
            // 
            // DatasetPrestamo
            // 
            this.DatasetPrestamo.DataSetName = "DatasetPrestamo";
            this.DatasetPrestamo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ExportarClientesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacionn.Reportes.ExportarClientesInforme.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(850, 492);
            this.reportViewer1.TabIndex = 0;
            // 
            // ExportarClientesTableAdapter
            // 
            this.ExportarClientesTableAdapter.ClearBeforeFill = true;
            // 
            // FormExportarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 492);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormExportarClientes";
            this.Text = "FormExportarClientes";
            this.Load += new System.EventHandler(this.FormExportarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExportarClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasetPrestamo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ExportarClientesBindingSource;
        private DatasetPrestamo DatasetPrestamo;
        private DatasetPrestamoTableAdapters.ExportarClientesTableAdapter ExportarClientesTableAdapter;
    }
}