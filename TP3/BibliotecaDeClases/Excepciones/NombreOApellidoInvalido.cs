using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases.Excepciones
{
    public class NombreOApellidoInvalido : Exception
    {
        public NombreOApellidoInvalido()
        {
        }

        public NombreOApellidoInvalido(string message) : base(message)
        {
        }

        public NombreOApellidoInvalido(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
