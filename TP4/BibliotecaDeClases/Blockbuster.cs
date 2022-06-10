using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static BibliotecaDeClases.Enumerados;


namespace BibliotecaDeClases
{
    public static class Blockbuster
    {
        private static List<Usuario> listaDeEmpleados;
        private static List<Pelicula> listaDePeliculas;
        private static List<Socio> listaDeSocios;
        private static List<Producto> listaDeProductos;
        private static string facturacionDiaria;

        static Blockbuster()
        {
            listaDeEmpleados = new List<Usuario>();
            listaDePeliculas = new List<Pelicula>();
            listaDeSocios = new List<Socio>();
            listaDeProductos = new List<Producto>();
        }

        public static List<Usuario> ListaDeEmpleados { get => listaDeEmpleados; set => listaDeEmpleados = value; }
        public static List<Pelicula> ListaDePeliculas { get => listaDePeliculas; set => listaDePeliculas = value; }
        public static List<Socio> ListaDeSocios { get => listaDeSocios; set => listaDeSocios = value; }
        public static List<Producto> ListaDeProductos { get => listaDeProductos; set => listaDeProductos = value; }
        public static string FacturacionDiaria { get => facturacionDiaria; set => facturacionDiaria = value; }

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

        /// <summary>
        /// Metodo para buscar un usuario por legajo
        /// </summary>
        /// <param name="legajo"></param>
        /// <returns>Devuelve el usuario o null si no se encontró</returns>
        public static Usuario BuscarUsuario(int legajo)
        {
            for (int i = 0; i < listaDeEmpleados.Count; i++)
            {
                if (listaDeEmpleados[i].Legajo == legajo)
                {
                    return listaDeEmpleados[i];
                }
            }
            return null;
        }

        /// <summary>
        /// Metodo para buscar un socio por ID
        /// </summary>
        /// <param name="numeroDeSocio"></param>
        /// <returns>Devuelve el Socio o null si no se encontró</returns>
        public static Socio BuscarSocio(int numeroDeSocio)
        {
            for (int i = 0; i < listaDeSocios.Count; i++)
            {
                if (listaDeSocios[i].IdSocio == numeroDeSocio)
                {
                    return listaDeSocios[i];
                }
            }
            return null;
        }

        /// <summary>
        /// Metodo para buscar un socio por ID
        /// </summary>
        /// <param name="idPelicula"></param>
        /// <returns>Devuelve la Pelicula o null si no se encontró</returns>
        public static Pelicula BuscarPelicula(int idPelicula)
        {
            for (int i = 0; i < listaDePeliculas.Count; i++)
            {
                if (listaDePeliculas[i].IdPelicula == idPelicula)
                {
                    return listaDePeliculas[i];
                }
            }
            return null;
        }

        /// <summary>
        /// Metodo para buscar el indice que ocupa una pelicula en la lista de peliculas
        /// </summary>
        /// <param name="pelicula"></param>
        /// <returns>Devuelve el indice de la pelicula o -1 si no se encontró</returns>
        public static int BuscarIndicePelicula(Pelicula pelicula)
        {
            int indice = -1;
            for (int i = 0; i < listaDePeliculas.Count; i++)
            {
                if (listaDePeliculas[i].IdPelicula == pelicula.IdPelicula)
                {
                    indice = i;
                }
            }
            return indice;
        }

        /// <summary>
        /// Metodo para buscar un producto por ID
        /// </summary>
        /// <param name="idProducto"></param>
        /// <returns>Devuelve el Producto o null si no se encontró</returns>
        public static Producto BuscarProducto(int idProducto)
        {
            for (int i = 0; i < listaDeProductos.Count; i++)
            {
                if (listaDeProductos[i].IdProducto == idProducto)
                {
                    return listaDeProductos[i];
                }
            }
            return null;
        }

        /// <summary>
        /// Metodo para buscar el indice de un producto
        /// </summary>
        /// <param name="producto"></param>
        /// <returns>Devuelve el indice del producto o -1 si no se encontró</returns>
        public static int BuscarIndiceProducto(Producto producto)
        {
            int indice = -1;
            for (int i = 0; i < listaDeProductos.Count; i++)
            {
                if (listaDeProductos[i].IdProducto == producto.IdProducto)
                {
                    indice = i;
                }
            }
            return indice;
        }

        public static int BuscarUltimoIdSocios()
        {
            int maximo = 0;
            for (int i = 0; i < listaDeSocios.Count; i++)
            {
                if (listaDeSocios[i].IdSocio > maximo)
                    maximo = listaDeSocios[i].IdSocio;
            }
            return maximo;
        }

        public static int BuscarUltimoIdPelicula()
        {
            int maximo = 0;
            for (int i = 0; i < listaDePeliculas.Count; i++)
            {
                if (listaDePeliculas[i].IdPelicula > maximo)
                    maximo = listaDePeliculas[i].IdPelicula;
            }
            return maximo;
        }

        public static int BuscarUltimoIdProducto()
        {
            int maximo = 0;
            for (int i = 0; i < listaDeProductos.Count; i++)
            {
                if (listaDeProductos[i].IdProducto > maximo)
                    maximo = listaDeProductos[i].IdProducto;
            }
            return maximo;
        }

        public static int BuscarUltimoLegajoEmpleado()
        {
            int maximo = 0;
            for (int i = 0; i < listaDeEmpleados.Count; i++)
            {
                if (listaDeEmpleados[i].Legajo > maximo)
                    maximo = listaDeEmpleados[i].Legajo;
            }
            return maximo;
        }


    }
}
