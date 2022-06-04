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
    public partial class AgregarSocio : Form, IModificarse
    {
        Socio socioElegido;
        public AgregarSocio()
        {
            InitializeComponent();
        }

        public AgregarSocio(Socio socioElegido):this()
        {
            this.socioElegido = socioElegido;
        }

        public void ActualizarInfo()
        {
            if(socioElegido is not null)
            {
                Validaciones();
                socioElegido.NombreSocio = txtBoxNombreSocio.Text;
                socioElegido.ApellidoSocio = txtBoxApellidoSocio.Text;
                socioElegido.EmailSocio = txtBoxEmailSocio.Text;
                socioElegido.TelefonoSocio = txtBoxTelefono.Text;
                if (socioElegido is SocioClasico socioClasico)
                    socioClasico.TarjetaDeCredito = txtBoxTarjetaSocio.Text;
            }
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
                if (socioElegido is not null)
                {
                    ActualizarInfo();
                }
                else
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
                    lblError.Visible = false;
                }
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

        private void AgregarSocio_Load(object sender, EventArgs e)
        {
            CargarDatosForm();
        }
        public void EliminarObjeto()
        {
            if(socioElegido is not null)
            {
                Blockbuster.ListaDeSocios.Remove(socioElegido);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult eleccion = MessageBox.Show($"¿Esta seguro que desea dar de baja a este socio?", "Dar de baja socio", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (eleccion == DialogResult.Yes)
            {
                EliminarObjeto();
                this.DialogResult = DialogResult.OK;
            }
        }

        public void CargarDatosForm()
        {
            if (socioElegido is not null)
            {
                txtBoxNombreSocio.Text = socioElegido.NombreSocio;
                txtBoxApellidoSocio.Text = socioElegido.ApellidoSocio;
                txtBoxEmailSocio.Text = socioElegido.EmailSocio;
                txtBoxTelefono.Text = socioElegido.TelefonoSocio;

                if (socioElegido is SocioClasico socioClasico)
                    txtBoxTarjetaSocio.Text = socioClasico.TarjetaDeCredito;

                lblIdSocio.Visible = true;
                lblId.Visible = true;
                lblIdSocio.Text = socioElegido.IdSocio.ToString();
                btnBorrar.Visible = true;
            }
            else
            {
                lblIdSocio.Visible = false;
                lblId.Visible = false;
            }
        }
    }
}
