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
        public MenuPrincipal()
        {
            InitializeComponent();
            Blockbuster.ListaDePeliculas = ClaseSerializadora<List<Pelicula>>.Leer("baseDatosPeliculas");
            List<SocioClasico> sociosAux = ClaseSerializadora<List<SocioClasico>>.Leer("baseDatosSocioClasico");
            List<SocioPremium> sociosPremiumAux = ClaseSerializadora<List<SocioPremium>>.Leer("baseDatosSocioPremium");
            Blockbuster.ListaDeSocios.AddRange(sociosAux);
            Blockbuster.ListaDeSocios.AddRange(sociosPremiumAux);
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

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            CargarMenu(new Devolucion());
        }
    }
}
