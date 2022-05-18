using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class Blockbuster
    {
        private static List<Usuario> listaDeEmpleados;
        private static List<Pelicula> listaDePeliculas;
        private static List<Socio> listaDeSocios;

        static Blockbuster()
        {
            listaDeEmpleados = new List<Usuario>();
            listaDePeliculas = new List<Pelicula>();
            listaDeSocios = new List<Socio>();
        }

        public static Usuario CheckLogIn(string usuario, string clave)
        {
            if (usuario is not null && clave is not null)
            {
                foreach (var item in listaDeEmpleados)
                {
                    if (item.CheckPassword(clave) && item.NombreUsuario == usuario)
                    {
                        return item;
                    }
                }
            }
            return null;
        }
    }
}
