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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            Blockbuster.ListaDeEmpleados = ClaseSerializadora<List<Usuario>>.Leer("baseDatosEmpleados");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string clave = txtClave.Text;
            Usuario usuarioSolicitado = Blockbuster.CheckLogIn(user, clave);

            if (usuarioSolicitado != null)
            {
                MenuPrincipal frmPrincipal = new MenuPrincipal(usuarioSolicitado.Legajo);
                frmPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Clave incorrecta.\n Favor vuelva a intentar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
