using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
namespace CapaLogicaNegocio
{
    public class LogicaCliente
    {
        
        public static string Insertar(string cedula, string nombre,string apellido,DateTime fecha,int edad,string direccion
            ,string telefono,string celular, int user)
        {
            DatosCliente cliente = new DatosCliente();

            cliente.Cedula = cedula;
            cliente.Nombre = nombre;
            cliente.Apellido = apellido;
            cliente.Fechanacimiento = fecha;
            cliente.Edad = edad;
            cliente.Direccion = direccion;
            cliente.Telefono = telefono;
            cliente.Celular = celular;
            cliente.idUser = user;

            return cliente.Ingresar(cliente);

        }


        public static string Modificar(int id, string cedula, string nombre, string apellido, DateTime fecha, int edad, string direccion
            , string telefono, string celular, int user)
        {
            DatosCliente cliente = new DatosCliente();
            cliente.Idcliente = id;
            cliente.Cedula = cedula;
            cliente.Nombre = nombre;
            cliente.Apellido = apellido;
            cliente.Fechanacimiento = fecha;
            cliente.Edad = edad;
            cliente.Direccion = direccion;
            cliente.Telefono = telefono;
            cliente.Celular = celular;
            cliente.idUser = user;
            return cliente.Modificar(cliente);
        }

        public static string Eliminar(int id)
        {
            DatosCliente cliente = new DatosCliente();
            cliente.Idcliente = id;
            return cliente.Eliminar(cliente);
        }

        public static DataTable Mostrar()
        {
            DatosCliente cliente = new DatosCliente();
            return cliente.MostrarTodo();
        }

        public static DataTable BuscarCliente(string busqueda)
        {
            DatosCliente cliente = new DatosCliente();
            cliente.Nombre = busqueda;
            return cliente.BuscarCliente(cliente);
        }
    }
}
