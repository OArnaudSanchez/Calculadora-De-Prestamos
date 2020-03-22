using System;
using System.Data;
using System.Windows.Forms;
using CapaLogicaNegocio;
using CapaPresentacionn.Reportes;

namespace CapaPresentacionn
{
    public partial class Aplicacion : Form
    {

        public string idUsuario="";
        public string nombre="";
        public string acceso = "";
        public static string cedula;


        public Aplicacion()
        {

            InitializeComponent();
            MostrarUsuarios();
            MostrarClientes();
            MostrarPrestamos();
        }


        private void GestionarVentanas(Form form)
        {
            form.MdiParent = this.MdiParent;
            form.Show();
        }


        private void Aplicaion_Load(object sender, EventArgs e)
        {
            GestionUsuario();

            lHora.Text = DateTime.Now.ToString();

            label1.Text = nombre;
            label11.Text = acceso;
            label12.Text = idUsuario;
            MostrarUsuarios();
            MostrarClientes();
            MostrarPrestamos();
            Calculos();
        }


        private void MostrarPrestamos()
        {
            dataPrestamo.DataSource = LogicaPrestamos.Todo();
            lResultado.Text = "Total De Prestamos: " + dataPrestamo.Rows.Count.ToString();
        }
        private void MostrarClientes()
        {
            dataCliente.DataSource = LogicaCliente.Mostrar();
            lResultadoClientes.Text = "Total De Clientes: " + dataCliente.Rows.Count.ToString();
        }
        private void MostrarUsuarios()
        {
            dataUsuarios.DataSource = LogicaUsuarios.Mostrar();
            lResultadoUsuarios.Text = "Total De Usuarios: " + dataUsuarios.Rows.Count.ToString();
        }



        private void GestionUsuario()
        {
            if (acceso=="Administrador")
            {
                btnCrearUsuarios.Enabled = true;
                bModificar.Enabled = true;
                bEliminar.Enabled = true;


            }
            else if (acceso == "Empleado")
            {
                btnCrearUsuarios.Enabled = false;
                bModificar.Enabled = false;
                bEliminar.Enabled = false;
                btnModificarClientes.Enabled = false;
                btnEliminarCLientes.Enabled = false;
                bModificarPrestamo.Enabled = false;
                bAnularPrestamo.Enabled = false;
            }
            
        }




        public static void EstablecerMensaje(ToolTip tool, string mensaje, Button b)
        {
            tool.SetToolTip(b, mensaje);
        }

        private void bSeleccionCliente_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(bSeleccionCliente, "Seleccione el Cliente para Realizar los reportes");
        }

        private void bLimpiar_MouseHover(object sender, EventArgs e)
        {
            EstablecerMensaje(toolTip1, "Limpiar el Campo", bLimpiarReporte);
        }

        private void Excel_MouseHover(object sender, EventArgs e)
        {
            EstablecerMensaje(toolTip1, "Exportar los datos a EXCEL", Excel);
        }

        private void PDF_MouseHover(object sender, EventArgs e)
        {
            EstablecerMensaje(toolTip1, "Exportar los datos a PDF", PDF);

        }

        private void bFacturar_MouseHover(object sender, EventArgs e)
        {
            EstablecerMensaje(toolTip1, "Genera la Factura del Prestamo perteneciente al cliente seleccionado", bFacturar);

        }

        private void CalcularPrestamo_MouseHover(object sender, EventArgs e)
        {
            EstablecerMensaje(toolTip1, "Calcula la informacion del prestamos perteneciente al cliente seleccionado", CalcularPrestamo);

        }

        private void bBuscarPrestamo_MouseHover(object sender, EventArgs e)
        {
            EstablecerMensaje(toolTip1, "Buscar Prestamo", bBuscarPrestamo);

        }

        private void bAnularPrestamo_MouseHover(object sender, EventArgs e)
        {
            EstablecerMensaje(toolTip1, "Anular Prestamos", bAnularPrestamo);

        }

        private void bModificarPrestamo_MouseHover(object sender, EventArgs e)
        {
            EstablecerMensaje(toolTip1, "Modificacion a los Prestamos", bModificarPrestamo);

        }

