using BibliotecaDeClases;
using System;
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
