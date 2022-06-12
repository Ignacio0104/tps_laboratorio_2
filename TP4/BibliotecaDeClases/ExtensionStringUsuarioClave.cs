using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class ExtensionStringUsuarioClave
    {
        public static bool ValidarUsuario(this string usuario)
        {
            return usuario.Length > 5 && usuario.Length < 17;
        }

        public static bool ValidarClave(this string clave)
        {
            return clave.Length > 3 && clave.Length < 17;
        }
    }
}
