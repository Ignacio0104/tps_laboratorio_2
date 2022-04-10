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

        public Operando():this(0)
        {
         
        }

        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando (string numero)
        {
            this.numero = ValidarOperando(numero);
        }

        private double ValidarOperando(string strNumero)
        {
            double numero = 0;

            double.TryParse(strNumero, out numero);

            return numero;

        }

        private bool EsBinario(string binario)
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

        public string DecimalBinario (double numero)
        {
            string numeroBinario = "";
  
            while (numero > 0)
            {
                string digito = (numero % 2).ToString();
                numeroBinario = digito + numeroBinario;
                numero = Math.Abs(numero) / 2;
            }

            return numeroBinario;
        }

        public string DecimalBinario(string numero)
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

        public string BinarioDecimal(string binario)
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

        public static double operator + (Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

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
