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

        /// <summary>
        /// Limpia los campos de la calculadora
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            lblResultado.Text = "0";
            cmbOperador.SelectedIndex = 0;
        }

        /// <summary>
        /// Invoca a la funcion Operar de la clase Calculadora
        /// </summary>
        /// <param name="numero1">Recibe un operando en formato string</param>
        /// <param name="numero2">Recibe un operando en formato string</param>
        /// <param name="operador">Recibe la operacion en formato string</param>
        /// <returns>Devuelve el resultado de la operacion o cero si hubo error</returns>
        private static double Operar(string numero1, string numero2,string operador)
        {
            Operando operadorUno = new Operando(numero1);
            Operando operadorDos = new Operando(numero2);
            double resultado = 0;
            char operadorVerificado = '+';

            char.TryParse(operador, out operadorVerificado);
            resultado = Calculadora.Operar(operadorUno, operadorDos, operadorVerificado);

            return resultado;
        }


        /// <summary>
        /// Carga de operadores al ComboBo cmbOperador al momento de carga del form. Llamada al metodo limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            cmbOperador.Items.Add("");
            cmbOperador.Items.Add('+');
            cmbOperador.Items.Add('-');
            cmbOperador.Items.Add('/');
            cmbOperador.Items.Add('*');
            Limpiar();
        }

        /// <summary>
        /// Invocacion al metodo limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Invocacion al metodo Operar (clase operando)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double prueba = 0;
            double resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
            if (resultado == double.MinValue)
            {
                lblResultado.Text = "Operacion invalida";
            }
            else
            {
                lblResultado.Text = resultado.ToString();
                lstOperaciones.Items.Add($"{(!double.TryParse(txtNumero1.Text,out prueba) ? "0" : txtNumero1.Text)} " +
                    $"{(cmbOperador.Text == "" ? "+" : cmbOperador.Text)} " +
                    $"{(!double.TryParse(txtNumero2.Text, out prueba) ? "0" : txtNumero2.Text)} = {lblResultado.Text} ");
            }

        }

        /// <summary>
        /// Llamada al método form_closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
          this.Close();     
        }

        /// <summary>
        /// Invocacion al metodo para convertir a binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string numeroOriginal = lblResultado.Text;
            lblResultado.Text = Operando.DecimalBinario(lblResultado.Text);
            lstOperaciones.Items.Add($"{(lblResultado.Text == "Valor invalido" ? "" : numeroOriginal + "b = ")}" +
            $"{(lblResultado.Text == "Valor invalido" ? "Error" : lblResultado.Text + "d")}");
        }
        /// <summary>
        /// Invocacion al metodo para convertir a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string numeroOriginal = lblResultado.Text;
            lblResultado.Text = Operando.BinarioDecimal(lblResultado.Text);
            lstOperaciones.Items.Add($"{(lblResultado.Text == "Valor invalido" ? "" : numeroOriginal + "b = ")}" +
                $"{(lblResultado.Text == "Valor invalido"? "Error" : lblResultado.Text + "d")}");
            
        }
        /// <summary>
        /// Consulta y cierre del formulario en consencuencia (desde la cruz)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Esta seguro de que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.No)
            {
                e.Cancel = true;
            }
          
        }
    }
}
