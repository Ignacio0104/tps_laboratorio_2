using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class SocioPremium : Socio
    {
        private double penalidad;
        private int limitePeliculas;
        public SocioPremium(string nombre, string apellido, string email, uint telefono) : base(nombre, apellido, email, telefono)
        {
            this.penalidad = 30;
            this.limitePeliculas = 20;
        }
        public double Penalidad { get => penalidad; set => penalidad = value; }
        public int LimitePeliculas { get => limitePeliculas; set => limitePeliculas = value; }
    }
}
