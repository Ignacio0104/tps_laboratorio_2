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
    public partial class ListaEmpleados : Form
    {
        Usuario usuarioLogueado;
        Color color;

        public ListaEmpleados(Usuario usuarioLogueado)
        {
            InitializeComponent();
            this.usuarioLogueado = usuarioLogueado;
            CargarEmpleados();
            color = ColorTranslator.FromHtml("#003566");
            dGridEmpleados.DefaultCellStyle.BackColor = color;
            color = ColorTranslator.FromHtml("#ffc300");
            dGridEmpleados.DefaultCellStyle.ForeColor = color;
        }

        private void dGridEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    int id = (int)dGridEmpleados.Rows[e.RowIndex].Cells[0].Value;
                    AgregarEmpleado frmModificacion = new AgregarEmpleado(Blockbuster.BuscarUsuario(id), usuarioLogueado);                 
                    frmModificacion.ShowDialog();
                    if (frmModificacion.DialogResult == DialogResult.OK)
                    {
                        dGridEmpleados.Rows.Clear();
                        CargarEmpleados();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEmpleado frmModificacion = new AgregarEmpleado();
            frmModificacion.ShowDialog();
            if (frmModificacion.DialogResult == DialogResult.OK)
            {
                dGridEmpleados.Rows.Clear();
                CargarEmpleados();
            }
        }

        private void CargarEmpleados()
        {
            foreach (Usuario item in Blockbuster.ListaDeEmpleados)
            {
                int indice = dGridEmpleados.Rows.Add();
                dGridEmpleados.Rows[indice].Cells[0].Value = item.Legajo;
                dGridEmpleados.Rows[indice].Cells[1].Value = item.Nombre;
                dGridEmpleados.Rows[indice].Cells[2].Value = item.Apellido;
                dGridEmpleados.Rows[indice].Cells[3].Value = item.DNI.ToString();
                dGridEmpleados.Rows[indice].Cells[4].Value = item.NombreUsuario;
                dGridEmpleados.Rows[indice].Cells[5].Value = "$" + item.Salario.ToString();
                dGridEmpleados.Rows[indice].Cells[6].Value = item.FechaIngreso.ToShortDateString();
                dGridEmpleados.Rows[indice].Cells[7].Value = item.FechaNacimiento.ToShortDateString();
                indice++;
            }
        }

        private void dGridEmpleados_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dGridEmpleados.RowCount - 1)
            {
                dGridEmpleados.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#003566");
            }
        }

        private void dGridEmpleados_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dGridEmpleados.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#468faf");
            }
        }
    }
}
