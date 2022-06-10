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
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Usuario> listaAux = new List<Usuario>();
            listaAux = MetodosSQL.LeerListaUsuarios();
            dGridEmpleados.DataSource = listaAux;
        }
    }
}
