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

        }

        private void cmbFiltroBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarInfo();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarProducto frmAgregar = new AgregarProducto(Blockbuster.ListaDePeliculas[4]);

            frmAgregar.ShowDialog();

            if(frmAgregar.DialogResult == DialogResult.OK)
            {
                dGridInventario.DataSource = null;
                ActualizarInfo();
            }
        }

        private void ActualizarInfo()
        {
            if (cmbFiltroBusqueda.SelectedItem == "Peliculas")
            {
                dGridInventario.DataSource = Blockbuster.ListaDePeliculas;
            }
            else
            {
                dGridInventario.DataSource = Blockbuster.ListaDeProductos;
            }
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            cmbFiltroBusqueda.Items.Add("Peliculas");
            cmbFiltroBusqueda.Items.Add("Productos");
            cmbFiltroBusqueda.SelectedIndex = 0;
        }

        private void dGridInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    AgregarProducto frmModificacion = new AgregarProducto();
                    int id = (int)dGridInventario.Rows[e.RowIndex].Cells[0].Value;
                    if (cmbFiltroBusqueda.SelectedIndex == 0)
                    {
                        Pelicula peliculaAux = Blockbuster.BuscarPelicula(id);
                        frmModificacion = new AgregarProducto(peliculaAux);
                    }
                    else
                    {
                        Producto productoAux = Blockbuster.BuscarProducto(id);
                        frmModificacion = new AgregarProducto(productoAux);
                    }             
                    frmModificacion.ShowDialog();
                    if (frmModificacion.DialogResult == DialogResult.OK)
                    {
                        dGridInventario.DataSource = null;
                        ActualizarInfo();
                    }
                }catch(Exception ex)
                {

                }
     
            }
        }
    }
}
