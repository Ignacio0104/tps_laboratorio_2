using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class ExtensionIntDni
    {
        public static bool ValidarDni(this int dni)
        {
            return dni > 15000000 && dni < 60000000;
        }
    }
}
