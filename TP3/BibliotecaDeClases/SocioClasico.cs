using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class SocioClasico : Socio
    {
        private double penalidad;
        private int limitePeliculas;
        private ulong tarjetaDeCredito;
        public SocioClasico(string nombre, string apellido, string email, uint telefono,ulong tarjetaDeCredito) : base(nombre, apellido, email, telefono)
        {
            this.penalidad = 100;
            this.limitePeliculas = 5;
            this.tarjetaDeCredito = tarjetaDeCredito;
        }

        public double Penalidad { get => penalidad; set => penalidad = value; }
        public int LimitePeliculas { get => limitePeliculas; set => limitePeliculas = value; }
    }
}
