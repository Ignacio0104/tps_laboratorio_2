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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Usuario item in Blockbuster.ListaDeEmpleados)
            {
                sb.AppendLine(item.ToString());
            }

            if (sb.Length < 1)
            {
                richTextBox1.Text = "No hay peliculas";
            }
            else
            {
                richTextBox1.Text = sb.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClaseSerializadora<List<Socio>>.Escribir(Blockbuster.ListaDeSocios, "baseDeDatosMixta");
        }
    }
}
