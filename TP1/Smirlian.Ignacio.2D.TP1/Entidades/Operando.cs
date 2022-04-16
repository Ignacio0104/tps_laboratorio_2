using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        private string SetNumero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        public Operando():this(0)
        {
         
        }

        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando (string numero)
        {
            this.SetNumero = numero;
        }

        /// <summary>
        /// Valida que el input sea efectivamente un numero valido
        /// </summary>
        /// <param name="strNumero">recibe el input en formato string</param>
        /// <returns>Devuelve el string convertido a double o 0 si hubo un error</returns>
        private double ValidarOperando(string strNumero)
        {
            double numero = 0;

            double.TryParse(strNumero, out numero);

            return numero;

        }

        /// <summary>
        /// Valida que el input sea un numero binario valido
        /// </summary>
        /// <param name="binario">recibe el input en formato string</param>
        /// <returns>Devuelve true si es binario o false si no lo es</returns>
        private static bool EsBinario(string binario)
        {
            for (int i = 0; i < binario.Length; i++)
            {
                if(binario[i] != '1' && binario[i] != '0')
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Convierte un numero (formato double) a binario (string)
        /// </summary>
        /// <param name="numero">recibe el numero en formato double</param>
        /// <returns>Devuelve el numero convertido, o una cadena vacia si hubo un error</returns>
        public static string DecimalBinario (double numero)
        {
            string numeroBinario = "";
            int numeroInt = (int)numero;
  
            while (numeroInt > 0)
            {
                string digito = (numeroInt % 2).ToString();
                numeroBinario = digito + numeroBinario;
                numeroInt = Math.Abs(numeroInt) / 2;
            }

            while (numeroBinario.Length < 4)
            {
                numeroBinario = "0" + numeroBinario;
            }

            return numeroBinario;
        }

        /// <summary>
        /// Convierte un numero (formato string) a binario (string)
        /// </summary>
        /// <param name="numero">recibe el numero en formato string</param>
        /// <returns>Devuelve el numero binario convertido o mensaje de error</returns>
        public static string DecimalBinario(string numero)
        {
            double numeroRevisado = 0;

            if(double.TryParse(numero, out numeroRevisado))
            {
                return DecimalBinario(Math.Abs(numeroRevisado));
            }
            else
            {
                return "Valor invalido";
            }

        }

        /// <summary>
        /// Convierte un numero binario (formato string) en decimal (string)
        /// </summary>
        /// <param name="binario">recibe el numero binario en formato string</param>
        /// <returns>Devuelve el numero decimal en formato string o un mensaje de error</returns>
        public static string BinarioDecimal(string binario)
        {
            double result = 0;
            if (EsBinario(binario))
            {
                int potencia = binario.Length - 1;
                for (int i = 0; i < binario.Length; i++)
                {
                    if (binario[i] is '1')
                    {
                        result += (int)Math.Pow(2, potencia);
                    }
                    potencia--;
                }

                return Math.Abs(result).ToString();
            }
            else
            {
                return "Valor invalido";
            }

        }

        /// <summary>
        /// Recibe 2 objetos de clase Operando y devuelve la suma entre sus atributos numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator + (Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Recibe 2 objetos de clase Operando y devuelve la resta entre sus atributos numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Recibe 2 objetos de clase Operando y devuelve la multriplicacion entre sus atributos numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Recibe 2 objetos de clase Operando y devuelve la división entre sus atributos numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Devuelve el resultado o double.MinValue si se dividió por cero</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            if (n2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return n1.numero / n2.numero;
            }
            
        }
    }
}
