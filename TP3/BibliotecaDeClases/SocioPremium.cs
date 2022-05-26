using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class SocioPremium : Socio
    {
        private int penalidad;
        private int limitePeliculas;

        public SocioPremium()
        {

        }
        public SocioPremium(string nombre, string apellido, string email, string telefono) : base(nombre, apellido, email, telefono)
        {
            this.penalidad = 30;
            this.limitePeliculas = 20;
        }
        public override int Penalidad { get => penalidad; set => penalidad = value; }
        public override int LimitePeliculas { get => limitePeliculas; set => limitePeliculas = value; }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine($"Penalidad: {penalidad}%");
            sb.AppendLine($"Limite peliculas: {limitePeliculas}");

            return sb.ToString();
        }
    }
}
