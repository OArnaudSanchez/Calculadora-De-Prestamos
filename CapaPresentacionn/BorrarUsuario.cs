using System;
using System.Windows.Forms;
using CapaLogicaNegocio;

namespace CapaPresentacionn
{
    public partial class BorrarUsuario : Form
    {

        public BorrarUsuario()
        {
            InitializeComponent();
        }

        private void bBorrarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (tID.Text == string.Empty)
                {

                    Operaciones.Mensaje("No Campos Vacios");
                }
                else
                {

                    LogicaUsuarios.Eliminar(int.Parse(tID.Text));

                    MessageBox.Show("Usuario Borrado Correctamente");
                    this.Close();
                }

                tID.Clear();

            }
            catch (Exception error)
            {

                Operaciones.Mensaje("Ha ocurrido un error al Borrar el Usuario");
            }
        }

    }
}