        private void bCrearPrestamo_MouseHover(object sender, EventArgs e)
        {
            EstablecerMensaje(toolTip1, "Creacion de Prestamos", bCrearPrestamo);

        }

        private void bBuscarCliente_MouseHover(object sender, EventArgs e)
        {
            EstablecerMensaje(toolTip1, "Buscar Clientes Registrados", bBuscarCliente);

        }

        private void bExportarPrestamos_MouseHover(object sender, EventArgs e)
        {
            EstablecerMensaje(toolTip1, "Exportar el listado de Prestamos", bExportarPrestamos);

        }

        private void bExportarClientes_MouseHover(object sender, EventArgs e)
        {
            EstablecerMensaje(toolTip1, "Exportar el Listado de Clientes", bExportarClientes);

        }

        private void btnEliminarCLientes_MouseHover(object sender, EventArgs e)
        {
            EstablecerMensaje(toolTip1, "Eliminar CLientes", btnEliminarCLientes);

        }

        private void btnModificarClientes_MouseHover(object sender, EventArgs e)
        {
            EstablecerMensaje(toolTip1, "Modificar Clientes", btnModificarClientes);

        }

        private void btnCrearClientes_MouseHover(object sender, EventArgs e)
        {
            EstablecerMensaje(toolTip1, "Crear Clientes", btnCrearClientes);

        }

        private void bBuscarUsuario_MouseHover(object sender, EventArgs e)
        {
            EstablecerMensaje(toolTip1, "Buscar Usuarios", bBuscarUsuario);

        }

        private void bExportarUsuarios_MouseHover(object sender, EventArgs e)
        {
            EstablecerMensaje(toolTip1, "Exportar El listado de Usuarios", bExportarUsuarios);

        }

        private void bEliminar_MouseHover(object sender, EventArgs e)
        {
            EstablecerMensaje(toolTip1, "Eliminar Usuarios", bEliminar);

        }

        private void bModificar_MouseHover(object sender, EventArgs e)
        {
            EstablecerMensaje(toolTip1, "Modificar Los Usuarios", bModificar);

        }

        private void btnCrearUsuarios_MouseHover(object sender, EventArgs e)
        {
            EstablecerMensaje(toolTip1, "Crear Usuarios", btnCrearUsuarios);

        }


        //Usuarios   
        private void btnCrearUsuarios_Click_1(object sender, EventArgs e)
        {
            MostrarUsuarios();
            GestionarVentanas(new CrearUsuario());
            
        }

        private void bModificar_Click_1(object sender, EventArgs e)
        {
            MostrarUsuarios();
            GestionarVentanas(new ModificarUsuario());
          
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            MostrarUsuarios();
            GestionarVentanas(new BorrarUsuario());
            
        }

        private void bBuscarUsuario_Click_1(object sender, EventArgs e)
        {
            if (tNombre.Text.Length == 0)
            {
                Operaciones.Mensaje("El Campo de Busqueda no Puede estar Vacio");
                MostrarUsuarios();
            }
        }

        private void tNombre_TextChanged(object sender, EventArgs e)
        {
            if (tNombre.Text.Length == 0)
            {
                MostrarUsuarios();
            }
            else
            {
                dataUsuarios.DataSource = LogicaUsuarios.Buscar(tNombre.Text);
            }
        }

        private void bExportarUsuarios_Click_1(object sender, EventArgs e)
        {
            if (dataUsuarios.Rows.Count < 1)
            {
                Operaciones.Mensaje("No hay datos para Exportar");

            }
            else
            {
                FormExportarUsuarios usuarios = new FormExportarUsuarios();
                usuarios.ShowDialog();
            }

        }
        private void tabPage2_MouseMove(object sender, MouseEventArgs e)
        {
            MostrarUsuarios();
        }
        private void tabPage2_MouseHover(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }




        //Clientes
        private void btnCrearClientes_Click_1(object sender, EventArgs e)
        {
            MostrarClientes();
            GestionarVentanas(new AgregarClientes());
        }

