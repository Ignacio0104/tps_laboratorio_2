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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Devolucion_Load(object sender, EventArgs e)
        {
            lblTituloPelicula.Text = alquilerDevolver.Pelicula.TituloPelicula;
            lblAlquiler.Text = alquilerDevolver.FechaDeAlquiler.ToShortDateString();
            lblDevolucion.Text = DateTime.Now.ToShortDateString();
            lblPenalidadFinal.Text = $"$ {CalculoPenalidad()}";
        }
    }
}
