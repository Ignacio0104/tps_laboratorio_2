using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Enumerados
    {
        public enum PrecioCategoriasAlquiler
        {
            Estreno = 300,
            Regular= 200,
            Clasica = 150,
        }
        public enum DiasCategoriasAlquiler
        {
            Estreno = 2,
            Regular = 5,
            Clasica = 7,
        }

        public enum GenerosPeliculas
        {
            Accion,
            CienciaFiccion,
            Comedia,
            Drama,
            Terror,
            Suspenso
        }
    }


}
