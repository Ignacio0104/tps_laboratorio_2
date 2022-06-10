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

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Usuario item in Blockbuster.ListaDeEmpleados)
            {
                MetodosSQL.Guardar(item);
            }
            
        }
    }
}
