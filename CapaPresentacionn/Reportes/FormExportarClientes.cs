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
    public partial class FormExportarClientes : Form
    {
        public FormExportarClientes()
        {
            InitializeComponent();
        }

        private void FormExportarClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatasetPrestamo.ExportarClientes' Puede moverla o quitarla según sea necesario.
            this.ExportarClientesTableAdapter.Fill(this.DatasetPrestamo.ExportarClientes);

            this.reportViewer1.RefreshReport();
        }
    }
}
