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
    public partial class FormVenta : Form
    {
        Socio socioAtendido;
        public FormVenta()
        {
            InitializeComponent();
        }

        private void txtNumeroSocio_Leave(object sender, EventArgs e)
        {
            int numeroSocio = -1;

            if(int.TryParse(txtNumeroSocio.Text, out numeroSocio))
            {
                socioAtendido = Blockbuster.BuscarSocio(numeroSocio);
            }

            if(socioAtendido is not null)
            {
                socioAtendido.ListaDeAlquileres.Add(new Alquiler<Pelicula>(Blockbuster.ListaDePeliculas[1]));
                socioAtendido.ListaDeAlquileres.Add(new Alquiler<Pelicula>(Blockbuster.ListaDePeliculas[5]));
                socioAtendido.ListaDeAlquileres.Add(new Alquiler<Pelicula>(Blockbuster.ListaDePeliculas[50]));
                socioAtendido.ListaDeAlquileres.Add(new Alquiler<Pelicula>(Blockbuster.ListaDePeliculas[8]));
                richTextBox1.Text = socioAtendido.Mostrar();
                lblError.Visible = false;
            }
            else
            {
                lblError.Visible = true;
            }
        }
    }
}
