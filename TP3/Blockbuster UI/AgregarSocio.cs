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
                Validaciones();
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
                lblError.Visible = false; ;
                this.DialogResult = DialogResult.OK;
            }catch(Exception exc)
            {
                lblError.Visible = true;
                lblError.Text = $"* {exc.Message}";
            }
        }

        private void Validaciones()
        {
            if(!txtBoxNombreSocio.Text.All(char.IsLetter))
            {
                throw new NombreOApellidoInvalido("Favor revisar el campo nombre");
            }

            if (!txtBoxApellidoSocio.Text.All(char.IsLetter))
            {
                throw new NombreOApellidoInvalido("Favor revisar el campo apellido");
            }

            if(!Logica.VerificarEmail(txtBoxEmailSocio.Text.Trim().ToLower()))
            {
                throw new EmailInvalido("Favor verificar el E-mail ingresado");
            }

            if (!Logica.VerificarTelefonoArgentina(txtBoxTelefono.Text))
            {
                throw new TelefonoArgInvalido("Favor verificar el telefono ingresado");
            }

            if (!Logica.VerificarTarjetaCredito(txtBoxTarjetaSocio.Text))
            {
                if(rdtSocioClasico.Checked)
                    throw new TarjetaCreditoInvalida("Favor verificar la tarjeta de crédito ingresada");
            }
        }
    }
}
