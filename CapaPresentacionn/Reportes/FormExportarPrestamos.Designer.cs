namespace CapaPresentacionn.Reportes
{
    partial class FormExportarPrestamos
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DatasetPrestamo = new CapaPresentacionn.Reportes.DatasetPrestamo();
            this.ExportarPrestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ExportarPrestamosTableAdapter = new CapaPresentacionn.Reportes.DatasetPrestamoTableAdapters.ExportarPrestamosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DatasetPrestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportarPrestamosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ExportarPrestamosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacionn.Reportes.ExportarPrestamos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(898, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DatasetPrestamo
            // 
            this.DatasetPrestamo.DataSetName = "DatasetPrestamo";
            this.DatasetPrestamo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ExportarPrestamosBindingSource
            // 
            this.ExportarPrestamosBindingSource.DataMember = "ExportarPrestamos";
            this.ExportarPrestamosBindingSource.DataSource = this.DatasetPrestamo;
            // 
            // ExportarPrestamosTableAdapter
            // 
            this.ExportarPrestamosTableAdapter.ClearBeforeFill = true;
            // 
            // FormExportarPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormExportarPrestamos";
            this.Text = "FormExportarPrestamos";
            this.Load += new System.EventHandler(this.FormExportarPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatasetPrestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportarPrestamosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ExportarPrestamosBindingSource;
        private DatasetPrestamo DatasetPrestamo;
        private DatasetPrestamoTableAdapters.ExportarPrestamosTableAdapter ExportarPrestamosTableAdapter;
    }
}