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
    public partial class ListaSocios : Form
    {
        Color color;
        public ListaSocios()
        {
            InitializeComponent();
            cmbCriterioBusqueda.Items.Add("ID");
            cmbCriterioBusqueda.Items.Add("Nombre");
            cmbCriterioBusqueda.Items.Add("Apellido");
            cmbCriterioBusqueda.Items.Add("Mail");
            cmbCriterioBusqueda.SelectedIndex = 0;
        }

        private void CargarSocios()
        {
            color = ColorTranslator.FromHtml("#003566");
            dGridSocios.DefaultCellStyle.BackColor = color;
            color = ColorTranslator.FromHtml("#ffc300");
            dGridSocios.DefaultCellStyle.ForeColor = color;
            foreach (Socio item in Blockbuster.ListaDeSocios)
            {
                int indice = dGridSocios.Rows.Add();
                CargarSociosConFiltro(item, indice);
                indice++;
            }
        }

        private void ListaSocios_Load(object sender, EventArgs e)
        {
            CargarSocios();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarSocio frmSocio = new AgregarSocio();

            frmSocio.ShowDialog();

            if(frmSocio.DialogResult == DialogResult.OK)
            {
                dGridSocios.Rows.Clear();
                CargarSocios();
            }
        }

        private void dGridSocios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int idSocio = (int)dGridSocios.Rows[e.RowIndex].Cells[0].Value;
                    Socio socioAux = Blockbuster.BuscarSocio(idSocio);

                    if(socioAux is not null)
                    {
                        AgregarSocio frmModificacion = new AgregarSocio(socioAux);

                        frmModificacion.ShowDialog();

                        if (frmModificacion.DialogResult == DialogResult.OK)
                        {
                            dGridSocios.Rows.Clear();
                            CargarSocios();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void dGridSocios_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dGridSocios.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#468faf");
            }
        }

        private void dGridSocios_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dGridSocios.RowCount - 1)
            {
                dGridSocios.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#003566");
            }
        }


        private void CargarSociosConFiltro(Socio socio, int indice)
        {
            dGridSocios.Rows[indice].Cells[0].Value = socio.IdSocio;
            dGridSocios.Rows[indice].Cells[1].Value = socio.NombreSocio;
            dGridSocios.Rows[indice].Cells[2].Value = socio.ApellidoSocio;
            dGridSocios.Rows[indice].Cells[3].Value = socio.EmailSocio;
            dGridSocios.Rows[indice].Cells[4].Value = socio.TelefonoSocio;
            dGridSocios.Rows[indice].Cells[5].Value = socio.LimitePeliculas;
            dGridSocios.Rows[indice].Cells[6].Value = socio.Penalidad + "%";
            dGridSocios.Rows[indice].Cells[7].Value = (socio is SocioClasico socioClasico
                ? socioClasico.TarjetaDeCredito : "N/A");                                        
        }


        private void txtInputBusqueda_TextChanged(object sender, EventArgs e)
        {
            dGridSocios.Rows.Clear();
            foreach (Socio item in Blockbuster.ListaDeSocios)
            {
                int idAux;
                int indice;
                switch (cmbCriterioBusqueda.SelectedItem)
                {
                    case "ID":
                        int.TryParse(txtInputBusqueda.Text, out idAux);
                        if (item.IdSocio == idAux)
                        {
                            indice = dGridSocios.Rows.Add();
                            CargarSociosConFiltro(item, indice);
                            indice++;
                        }
                        break;
                    case "Nombre":
                        if (item.NombreSocio.ToLower().Contains(txtInputBusqueda.Text.ToLower()))
                        {
                            indice = dGridSocios.Rows.Add();
                            CargarSociosConFiltro(item, indice);
                            indice++;
                        }
                        break;
                    case "Apellido":
                        if (item.ApellidoSocio.ToLower().Contains(txtInputBusqueda.Text.ToLower()))
                        {
                            indice = dGridSocios.Rows.Add();
                            CargarSociosConFiltro(item, indice);
                            indice++;
                        }
                        break;
                    case "Mail":
                        if (item.EmailSocio.ToLower().Contains(txtInputBusqueda.Text.ToLower()))
                        {
                            indice = dGridSocios.Rows.Add();
                            CargarSociosConFiltro(item, indice);
                            indice++;
                        }
                        break;
                }

            }
        }
    }
}
