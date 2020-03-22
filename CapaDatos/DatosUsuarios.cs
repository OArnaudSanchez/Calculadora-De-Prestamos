using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class DatosUsuarios
    {
        private int iduser;
        private string nombre;
        private string correo;
        private string estado;
        private string acceso;
        private string usuario;
        private string clave;
        private string buscar;

        public int Iduser {
            get { return iduser; }
            set { iduser = value; }
        }
        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Correo {
            get { return correo; }
            set { correo = value; }
        }
        public string Estado {
            get { return estado; }
            set { estado = value; }
        }
        public string Acceso {
            get { return acceso; }
            set { acceso = value; }
        }
        public string Usuario {
            get { return usuario; }
            set { usuario = value; }
        }
        public string Clave {
            get { return clave; }
            set { clave = value; }
        }
        public string Buscar {
            get { return buscar; }
            set { buscar = value; }
        }

        public DatosUsuarios()
        {

        }

        public DatosUsuarios(int id,string nombre,string correo,string estado,string acceso,string usuario,string clave, string buscar)
        {
            Iduser = id;
            Nombre = nombre;
            Correo = correo;
            Estado = estado;
            Acceso = acceso;
            Usuario = usuario;
            Clave = clave;
            Buscar = buscar;
        }

        SqlConnection conexion = new SqlConnection();
        SqlCommand comando;
        string query = "";

        public string Ingresar(DatosUsuarios usuario)
        {
            conexion.ConnectionString = Conexion.CadenaConexion;
            conexion.Open();

             query = $"Exec InsertarUsuario '{usuario.nombre}','{usuario.correo}','{usuario.estado}'" +
                $",'{usuario.acceso}','{usuario.usuario}','{usuario.clave}'";
            comando = new SqlCommand(query,conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            return "Se inserto correctamente";
        }

        public string Modificar(DatosUsuarios usuario) {
            conexion.ConnectionString = Conexion.CadenaConexion;
            conexion.Open();
            query = $"Exec ModificarUsuario '{usuario.iduser}','{usuario.nombre}','{usuario.correo}','{usuario.estado}'" +
                $",'{usuario.acceso}','{usuario.usuario}','{usuario.clave}'";
            comando = new SqlCommand(query,conexion);
            comando.ExecuteNonQuery();
            conexion.Close();

            return "Se modifico correctamente";

        }
        public string Eliminar(DatosUsuarios usuario)
        {
            conexion.ConnectionString = Conexion.CadenaConexion;
            conexion.Open();
            query = $"Exec EliminarUsuario '{usuario.Iduser}'";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();

            return "Se elimino Correctamente";
        }
        public DataTable MostrarTodo()
        {
            conexion.ConnectionString = Conexion.CadenaConexion;
            conexion.Open();
            query = $"Exec ExportarUsuarios";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            DataTable tabla = new DataTable();

            adaptador.Fill(tabla);
            conexion.Close();
            return tabla;
        }

        public DataTable BuscarUsuario(DatosUsuarios usuario)
        {
            conexion.ConnectionString = Conexion.CadenaConexion;
            conexion.Open();

            query = $"Exec BuscarUsuario '{usuario.nombre}'";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            DataTable tabla = new DataTable();

            adaptador.Fill(tabla);
            conexion.Close();
            return tabla;
        }
    }
}
