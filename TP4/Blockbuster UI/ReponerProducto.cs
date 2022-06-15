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
        public ReponerProducto()
        {
            InitializeComponent();
            AnimarMensaje();

        }

        private void AnimarMensaje()
        {
            Task task = Task.Run(() =>
            {
                do
                {
                    CambiarColor();
                    Thread.Sleep(500);
                    lblMensaje.ForeColor = ColorTranslator.FromHtml("#ffc300");
                } while (true);
            });
        }

        private void CambiarColor()
        {
            if (lblMensaje.InvokeRequired)
            {
                Action delegadoCambioColor = CambiarColor;
                lblMensaje.Invoke(delegadoCambioColor);
            }
            else
            {
                lblMensaje.ForeColor = Color.Red;
                
            }
        }



    }
}
