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
            if (!new EmailAddressAttribute().IsValid(dato))
            {
                if (dato.Length < 6)
                    return false;
                string finalEmail = "";    
                int indexArroba = 0;
                int contadorPuntos = 0;
                for (int i = 0; i < dato.Length; i++)
                {
                    if (dato[i] == '@')
                    {
                        indexArroba = i;
                    }

                    if(indexArroba>0)
                    {
                        finalEmail.Append(dato[i]);
                    }                                      
                    if (indexArroba != 1)
                        return false;
                    if (finalEmail.Any(char.IsDigit))
                    {
                        return false;
                    }

                    if (!finalEmail.Any(char.IsPunctuation))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
