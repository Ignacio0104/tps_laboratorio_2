using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeClases;
using BibliotecaDeClases.Excepciones;

namespace Blockbuster_UI
{
    public partial class AgregarEmpleado : Form
    {
        public Usuario usuario;
        public AgregarEmpleado()
        {
            InitializeComponent();
        }

        public AgregarEmpleado(Usuario usuario):this()
        {
            this.usuario = usuario;
        }

        private void AgregarEmpleado_Load(object sender, EventArgs e)
        {
            if(usuario is not null)
            {
                CargarDatosUsuario();
            }
           
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Validaciones();
                if (usuario is not null)
                {
                    ActualizarDatosUsuario();
                }
                else
                {
                    Blockbuster.ListaDeEmpleados.Add(new Usuario(txtNombreEmpleado.Text, txtApellidoEmpleado.Text, Convert.ToInt32(txtDni.Text), txtUsername.Text,
                                        txtClave.Text, chkEsAdmin.Checked, DateTime.Now, dateFechaNacimiento.SelectionStart, Convert.ToDouble(txtSalario.Text)));
                }
                this.DialogResult = DialogResult.OK;
            }catch (Exception ex)
            {
                lblError.Visible = true;
                lblError.Text = "*" + ex.Message;
            }

        }

        private void CargarDatosUsuario()
        {
            txtNombreEmpleado.Text = usuario.Nombre;
            txtApellidoEmpleado.Text = usuario.Apellido;
            txtDni.Text= usuario.DNI.ToString();
            txtUsername.Text = usuario.NombreUsuario;
            txtClave.Text = usuario.Password;
            txtSalario.Text = usuario.Salario.ToString();
            dateFechaNacimiento.SelectionStart = usuario.FechaNacimiento;
            dateFechaNacimiento.SelectionEnd = usuario.FechaNacimiento;
            chkEsAdmin.Checked = usuario.EsAdmin;
            btnEliminar.Visible = true;
        }

        private void ActualizarDatosUsuario()
        {
            usuario.Nombre = txtNombreEmpleado.Text;
            usuario.Apellido = txtApellidoEmpleado.Text;
            usuario.DNI = Convert.ToInt32(txtDni.Text);
            usuario.NombreUsuario = txtUsername.Text;
            usuario.Password = txtClave.Text;
            usuario.EsAdmin = chkEsAdmin.Checked;
            usuario.Salario = Convert.ToDouble(txtSalario.Text);
            usuario.FechaNacimiento = dateFechaNacimiento.SelectionStart;
        }

        private void picOcultar_Click(object sender, EventArgs e)
        {
            picOcultar.Visible = false;
            picMostrar.Visible = true;
            txtClave.PasswordChar = '*';
        }

        private void picMostrar_Click(object sender, EventArgs e)
        {
            picMostrar.Visible = false;
            picOcultar.Visible = true;
            txtClave.PasswordChar = '\0';
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show($"Esta a punto de borrar al usuario {usuario.Nombre} {usuario.Apellido}\n ¿Desea continuar?", $"Eliminar usuario {usuario.Legajo}", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(opcion == DialogResult.OK)
            {
                Blockbuster.ListaDeEmpleados.Remove(usuario);
                this.DialogResult = DialogResult.OK;
            }
            
        }

        private void Validaciones()
        {
            if (!txtNombreEmpleado.Text.All(char.IsLetter))
            {
                throw new NombreOApellidoInvalido("Favor revisar el campo nombre");
            }

            if (!txtApellidoEmpleado.Text.All(char.IsLetter))
            {
                throw new NombreOApellidoInvalido("Favor revisar el campo apellido");
            }
            int dniAux;
            int.TryParse(txtDni.Text, out dniAux);
            if (dniAux < 15000000 || dniAux > 60000000)
            {
                throw new DniInvalido("Favor verificar el DNI ingresado (sin puntos ni espacios)");
            }

            if ((txtUsername.Text.Length < 6 || txtUsername.Text.Length > 16) || (txtClave.Text.Length < 4 || txtClave.Text.Length > 16))
            {
                throw new DatosIncompletos("Favor verificar el nombre de usuario y/o clave ingresados");
            }

            double salarioAux;
            double.TryParse(txtSalario.Text, out salarioAux);
            if (salarioAux < 20000 || salarioAux > 1000000)
            {
                throw new DatosIncompletos("Favor verificar salario ingresado");
            }

            if (dateFechaNacimiento.SelectionStart.Year > 2005 || dateFechaNacimiento.SelectionStart.Year < 1925)
            {
                throw new DatosIncompletos("Favor verificar la fecha de nacimiento ingresada");
            }
        }

    }
}
