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
        private static int ultimoId;
        private int idPelicula;

        public Pelicula()
        {

        }
        public Pelicula(string tituloPelicula, int duracion,GenerosPeliculas generoPelicula,
            DiasCategoriasAlquiler diasDeAlquiler, PrecioCategoriasAlquiler precioDeAlquiler, int stock)
        {
            ultimoId = Blockbuster.BuscarUltimoIdPelicula();
            this.idPelicula = ultimoId + 1;
            this.tituloPelicula = tituloPelicula;
            this.duracionPelicula = duracion;
            this.generoPelicula = generoPelicula;
            this.diasDeAlquiler = diasDeAlquiler;
            this.precioDeAlquiler = precioDeAlquiler;
            this.stock = stock;
            ultimoId++;
        }

        public int IdPelicula { get => idPelicula; set => idPelicula = value; }
        public string TituloPelicula { get => tituloPelicula; set => tituloPelicula = value; }
        public int DuracionPelicula { get => duracionPelicula; set => duracionPelicula = value; }
        public GenerosPeliculas GeneroPelicula { get => generoPelicula; set => generoPelicula = value; }
        public DiasCategoriasAlquiler DiasDeAlquiler { get => diasDeAlquiler; set => diasDeAlquiler = value; }
        public PrecioCategoriasAlquiler PrecioDeAlquiler { get => precioDeAlquiler; set => precioDeAlquiler = value; }
        public int Stock { get => stock; set => stock = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Titulo {tituloPelicula} - Duracion {duracionPelicula}min");
            sb.AppendLine($"Genero {generoPelicula} - Dias de alquiler {(int)diasDeAlquiler}");
            sb.Append($"Precio ${(int)precioDeAlquiler}");
            return sb.ToString();
        }
    }
}   