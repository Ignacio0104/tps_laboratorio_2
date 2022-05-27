using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases.Excepciones
{
    public class TarjetaCreditoInvalida : Exception
    {
        public TarjetaCreditoInvalida()
        {
        }

        public TarjetaCreditoInvalida(string message) : base(message)
        {
        }

        public TarjetaCreditoInvalida(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
