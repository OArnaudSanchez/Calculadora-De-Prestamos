using System;
using System.Windows.Forms;
using CapaLogicaNegocio;

namespace CapaPresentacionn
{
    public partial class AnularPrestamo : Form
    {
        public AnularPrestamo()
        {
            InitializeComponent();
        }


        private void bBuscarPrestamo_Click(object sender, EventArgs e)
        {
            //Seleccionar el prestamo
            EscogerPrestamo prestamo = new EscogerPrestamo();
            prestamo.ShowDialog();
            tBusqueda.Text = EscogerPrestamo.IDPrestamo;
        }

        private void bAnularPrestamo_Click(object sender, EventArgs e)
        {
        
            try
            {

                if (MessageBox.Show("Desea Anular el Prestamo", "Alerta!!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    LogicaPrestamos.Anular(int.Parse(tBusqueda.Text));

                    Operaciones.Mensaje("Prestamo Anulado");
                    tBusqueda.Clear();
                    this.Close();
                }
            }
            catch (Exception error)
            {
                Operaciones.Mensaje("Ha ocurrido un error al Anular el Prestamo");
            }
        }
    }
}
