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
        public MenuPrincipal(int numeroLegajo)
        {
            InitializeComponent();
            Blockbuster.ListaDeProductos = ClaseSerializadora<List<Producto>>.Leer("baseDatosProductos");
            Blockbuster.ListaDePeliculas = ClaseSerializadora<List<Pelicula>>.Leer("baseDatosPeliculas");
            List<SocioClasico> sociosAux = ClaseSerializadora<List<SocioClasico>>.Leer("baseDatosSocioClasico");
            List<SocioPremium> sociosPremiumAux = ClaseSerializadora<List<SocioPremium>>.Leer("baseDatosSocioPremium");
            Blockbuster.ListaDeSocios.AddRange(sociosPremiumAux);
            Blockbuster.ListaDeSocios.AddRange(sociosAux);
            usuarioLogueado = Blockbuster.BuscarUsuario(numeroLegajo);
            lblNombreUsuario.Text = $"{usuarioLogueado.Nombre} {usuarioLogueado.Apellido}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarMenu(new FormVenta());
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

        private void button2_Click(object sender, EventArgs e)
        {
            CargarMenu(new Inventario());
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
            List<SocioClasico> listaClasicosAux = new List<SocioClasico>();
            List<SocioPremium> listaPremiumAux = new List<SocioPremium>();
            foreach (Socio item in Blockbuster.ListaDeSocios)
            {
                if (item is SocioClasico)
                {
                    listaClasicosAux.Add((SocioClasico)item);
                }
                else
                {
                    listaPremiumAux.Add((SocioPremium)item);
                }
            }
            ClaseSerializadora<List<SocioClasico>>.Escribir(listaClasicosAux, "baseDatosSocioClasico");
            ClaseSerializadora<List<SocioPremium>>.Escribir(listaPremiumAux, "baseDatosSocioPremium");
            ClaseSerializadora<List<Producto>>.Escribir(Blockbuster.ListaDeProductos, "baseDatosProductos");
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {

        }
    }
}
