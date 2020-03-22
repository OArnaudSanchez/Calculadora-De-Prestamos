using System;
using System.Data;
using System.Windows.Forms;
using CapaLogicaNegocio;

namespace CapaPresentacionn
{
    public partial class CrearPrestamo : Form
    {

        private string estadoPrestamo;

        public CrearPrestamo()
        {
            InitializeComponent();
        }

        private void CrearPrestamo_Load(object sender, EventArgs e)
        {
            tUsuario.Text = Login.nom;
        }


        private void bLimpiarPrestamo_Click(object sender, EventArgs e)
        {
            tInteres.Clear();
            tTiempo.Clear();
            tMonto.Clear();
        }


        private void Error()
        {
            MessageBox.Show("No campos Vacios");
            errorProvider1.SetError(tInteres, "Ingresa el interes");
            errorProvider1.SetError(tTiempo, "Ingresa el tiempo del prestamo");
            errorProvider1.SetError(tMonto, "Debe ingresar el Monto");
            errorProvider1.SetError(tCedula, "Debe elegir el cliente");
            errorProvider1.SetError(tNombreCliente, "Debe elegir el cliente");
        }

        private void bBuscarCliente_Click(object sender, EventArgs e)
        {
            EscogerCliente cliente = new EscogerCliente();
            cliente.ShowDialog();
            tNombreCliente.Text = EscogerCliente.NombreCliente;
            tCedula.Text = EscogerCliente.CedulaCliente;
        }


        private void tCedula_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(EscogerCliente.OpcionPrestamo) > 0)
            {
                errorProvider1.SetError(tNombreCliente, "Este cliente ya tiene un prestamo asociado");
                errorProvider1.SetError(tCedula, "Este cliente ya tiene un prestamo asociado");
            }
            else
            {
                errorProvider1.Clear();
            }
        }


        public string Estado()
        {
            //Evaluar el estado
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


        private void bGuardar_Click(object sender, EventArgs e)
        {   

            try
            {

                if (tInteres.Text == string.Empty || tTiempo.Text == string.Empty ||
                        dateTimePrestamo.Text == "" || tMonto.Text == string.Empty || tCedula.Text == string.Empty ||
                        tNombreCliente.Text == string.Empty || tUsuario.Text == string.Empty)
                {
                    Error();
                }
                else
                {

                    //Evaluando si el cliente ya tiene un prestamo registrado
                    if (int.Parse(EscogerCliente.OpcionPrestamo) > 0)
                    {

                        Operaciones.Mensaje("El cliente solo puede tener un prestamo activo");
                    }
                    else
                    {
                        LogicaPrestamos.Ingresar(int.Parse(tInteres.Text), int.Parse(tTiempo.Text),
                         dateTimePrestamo.Value,
                         int.Parse(Login.id), int.Parse(EscogerCliente.IDCliente), Estado(), double.Parse(tMonto.Text));


                        //Consulta para saber el id del prestamo que se esta creando, para luego asignarselo a la factura
                        string comando = string.Format($"select * from Prestamos where idCliente='{EscogerCliente.IDCliente}'");
                        DataSet data = LogicaUsuarios.Ejecutar(comando);
                        string idPrestamos = data.Tables[0].Rows[0]["idPrestamo"].ToString().Trim();


                        double totalPago = Operaciones.funcion(double.Parse(tMonto.Text),
                            double.Parse(tInteres.Text), int.Parse(tTiempo.Text));


                        Operaciones.InsertarFactura(totalPago, double.Parse(tInteres.Text), int.Parse(idPrestamos),
                            int.Parse(EscogerCliente.IDCliente), int.Parse(Login.id));

                        Operaciones.Mensaje("Prestamo Creado Correctamente");
                        this.Close();
                    }

                }

            }
            catch (Exception error)
            {
                Operaciones.Mensaje("Ha ocurrido un error al Crear el Prestamo");
            }

        }

    }
}
