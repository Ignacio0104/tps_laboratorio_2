using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Usuario
    {
        private string nombre;
        private string apellido;
        private int dni;
        private string nombreUsuario;
        private string password;
        private static int ultimoLegajo;
        private int legajo;
        private bool esAdmin;
        private double salario;
        private DateTime fechaIngreso;
        private DateTime fechaNacimiento;

        static Usuario()
        {
            ultimoLegajo = 50;
        }

        public Usuario()
        {

        }

        public Usuario(string nombre, string apellido,
            int dni, string nombreUsuario, string password, bool esAdmin,
            DateTime fechaIngreso, DateTime fechaNacimiento, double salario)
        {
            this.legajo = ultimoLegajo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.nombreUsuario = nombreUsuario;
            this.Password = password;
            this.esAdmin = esAdmin;
            this.fechaIngreso = fechaIngreso;
            this.fechaNacimiento = fechaNacimiento;
            this.salario = salario;
            ultimoLegajo++;
        }

        public int Legajo { get => this.legajo; set => this.legajo = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public string Apellido { get => this.apellido; set => this.apellido = value; }
        public int Dni { get => this.dni; set => this.dni = value; }
        public string NombreUsuario { get => this.nombreUsuario; set => this.nombreUsuario = value; }
        public bool EsAdmin { get => esAdmin; set => esAdmin = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public double Salario { get => salario; set => salario = value; }
        public string Password { get => password; set => password = value; }

        /// <summary>
        /// Metodo para verificar contrasena
        /// </summary>
        /// <param name="clave"></param>
        /// <returns>Devuelve true si la contrasena ingresada fue correcta. False caso contrario</returns>
        public bool CheckPassword(string clave)
        {
            return clave == this.Password;
        }

        /// <summary>
        /// Metodo para actualizar informacion de un usuario
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="esAdmin"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="salario"></param>
        public void ActualizarDatos(string nombre, string apellido,
            int dni, bool esAdmin, DateTime fechaNacimiento, double salario)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.esAdmin = esAdmin;
            this.fechaNacimiento = fechaNacimiento;
            this.salario = salario;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            
            sb.AppendLine($"ID :{legajo} - {nombre} - {apellido}");
            sb.AppendLine($"DNI {dni} - Usuario: {nombreUsuario} - Clave: {Password}");
            sb.AppendLine($"Es admin {esAdmin} - Fecha de ingreso: {fechaIngreso.ToShortDateString()} - Nacimiento: {fechaNacimiento.ToShortDateString()}");
            sb.AppendLine($"Salario ${salario}");

            return sb.ToString();
        }
    }
}
