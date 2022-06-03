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
        int penalidad;
        public Devolucion(Alquiler <Pelicula> alquiler,bool esPremium)
        {
            InitializeComponent();
            this.alquilerDevolver = alquiler;
            this.esPremium = esPremium;
        }

        private double CalculoPenalidad()
        {
            int difereciaDias = (int)(DateTime.Now - alquilerDevolver.FechaDeAlquiler).TotalDays;
            penalidad = 0;

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
            if(penalidad > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"{DateTime.Now} - Penalidad - Total ${penalidad} - Alquiler {alquilerDevolver.Pelicula.TituloPelicula}");
                Blockbuster.FacturacionDiaria += sb.ToString(); //Acá se agrega la información a la facturación diaria
            }

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
