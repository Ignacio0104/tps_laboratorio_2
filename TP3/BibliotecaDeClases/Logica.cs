using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class Logica
    {
        public static bool VerificarTelefonoArgentina(string dato)
        {
            if (!dato.All(char.IsDigit) || (dato.Length != 8 || dato.Length != 10))
            {
                return false;
            }

            return true;
        }

        public static bool VerificarTarjetaCredito(string dato)
        {
            if (!dato.StartsWith("4") || !dato.StartsWith("5") || !dato.StartsWith("3")
                || dato.Length != 16 || dato.Length != 15)
            {
                return false;
            }

            return true;
        }

        public static bool VerificarEmail(string dato)
        {
            if (new EmailAddressAttribute().IsValid(dato))
            {
                if ((int)dato[dato.Length] < 122 && (int)dato[dato.Length] > 97)
                    return true;
            }

            return false;
        }
    }
}
