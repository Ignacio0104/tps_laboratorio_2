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
    public partial class AgregarAlquiler : Form
    {
        public Socio socioAtendido;
        public List<Alquiler<Pelicula>> listaAlquilerAux;
        public List<Producto> listaProductosAux;
        public double acumuladorPrecio;
        public AgregarAlquiler(Socio socioAtendido)
        {
            InitializeComponent();
            listaAlquilerAux = new List<Alquiler<Pelicula>>();
            listaProductosAux = new List<Producto>();
            this.socioAtendido = socioAtendido;
            CargarPeliculas();
            CargarProductos();
        }
        public void CargarPeliculas()
        {
            foreach (Pelicula item in Blockbuster.ListaDePeliculas)
            {
                int indice = dGridPeliculas.Rows.Add();
                dGridPeliculas.Rows[indice].Cells[0].Value = item.IdPelicula;
                dGridPeliculas.Rows[indice].Cells[1].Value = item.TituloPelicula;
                dGridPeliculas.Rows[indice].Cells[2].Value = item.DuracionPelicula + " min";
                dGridPeliculas.Rows[indice].Cells[3].Value = item.GeneroPelicula.ToString();
                dGridPeliculas.Rows[indice].Cells[4].Value = item.Stock.ToString();
                dGridPeliculas.Rows[indice].Cells[5].Value = "$" + (int)item.PrecioDeAlquiler;
                indice++;
            }
        }

        public void CargarProductos()
        {
            foreach (Producto item in Blockbuster.ListaDeProductos)
            {
                int indice = dGridProducto.Rows.Add();
                dGridProducto.Rows[indice].Cells[0].Value = item.IdProducto;
                dGridProducto.Rows[indice].Cells[1].Value = item.NombreProducto;
                dGridProducto.Rows[indice].Cells[2].Value = "$" + item.PrecioProducto;
                dGridProducto.Rows[indice].Cells[3].Value = item.StockProducto;
                indice++;
            }
        }

        private void dGridPeliculas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    if ((listaAlquilerAux.Count + socioAtendido.ListaDeAlquileres.Count) < socioAtendido.LimitePeliculas)
                    {
                        DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)dGridPeliculas.Rows[e.RowIndex].Cells[0];
                        listaAlquilerAux.Add(new Alquiler<Pelicula>(Blockbuster.BuscarPelicula((int)cell.Value)));
                        Blockbuster.BuscarPelicula((int)cell.Value).Stock--;
                        dGridPeliculas.Rows.Clear();
                        CargarPeliculas();
                        ActualizarCuenta();
                    }
                    else
                    {
                        throw new Exception("Error, no hay mas lugar");
                    }

                }
   
            }catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void dGridProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {                                
                    DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)dGridProducto.Rows[e.RowIndex].Cells[0];
                    listaProductosAux.Add(Blockbuster.BuscarProducto((int)cell.Value));
                    Blockbuster.BuscarProducto((int)cell.Value).StockProducto--;
                    dGridProducto.Rows.Clear();
                    CargarProductos();
                    ActualizarCuenta();
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ActualizarCuenta()
        {
            StringBuilder sb = new StringBuilder();
            richAlquileresParcial.Text = "";
            acumuladorPrecio = 0;
            if (listaAlquilerAux.Count > 0)
            {
                foreach (Alquiler<Pelicula> item in listaAlquilerAux)
                {
                    sb.AppendLine($"{item.Pelicula.ToString()}");
                    sb.AppendLine("---------------------------");
                    acumuladorPrecio += (int)item.Pelicula.PrecioDeAlquiler;
                }
            }

            if (listaProductosAux.Count > 0)
            {
                foreach (Producto item in listaProductosAux)
                {
                    sb.AppendLine($"{item.ToString()}");
                    sb.AppendLine("---------------------------");
                    acumuladorPrecio += item.PrecioProducto;
                }
            }

            richAlquileresParcial.Text = sb.ToString();
            lblFacturacion.Text = $"Facturacion: ${acumuladorPrecio}";
        }
    }

}
