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
    public partial class frmFuncionR : Form
    {
        int contador = 0;
        public frmFuncionR()
        {
            InitializeComponent();
        }

        private void btnCalcR_Click(object sender, EventArgs e)
        {
            try
            {
                lblResultadoR.Text = (evaluarFuncionR(Convert.ToInt64(txtNumero2.Text))).ToString();
                lblRegistros.Text = contador.ToString();
                lblMemoria.Text = (contador * 12).ToString();
                contador = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show("El formato no es correcto, Ingrese otro.", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnBorrar_Click(sender, e);
                contador = 0;
            }
        }//BOTON CALCULAR.

        long evaluarFuncionR(long numero)
        {

            if (numero > 100)
            {
                return numero - 10;
            }
            else
            {
                contador++;
                return evaluarFuncionR(evaluarFuncionR(numero + 11));
            }
        }//EVALUAR FUNCION R.

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lblResultadoR.Text = "";
            txtNumero2.Clear();
            txtNumero2.Focus();
            lblRegistros.Text = "";
            lblMemoria.Text = "";
        }//BOTON BORRAR.

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Esta seguro de Salir?", "Evaluar Función R", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (r == DialogResult.Yes) this.Close();
        }//BOTON SALIR.

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            txtNumero2.Text = "-98";
        }//BOTON COMPROBAR
    }
}
