using System;
using System.Windows.Forms;
using CapaLogicaNegocio;
namespace CapaPresentacionn
{
    public partial class CrearUsuario : Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void bLImpiarUsuario_Click(object sender, EventArgs e)
        {
            tNombre.Clear();
            tClave.Clear();
            tCorreo.Clear();
            tUsuario.Clear();
        }

        private void Error()
        {
            Operaciones.Mensaje("No campos Vacios");
            errorProvider1.SetError(tNombre, "Debe Ingresar el nombre");
            errorProvider1.SetError(tCorreo, "Debe ingresar el correo");
            errorProvider1.SetError(tClave, "Debe Ingresar la Clave");
            errorProvider1.SetError(cAcceso,"Debe Poner el tipo de acceso que tendra el usuario");
            errorProvider1.SetError(tUsuario,"Debe ingresar el nombre de usuario");
            errorProvider1.SetError(cAcceso, "Debe Seleccionar el Tipo de Acceso");

        }



        private void bGuardar_Click(object sender, EventArgs e)
        {
            
            try
            {
                int indice = cAcceso.SelectedIndex;

                if (tNombre.Text == string.Empty || tCorreo.Text == string.Empty || tClave.Text == string.Empty ||
                    cAcceso.Text == string.Empty || tUsuario.Text == string.Empty || cAcceso.GetItemText(cAcceso.Items[indice]) == string.Empty)
                {
                    Error();
                }
                else
                {
                    
                    if (Operaciones.ValidarEmail(tCorreo.Text) == false)
                    {
                        Operaciones.Mensaje("Debe Ingresar un Email Valido");
                    }
                    else
                    {
                        LogicaUsuarios.Ingresar(tNombre.Text.Trim(), tCorreo.Text.Trim(), "Activo"
                    , cAcceso.GetItemText(cAcceso.Items[indice]), tUsuario.Text.Trim()
                    , Encriptar.encriptar(tClave.Text));

                        Operaciones.Mensaje("Usuario Guardado Correctamente");
                        this.Close();
                    }
                }
            }
            catch (Exception error)
            {
                Operaciones.Mensaje("Debe seleccionar El tipo de Acceso");
            }
        }


    }
}
