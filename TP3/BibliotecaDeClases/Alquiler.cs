using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaDeClases.Enumerados;

namespace BibliotecaDeClases
{
    public class Alquiler <T>
    {
        private T pelicula;

        private int penalidad;
        private DateTime fechaDeAlquiler;

        public Alquiler(T pelicula)
        {
            this.pelicula = pelicula;
            this.penalidad = 50;
            this.fechaDeAlquiler = DateTime.Now;
        }

        public T Pelicula { get => pelicula; set => pelicula = value; }
        public int Penalidad { get => penalidad; set => penalidad = value; }
        public DateTime FechaDeAlquiler { get => fechaDeAlquiler; set => fechaDeAlquiler = value; }
    }
}
