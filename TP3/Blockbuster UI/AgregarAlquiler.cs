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
        public AgregarAlquiler()
        {
            InitializeComponent();
        }
        public void CargarPeliculas()
        {
            foreach (Pelicula item in Blockbuster.ListaDePeliculas)
            {
                int indice = dGridPeliculas.Rows.Add();
                dGridPeliculas.Rows[indice].Cells[0].Value = item.TituloPelicula;
                dGridPeliculas.Rows[indice].Cells[1].Value = item.DuracionPelicula + " min";
                dGridPeliculas.Rows[indice].Cells[2].Value = item.GeneroPelicula.ToString();
                dGridPeliculas.Rows[indice].Cells[3].Value = item.Stock.ToString();
                dGridPeliculas.Rows[indice].Cells[4].Value = "$" + (int)item.PrecioDeAlquiler;
                indice++;
            }
        }
    }


}
