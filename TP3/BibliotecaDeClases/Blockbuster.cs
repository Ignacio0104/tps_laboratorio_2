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

        static Blockbuster()
        {
            listaDeEmpleados = new List<Usuario>();
            listaDePeliculas = new List<Pelicula>();
            listaDeSocios = new List<Socio>();
        }

        public static List<Usuario> ListaDeEmpleados { get => listaDeEmpleados; set => listaDeEmpleados = value; }
        public static List<Pelicula> ListaDePeliculas { get => listaDePeliculas; set => listaDePeliculas = value; }
        public static List<Socio> ListaDeSocios { get => listaDeSocios; set => listaDeSocios = value; }

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


        /* private static void HardcodeoPeliculas()
         {
             listaDePeliculas.Add(new Pelicula("El senor de los anillos La comunidad del anillo",123,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica,10));
             listaDePeliculas.Add(new Pelicula("El senor de los anillos Las dos torres",133,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica,5));
             listaDePeliculas.Add(new Pelicula("El senor de los anillos El retorno del rey",135,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica,20));
             listaDePeliculas.Add(new Pelicula("Star Wars La Amenaza Fantasma",113,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica,8));
             listaDePeliculas.Add(new Pelicula("Star Wars El Ataque de los Clones",103,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica,15));
             listaDePeliculas.Add(new Pelicula("Star Wars La Venganza de los Sith",130,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica,30));
             listaDePeliculas.Add(new Pelicula("Star Wars Una nueva esperanza",125,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica,20));
             listaDePeliculas.Add(new Pelicula("Star Wars El imperio contraataca",116,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica,32));
             listaDePeliculas.Add(new Pelicula("Star Wars El retorno del Jedi",102,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica,70));
             listaDePeliculas.Add(new Pelicula("Star Wars El Despertar de la Fuerza",107,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica,2));
             listaDePeliculas.Add(new Pelicula("Star Wars Los ultimos Jedi",133,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica,4));
             listaDePeliculas.Add(new Pelicula("Star Wars El ascenso de Skywalker",137,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica,10));
             listaDePeliculas.Add(new Pelicula("The Batman",138,GenerosPeliculas.Accion,DiasCategoriasAlquiler.Estreno,PrecioCategoriasAlquiler.Estreno,23));
             listaDePeliculas.Add(new Pelicula("Matrix Revoluciones",119,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Estreno,PrecioCategoriasAlquiler.Estreno,13));
             listaDePeliculas.Add(new Pelicula("Hoy se arregla el mundo",105,GenerosPeliculas.Comedia,DiasCategoriasAlquiler.Regular,PrecioCategoriasAlquiler.Regular,1));
             listaDePeliculas.Add(new Pelicula("Granizo",99,GenerosPeliculas.Comedia,DiasCategoriasAlquiler.Estreno,PrecioCategoriasAlquiler.Estreno,4));
             listaDePeliculas.Add(new Pelicula("Duro de Matar",90,GenerosPeliculas.Accion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica,8));
             listaDePeliculas.Add(new Pelicula("Terminator",103,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica,7));
             listaDePeliculas.Add(new Pelicula("Terminator 2: El juicio final", 110,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica,11));
             listaDePeliculas.Add(new Pelicula("Terminator 3: La rebelion de las maquinas", 108,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica,13));
             listaDePeliculas.Add(new Pelicula("La familia de mi novia",108,GenerosPeliculas.Comedia,DiasCategoriasAlquiler.Regular,PrecioCategoriasAlquiler.Regular,13));
             listaDePeliculas.Add(new Pelicula("Los Fockers, la familia de mi novio",103,GenerosPeliculas.Comedia,DiasCategoriasAlquiler.Regular,PrecioCategoriasAlquiler.Regular,12));
             listaDePeliculas.Add(new Pelicula("¿Que paso ayer?",110,GenerosPeliculas.Comedia,DiasCategoriasAlquiler.Regular,PrecioCategoriasAlquiler.Regular,11));
             listaDePeliculas.Add(new Pelicula("¿Que paso ayer? Parte II",113,GenerosPeliculas.Comedia,DiasCategoriasAlquiler.Regular,PrecioCategoriasAlquiler.Regular,24));
             listaDePeliculas.Add(new Pelicula("¿Que paso ayer? Parte III",119,GenerosPeliculas.Comedia,DiasCategoriasAlquiler.Regular,PrecioCategoriasAlquiler.Regular,18));
             listaDePeliculas.Add(new Pelicula("Toy Story",93,GenerosPeliculas.Animada,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica,13));
             listaDePeliculas.Add(new Pelicula("Toy Story 2",99,GenerosPeliculas.Animada,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica,15));
             listaDePeliculas.Add(new Pelicula("Toy Story 3",100,GenerosPeliculas.Animada,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica,23));
             listaDePeliculas.Add(new Pelicula("Sin tiempo para morir 007",120,GenerosPeliculas.Accion,DiasCategoriasAlquiler.Estreno,PrecioCategoriasAlquiler.Estreno,16));
             listaDePeliculas.Add(new Pelicula("Donde están las rubias",93,GenerosPeliculas.Comedia,DiasCategoriasAlquiler.Regular,PrecioCategoriasAlquiler.Regular,16));
             listaDePeliculas.Add(new Pelicula("Shrek",102,GenerosPeliculas.Animada,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica,12));
             listaDePeliculas.Add(new Pelicula("Shrek 2",103,GenerosPeliculas.Animada,DiasCategoriasAlquiler.Regular,PrecioCategoriasAlquiler.Regular,20));
             listaDePeliculas.Add(new Pelicula("Proyecto Adam",122,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Estreno,PrecioCategoriasAlquiler.Estreno,4));
             listaDePeliculas.Add(new Pelicula("V de Venganza",110,GenerosPeliculas.Suspenso,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica,12));
             listaDePeliculas.Add(new Pelicula("La vida es Bella",124,GenerosPeliculas.Drama,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica,20));
             listaDePeliculas.Add(new Pelicula("Sin escape",103,GenerosPeliculas.Suspenso,DiasCategoriasAlquiler.Regular,PrecioCategoriasAlquiler.Regular,16));
             listaDePeliculas.Add(new Pelicula("Un camino a casa",119,GenerosPeliculas.Drama,DiasCategoriasAlquiler.Regular,PrecioCategoriasAlquiler.Regular,11));
             listaDePeliculas.Add(new Pelicula("Juego del miedo",101,GenerosPeliculas.Terror,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica, 19));
             listaDePeliculas.Add(new Pelicula("Scream",100,GenerosPeliculas.Terror,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica,14));
             listaDePeliculas.Add(new Pelicula("Bajo la misma estrella",106,GenerosPeliculas.Drama,DiasCategoriasAlquiler.Estreno,PrecioCategoriasAlquiler.Estreno,19));
             listaDePeliculas.Add(new Pelicula("Familia instantanea",97,GenerosPeliculas.Comedia,DiasCategoriasAlquiler.Estreno,PrecioCategoriasAlquiler.Estreno,16));
             listaDePeliculas.Add(new Pelicula("Yo robot",121,GenerosPeliculas.Accion,DiasCategoriasAlquiler.Regular,PrecioCategoriasAlquiler.Regular,20));
             listaDePeliculas.Add(new Pelicula("Batman begins",128,GenerosPeliculas.Accion,DiasCategoriasAlquiler.Regular,PrecioCategoriasAlquiler.Regular,16));
             listaDePeliculas.Add(new Pelicula("Agus profundas",114,GenerosPeliculas.Suspenso,DiasCategoriasAlquiler.Estreno,PrecioCategoriasAlquiler.Estreno,5));
             listaDePeliculas.Add(new Pelicula("Dune",130,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Estreno,PrecioCategoriasAlquiler.Estreno,6));
             listaDePeliculas.Add(new Pelicula("Juego de honor",90,GenerosPeliculas.Drama,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica,13));
             listaDePeliculas.Add(new Pelicula("El callejon de las almas perdidas",127,GenerosPeliculas.Drama,DiasCategoriasAlquiler.Estreno,PrecioCategoriasAlquiler.Estreno,10));
             listaDePeliculas.Add(new Pelicula("Space Jam",89,GenerosPeliculas.Animada,DiasCategoriasAlquiler.Clasica,PrecioCategoriasAlquiler.Clasica,26));
             listaDePeliculas.Add(new Pelicula("Hulk",93,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Regular,PrecioCategoriasAlquiler.Regular,15));
             listaDePeliculas.Add(new Pelicula("Avengers",129,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Regular,PrecioCategoriasAlquiler.Regular,19));
             listaDePeliculas.Add(new Pelicula("Shazam",122,GenerosPeliculas.CienciaFiccion,DiasCategoriasAlquiler.Regular,PrecioCategoriasAlquiler.Regular,3));
             listaDePeliculas.Add(new Pelicula("Tick tick boom!",129,GenerosPeliculas.Comedia,DiasCategoriasAlquiler.Estreno,PrecioCategoriasAlquiler.Estreno,6));
         }*/
    }
}
