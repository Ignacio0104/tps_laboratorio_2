using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeClases;
using BibliotecaDeClases.Excepciones;

namespace Blockbuster_UI
{
    public partial class AgregarSocio : Form
    {
        public AgregarSocio()
        {
            InitializeComponent();
        }

        private void AgregarSocio_Load(object sender, EventArgs e)
        {

        }

        private void rdtSocioPremium_CheckedChanged(object sender, EventArgs e)
        {
            if (rdtSocioPremium.Checked)
            {
                panTarjeta.Visible = false;
            }
            else
            {
                panTarjeta.Visible = true;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdtSocioClasico.Checked)
                {
                    Blockbuster.ListaDeSocios.Add(new SocioClasico(txtBoxNombreSocio.Text, txtBoxApellidoSocio.Text,
                        txtBoxEmailSocio.Text, txtBoxTelefono.Text, txtBoxTarjetaSocio.Text));
                }
                else
                {
                    Blockbuster.ListaDeSocios.Add(new SocioPremium(txtBoxNombreSocio.Text, txtBoxApellidoSocio.Text,
                                           txtBoxEmailSocio.Text, txtBoxTelefono.Text));
                }

                this.DialogResult = DialogResult.OK;
            }catch(Exception exc)
            {
                MessageBox.Show("Favor chequear datos");
            }
        }

        private void Validaciones()
        {
            if(!txtBoxNombreSocio.Text.Any(char.IsLetter)||!txtBoxApellidoSocio.Text.Any(char.IsLetter))
            {
                throw new NombreOApellidoInvalido("Los campos nombre y apellido solo deben contener letras");
            }

            if(!new EmailAddressAttribute().IsValid(txtBoxEmailSocio.Text))
            {
                throw new EmailInvalido("Favor verificar el E-mail ingresado");
            }
        }
    }
}
