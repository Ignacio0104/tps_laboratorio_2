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
        private string tarjetaDeCredito;

        public SocioClasico()
        {
            this.penalidad = 100;
            this.limitePeliculas = 5;
        }
        public SocioClasico(string nombre, string apellido, string email, string telefono,string tarjetaDeCredito) : base(nombre, apellido, email, telefono)
        {
            this.tarjetaDeCredito = tarjetaDeCredito;
        }


        public double Penalidad { get => penalidad; set => penalidad = value; }
        public int LimitePeliculas { get => limitePeliculas; set => limitePeliculas = value; }
        public string TarjetaDeCredito { get => tarjetaDeCredito; set => tarjetaDeCredito = value; }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine($"Penalidad: {penalidad}%");
            sb.AppendLine($"Limite peliculas: {limitePeliculas}%");
            sb.AppendLine($"Tarjeta: {tarjetaDeCredito}%");

            return sb.ToString();
        }
    }
}
