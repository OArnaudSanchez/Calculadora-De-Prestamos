using System;
using System.Windows.Forms;
using CapaLogicaNegocio;

namespace CapaPresentacionn
{
    public partial class EscogerPrestamo : Form
    {

        public static string IDPrestamo;
        public static string IDCliente;
        public static string NombreCliente;
        public static string Monto;
        public static string Interes;
        public static string Tiempo;


        public EscogerPrestamo()
        {
            InitializeComponent();
        }

        

        private void Mostrar()
        {
            dataGridView1.DataSource = LogicaPrestamos.Todo();
        }


        private void EscogerPrestamo_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        //Mostrar un mensaje de ayuda cuando se pase el mouse por encima de un componente
        private void EscogerPrestamo_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(dataGridView1, "Haga Doble Click EN el Prestamo que Desea");

        }

        private void dataGridView1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(dataGridView1, "Haga Doble Click EN el Prestamo que Desea");
        }

        private void tBuscarPrestamo_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(tBuscarPrestamo, "Busque un Prestamo por su ID y luego Haga doble Click en dicho Prestamo para Seleccionarlo");

        }



        private void tBuscarPrestamo_TextChanged(object sender, EventArgs e)
        {
            if (tBuscarPrestamo.Text.Length == 0)
            {
                Mostrar();
            }
            else
            {
                dataGridView1.DataSource = LogicaPrestamos.Prestamos(int.Parse(tBuscarPrestamo.Text));
                tBuscarPrestamo.Text = IDPrestamo;
            }
        }


        //Al hacer doble click se selecciona el cliente
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IDPrestamo = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            NombreCliente = dataGridView1.Rows[e.RowIndex].Cells["Cliente"].Value.ToString();
            IDCliente = dataGridView1.Rows[e.RowIndex].Cells["ID Cliente"].Value.ToString();
            Monto = dataGridView1.Rows[e.RowIndex].Cells["Monto"].Value.ToString();

            Interes = dataGridView1.Rows[e.RowIndex].Cells["Interes"].Value.ToString();
            Tiempo = dataGridView1.Rows[e.RowIndex].Cells["Periodo en Años"].Value.ToString();

            if (IDPrestamo == "")
            {
                Operaciones.Mensaje("Seleccione una fila para seleccionar el Prestamo");
            }
            else
            {

                this.Close();
            }
        }

      
    }
}
