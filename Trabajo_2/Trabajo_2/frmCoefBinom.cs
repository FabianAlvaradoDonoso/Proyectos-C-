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
    public partial class frmCoefBinom : Form
    {
        int contador = 0;
        public frmCoefBinom()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Esta seguro de Salir?", "Coeficiente Binomial", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (r == DialogResult.Yes) this.Close();
        }// SALIR.

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            lblR.Text = "";
            lblM.Text = "";
            txtN1.Clear();
            txtN2.Clear();
            txtN1.Focus();
        }//BORRAR.

        private void btnCalcular_Click(object sender, EventArgs e)//BOTON CALCULAR.
        {
            try
            {
                lblResultado.Text = (coefBinominal(Convert.ToInt64(txtN1.Text), Convert.ToInt64(txtN2.Text))).ToString();
                lblR.Text = contador.ToString();
                lblM.Text = (contador * 32).ToString();
                contador = 0;
            }
            catch(System.FormatException)
            {
                MessageBox.Show("El formato no es correcto, Ingrese otro", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnBorrar_Click(sender, e);
                contador = 0;
            }
        } 

        long coefBinominal(long numero1, long numero2)
        {
            if (numero2 > numero1)
            {
                return 0;
            }
            else
            {
                if (numero2 == 0)
                {
                    return 1;
                }
                else
                {
                    contador += 2;
                    return (coefBinominal(numero1 - 1, numero2 - 1) + coefBinominal(numero1 - 1, numero2));
                }
            }
        }//CALCULO COEF. BINOM.

        private void btnComprobar_Click_1(object sender, EventArgs e)
        {
            txtN1.Text = "5";
            txtN2.Text = "5";
        }//BOTON COMPROBAR.


       

    }
}
