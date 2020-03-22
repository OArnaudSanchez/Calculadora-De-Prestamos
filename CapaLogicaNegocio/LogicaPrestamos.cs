using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;
namespace CapaLogicaNegocio
{
   public class LogicaPrestamos
    {

        public static string Ingresar(int interes, 
          int tiempo, DateTime fecha, int usuario, int cliente, string estado,double monto)
        {
            DatosPrestamos prestamo = new DatosPrestamos();
            prestamo.Interes = interes;
            prestamo.Tiempo = tiempo;
            prestamo.Fecha = fecha;
            prestamo.Idusuario = usuario;
            prestamo.Idcliente = cliente;
            prestamo.Estado = estado;
            prestamo.Monto = monto;
           return prestamo.Ingresar(prestamo);           
        }



        public static string Modificar(int id,int interes, 
          int tiempo, DateTime fecha, int usuario, int cliente, string estado,double monto)
        {
            DatosPrestamos prestamo = new DatosPrestamos();
            prestamo.Idprestamo = id;
            prestamo.Interes = interes;
            prestamo.Tiempo = tiempo;
            prestamo.Fecha = fecha;
            prestamo.Idusuario = usuario;
            prestamo.Idcliente = cliente;
            prestamo.Estado = estado;
            prestamo.Monto = monto;
            return prestamo.Modificar(prestamo);
        }

        public static string Anular(int id)
        {
            DatosPrestamos prestamo = new DatosPrestamos();
            prestamo.Idprestamo = id;
           return prestamo.Anular(prestamo);
        }     
      
        public static DataTable Prestamos(int id)
        {
            DatosPrestamos prestamo = new DatosPrestamos();
            prestamo.Idprestamo = id;
           return prestamo.BuscarPrestamoID(prestamo);
        }

        public static DataTable Todo()
        {
            DatosPrestamos prestamo = new DatosPrestamos();

            return prestamo.MostrarTodo();
        }
    }
}
