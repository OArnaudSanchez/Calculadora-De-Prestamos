using System;
using System.Windows.Forms;
using CapaLogicaNegocio;

namespace CapaPresentacionn
{
    public partial class EliminarClientes : Form
    {

        public EliminarClientes()
        {
            InitializeComponent();
        }

        private void bSeleccionCliente_Click_1(object sender, EventArgs e)
        {
            //Seleccionar el Cliente y colocar su ID en el textbox
            EscogerCliente cliente = new EscogerCliente();
            cliente.ShowDialog();
            tID.Text = EscogerCliente.IDCliente;
        }


        private void bBorrarUsuario_Click(object sender, EventArgs e)
        {

            try
            {
                if (tID.Text == "")
                {
                    errorProvider1.SetError(tID,"Debe colocar el ID");
                }
                else
                {

                    if (MessageBox.Show("Desea Eliminar este Cliente", "!Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {

                        LogicaCliente.Eliminar(int.Parse(tID.Text));
                        Operaciones.Mensaje("Cliente Eliminado");
                        this.Close();
                    }
                }


            }
            catch (Exception error)
            {
                Operaciones.Mensaje("Este cliente no se puede Eliminar, Tiene prestamos pendiente");
            }
        }
    }
}
