using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class DatosPrestamos
    {
        private int idprestamo;
        private int interes;
        private int capital;
        private int tiempo;
        private DateTime fecha;
        private int cuotas;
        private int idusuario;
        private int idcliente;
        private string estado;
        private DateTime fechainicial;
        private DateTime fechafinal;
        private double monto;


        public int Idprestamo {
            get { return idprestamo; }
            set { idprestamo = value; }
        }
        public int Interes {
            get { return interes; }
            set { interes = value; }
        }
        public int Capital {
            get { return capital; }
            set { capital = value; }
        }
        public int Tiempo {
            get { return tiempo; }
            set { tiempo = value; }
        }
        public DateTime Fecha {
            get { return fecha; }
            set { fecha = value; }
        }
        public int Cuotas {
            get { return cuotas; }
            set { cuotas = value; }
        }
        public int Idusuario {
            get { return idusuario; }
            set { idusuario = value; }
        }
        public int Idcliente {
            get { return idcliente; }
            set { idcliente = value; }
        }
        public string Estado {
            get { return estado; }
            set { estado = value; }
        }
        public DateTime FechaInicial {
            get { return fechainicial; }
            set { fechainicial = value; }
        }
        public DateTime FechaFinal {
            get { return fechafinal; }
            set { fechafinal = value; }
        }

        public double Monto {
            get { return monto; }
            set { monto = value; }
        }

        public DatosPrestamos()
        {

        }
        public DatosPrestamos(int id, double monto, int interes, int capital,
            int tiempo, DateTime fecha, int cuotas, int usuario, int cliente, string estado, DateTime fechainicial, DateTime fechafinal)
        {
            Idprestamo = id;
            Monto = monto;
            Interes = interes;
            Capital = capital;
            Tiempo = tiempo;
            Fecha = fecha;
            Cuotas = cuotas;
            Idusuario = usuario;
            Idcliente = cliente;
            Estado = estado;
            FechaInicial = fechainicial;
            FechaFinal = fechafinal;
        }

        SqlConnection conexion = new SqlConnection();
        SqlCommand comando;
        string query = "";

        public string Ingresar(DatosPrestamos prestamo)
        {
            conexion.ConnectionString = Conexion.CadenaConexion;
            SqlCommand comando;

            conexion.Open();
            query = $"Exec InsertarPrestamo '{prestamo.Interes}','{prestamo.Tiempo}','{prestamo.Fecha}','{prestamo.Idusuario}','{prestamo.Idcliente}','{prestamo.Estado}','{prestamo.Monto}'";

            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            return "OK";
        }

        public string Modificar(DatosPrestamos prestamo)
        {
            conexion.ConnectionString = Conexion.CadenaConexion;
            conexion.Open();
            query = $" Exec ModificarPrestamo '{prestamo.Idprestamo}','{prestamo.Interes}','{prestamo.Tiempo}','{prestamo.Fecha}','{prestamo.Idusuario}','{prestamo.Idcliente}','{prestamo.Estado}','{prestamo.Monto}'";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            return "OK";
        }

        public string Anular(DatosPrestamos prestamo)
        {
            conexion.ConnectionString = Conexion.CadenaConexion;
            conexion.Open();
            query = $"AnularPrestamo '{prestamo.Idprestamo}'";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            return "OK";
        }


        public DataTable BuscarPrestamoID(DatosPrestamos prestamo)
        {//Buscar Prestamos por el nombre del cliente
            conexion.ConnectionString = Conexion.CadenaConexion;
            conexion.Open();


            query = $"Exec BuscarPrestamoID '{prestamo.Idprestamo}'";
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
            query = $"Exec MostrarPrestamos";
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
