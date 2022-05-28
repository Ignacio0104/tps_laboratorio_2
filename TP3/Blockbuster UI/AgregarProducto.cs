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
    public partial class AgregarProducto : Form, IModificarse
    {
        Enumerados.GenerosPeliculas generoSeleccionado;
        Producto productoElegido;
        Pelicula peliculaElegida;
        public AgregarProducto()
        {
            InitializeComponent();
        }

        public AgregarProducto(Pelicula peliculaElegida):this()
        {
            this.peliculaElegida = peliculaElegida;
            this.productoElegido = null;
        }

        public AgregarProducto(Producto productoElegido) : this()
        {
            this.productoElegido = productoElegido;
            this.peliculaElegida = null;
        }

        private void rdtPeliculas_CheckedChanged(object sender, EventArgs e)
        {
            if (rdtPeliculas.Checked)
            {
                panPeliculas.Visible = true;
                panProductos.Visible = false;
            }
            else
            {
                panPeliculas.Visible = false;
                panProductos.Visible = true;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if(productoElegido is not null || peliculaElegida is not null)
                {
                    ActualizarInfo();
                }
                else
                {
                    if (rdtPeliculas.Checked)
                    {
                        string nombrePelicula = txtBoxTituloPelicula.Text;
                        int duracionPelicula = (int)nupDuracion.Value;
                        Enumerados.DiasCategoriasAlquiler diasAlquiler = (Enumerados.DiasCategoriasAlquiler)cmbDiasDeAlquiler.SelectedItem;
                        Enumerados.PrecioCategoriasAlquiler precioAlquiler = (Enumerados.PrecioCategoriasAlquiler)cmbPrecioAlquiler.SelectedItem;
                        int stockPelicula = (int)nupStock.Value;

                        Blockbuster.ListaDePeliculas.Add(new(nombrePelicula, duracionPelicula, generoSeleccionado, diasAlquiler, precioAlquiler, stockPelicula));

                    }
                    else
                    {
                        Blockbuster.ListaDeProductos.Add(new Producto(txtBoxNombreProducto.Text, (int)nupPrecioProducto.Value, (int)nupStockProducto.Value));
                    }
                }
                this.DialogResult = DialogResult.OK;
            }catch(Exception ex)
            {
                lblError.Text = $"*Favor verificar los datos";
            }

        }

        private void rdtAccion_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is RadioButton radioButton && radioButton.Checked)
            {
                switch (radioButton.Text)
                {
                    case "Accion":
                        generoSeleccionado = Enumerados.GenerosPeliculas.Accion;
                        break;
                    case "CienciaFiccion":
                        generoSeleccionado = Enumerados.GenerosPeliculas.CienciaFiccion;
                        break;
                    case "Comedia":
                        generoSeleccionado = Enumerados.GenerosPeliculas.Comedia;
                        break;
                    case "Drama":
                        generoSeleccionado = Enumerados.GenerosPeliculas.Drama;
                        break;
                    case "Terror":
                        generoSeleccionado = Enumerados.GenerosPeliculas.Terror;
                        break;
                    case "Suspenso":
                        generoSeleccionado = Enumerados.GenerosPeliculas.Suspenso;
                        break;
                    case "Animada":
                        generoSeleccionado = Enumerados.GenerosPeliculas.Animada;
                        break;
                }
            }
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            cmbDiasDeAlquiler.Items.Add(Enumerados.DiasCategoriasAlquiler.Clasica);
            cmbDiasDeAlquiler.Items.Add(Enumerados.DiasCategoriasAlquiler.Estreno);
            cmbDiasDeAlquiler.Items.Add(Enumerados.DiasCategoriasAlquiler.Regular);
            cmbPrecioAlquiler.Items.Add(Enumerados.PrecioCategoriasAlquiler.Especial);
            cmbPrecioAlquiler.Items.Add(Enumerados.PrecioCategoriasAlquiler.Normal);
            cmbPrecioAlquiler.Items.Add(Enumerados.PrecioCategoriasAlquiler.Promo);

            if (productoElegido is not null || peliculaElegida is not null)
            {
                btnBorrar.Visible = true;
                if (productoElegido is not null)
                {
                    txtBoxNombreProducto.Text = productoElegido.NombreProducto;
                    nupPrecioProducto.Value = (decimal)productoElegido.PrecioProducto;
                    nupStockProducto.Value = productoElegido.StockProducto;
                    rdtProductos.Checked = true;
                    rdtPeliculas.Enabled = false;
                }
                else
                {
                    txtBoxTituloPelicula.Text = peliculaElegida.TituloPelicula;
                    nupDuracion.Value = peliculaElegida.DuracionPelicula;
                    cmbDiasDeAlquiler.SelectedItem = peliculaElegida.DiasDeAlquiler;
                    cmbPrecioAlquiler.SelectedItem = peliculaElegida.PrecioDeAlquiler;
                    nupStock.Value = peliculaElegida.Stock;
                    rdtProductos.Enabled = false;
                    rdtPeliculas.Checked = true;
                }
            }

        }

        public void ActualizarInfo()
        {
            if (peliculaElegida is not null)
            {
                peliculaElegida.TituloPelicula = txtBoxTituloPelicula.Text;
                peliculaElegida.DuracionPelicula = (int)nupDuracion.Value;
                peliculaElegida.DiasDeAlquiler= (Enumerados.DiasCategoriasAlquiler)cmbDiasDeAlquiler.SelectedItem;
                cmbPrecioAlquiler.SelectedItem = (Enumerados.PrecioCategoriasAlquiler)cmbPrecioAlquiler.SelectedItem;
                peliculaElegida.Stock = (int)nupStock.Value;
                peliculaElegida.GeneroPelicula = generoSeleccionado;
            }
            else
            {
                if(productoElegido is not null)
                {
                    productoElegido.NombreProducto = txtBoxNombreProducto.Text;
                    productoElegido.StockProducto = (int)nupStockProducto.Value;
                    productoElegido.PrecioProducto = (double)nupPrecioProducto.Value;
                }
            }
        }

        public void EliminarObjeto()
        {
            if(peliculaElegida is not null)
            {
                Blockbuster.ListaDePeliculas.RemoveAt(Blockbuster.BuscarIndicePelicula(peliculaElegida));
            }
            else
            {
                Blockbuster.ListaDeProductos.RemoveAt(Blockbuster.BuscarIndiceProducto(productoElegido));
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult eleccion = MessageBox.Show($"¿Esta seguro que desea borrar este item?", "Borrar item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(eleccion == DialogResult.Yes)
            {
                EliminarObjeto();
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
