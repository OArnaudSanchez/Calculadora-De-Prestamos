using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacionn.Reportes
{
    public partial class FormExportarPrestamos : Form
    {
        public FormExportarPrestamos()
        {
            InitializeComponent();
        }

        private void FormExportarPrestamos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatasetPrestamo.ExportarPrestamos' Puede moverla o quitarla según sea necesario.
            this.ExportarPrestamosTableAdapter.Fill(this.DatasetPrestamo.ExportarPrestamos);

            this.reportViewer1.RefreshReport();
        }
    }
}
