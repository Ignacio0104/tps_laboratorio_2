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
using System.Media;

namespace Blockbuster_UI
{
    public partial class FormVenta : Form
    {
        Socio socioAtendido;
        Color color;
        public FormVenta()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarInformacionSocios();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la carga de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                   
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
                    color = ColorTranslator.FromHtml("#003566");
                    dGridAlquileres.DefaultCellStyle.BackColor = color;
                    color = ColorTranslator.FromHtml("#ffc300");
                    dGridAlquileres.DefaultCellStyle.ForeColor = color;

                    for (int i = 0; i < socioAtendido.ListaDeAlquileres.Count; i++)
                    {

                        int indice = dGridAlquileres.Rows.Add();
                        dGridAlquileres.Rows[indice].Cells[0].Value = socioAtendido.ListaDeAlquileres[i].Pelicula.TituloPelicula;
                        dGridAlquileres.Rows[indice].Cells[1].Value = socioAtendido.ListaDeAlquileres[i].Pelicula.DuracionPelicula + " min";
                        dGridAlquileres.Rows[indice].Cells[2].Value = "$ " + (int)socioAtendido.ListaDeAlquileres[i].Pelicula.PrecioDeAlquiler;
                        dGridAlquileres.Rows[indice].Cells[3].Value = (int)socioAtendido.ListaDeAlquileres[i].Pelicula.DiasDeAlquiler;
                        dGridAlquileres.Rows[indice].Cells[4].Value = socioAtendido.ListaDeAlquileres[i].FechaDeAlquiler.ToShortDateString();
                        
                        int difereciaDias = (int)(DateTime.Now - socioAtendido.ListaDeAlquileres[i].FechaDeAlquiler).TotalDays;

                        if (difereciaDias > (int)socioAtendido.ListaDeAlquileres[i].Pelicula.DiasDeAlquiler)
                        {
                            dGridAlquileres.Rows[indice].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#e63946");
                            dGridAlquileres.Rows[indice].DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#f1faee");
                        }
                        else if(difereciaDias == (int)socioAtendido.ListaDeAlquileres[i].Pelicula.DiasDeAlquiler)
                        {
                            dGridAlquileres.Rows[indice].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#f77f00");
                            dGridAlquileres.Rows[indice].DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#f1faee");
                        }
                           
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
                    Devolucion frmDevolucion = new Devolucion(socioAtendido.ListaDeAlquileres[e.RowIndex],socioAtendido is SocioPremium);
                    frmDevolucion.ShowDialog();

                    if (frmDevolucion.DialogResult == DialogResult.OK)
                    {
                        Blockbuster.ListaDePeliculas[Blockbuster.BuscarIndicePelicula(socioAtendido.ListaDeAlquileres[e.RowIndex].Pelicula)].Stock++;
                        socioAtendido.ListaDeAlquileres.RemoveAt(e.RowIndex);                     
                        CargarInformacionSocios();
                    }
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,"Error",MessageBoxButtons.OK);
            }
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            pnlInfoUsuario.Visible = false;
        }

        private void panTarjetaSocio_Paint(object sender, PaintEventArgs e)
        {
            color = ColorTranslator.FromHtml("#ffd60a");
            ControlPaint.DrawBorder(e.Graphics, this.panTarjetaSocio.ClientRectangle, color, ButtonBorderStyle.Solid) ;
        }
    }
}
