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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
            cmbFiltroBusqueda.Items.Add("Peliculas");
            cmbFiltroBusqueda.Items.Add("Productos");
            cmbFiltroBusqueda.SelectedIndex = 0;
        }

        private void cmbFiltroBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbFiltroBusqueda.SelectedItem == "Peliculas")
            {
                dGridInventario.DataSource = Blockbuster.ListaDePeliculas;
            }
            else
            {
                dGridInventario.DataSource = Blockbuster.ListaDeProductos;
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarProducto frmAgregar = new AgregarProducto();

            frmAgregar.ShowDialog();
        }
    }
}
