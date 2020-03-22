namespace CapaPresentacionn.Reportes
{
    partial class FormExportarUsuarios
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
            this.ExportarUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatasetPrestamo = new CapaPresentacionn.Reportes.DatasetPrestamo();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ExportarUsuariosTableAdapter = new CapaPresentacionn.Reportes.DatasetPrestamoTableAdapters.ExportarUsuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ExportarUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasetPrestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // ExportarUsuariosBindingSource
            // 
            this.ExportarUsuariosBindingSource.DataMember = "ExportarUsuarios";
            this.ExportarUsuariosBindingSource.DataSource = this.DatasetPrestamo;
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
            reportDataSource1.Value = this.ExportarUsuariosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacionn.Reportes.ExportarUsuarios.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(900, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ExportarUsuariosTableAdapter
            // 
            this.ExportarUsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // FormExportarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormExportarUsuarios";
            this.Text = "FormExportarUsuarios";
            this.Load += new System.EventHandler(this.FormExportarUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExportarUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasetPrestamo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ExportarUsuariosBindingSource;
        private DatasetPrestamo DatasetPrestamo;
        private DatasetPrestamoTableAdapters.ExportarUsuariosTableAdapter ExportarUsuariosTableAdapter;
    }
}