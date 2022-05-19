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
        private List<T> listaDeAlquileresPedido;
        private List<Producto> listaDeProductosPedido;
        private double precioCuenta;

        public Venta(Socio socioActual,List<T> listaDeAlquileresPedido, List<Producto> listaDeProductosPedido)
        {
            this.socioActual = socioActual;
            this.listaDeAlquileresPedido = listaDeAlquileresPedido;
            this.listaDeProductosPedido = listaDeProductosPedido;
        }

        public Socio SocioActual { get => socioActual; set => socioActual = value; }
        public List<T> ListaDeAlquileresPedido { get => listaDeAlquileresPedido; set => listaDeAlquileresPedido = value; }
        public List<Producto> ListaDeProductosPedido { get => listaDeProductosPedido; set => listaDeProductosPedido = value; }
    }
}
