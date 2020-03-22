using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaNegocio;

namespace CapaPresentacionn
{
    public partial class ModificarPrestamo : Form
    {

        private string estadoPrestamo;

        public ModificarPrestamo()
        {
            InitializeComponent();
        }


        private void ModificarPrestamo_Load(object sender, EventArgs e)
        {
            tUsuario.Text = Login.nom;
        }

        private void bLimpiarPrestamo_Click(object sender, EventArgs e)
        {
            tId.Clear();
            tInteres.Clear();
            tTiempo.Clear();
        }



        private void bBuscarPrestamo_Click(object sender, EventArgs e)
        {
            EscogerPrestamo prestamo = new EscogerPrestamo();
            prestamo.ShowDialog();

            tId.Text = EscogerPrestamo.IDPrestamo;
            tNombre.Text = EscogerPrestamo.NombreCliente;
            tMonto.Text = EscogerPrestamo.Monto;
            tInteres.Text = EscogerPrestamo.Interes;
            tTiempo.Text = EscogerPrestamo.Tiempo;

        }


        private bool Error()
        {
            if (tInteres.Text == string.Empty || tTiempo.Text == string.Empty ||
                   tMonto.Text == string.Empty)
            {
                Operaciones.Mensaje("No campos Vacios");
                errorProvider1.SetError(tInteres, "Ingresa el interes");
                errorProvider1.SetError(tTiempo, "Ingresa el tiempo del prestamo");
                errorProvider1.SetError(tMonto, "Debe ingresar el monto");
                return true;
            }
            else
            {
                return false;
            }

        }

        private string Estado()
        {
            if (cEstaddo.Checked == true)
            {
                estadoPrestamo = "Prestamo Activo";
            }
            if (cEstaddo.Checked == false)
            {
                estadoPrestamo = "Prestamo Inactivo";
            }

            return estadoPrestamo;
        }

        private void bModificar_Click(object sender, EventArgs e)
        {

            try
            {
                DateTime fecha = dateTimePrestamo.Value;

                if (!tId.Text.Equals("") || Error() == true)
                {
                    LogicaPrestamos.Modificar(int.Parse(tId.Text), int.Parse(tInteres.Text), int.Parse(tTiempo.Text),
                       dateTimePrestamo.Value,
                       int.Parse(Login.id), int.Parse(EscogerPrestamo.IDCliente), Estado(), double.Parse(tMonto.Text));

                    Operaciones.Mensaje("Prestamo Modificado");
                    this.Close();
                }
                else
                {
                    Operaciones.Mensaje("Debe selecionar el Prestamo que desea modificar");
                }
            }
            catch (Exception error)
            {
                Operaciones.Mensaje("Ha ocurrido un error al Modificar el Prestamo");
            }
        }


    }
}
