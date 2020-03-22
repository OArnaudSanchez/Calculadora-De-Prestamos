using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class DatosCliente
    {
        private int idcliente;
        private string nombre;
        private string apellido;
        private string cedula;
        private DateTime fechanacimiento;
        private int edad;
        private string direccion;
        private string telefono;
        private string celular;
        private string buscar;
        private int iduser;

        public int Idcliente {
            get { return idcliente; }
            set { idcliente = value; }
        }
        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Cedula {
            get { return cedula; }
            set { cedula = value; }
        }
        public DateTime Fechanacimiento {
            get { return fechanacimiento; }
            set { fechanacimiento = value; }
        }
        public int Edad {
            get { return edad; }
            set { edad = value; }
        }
        public string Direccion {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Telefono {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Celular {
            get { return celular; }
            set { celular = value; }
        }
        public string Buscar {
            get { return buscar; }
            set { buscar = value; }
        }

        public int idUser
        {
            get { return iduser; }
            set { iduser = value; }
        }

        public DatosCliente()
        {

        }
        public DatosCliente(int id,string nombre,string apellido,string cedula,DateTime fecha,
            int edad,string direccion,string telefono,string celular,string buscar)
        {
            Idcliente = id;
            Nombre = nombre;
            Apellido = apellido;
            Cedula = cedula;
            fechanacimiento = fecha;
            Edad = edad;
            Direccion = direccion;
            Telefono = telefono;
            Celular = celular;
            Buscar = buscar;
        }
        SqlConnection conexion = new SqlConnection();
        


        SqlCommand comando;
        string query = "";
        
        

        public string Ingresar(DatosCliente cliente)
        {
            SqlCommand comando;
            conexion.ConnectionString = Conexion.CadenaConexion;

            conexion.Open();
            query = $"Exec InsertarCliente '{cliente.Nombre}','{cliente.Apellido}','{cliente.Cedula}','{cliente.Fechanacimiento}','{cliente.Edad}','{cliente.Direccion}','{cliente.Telefono}','{cliente.Celular}'";

            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            return "OK";
        }

        public string Modificar(DatosCliente cliente)
        {
            conexion.ConnectionString = Conexion.CadenaConexion;
            conexion.Open();
            query = $"Exec ModificarCliente '{cliente.Idcliente}','{cliente.Nombre}','{cliente.Apellido}','{cliente.Cedula}','{cliente.Fechanacimiento}'" +
                $",'{cliente.Edad}','{cliente.Direccion}','{cliente.Telefono}','{cliente.Celular}'";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            return "OK";
        }

        public string Eliminar(DatosCliente cliente)
        {
            conexion.ConnectionString = Conexion.CadenaConexion;
            conexion.Open();
            query = $"Exec EliminarCliente '{cliente.Idcliente}'";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            return "OK";
        }


        public DataTable BuscarCliente(DatosCliente cliente)
        {
            conexion.ConnectionString = Conexion.CadenaConexion;
            conexion.Open();

            query = $"Exec BuscarCliente '{cliente.nombre}'";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            DataTable tabla = new DataTable();

            adaptador.Fill(tabla);
            conexion.Close();
            return tabla;
        }

        public DataTable MostrarTodo()
        {
            conexion.ConnectionString = Conexion.CadenaConexion;
            conexion.Open();
            query = $"Exec ExportarClientes";
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
