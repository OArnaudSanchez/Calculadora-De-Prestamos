using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DatosFactura
    {
        private double totalpago;
        private double interes;
        private int prestamo;
        private int cliente;
        private int usuario;

        public double TotalPago { get { return totalpago; } set { totalpago = value; } }
        public double InteresTotal { get { return interes; } set { interes = value; } } 
        public int  idPrestamo { get { return prestamo; } set{ prestamo = value; } }
        public int idCliente { get { return cliente; } set { cliente = value; } }
        public int idUsuario { get { return usuario; } set { usuario = value; } }


        SqlConnection conexion = new SqlConnection();
        SqlCommand comando;
        string query = "";

        public string Ingresar(DatosFactura factura)
        {
            conexion.ConnectionString = Conexion.CadenaConexion;
            SqlCommand comando;
            conexion.Open();
            query = $"exec InsertarFactura '{factura.TotalPago}','{factura.InteresTotal}' ,'{factura.idPrestamo}'," +
                $"'{factura.idCliente}','{factura.idUsuario}'";

            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            return "OK";
        }
    }
}
