using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases.Excepciones
{
    public class EmailInvalido : Exception
    {
        public EmailInvalido()
        {
        }

        public EmailInvalido(string message) : base(message)
        {
        }

        public EmailInvalido(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}
