using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Blockbuster_UI
{
    public partial class MenuPrincipal : Form
    {
        Usuario usuarioLogueado;
        int numeroLegajo;
        public MenuPrincipal(int numeroLegajo)
        {
            InitializeComponent();
            this.numeroLegajo = numeroLegajo;
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            CargarMenu(new FormVenta());
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            CargarMenu(new Inventario());
        }



        private void CargarMenu(Form formulario)
        {
            if (this.panelPrincipal.Controls.Count > 0)
            {
                this.panelPrincipal.Controls.RemoveAt(0);
            }

            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(formulario);
            this.panelPrincipal.Tag = formulario;
            formulario.Show();
        }

 

        private void btnSocios_Click(object sender, EventArgs e)
        {
            CargarMenu(new ListaSocios());
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseSerializadora<List<Socio>>.EscribirXml(Blockbuster.ListaDeSocios, "baseDatosSocios");
                ClaseSerializadora<List<Producto>>.EscribirJson(Blockbuster.ListaDeProductos, "baseDatosProductos");
                ClaseSerializadora<List<Pelicula>>.EscribirJson(Blockbuster.ListaDePeliculas, "baseDatosPeliculas");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
           
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            Blockbuster.ListaDeProductos = ClaseSerializadora<List<Producto>>.LeerJson("baseDatosProductos");
            Blockbuster.ListaDePeliculas = ClaseSerializadora<List<Pelicula>>.LeerJson("baseDatosPeliculas");
            Blockbuster.ListaDeSocios = ClaseSerializadora<List<Socio>>.LeerXml("baseDatosSocios");
            usuarioLogueado = Blockbuster.BuscarUsuario(numeroLegajo);
            lblNombreUsuario.Text = $"{usuarioLogueado.Nombre} {usuarioLogueado.Apellido}";
        }
    }
}
