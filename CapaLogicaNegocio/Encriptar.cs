using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CapaLogicaNegocio
{
    public class Encriptar
    {

        public static string encriptar(string campo)
        {
            string resultado = string.Empty;

            Byte[] encriptar = System.Text.Encoding.Unicode.GetBytes(campo);//rellena el arreglo de byte con el campo especificado
            resultado = Convert.ToBase64String(encriptar);

            return resultado;
        }

        public static string Desencriptar(string campo)
        {
            string resultado = string.Empty;
            Byte[] desencriptar = Convert.FromBase64String(campo);

            resultado = System.Text.Encoding.Unicode.GetString(desencriptar);
            return resultado;
        }
    }
}
