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
        bool esPremium;
        public Devolucion(Alquiler <Pelicula> alquiler,bool esPremium)
        {
            InitializeComponent();
            this.alquilerDevolver = alquiler;
            this.esPremium = esPremium;
            lblTituloPelicula.Text = alquilerDevolver.Pelicula.TituloPelicula;
            lblAlquiler.Text = alquilerDevolver.FechaDeAlquiler.ToShortDateString();
            lblDevolucion.Text = DateTime.Now.ToShortDateString();
            lblPenalidadFinal.Text = $"$ {CalculoPenalidad()}";
        }

        private double CalculoPenalidad()
        {
            int difereciaDias = DateTime.Now.Day - alquilerDevolver.FechaDeAlquiler.Day;
            int penalidad = 0;

            if (difereciaDias > (int)alquilerDevolver.Pelicula.DiasDeAlquiler)
            {
                if (esPremium)
                {
                    penalidad = (alquilerDevolver.Penalidad * 30) / 100 * difereciaDias;
                }
                else
                {
                    penalidad = alquilerDevolver.Penalidad * difereciaDias;
                }
            }

            return penalidad;
        }
        
    }
}
