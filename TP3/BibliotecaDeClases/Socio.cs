﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaDeClases
{
    public abstract class Socio
    {
        protected static int ultimoId;
        protected int idSocio;
        protected string nombreSocio;
        protected string apellidoSocio;
        protected string emailSocio;
        protected string telefonoSocio;
        protected List<Alquiler<Pelicula>> listaDeAlquileres;

        static Socio()
        {
            ultimoId = 1000;
        }

        public Socio()
        {

        }

        public Socio(string nombre,string apellido,string email,string telefono)
        {
            this.idSocio = ultimoId;
            this.nombreSocio = nombre;
            this.apellidoSocio = apellido;
            this.emailSocio = email;
            this.telefonoSocio = telefono;
            this.listaDeAlquileres = new List<Alquiler<Pelicula>>();
            ultimoId++;
        }
        public int IdSocio { get => idSocio; set => idSocio = value; }
        public string NombreSocio { get => nombreSocio; set => nombreSocio = value; }
        public string ApellidoSocio { get => apellidoSocio; set => apellidoSocio = value; }
        public string EmailSocio { get => emailSocio; set => emailSocio = value; }
        public string TelefonoSocio { get => telefonoSocio; set => telefonoSocio = value; }

        public virtual string Mostrar()
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
