using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Recibe un operador en formato char y valida que sea correcto
        /// </summary>
        /// <param name="operador">Operador en formato char</param>
        /// <returns>El signo elegido o + si hubo un error</returns>
        private static char ValidarOperador(char operador)
        {
            if(operador == '+' ||
                operador == '-'||
                operador == '*' ||
                operador ==  '/')
            {
                return operador;
            }
            else
            {
                return '+';
            }
        }

        /// <summary>
        /// Recibe 2 operandos y una operacion y realiza el calculo correspondiente
        /// </summary>
        /// <param name="num1">Operando numero uno </param>
        /// <param name="num2"> Operando numero dos</param>
        /// <param name="operador">Operacion a realizar</param>
        /// <returns>Devuelve el resultado de la operacion</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            switch (operador)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;   
                case '*':
                    return num1 * num2;
                case '/':
                    return num1 / num2;
                default:
                    return num1 + num2;

            }
        }
    }
}
