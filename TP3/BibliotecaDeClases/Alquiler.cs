using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaDeClases.Enumerados;

namespace BibliotecaDeClases
{
    public class Alquiler
    {
        private Pelicula pelicula;
        private DiasCategoriasAlquiler diasDeAlquiler;
        private PrecioCategoriasAlquiler precioDeAlquiler;
        private int penalidad;
        private DateTime fechaDeAlquiler;

        public Alquiler(Pelicula pelicula, DiasCategoriasAlquiler diasDeAlquiler, 
            PrecioCategoriasAlquiler precioDeAlquiler)
        {
            this.pelicula = pelicula;
            this.diasDeAlquiler = diasDeAlquiler;
            this.precioDeAlquiler = precioDeAlquiler;
            this.penalidad = 50;
            this.fechaDeAlquiler = DateTime.Now;
        }

        public Pelicula Pelicula { get => pelicula; set => pelicula = value; }
        public DiasCategoriasAlquiler DiasDeAlquiler { get => diasDeAlquiler; set => diasDeAlquiler = value; }
        public PrecioCategoriasAlquiler PrecioDeAlquiler { get => precioDeAlquiler; set => precioDeAlquiler = value; }
        public int Penalidad { get => penalidad; set => penalidad = value; }
        public DateTime FechaDeAlquiler { get => fechaDeAlquiler; set => fechaDeAlquiler = value; }
    }
}
