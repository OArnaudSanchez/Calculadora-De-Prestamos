using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Windows.Forms;
using CapaLogicaNegocio;
namespace CapaPresentacionn
{
    public partial class ModificarUsuario : Form
    {
        public ModificarUsuario()
        {
            InitializeComponent();
        }

        private string estado;

        private void bLImpiarUsuario_Click(object sender, EventArgs e)
        {
            tNombre.Clear();
            tClave.Clear();
            tCorreo.Clear();
            tUsuario.Clear();
            tID.Clear();
        }

        private string Estatus()
        {
            if (rActivo.Checked)
            {
                estado = "Activo";
            }
            if (rInactivo.Checked)
            {
                estado = "Inactivo";
            }

            return estado;
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tID.Text == string.Empty || tNombre.Text == string.Empty || tCorreo.Text == string.Empty || tClave.Text == string.Empty ||
                   tUsuario.Text == string.Empty)
                {

                    Operaciones.Mensaje("No campos Vacios");
                }
                else
                {

                    int indice = cAcceso.SelectedIndex;

                    if (Operaciones.ValidarEmail(tCorreo.Text) == false)
                    {
                        Operaciones.Mensaje("Debe Ingresar un Email Valido");
                    }
                    else
                    {
                        LogicaUsuarios.Modificar(int.Parse(tID.Text), tNombre.Text.Trim(), tCorreo.Text.Trim(), Estatus()
                       , cAcceso.GetItemText(cAcceso.Items[indice]), tUsuario.Text.Trim()
                       , Encriptar.encriptar(tClave.Text));

                        Operaciones.Mensaje("Usuario Modificado Correctamente");
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
