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
    public partial class ModificarClientes : Form
    {
        public ModificarClientes()
        {
            InitializeComponent();
        }

        private void bSeleccionCliente_Click(object sender, EventArgs e)
        {
            EscogerCliente cliente = new EscogerCliente();
            cliente.ShowDialog();
            tIDCliente.Text = EscogerCliente.IDCliente;
            tCedula.Text = EscogerCliente.CedulaCliente;
            tNombre.Text = EscogerCliente.NombreCliente;
            tApellidos.Text = EscogerCliente.Apellidos;
            tTelefono.Text = EscogerCliente.Telefono;
            tCelular.Text = EscogerCliente.Celular;
            tDireccion.Text = EscogerCliente.Direccion;
        }

        private void bLimpiarCliente_Click(object sender, EventArgs e)
        {
            tCedula.Clear();
            tNombre.Clear();
            tApellidos.Clear();
            tTelefono.Clear();
            tCelular.Clear();
            tDireccion.Clear();
            dateTimePicker1.ResetText();
        }

        private bool Error()
        {
            if (tNombre.Text == string.Empty || tApellidos.Text == string.Empty ||
                tTelefono.Text == string.Empty || tCelular.Text == string.Empty || tDireccion.Text == string.Empty
                || tCedula.Text == string.Empty)
            {
                Operaciones.Mensaje("NO Campos Vacios");
                errorProvider1.SetError(tCedula, "Debe ingresar la cedula");
                errorProvider1.SetError(tNombre, "Debe ingresar el nombre");
                errorProvider1.SetError(tApellidos, "Debe ingresar los apellidos");
                errorProvider1.SetError(dateTimePicker1, "Debe ingresar la fecha");
                errorProvider1.SetError(tDireccion, "Debe ingresar la direccion");
                errorProvider1.SetError(tTelefono, "Debe ingresar el telefono");
                errorProvider1.SetError(tCelular, "Debe ingresar el celular");
                return true;
            }
            else
            {
                return false;
            }
        }


        private void bModificar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = dateTimePicker1.Value;

                if (!tIDCliente.Text.Equals("") || Error() != true)
                {
                    int Edad = (dateTimePicker1.Value.Year - 2020);

                    LogicaCliente.Modificar(int.Parse(tIDCliente.Text), tCedula.Text.Trim(), tNombre.Text.Trim(), tApellidos.Text.Trim(),
                        fecha,Edad, tDireccion.Text.Trim(), tTelefono.Text.Trim(),
                        tCelular.Text.Trim(),int.Parse(Login.id));

                    Operaciones.Mensaje("Cliente Modificado");
                    this.Close();
                }
                else
                {
                    Error();
                }

            }
            catch (Exception error)
            {
                Operaciones.Mensaje("Ya hay un cliente con La Cedula, Telefono o Celular que desea ing");
            }
        }

   
    }
}
