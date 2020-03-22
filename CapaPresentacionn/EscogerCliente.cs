using System;
using System.Data;
using System.Windows.Forms;
using CapaLogicaNegocio;
namespace CapaPresentacionn
{
    public partial class EscogerCliente : Form
    {

        public static string CedulaCliente;
        public static string NombreCliente;
        public static string IDCliente;
        public static string OpcionPrestamo;
        public static string Apellidos;
        public static string Telefono;
        public static string Celular;
        public static string Direccion;
        public static string OpcionCedula;
        public static string OpcionTelefono;
        public static string OpcionCelular;

        public EscogerCliente()
        {
            InitializeComponent();
        }

    
        private void Mostrar()
        {
            dataGridView1.DataSource = LogicaCliente.Mostrar();
        }

        private void EscogerCliente_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        //Mensajes de ayuda en cada componente
        private void EscogerCliente_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(dataGridView1, "Haga Doble Click EN el Cliente que Desea");
        }

        private void dataGridView1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(dataGridView1, "Haga Doble Click EN el Cliente que Desea");
        }

        private void tBuscar_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(tBuscar, "Busque un Cliente por su Nombre y luego Haga doble Click en dicho Cliente para Seleccionarlo");

        }

        private void tBuscar_TextChanged(object sender, EventArgs e)
        {
            if (tBuscar.Text.Length == 0)
            {
                Mostrar();
            }
            else
            {
                dataGridView1.DataSource = LogicaCliente.BuscarCliente(tBuscar.Text);
            }
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CedulaCliente = dataGridView1.Rows[e.RowIndex].Cells["Cedula"].Value.ToString();
            NombreCliente = dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            IDCliente = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            Apellidos = dataGridView1.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
            Telefono = dataGridView1.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();

            Celular = dataGridView1.Rows[e.RowIndex].Cells["Celular"].Value.ToString();
            Direccion = dataGridView1.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();

            if (CedulaCliente == "")
            {
                MessageBox.Show("Seleccione una fila para seleccionar el cliente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Consulta para contar la cantidad de prestamos que tiene el cliente
                string comando = string.Format($"select count(idPrestamo) as Conteo from Prestamos where idCliente='{EscogerCliente.IDCliente}'");
                DataSet data = LogicaUsuarios.Ejecutar(comando);
                OpcionPrestamo = data.Tables[0].Rows[0]["Conteo"].ToString().Trim();


                //Consulta para seleccionar un cliente en especifico
                 comando = string.Format($"select *  from Clientes where idClient='{EscogerCliente.IDCliente}'");
                 data = LogicaUsuarios.Ejecutar(comando);

                OpcionCedula = data.Tables[0].Rows[0]["Cedula"].ToString().Trim();
                OpcionCelular = data.Tables[0].Rows[0]["Celular"].ToString().Trim();
                 OpcionTelefono = data.Tables[0].Rows[0]["Telefono"].ToString().Trim();


                this.Close();
            }
        }

       
    }
}
