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
            dGridEmpleados.DataSource = Blockbuster.ListaDeEmpleados;
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
                        MetodosSQL.GuardarUsuario(frmModificacion.usuario);
                        Blockbuster.ListaDeEmpleados = MetodosSQL.LeerListaUsuarios();
                        dGridEmpleados.DataSource = null;
                        dGridEmpleados.DataSource = Blockbuster.ListaDeEmpleados;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }

            }
        }
    }
}
