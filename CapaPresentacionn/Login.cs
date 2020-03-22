using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CapaLogicaNegocio;

namespace CapaPresentacionn
{
    public partial class Login : Form
    {

        public static string nom;
        public static string id;


        public Login()
        {
            InitializeComponent();
        }


        private void Login_Load(object sender, EventArgs e)
        {
            tContra.UseSystemPasswordChar = false;

        }


        //Configurando un ejecto Hover en los textbos
        private void tCorreo_Enter(object sender, EventArgs e)
        {
            if (tUsuario.Text == "USUARIO")
            {
                tUsuario.Text = "";
                tUsuario.ForeColor = Color.LightGray;
            }
        }

        private void tContra_Enter(object sender, EventArgs e)
        {
            if (tContra.Text == "PASSWORD")
            {
                tContra.Text = "";
                tContra.ForeColor = Color.LightGray;
                tContra.UseSystemPasswordChar = false;
            }
        }

        private void tCorreo_Leave(object sender, EventArgs e)
        {
            if (tUsuario.Text == "")
            {
                tUsuario.Text = "USUARIO";
                tUsuario.ForeColor = Color.DimGray;
            }
        }

        private void tContra_Leave(object sender, EventArgs e)
        {
            if (tContra.Text == "")
            {

                tContra.Text = "PASSWORD";
                tContra.ForeColor = Color.DimGray;
                tContra.UseSystemPasswordChar = true;
            }
        }




        private void bIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                //Consulta para obtener los datos de quien hace el login 
                string codigo = string.Format("Select * from Usuarios where Usuario='{0}'", tUsuario.Text.Trim());
                DataSet set = LogicaUsuarios.Ejecutar(codigo);

                string Nombre = set.Tables[0].Rows[0]["Nombre"].ToString().Trim();
                string idU = set.Tables[0].Rows[0]["idUser"].ToString().Trim();

                string contra = set.Tables[0].Rows[0]["Clave"].ToString().Trim();
                string usuario = set.Tables[0].Rows[0]["Usuario"].ToString().Trim();

                
                if (usuario == tUsuario.Text.Trim() && Encriptar.Desencriptar(contra) == tContra.Text.Trim())
                {

                    //Enviando los datos de quien hace el login a la app principal
                    Aplicacion aplicacion = new Aplicacion();

                    nom = Nombre;
                    id = idU;
                    aplicacion.idUsuario = set.Tables[0].Rows[0][0].ToString();
                    aplicacion.nombre = set.Tables[0].Rows[0][1].ToString();
                    aplicacion.acceso = set.Tables[0].Rows[0][4].ToString();
           
                    aplicacion.Show();
                    this.Hide();
                }

                else
                {
                   Operaciones.Mensaje("El usuario o la clave no son correctos");
                }
            }
            catch (Exception error)
            {
                Operaciones.Mensaje("El usuario o la clave no son correctos");
                tUsuario.Text = "USUARIO";
                tContra.Text = "PASSWORD";
            }

        }

        

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
    }
}
