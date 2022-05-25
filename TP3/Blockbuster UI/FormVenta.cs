﻿using System;
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
            pnlInfoUsuario.Visible = false;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarInformacionSocios();
        }

        private void btnAgregarAlquiler_Click(object sender, EventArgs e)
        {
            AgregarAlquiler frmAlquiler = new AgregarAlquiler(socioAtendido);

            frmAlquiler.ShowDialog();

            if(frmAlquiler.DialogResult == DialogResult.OK)
            {
                socioAtendido.ListaDeAlquileres.AddRange(frmAlquiler.listaAlquilerAux);
                CargarInformacionSocios();
            }
            else
            {
                foreach (Alquiler<Pelicula> item in frmAlquiler.listaAlquilerAux)
                {
                    Blockbuster.ListaDePeliculas[Blockbuster.BuscarIndicePelicula(item.Pelicula)].Stock++;
                }
            }
        }

        private void CargarInformacionSocios()
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
                if (socioAtendido.ListaDeAlquileres.Count >= socioAtendido.LimitePeliculas)
                {
                    btnAgregarAlquiler.Enabled = false;
                }
                else
                {
                    btnAgregarAlquiler.Enabled = true;
                }
                if (socioAtendido.ListaDeAlquileres.Count > 0)
                {
                    dGridAlquileres.Visible = true;
                    dGridAlquileres.Rows.Clear();
                    lblNoHayPeliculas.Visible = false;
                    for (int i = 0; i < socioAtendido.ListaDeAlquileres.Count; i++)
                    {
                        int indice = dGridAlquileres.Rows.Add();
                        dGridAlquileres.Rows[indice].Cells[0].Value = socioAtendido.ListaDeAlquileres[i].Pelicula.TituloPelicula;
                        dGridAlquileres.Rows[indice].Cells[1].Value = socioAtendido.ListaDeAlquileres[i].Pelicula.DuracionPelicula + " min";
                        dGridAlquileres.Rows[indice].Cells[2].Value = "$ " + (int)socioAtendido.ListaDeAlquileres[i].Pelicula.PrecioDeAlquiler;
                        dGridAlquileres.Rows[indice].Cells[3].Value = (int)socioAtendido.ListaDeAlquileres[i].Pelicula.DiasDeAlquiler;
                        dGridAlquileres.Rows[indice].Cells[4].Value = socioAtendido.ListaDeAlquileres[i].FechaDeAlquiler.ToShortDateString();
                        indice++;
                    }
                }
                else
                {
                    dGridAlquileres.Visible = false;
                    lblNoHayPeliculas.Visible = true;
                }

                lblNombreUsuario.Text = socioAtendido.NombreSocio;
                lblApellido.Text = socioAtendido.ApellidoSocio;
                lblID.Text += socioAtendido.IdSocio;
                lblLimite.Text += socioAtendido.LimitePeliculas.ToString();
                lblDisponible.Text += (socioAtendido.LimitePeliculas - socioAtendido.ListaDeAlquileres.Count).ToString();
                lblError.Visible = false;
            }
            else
            {
                lblError.Visible = true;
                pnlInfoUsuario.Visible = false;
            }
        }

        private void dGridAlquileres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    Devolucion frmDevolucion = new Devolucion(socioAtendido.ListaDeAlquileres[e.RowIndex]);
                    frmDevolucion.ShowDialog();  
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
