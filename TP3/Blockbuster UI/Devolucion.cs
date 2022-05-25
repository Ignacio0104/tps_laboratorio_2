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
    public partial class Devolucion : Form
    {
        Alquiler<Pelicula> alquilerDevolver;
        public Devolucion(Alquiler <Pelicula> alquiler)
        {
            InitializeComponent();
            this.alquilerDevolver = alquiler;
            lblTituloPelicula.Text = alquiler.Pelicula.TituloPelicula;
            lblAlquiler.Text = alquiler.FechaDeAlquiler.ToShortDateString();
            lblDevolucion.Text = DateTime.Now.ToShortDateString();
            lblPenalidad.Text = (DateTime.Now.Day - alquiler.FechaDeAlquiler.Day).ToString();
        }
    }
}