        private void btnModificarClientes_Click_1(object sender, EventArgs e)
        {
            MostrarClientes();

            GestionarVentanas(new ModificarClientes());
        }

        private void btnEliminarCLientes_Click_1(object sender, EventArgs e)
        {
            MostrarClientes();

            GestionarVentanas(new EliminarClientes());
        }

        private void bBuscarCliente_Click_1(object sender, EventArgs e)
        {
            if (tBusqueda.Text.Length == 0)
            {
                Operaciones.Mensaje("El Campo de Busqueda no Puede estar Vacio");

                MostrarClientes();
            }
        }

        private void tBusqueda_TextChanged_1(object sender, EventArgs e)
        {
            if (tBusqueda.Text.Length == 0)
            {
                MostrarClientes();
            }
            else
            {
                dataCliente.DataSource = LogicaCliente.BuscarCliente(tBusqueda.Text);
            }
        }

        private void bExportarClientes_Click_1(object sender, EventArgs e)
        {
            if (dataCliente.Rows.Count < 1)
            {
                Operaciones.Mensaje("No hay datos para Exportar");

            }
            else
            {
                FormExportarClientes clientes = new FormExportarClientes();
                clientes.ShowDialog();
            }

        }

        private void tabPage3_MouseHover(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void tabPage3_MouseMove(object sender, MouseEventArgs e)
        {
            MostrarClientes();
        }





        //Prestamos
        private void bCrearPrestamo_Click_1(object sender, EventArgs e)
        {
            MostrarPrestamos();
            GestionarVentanas(new CrearPrestamo());
        }

        private void bModificarPrestamo_Click_1(object sender, EventArgs e)
        {
            MostrarPrestamos();
            GestionarVentanas(new ModificarPrestamo());
        }

        private void bAnularPrestamo_Click_1(object sender, EventArgs e)
        {
            MostrarPrestamos();
            GestionarVentanas(new AnularPrestamo());
        }

        private void bBuscarPrestamo_Click_1(object sender, EventArgs e)
        {
            if (tBuscarPrestamo.Text.Length == 0)
            {
                Operaciones.Mensaje("El Campo de Busqueda no Puede estar Vacio");
                MostrarPrestamos();
            }
        }
        private void tBuscarPrestamo_TextChanged_1(object sender, EventArgs e)
        {
            if (tBuscarPrestamo.Text.Length == 0)
            {
                MostrarPrestamos();
            }
            else
            {
                int dato = int.Parse(tBuscarPrestamo.Text);
                dataPrestamo.DataSource = LogicaPrestamos.Prestamos(dato);
            }
        }

        private void bExportarPrestamos_Click(object sender, EventArgs e)
        {
            if (dataPrestamo.Rows.Count < 1)
            {
                Operaciones.Mensaje("No hay datos para Exportar");

            }
            else
            {
                FormExportarPrestamos prestamos = new FormExportarPrestamos();
                prestamos.ShowDialog();
            }

        }

        private void tabPage4_MouseMove(object sender, MouseEventArgs e)
        {
            MostrarPrestamos();
        }

        private void tabPage4_MouseHover(object sender, EventArgs e)
        {
            MostrarPrestamos();
        }




        //Reportes
        public void Calculos()
        {
            Operaciones procedimientoCalculos = new Operaciones();


            try
            {
                if (string.IsNullOrEmpty(tCalcularPrestamoReporte.Text.Trim()) == false)
                {
                    string comando = string.Format("Select * from Prestamos where idCliente='{0}'", EscogerCliente.IDCliente);
                    DataSet data = LogicaUsuarios.Ejecutar(comando);

                    int tasa = Convert.ToInt32(data.Tables[0].Rows[0]["Interes"]);
                    int plazo = Convert.ToInt32(data.Tables[0].Rows[0]["Tiempo"]);
                    DateTime fecha = Convert.ToDateTime(data.Tables[0].Rows[0]["Fecha"]);
                    int usuario = Convert.ToInt32(data.Tables[0].Rows[0]["idUsuario"]);
                    int cliente = Convert.ToInt32(data.Tables[0].Rows[0]["idCliente"]);
                    Int32 monto = Convert.ToInt32(data.Tables[0].Rows[0]["monto"]);
                    Int32 pagoextra = Convert.ToInt32(data.Tables[0].Rows[0]["pagoextra"]);

                    procedimientoCalculos.procedimiento(monto, tasa, plazo, fecha, pagoextra, dataReporte);
              
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }


        private void bSeleccionCliente_Click_1(object sender, EventArgs e)
        {
            EscogerCliente cliente = new EscogerCliente();
            cliente.ShowDialog();
            tCalcularPrestamoReporte.Text = EscogerCliente.CedulaCliente;

        }

        private void tCalcularPrestamoReporte_TextChanged_1(object sender, EventArgs e)
        {
            if (tCalcularPrestamoReporte.Text.Length == 0 || int.Parse(EscogerCliente.OpcionPrestamo) == 0)
            {
                dataReporte.Rows.Clear();
                lResultadoPagos.Text = "Total Pagos: " + 0;

            }
        }

        private void CalcularPrestamo_Click(object sender, EventArgs e)
        {

            if (tCalcularPrestamoReporte.Text == string.Empty)
            {
                Operaciones.Mensaje("Primero debe seleccionar el cliente para luego calcular el prestamo");

            }
            else
            {
                if (int.Parse(EscogerCliente.OpcionPrestamo) == 0)
                {

                    Operaciones.Mensaje("El Cliente que Selecciono No tiene un Prestamo Activo");
                }
                else
                {
                    
                    Calculos();
                    lResultadoPagos.Text = "Total Pagos: " + dataReporte.Rows.Count.ToString();
                    
                }
             
            }

        }

        private void bFacturar_Click(object sender, EventArgs e)
        {
            if (tCalcularPrestamoReporte.Text == string.Empty)
            {
                Operaciones.Mensaje("Para Facturar Debe seleccionar el cliente");
            }
            else
            {
                if (int.Parse(EscogerCliente.OpcionPrestamo) == 0)
                {
                    Operaciones.Mensaje("El Cliente que Selecciono No tiene un Prestamo Activo");
                    dataReporte.Rows.Clear();
                }
                else
                {
                    FrmGenerarFactura factura = new FrmGenerarFactura();
                    cedula = tCalcularPrestamoReporte.Text;
                    factura.ShowDialog();
                }

            }

        }

        private void PDF_Click(object sender, EventArgs e)
        {
            if (dataReporte.Rows.Count < 1)
            {
                Operaciones.Mensaje("No hay datos para Exportar a PDF");
            }
            else
            {
                if (int.Parse(EscogerCliente.OpcionPrestamo) == 0)
                {
                    Operaciones.Mensaje("El Cliente que Selecciono No tiene un Prestamo Activo");
                    dataReporte.Rows.Clear();
                }
                else
                {
                    Operaciones.ExportarPDF(dataReporte, EscogerCliente.NombreCliente + " " + EscogerCliente.CedulaCliente);
                }

            }


        }

        private void Excel_Click(object sender, EventArgs e)
        {
            if (dataReporte.Rows.Count < 1)
            {
                Operaciones.Mensaje("No hay datos para Exportar a EXCEL");
            }
            else
            {
                if (int.Parse(EscogerCliente.OpcionPrestamo) == 0)
                {
                    Operaciones.Mensaje("El Cliente que Selecciono No tiene un Prestamo Activo");
                    dataReporte.Rows.Clear();
                }
                else
                {
                    Operaciones.ExportarEXCEL(dataReporte, EscogerCliente.NombreCliente + " " + EscogerCliente.CedulaCliente);
                }

            }
        }

        private void bLimpiarReporte_Click(object sender, EventArgs e)
        {
            dataReporte.Rows.Clear();
            tCalcularPrestamoReporte.Clear();
            lResultadoPagos.Text = "Total Pagos: " + 0;
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerrarSeccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login inicio = new Login();
            this.Hide();
            inicio.ShowDialog();
        }

        private void salirDeLaAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}   
