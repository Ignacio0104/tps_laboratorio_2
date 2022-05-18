using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaDeClases
{
    public abstract class Socio
    {
        private static int ultimoId;
        private int idSocio;
        private string nombreSocio;
        private string apellidoSocio;
        private string emailSocio;
        private int telefonoSocio;
        private List<Alquiler> listaDeAlquileres;

        static Socio()
        {
            ultimoId = 1000;
        }

        public Socio(string nombre,string apellido,string email,int telefono)
        {
            this.idSocio = ultimoId;
            this.nombreSocio = nombre;
            this.apellidoSocio = apellido;
            this.emailSocio = email;
            this.telefonoSocio = telefono;
            this.listaDeAlquileres = new List<Alquiler>();
            ultimoId++;
        }
        public int IdSocio { get => idSocio; }
        public string NombreSocio { get => nombreSocio; set => nombreSocio = value; }
        public string ApellidoSocio { get => apellidoSocio; set => apellidoSocio = value; }
        public string EmailSocio { get => emailSocio; set => emailSocio = value; }
        public int TelefonoSocio { get => telefonoSocio; set => telefonoSocio = value; }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {nombreSocio}");
            sb.AppendLine($"Apellido: {apellidoSocio}");
            sb.AppendLine($"Email: {emailSocio}");
            sb.AppendLine($"Teléfono: {telefonoSocio}");

            return sb.ToString();
        }
    }
}
