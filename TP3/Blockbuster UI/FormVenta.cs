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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int numeroSocio = -1;

            if (int.TryParse(txtNumeroSocio.Text, out numeroSocio))
            {
                socioAtendido = Blockbuster.BuscarSocio(numeroSocio);

            }

            if (socioAtendido is not null)
            {
                lblID.Text = "ID: ";
                lblLimite.Text = "Limite de peliculas: ";
                lblDisponible.Text = "Limite disponible: ";
                pnlInfoUsuario.Visible = true;

                lblNombreUsuario.Text = socioAtendido.NombreSocio;
                lblApellido.Text = socioAtendido.ApellidoSocio;
                lblID.Text += socioAtendido.IdSocio;
                lblLimite.Text += socioAtendido.LimitePeliculas.ToString();
                lblDisponible.Text += (socioAtendido.LimitePeliculas -socioAtendido.ListaDeAlquileres.Count).ToString();
                lblError.Visible = false;
            }
            else
            {
                lblError.Visible = true;
                pnlInfoUsuario.Visible = false;
            }
        }

    }
}
