using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaDeClases.Enumerados;

namespace BibliotecaDeClases
{
    public class Pelicula
    {
        private string tituloPelicula;
        private int duracionPelicula;
        private GenerosPeliculas generoPelicula;
        private DiasCategoriasAlquiler diasDeAlquiler;
        private PrecioCategoriasAlquiler precioDeAlquiler;
        private int stock;
        
        public Pelicula()
        {

        }
        public Pelicula(string tituloPelicula, int duracion,GenerosPeliculas generoPelicula,
            DiasCategoriasAlquiler diasDeAlquiler, PrecioCategoriasAlquiler precioDeAlquiler, int stock)
        {
            this.tituloPelicula = tituloPelicula;
            this.duracionPelicula = duracion;
            this.generoPelicula = generoPelicula;
            this.diasDeAlquiler = diasDeAlquiler;
            this.precioDeAlquiler = precioDeAlquiler;
            this.stock = stock;
        }

        public string TituloPelicula { get => tituloPelicula; set => tituloPelicula = value; }
        public int DuracionPelicula { get => duracionPelicula; set => duracionPelicula = value; }
        public GenerosPeliculas GeneroPelicula { get => generoPelicula; set => generoPelicula = value; }
    }
}