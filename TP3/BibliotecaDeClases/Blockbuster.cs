using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaDeClases.Enumerados;


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

        private static void HardcodeoPeliculas()
        {
            listaDePeliculas.Add(new Pelicula("El senor de los anillos La comunidad del anillo",123,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("El senor de los anillos Las dos torres",133,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("El senor de los anillos El retorno del rey",135,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("Star Wars La Amenaza Fantasma",113,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("Star Wars El Ataque de los Clones",103,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("Star Wars La Venganza de los Sith",130,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("Star Wars Una nueva esperanza",125,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("Star Wars El imperio contraataca",116,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("Star Wars El retorno del Jedi",102,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("Star Wars El Despertar de la Fuerza",107,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("Star Wars Los ultimos Jedi",133,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("Star Wars El ascenso de Skywalker",137,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("The Batman",138,GenerosPeliculas.Accion,DiasCategoriasAlquiler.Estreno,PrecioCategoriasAlquiler.Estreno));
            listaDePeliculas.Add(new Pelicula("Matrix Revoluciones",119,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Estreno,PrecioCategoriasAlquiler.Estreno));
            listaDePeliculas.Add(new Pelicula("Hoy se arregla el mundo",105,GenerosPeliculas.Comedia,DiasCategoriasAlquiler.Regular,PrecioCategoriasAlquiler.Regular));
            listaDePeliculas.Add(new Pelicula("Granizo",99,GenerosPeliculas.Comedia,DiasCategoriasAlquiler.Estreno,PrecioCategoriasAlquiler.Estreno));
            listaDePeliculas.Add(new Pelicula("El senor de los anillos La comunidad del anillo",123,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("El senor de los anillos La comunidad del anillo",123,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("El senor de los anillos La comunidad del anillo",123,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("El senor de los anillos La comunidad del anillo",123,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("El senor de los anillos La comunidad del anillo",123,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("El senor de los anillos La comunidad del anillo",123,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("El senor de los anillos La comunidad del anillo",123,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("El senor de los anillos La comunidad del anillo",123,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("El senor de los anillos La comunidad del anillo",123,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("El senor de los anillos La comunidad del anillo",123,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("El senor de los anillos La comunidad del anillo",123,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("El senor de los anillos La comunidad del anillo",123,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("El senor de los anillos La comunidad del anillo",123,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("El senor de los anillos La comunidad del anillo",123,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("El senor de los anillos La comunidad del anillo",123,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("El senor de los anillos La comunidad del anillo",123,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("El senor de los anillos La comunidad del anillo",123,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("El senor de los anillos La comunidad del anillo",123,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("El senor de los anillos La comunidad del anillo",123,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("El senor de los anillos La comunidad del anillo",123,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("El senor de los anillos La comunidad del anillo",123,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("El senor de los anillos La comunidad del anillo",123,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("El senor de los anillos La comunidad del anillo",123,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("El senor de los anillos La comunidad del anillo",123,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("El senor de los anillos La comunidad del anillo",123,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("El senor de los anillos La comunidad del anillo",123,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("El senor de los anillos La comunidad del anillo",123,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
            listaDePeliculas.Add(new Pelicula("El senor de los anillos La comunidad del anillo",123,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica));
        }
    }
}
