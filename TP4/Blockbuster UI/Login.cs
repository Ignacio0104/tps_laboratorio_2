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

        private void login_Load(object sender, EventArgs e)
        {
            try
            {
                Blockbuster.ListaDeEmpleados = MetodosSQL.LeerListaUsuarios();
                //Blockbuster.ListaDeEmpleados = ClaseSerializadora<List<Usuario>>.LeerJson("baseDatosEmpleados"); Sirve a modo de backup por si se daña la DB
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al descargar base de datos de usuarios, favor verificar y reiniciar el programa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnAutoComplete_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "nacho2022";
            txtClave.Text = "1234";
        }
    }
}
