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
    public partial class frmShift : Form
    {
        int contador = 0;
        public frmShift()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Esta seguro de Salir?", "Multiplicación Shift", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (r == DialogResult.Yes) this.Close();
        }//SALIR.

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            lblResultado.Text = "";
            lblM.Text = "";
            lblR.Text = "";
            txtN1.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                lblResultado.Text = (leftShift(Convert.ToInt32(txtN1.Text), Convert.ToInt32(txtN2.Text))).ToString();
                lblR.Text = contador.ToString();
                lblM.Text = (contador * 8).ToString();
                contador = 0;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("El formato no es correcto, Ingrese otro", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnBorrar_Click(sender,e);
                contador = 0;
            }
            
        }

        public int leftShift(int numero, int nbase)
       {
           contador++;
            return (numero<<Convert.ToInt32(Math.Log10(nbase) / Math.Log10(2)));
       }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            txtN1.Text = "7";
            txtN2.Text = "13";
        }
        
        
    }
}
