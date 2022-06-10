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
                txtNombreEmpleado.Text = usuario.Nombre;
            }
           
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            usuario.Nombre = txtNombreEmpleado.Text;
            MetodosSQL.ModificarUsuario(usuario);
            this.DialogResult = DialogResult.OK;
        }
    }
}
