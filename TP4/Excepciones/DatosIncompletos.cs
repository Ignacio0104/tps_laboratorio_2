using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases.Excepciones
{
    public class DatosIncompletos : Exception
    {
        public DatosIncompletos()
        {
        }

        public DatosIncompletos(string message) : base(message)
        {
        }

        public DatosIncompletos(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}
