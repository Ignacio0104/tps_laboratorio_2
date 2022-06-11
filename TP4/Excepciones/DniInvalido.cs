using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases.Excepciones
{
    public class DniInvalido : Exception
    {
        public DniInvalido()
        {
        }

        public DniInvalido(string message) : base(message)
        {
        }

        public DniInvalido(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}
