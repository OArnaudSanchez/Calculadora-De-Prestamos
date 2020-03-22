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
    public partial class FormExportarUsuarios : Form
    {
        public FormExportarUsuarios()
        {
            InitializeComponent();
        }

        private void FormExportarUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatasetPrestamo.ExportarUsuarios' Puede moverla o quitarla según sea necesario.
            this.ExportarUsuariosTableAdapter.Fill(this.DatasetPrestamo.ExportarUsuarios);

            this.reportViewer1.RefreshReport();
        }
    }
}
