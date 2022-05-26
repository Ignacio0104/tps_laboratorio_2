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
    public partial class ListaSocios : Form
    {
        public ListaSocios()
        {
            InitializeComponent();    
        }

        private void CargarSocios()
        {
            foreach (Socio item in Blockbuster.ListaDeSocios)
            {
                int indice = dGridSocios.Rows.Add();
                dGridSocios.Rows[indice].Cells[0].Value = item.IdSocio;
                dGridSocios.Rows[indice].Cells[1].Value = item.NombreSocio;
                dGridSocios.Rows[indice].Cells[2].Value = item.ApellidoSocio;
                dGridSocios.Rows[indice].Cells[3].Value = item.EmailSocio;
                dGridSocios.Rows[indice].Cells[4].Value = item.TelefonoSocio;
                dGridSocios.Rows[indice].Cells[5].Value = item.LimitePeliculas;
                dGridSocios.Rows[indice].Cells[6].Value = item.Penalidad + "%";
                dGridSocios.Rows[indice].Cells[7].Value = (item is SocioClasico socioClasico
                    ? socioClasico.TarjetaDeCredito : "N/A");
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
        }
    }
}
