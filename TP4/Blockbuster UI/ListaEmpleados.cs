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
    public partial class ListaEmpleados : Form
    {
        public ListaEmpleados()
        {
            InitializeComponent();
            CargarEmpleados();
        }

        private void dGridEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    int id = (int)dGridEmpleados.Rows[e.RowIndex].Cells[0].Value;
                    AgregarEmpleado frmModificacion = new AgregarEmpleado(Blockbuster.BuscarUsuario(id));                 
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
                dGridEmpleados.DataSource = null;
                dGridEmpleados.DataSource = Blockbuster.ListaDeEmpleados;
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
    }
}
