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

        static Blockbuster()
        {
            listaDeEmpleados = new List<Usuario>();
            listaDePeliculas = new List<Pelicula>();
            listaDeSocios = new List<Socio>();
            listaDeProductos = new List<Producto>();
            //HardcodeoProductos();
        }

        public static List<Usuario> ListaDeEmpleados { get => listaDeEmpleados; set => listaDeEmpleados = value; }
        public static List<Pelicula> ListaDePeliculas { get => listaDePeliculas; set => listaDePeliculas = value; }
        public static List<Socio> ListaDeSocios { get => listaDeSocios; set => listaDeSocios = value; }
        public static List<Producto> ListaDeProductos { get => listaDeProductos; set => listaDeProductos = value; }

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
        /// <returns>Devuelve el indice o -1 si no se encontró</returns>
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




      /*  private static void HardcodeoProductos()
        {
            listaDeProductos.Add(new Producto("Pochoclos Grandes", 600, 50));
            listaDeProductos.Add(new Producto("Pochoclos Medianos", 450, 60));
            listaDeProductos.Add(new Producto("Pochoclos Chicos", 370, 70));
            listaDeProductos.Add(new Producto("Sugus", 290, 30));
            listaDeProductos.Add(new Producto("Mani con chocolate", 200, 25));
            listaDeProductos.Add(new Producto("Confites M&M", 700, 10));
            listaDeProductos.Add(new Producto("Gomitas Mogul", 160, 20));
            listaDeProductos.Add(new Producto("Tita", 100, 15));
            listaDeProductos.Add(new Producto("Papas Pringles", 500, 100));
            listaDeProductos.Add(new Producto("Bananita Dolca", 90, 10));
            listaDeProductos.Add(new Producto("Rocklets", 300, 20));
            listaDeProductos.Add(new Producto("Lenguetazo", 150, 30));
            listaDeProductos.Add(new Producto("Rhodesia", 100, 60));
            listaDeProductos.Add(new Producto("Bon o Bon", 120, 80));
            listaDeProductos.Add(new Producto("Flynn Paff", 80, 10));
            listaDeProductos.Add(new Producto("Huevo Kinder", 400, 20));
            listaDeProductos.Add(new Producto("Nugaton", 200, 40));
            listaDeProductos.Add(new Producto("Galletitas Oreo", 400, 20));
            listaDeProductos.Add(new Producto("Mentitas", 70, 20));
        }*/
    }
}
