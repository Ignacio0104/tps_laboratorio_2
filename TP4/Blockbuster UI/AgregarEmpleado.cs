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
        public Usuario usuarioElegido;
        public Usuario usuarioLogueado;
        public AgregarEmpleado()
        {
            InitializeComponent();
        }

        public AgregarEmpleado(Usuario usuarioElegido,Usuario usuarioLogueado):this()
        {
            this.usuarioElegido = usuarioElegido;
            this.usuarioLogueado = usuarioLogueado;
        }

        private void AgregarEmpleado_Load(object sender, EventArgs e)
        {
            if(usuarioElegido is not null)
            {
                CargarDatosUsuario();
            }
           
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Validaciones();
                if (usuarioElegido is not null)
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
            lblLegajo.Text += $" {usuarioElegido.Legajo}";
            txtNombreEmpleado.Text = usuarioElegido.Nombre;
            txtApellidoEmpleado.Text = usuarioElegido.Apellido;
            txtDni.Text= usuarioElegido.DNI.ToString();
            txtUsername.Text = usuarioElegido.NombreUsuario;
            txtClave.Text = usuarioElegido.Password;
            txtSalario.Text = usuarioElegido.Salario.ToString();
            dateFechaNacimiento.SelectionStart = usuarioElegido.FechaNacimiento;
            dateFechaNacimiento.SelectionEnd = usuarioElegido.FechaNacimiento;
            chkEsAdmin.Checked = usuarioElegido.EsAdmin;
            btnEliminar.Visible = true;
        }

        private void ActualizarDatosUsuario()
        {
            usuarioElegido.Nombre = txtNombreEmpleado.Text;
            usuarioElegido.Apellido = txtApellidoEmpleado.Text;
            usuarioElegido.DNI = Convert.ToInt32(txtDni.Text);
            usuarioElegido.NombreUsuario = txtUsername.Text;
            usuarioElegido.Password = txtClave.Text;
            usuarioElegido.EsAdmin = chkEsAdmin.Checked;
            usuarioElegido.Salario = Convert.ToDouble(txtSalario.Text);
            usuarioElegido.FechaNacimiento = dateFechaNacimiento.SelectionStart;
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
            if (usuarioLogueado.Legajo == usuarioElegido.Legajo)
            {
                MessageBox.Show("No puede eliminar el usuario del que está logueado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult opcion = MessageBox.Show($"Esta a punto de borrar al usuario {usuarioElegido.Nombre} {usuarioElegido.Apellido}\n ¿Desea continuar?", $"Eliminar usuario {usuarioElegido.Legajo}", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (opcion == DialogResult.OK)
                {
                    Blockbuster.ListaDeEmpleados.Remove(usuarioElegido);
                    this.DialogResult = DialogResult.OK;
                }
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
            if (!dniAux.ValidarDni())
            {
                throw new DniInvalido("Favor verificar el DNI ingresado (sin puntos ni espacios)");
            }

            if ((!txtUsername.Text.ValidarUsuario()) || (!txtClave.Text.ValidarClave()))
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
