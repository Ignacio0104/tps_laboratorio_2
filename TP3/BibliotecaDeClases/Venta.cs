using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Venta <T>
    {
        private Socio socioActual;
        private List<Alquiler> listaDeAlquileresPedido;
        private List<T> listaDeProductosPedido;

        public Venta(Socio socioActual,List<Alquiler> listaDeAlquileresPedido, List<T> listaDeProductosPedido)
        {
            this.socioActual = socioActual;
            this.listaDeAlquileresPedido = listaDeAlquileresPedido;
            this.listaDeProductosPedido = listaDeProductosPedido;
        }

        public Socio SocioActual { get => socioActual; set => socioActual = value; }
        public List<Alquiler> ListaDeAlquileresPedido { get => listaDeAlquileresPedido; set => listaDeAlquileresPedido = value; }
        public List<T> ListaDeProductosPedido { get => listaDeProductosPedido; set => listaDeProductosPedido = value; }
    }
}
