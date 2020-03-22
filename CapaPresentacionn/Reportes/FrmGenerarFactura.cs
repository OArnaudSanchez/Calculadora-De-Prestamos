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
    public partial class FrmGenerarFactura : Form
    {
        public FrmGenerarFactura()
        {
            InitializeComponent();
        }

        private void FrmGenerarFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatasetPrestamo.GenerarFactura' Puede moverla o quitarla según sea necesario.
            this.GenerarFacturaTableAdapter.Fill(this.DatasetPrestamo.GenerarFactura, Aplicacion.cedula);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
