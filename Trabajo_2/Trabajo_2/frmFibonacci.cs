using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_2
{
    public partial class frmFibonacci : Form
    {
        int contador = 0;
        public frmFibonacci()
        {
            InitializeComponent();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            lblResultado.Text = "";
            txtNumero.Focus();
            lblM.Text = "";
            lblR.Text = "";
        }//BOTON BORRAR.

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Esta seguro de Salir?", "Fibonacci", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (r == DialogResult.Yes) this.Close();
        }//BOTON SALIR.

        private void btnCalcular_Click(object sender, EventArgs e)//BOTON CALCULAR.
        {
            try
            {
                lblResultado.Text = (fibonacci(Convert.ToInt64(txtNumero.Text))).ToString();
                lblR.Text = contador.ToString();
                lblM.Text = (contador * 24).ToString();
                contador = 0;
            }
            catch(System.FormatException)
            {
                MessageBox.Show("El formato no es correcto, Ingrese otro", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnBorrar_Click(sender, e);
                contador = 0;
            }
        }

        long fibonacci(long numero)
        {
            
            if (numero < 2) return numero;
            else
            {
                contador += 2;
                return fibonacci(numero - 1) + fibonacci(numero - 2);
            }
        }//CALCULO DE FIBONACCI.

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "30";
        }//COMPROBACION.
    }
}
