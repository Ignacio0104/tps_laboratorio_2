using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            lblResultado.Text = "0";
            cmbOperador.SelectedIndex = 0;
           // lstOperaciones.Items.Clear();
        }

        private static double Operar(string numero1, string numero2,string operador)
        {
            Operando operadorUno = new Operando(numero1);
            Operando operadorDos = new Operando(numero2);
            double resultado = 0;


            resultado = Calculadora.Operar(operadorUno, operadorDos, Convert.ToChar(operador));
            return resultado;
        }


        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            cmbOperador.Items.Add("");
            cmbOperador.Items.Add('+');
            cmbOperador.Items.Add('-');
            cmbOperador.Items.Add('/');
            cmbOperador.Items.Add('*');
            Limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text , cmbOperador.Text).ToString();
            lstOperaciones.Items.Add($"{txtNumero1.Text} {cmbOperador.Text} {txtNumero2.Text} = {lblResultado.Text} ");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Esta seguro de que desea salir?", "Salir", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(opcion == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Operando.DecimalBinario(lblResultado.Text);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Operando.BinarioDecimal(lblResultado.Text);
        }
    }
}
