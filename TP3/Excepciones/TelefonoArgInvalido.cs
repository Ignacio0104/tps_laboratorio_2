using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases.Excepciones
{
    public class TelefonoArgInvalido : Exception
    {
        public TelefonoArgInvalido()
        {
        }

        public TelefonoArgInvalido(string message) : base(message)
        {
        }

        public TelefonoArgInvalido(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}
