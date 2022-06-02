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
            DialogResult opcion = MessageBox.Show("Esta seguro que desea salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(opcion == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                try
                {
                    ClaseSerializadora<List<Socio>>.EscribirXml(Blockbuster.ListaDeSocios, "baseDatosSocios");
                    ClaseSerializadora<List<Producto>>.EscribirJson(Blockbuster.ListaDeProductos, "baseDatosProductos");
                    ClaseSerializadora<List<Pelicula>>.EscribirJson(Blockbuster.ListaDePeliculas, "baseDatosPeliculas");
                    using (StreamWriter outputfile = File.AppendText($".\\Recursos\\Facturacion-{DateTime.Now.ToString("dd-MM-yyyy")}.txt"))
                    {
                        outputfile.WriteLine(Blockbuster.FacturacionDiaria);
                    }
                    MessageBox.Show("Todos los datos han sido guardados exitósamente", "Guardado con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                catch (Exception exc)
                {
                    DialogResult opcionDos = MessageBox.Show("Hubo un error al guardar los datos \n ¿Desea salir y perder los datos no guardados?", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                    if (opcionDos == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }                  
                }                              
            }
            
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            Blockbuster.ListaDeProductos = ClaseSerializadora<List<Producto>>.LeerJson("baseDatosProductos");
            Blockbuster.ListaDePeliculas = ClaseSerializadora<List<Pelicula>>.LeerJson("baseDatosPeliculas");
            Blockbuster.ListaDeSocios = ClaseSerializadora<List<Socio>>.LeerXml("baseDatosSocios");
            usuarioLogueado = Blockbuster.BuscarUsuario(numeroLegajo);
            lblNombreUsuario.Text = $"{usuarioLogueado.Nombre} {usuarioLogueado.Apellido}";
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
