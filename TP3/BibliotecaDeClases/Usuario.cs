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
        private string dni;
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
            ultimoLegajo = 1;
        }

        public Usuario(string nombre, string apellido,
            string dni, string nombreUsuario, string password, bool esAdmin,
            DateTime fechaIngreso, DateTime fechaNacimiento, double salario)
        {
            this.legajo = ultimoLegajo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.nombreUsuario = nombreUsuario;
            this.password = password;
            this.esAdmin = esAdmin;
            this.fechaIngreso = fechaIngreso;
            this.fechaNacimiento = fechaNacimiento;
            this.salario = salario;
            ultimoLegajo++;
        }

        public int Legajo { get => this.legajo; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public string Apellido { get => this.apellido; set => this.apellido = value; }
        public string Dni { get => this.dni; set => this.dni = value; }
        public string NombreUsuario { get => this.nombreUsuario; set => this.nombreUsuario = value; }
        public bool EsAdmin { get => esAdmin; set => esAdmin = value; }
        public DateTime FechaIngreso { get => fechaIngreso; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public double Salario { get => salario; set => salario = value; }

        /// <summary>
        /// Metodo para verificar contrasena
        /// </summary>
        /// <param name="clave"></param>
        /// <returns>Devuelve true si la contrasena ingresada fue correcta. False caso contrario</returns>
        public bool CheckPassword(string clave)
        {
            return clave == this.password;
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
            string dni, bool esAdmin, DateTime fechaNacimiento, double salario)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.esAdmin = esAdmin;
            this.fechaNacimiento = fechaNacimiento;
            this.salario = salario;
        }

    }
}
