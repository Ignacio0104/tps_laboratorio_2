using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BibliotecaDeClases
{
    [XmlInclude(typeof(SocioClasico))]
    [XmlInclude(typeof(SocioPremium))]
    public abstract class Socio
    {
        protected static int ultimoId;
        protected int idSocio;
        protected string nombreSocio;
        protected string apellidoSocio;
        protected string emailSocio;
        protected string telefonoSocio;
        protected List<Alquiler<Pelicula>> listaDeAlquileres;

        public Socio()
        {
            this.listaDeAlquileres = new List<Alquiler<Pelicula>>();
        }

        public Socio(string nombre,string apellido,string email,string telefono):this()
        {
            ultimoId = Blockbuster.BuscarUltimoIdSocios();
            this.idSocio = ultimoId +1;
            this.nombreSocio = nombre;
            this.apellidoSocio = apellido;
            this.emailSocio = email;
            this.telefonoSocio = telefono;
            ultimoId++;
        }
        public int IdSocio { get => idSocio; set => idSocio = value; }
        public string NombreSocio { get => nombreSocio; set => nombreSocio = value; }
        public string ApellidoSocio { get => apellidoSocio; set => apellidoSocio = value; }
        public string EmailSocio { get => emailSocio; set => emailSocio = value; }
        public string TelefonoSocio { get => telefonoSocio; set => telefonoSocio = value; }
        public List<Alquiler<Pelicula>> ListaDeAlquileres { get => listaDeAlquileres; set => listaDeAlquileres = value; }
        public abstract int LimitePeliculas { get; set; }
        public abstract int Penalidad { get; set; }


        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {nombreSocio}");
            sb.AppendLine($"Apellido: {apellidoSocio}");
            sb.AppendLine($"Email: {emailSocio}");
            sb.AppendLine($"Teléfono: {telefonoSocio}");
            foreach (Alquiler<Pelicula> item in listaDeAlquileres)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        public void AgregarAlquiler(List<Alquiler<Pelicula>> peliculasElegidas, Pelicula pelicula, Action delegadoInformacion)
        {                               //El delegado se le pasa para ser invocado cuando el socio llegue al limite de peliculas
            if((peliculasElegidas.Count + this.listaDeAlquileres.Count) < this.LimitePeliculas)
            {
                peliculasElegidas.Add(new Alquiler<Pelicula>(pelicula));
                Blockbuster.BuscarPelicula(pelicula.IdPelicula).Stock--;
            }
            else
            {
                delegadoInformacion.Invoke();
            }
        }
    }
}
