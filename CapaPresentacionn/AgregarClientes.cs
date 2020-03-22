using System;
using System.Data;
using System.Windows.Forms;
using CapaLogicaNegocio;

namespace CapaPresentacionn
{
    public partial class AgregarClientes : Form
    {

        public string OpcionCedula;
        public string OpcionTelefono;
        public string OpcionCelular;


        public AgregarClientes()
        {
            InitializeComponent();
        }

        

        //Metodo para los mensajes de error
        private void Error()
        {
            Operaciones.Mensaje("No campos Vacios");

            errorProvider1.SetError(tCedula, "Debe ingresar la cedula");
            errorProvider1.SetError(tNombre, "Debe ingresar el nombre");
            errorProvider1.SetError(tApellidos, "Debe ingresar los apellidos");
            errorProvider1.SetError(dateTimePicker1, "Debe ingresar la fecha");

            errorProvider1.SetError(tDireccion, "Debe ingresar la direccion");
            errorProvider1.SetError(tTelefono, "Debe ingresar el telefono");
            errorProvider1.SetError(tCelular, "Debe ingresar el celular");
        }


        //Metodo que limpia los textbox
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



        //Mensajes de error 
        private void tCedula_TextChanged(object sender, EventArgs e)
        {
            if (OpcionCedula == tCedula.Text)
            {
                errorProvider1.SetError(tCedula, "Ya existe un cliente con esta Cedula");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void tCelular_TextChanged(object sender, EventArgs e)
        {
            if (OpcionCelular == tCelular.Text)
            {
                errorProvider1.SetError(tCelular, "Ya existe un cliente con este Celular");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void tTelefono_TextChanged(object sender, EventArgs e)
        {
            if (OpcionTelefono == tTelefono.Text)
            {
                errorProvider1.SetError(tTelefono, "Ya existe un cliente con Telefono");
            }
            else
            {
                errorProvider1.Clear();
            }
        }



        private void bGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (tNombre.Text == string.Empty || tApellidos.Text == string.Empty ||
                    tTelefono.Text == string.Empty || tCelular.Text == string.Empty || tDireccion.Text == string.Empty
                    || tCedula.Text == string.Empty || dateTimePicker1.Text == "")
                {
                    Error();
                }
                else
                {
                    LogicaCliente.Insertar(tCedula.Text.Trim(), tNombre.Text.Trim(), tApellidos.Text.Trim()
                      , dateTimePicker1.Value, (2020 - dateTimePicker1.Value.Year), tDireccion.Text.Trim(), tTelefono.Text.Trim()
                      , tCelular.Text.Trim(), int.Parse(Login.id));

                    Operaciones.Mensaje("Cliente Guardado Correctamente");
                    this.Close();
                }

            }
            catch (Exception error)
            {
                Operaciones.Mensaje("Ya hay un cliente con La Cedula, Telefono o Celular que desea Ingresar");
            }
        }

        private void bLImpiarUsuario_Click(object sender, EventArgs e)
        {

        }

        
    }
}
