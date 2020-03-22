using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;
namespace CapaLogicaNegocio
{
    public class LogicaUsuarios
    {

        //public static string Insertar(string nombre, string correo, string estado, string acceso, string usuarioo, string clave)
        //{
        //    DatosUsuarios usuario = new DatosUsuarios();
        //    usuario.Nombre = nombre;
        //    usuario.Correo = correo;
        //    usuario.Estado = estado;
        //    usuario.Acceso = acceso;
        //    usuario.Usuario = usuarioo;
        //    usuario.Clave = clave;

        //    return usuario.Insertar(usuario);

        //}

        public static string Ingresar(string nombre, string correo, string estado, string acceso, string usuarioo, string clave)
        {
            DatosUsuarios usuario = new DatosUsuarios();
            usuario.Nombre= nombre;
            usuario.Correo = correo;
            usuario.Estado = estado;
            usuario.Acceso = acceso;
            usuario.Usuario = usuarioo;
            usuario.Clave = clave;

           return usuario.Ingresar(usuario);
            
        }

        public static string Modificar(int id,string nombre, string correo, string estado, string acceso, string usuarioo, string clave)
        {
            DatosUsuarios usuario = new DatosUsuarios();
            usuario.Iduser = id;
            usuario.Nombre = nombre;
            usuario.Correo = correo;
            usuario.Estado = estado;
            usuario.Acceso = acceso;
            usuario.Usuario = usuarioo;
            usuario.Clave = clave;

            return usuario.Modificar(usuario);
        }

        public static string Eliminar(int id)
        {
            DatosUsuarios usuario = new DatosUsuarios();
            usuario.Iduser = id;
           return  usuario.Eliminar(usuario);
        }

        public static DataTable Mostrar()
        {
            DatosUsuarios usuario = new DatosUsuarios();

            return usuario.MostrarTodo();
        }

        public static DataTable Buscar(string nombre)
        {
            DatosUsuarios usuario = new DatosUsuarios();
            usuario.Nombre = nombre;

            return usuario.BuscarUsuario(usuario);
        }

        public static DataSet Ejecutar(string codigo)
        {
            //Creacion de la coneccion a la base de datos
            SqlConnection con = new SqlConnection("Data Source = DESKTOP-NBEBLU8; Initial Catalog = Proyecto_FinalP2; Integrated Security = True");

            //Dataset para pasar y recibir los datos
            DataSet data = new DataSet();

            //Adaptar los datos a un formato soportado
            SqlDataAdapter adapter = new SqlDataAdapter(codigo, con);

            //Llenar las tablas o matriz donde se transportaran los datos
            adapter.Fill(data);

            //Cierre de la coneccion a la base de datos
            con.Close();

            //retornando el dataset
            return data;
        }

        //public static DataTable Login(string usuarioo,string clave)
        //{
        //    DatosUsuarios usuario = new DatosUsuarios();
        //    usuario.Usuario = usuarioo;
        //    usuario.Clave = clave;
        //    return usuario.BuscarUsuario(usuario);
        //}
    }
}
