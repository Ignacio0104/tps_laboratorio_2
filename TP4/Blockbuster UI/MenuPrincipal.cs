using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blockbuster_UI
{
    public partial class MenuPrincipal : Form
    {
        Usuario usuarioLogueado;
        int numeroLegajo;
        CancellationTokenSource cancelacionAutoguardado;
        bool autoguardadoActivado = false;
        public MenuPrincipal(int numeroLegajo)
        {
            InitializeComponent();
            this.numeroLegajo = numeroLegajo;
            MostrarHora();
            cancelacionAutoguardado= new CancellationTokenSource();
            lblAutoGuardado.Text = "Autoguardado OFF";
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            CargarMenu(new FormVenta());
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            CargarMenu(new Inventario());
        }


        /// <summary>
        /// Metodo para cambiar las diferentes pantallas del menu principal
        /// </summary>
        /// <param name="formulario"></param>
        private void CargarMenu(Form formulario) 
        {
            if (this.panelPrincipal.Controls.Count > 0)
            {
                this.panelPrincipal.Controls.RemoveAt(0);
            }

            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(formulario);
            this.panelPrincipal.Tag = formulario;
            formulario.Show();
        }


        private void btnSocios_Click(object sender, EventArgs e)
        {
            CargarMenu(new ListaSocios());
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult opcion = MessageBox.Show("Esta seguro que desea salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (opcion == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else
                {
                    try
                    {
                        cancelacionAutoguardado.Cancel();
                        MetodosSQL.GuardarListaUsuarios(Blockbuster.ListaDeEmpleados);
                        ClaseSerializadora<List<Socio>>.EscribirXml(Blockbuster.ListaDeSocios, "baseDatosSocios");
                        ClaseSerializadora<List<Producto>>.EscribirJson(Blockbuster.ListaDeProductos, "baseDatosProductos");
                        ClaseSerializadora<List<Pelicula>>.EscribirJson(Blockbuster.ListaDePeliculas, "baseDatosPeliculas");
                        
                        using (StreamWriter outputfile = File.AppendText($".\\Recursos\\Facturacion-{DateTime.Now.ToString("dd-MM-yyyy")}.txt"))
                        {
                            outputfile.WriteLine(Blockbuster.FacturacionDiaria);
                        }
                        MessageBox.Show("Todos los datos han sido guardados exitósamente", "Guardado con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception exc)
                    {
                        DialogResult opcionDos = MessageBox.Show("Hubo un error al guardar los datos \n ¿Desea salir y perder los datos no guardados?", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                        if (opcionDos == DialogResult.Cancel)
                        {

                            e.Cancel = true;
                        }
                    }
                }
            }            
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            Blockbuster.ListaDeProductos = ClaseSerializadora<List<Producto>>.LeerJson("baseDatosProductos");
            Blockbuster.ListaDePeliculas = ClaseSerializadora<List<Pelicula>>.LeerJson("baseDatosPeliculas");
            Blockbuster.ListaDeSocios = ClaseSerializadora<List<Socio>>.LeerXml("baseDatosSocios");
            usuarioLogueado = Blockbuster.BuscarUsuario(numeroLegajo);
            lblNombreUsuario.Text = $"{usuarioLogueado.Nombre} {usuarioLogueado.Apellido}";
            if (usuarioLogueado.EsAdmin)
                btnListaEmpleados.Visible = true;
            else
                btnListaEmpleados.Visible = false;
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSalirSinGuardar_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("Esta a punto de salir sin guardar los datos\n¿Esta seguro de que desea continuar?", "Salir sin guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (opcion == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnListaEmpleados_Click(object sender, EventArgs e)
        {
            CargarMenu(new ListaEmpleados());
        }

        private void MostrarHora()
        {
            Task task = Task.Run(() =>
            {
                do
                {
                    ActualizarReloj();
                    Thread.Sleep(1000);
                } while (true);
            });
        }

        private void ActualizarReloj()
        {
            if(lblReloj.InvokeRequired)
            {
                Action delegadoActualizarHora = ActualizarReloj;
                lblReloj.Invoke(delegadoActualizarHora);
            }
            else
            {
                lblReloj.Text = DateTime.Now.ToString("dd/MM/yyy HH:mm:ss");
            }
        }

        private void AutoGuardado(CancellationToken cancelacion)
        {
            Task task = Task.Run(() =>
            {
                while(!cancelacion.IsCancellationRequested)
                {
                    ActualizarBaseDeDatos();
                    MostrarInfoActualizacion();
                    Thread.Sleep(5000);
                }
            });
        }

        private void ActualizarBaseDeDatos()
        {
            ClaseSerializadora<List<Socio>>.EscribirXml(Blockbuster.ListaDeSocios, "baseDatosSocios");
            ClaseSerializadora<List<Producto>>.EscribirJson(Blockbuster.ListaDeProductos, "baseDatosProductos");
            ClaseSerializadora<List<Pelicula>>.EscribirJson(Blockbuster.ListaDePeliculas, "baseDatosPeliculas");
            MetodosSQL.GuardarListaUsuarios(Blockbuster.ListaDeEmpleados);
            using (StreamWriter outputfile = File.AppendText($".\\Recursos\\Facturacion-{DateTime.Now.ToString("dd-MM-yyyy")}.txt"))
            {
                outputfile.WriteLine(Blockbuster.FacturacionDiaria);
            }
        }

        private void MostrarInfoActualizacion()
        {
            if (lblActualizacionInfo.InvokeRequired)
            {
                Action delegadoMostrarInfo = MostrarInfoActualizacion;
                lblActualizacionInfo.Invoke(delegadoMostrarInfo);
            }
            else
            {
                lblActualizacionInfo.Text = "Ult actualización: " + DateTime.Now.ToString();
            }
        }

        private void picSwitchOn_Click(object sender, EventArgs e)
        {
            lblAutoGuardado.Text = "Autoguardado ON";
            AutoGuardado(cancelacionAutoguardado.Token);
            autoguardadoActivado = true;
            picSwitchOff.Visible = true;
            picSwitchOn.Visible = false;           
        }

        private void picSwitchOff_Click(object sender, EventArgs e)
        {
            lblAutoGuardado.Text = "Autoguardado OFF";
            cancelacionAutoguardado.Cancel();
            autoguardadoActivado = false;
            picSwitchOff.Visible = false;
            picSwitchOn.Visible = true; 
            cancelacionAutoguardado = new CancellationTokenSource();
        }
    }
}
