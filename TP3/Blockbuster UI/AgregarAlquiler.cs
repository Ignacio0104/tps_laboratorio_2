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
        Socio socioAtendido;
        List<Alquiler<Pelicula>> listaAlquilerAux;
        public AgregarAlquiler(Socio socioAtendido)
        {
            InitializeComponent();
            listaAlquilerAux = new List<Alquiler<Pelicula>>();
            this.socioAtendido = socioAtendido;
            CargarPeliculas();
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

        private void dGridPeliculas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)dGridPeliculas.Rows[e.RowIndex].Cells[0];
                listaAlquilerAux.Add(new Alquiler<Pelicula>(Blockbuster.ListaDePeliculas[(int)cell.Value - 1]));
                //restaurante -= restaurante.Inventario[(int)cell.Value - 1];
               // dGridProductos.Rows.Clear();
                //CargarProductos(); //Se actualiza la lista para mostrar el stock actual
                StringBuilder sb = new StringBuilder();
                richAlquileresParcial.Text = "";
                if (listaAlquilerAux.Count > 0)
                {
                    foreach (Alquiler<Pelicula> item in listaAlquilerAux)
                    {
                        sb.AppendLine($"{item.Pelicula.TituloPelicula}");
                    }
                }
                richAlquileresParcial.Text = sb.ToString();
            }
        }
    }


}
