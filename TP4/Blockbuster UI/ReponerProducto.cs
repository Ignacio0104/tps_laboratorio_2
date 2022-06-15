using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeClases;

namespace Blockbuster_UI
{
    public partial class ReponerProducto : Form
    {
        public List<Task> listaTareas;
        public CancellationTokenSource cts;
        public ReponerProducto()
        {
            InitializeComponent();
            AnimarMensaje();
            cts = new CancellationTokenSource();
        }

        private void AnimarMensaje()
        {
            Task task = Task.Run(() =>
            {
                do
                {
                    CambiarColor(Color.Red);
                    Thread.Sleep(500);
                    CambiarColor(ColorTranslator.FromHtml("#ffc300"));
                    Thread.Sleep(500);
                } while (true);
            });
        }

        private void CambiarColor(Color color)
        {
            if (lblMensaje.InvokeRequired)
            {
                Action<Color> delegadoCambioColor = color => CambiarColor(color);
                lblMensaje.Invoke(delegadoCambioColor,color);
            }
            else
            {
                lblMensaje.ForeColor = color;
            }
        }

        private void btnLlamarProveedor_Click(object sender, EventArgs e)
        {
            picNoStock.Visible = false;
            btnLlamarProveedor.Enabled = false;
            Task esperarLlamada = Task.Run(() =>
            {
                int vueltas = 0;
                MostrarPanel();
                while (!cts.IsCancellationRequested && vueltas < 5)
                {
                    Thread.Sleep(1000);
                    vueltas++;
                }
                if (!cts.IsCancellationRequested)
                {
                    MessageBox.Show("Llamado exitoso, actualice el inventario al recibir los productos",
                        "Llamada exitosa");
                    this.DialogResult = DialogResult.OK;
                }

            }, cts.Token);

        }

        private void MostrarPanel()
        {
            if (panLlamada.InvokeRequired)
            {
                Action mostrarPanelDelegado = MostrarPanel;
                panLlamada.Invoke(mostrarPanelDelegado);
            }   
            else
            {
                panLlamada.Visible = true;
            }
        }

        private void ReponerProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (!cts.IsCancellationRequested)
                {
                    cts.Cancel();
                    MessageBox.Show("Llamada cancelada");
                }
            }
          
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();         
        }
    }
}
