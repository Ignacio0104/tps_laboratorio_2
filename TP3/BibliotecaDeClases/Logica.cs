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
            if (!dato.All(char.IsDigit) || (dato.Length<8 || dato.Length>10))
            {
                return false;
            }

            return true;
        }

        public static bool VerificarTarjetaCredito(string dato)
        {
            if ((dato[0]!= '5'&& dato[0] != '4' && dato[0] != '3') || (dato.Length != 16 && dato.Length != 15) || !dato.All(char.IsNumber))
            {
                return false;
            }

            return true;
        }

        public static bool VerificarEmail(string dato)
        { 
            if (dato.Length < 6)
                return false;
            StringBuilder finalEmail = new StringBuilder();    
            int indexArroba = 0;
            int contadorArroba = 0;
            int contadorPuntos = 0;
            for (int i = 0; i < dato.Length; i++)
            {
                if (dato[i] == '@')
                {
                    indexArroba = i;
                    contadorArroba++;
                }

                if(indexArroba>0)
                {
                    if(dato[i]!='@')
                        finalEmail.Append(dato[i]);
                    if (finalEmail.ToString().Any(char.IsNumber))
                    {
                        return false;
                    }
                }                                      
            }
            if (finalEmail.ToString().Any(char.IsPunctuation))
            {
                contadorPuntos++;
                if (contadorPuntos > 3)
                {
                    return false;
                }
            }
            if (finalEmail.ToString().Length<3)
                return false;
            if (contadorArroba != 1)
                return false;
            return true;    
        }
    }
}
