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
    public partial class frmAckermann : Form
    {
        int contador = 0;
        public frmAckermann()
        {
            InitializeComponent();
            txtN1.Focus();
        }
        
        private void btnBorrar_Click(object sender, EventArgs e)//BOTON BORRAR.
        {
            lblResultado.Text = "";
            lblR.Text = "";
            lblM.Text = "";
            txtN1.Clear();
            txtN2.Clear();
            txtN1.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Esta seguro?", "Ackermann",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes) this.Close();
        }//BOTON SALIR.

        long Ackermann(long m, long n)
        {
            if(m == 0)
            {
                return n + 1;
            }
            else
            {
                if(n == 0 && m > 0)
                {
                    contador++;
                    return Ackermann(m - 1, 1);
                }
                else
                {
                    if (m > 0 && n > 0)
                    {
                        contador++;
                        return Ackermann(m - 1, Ackermann(m, n - 1));
                    }
                    
                }
            }
            return 0;
        }

        private void btnCalcular_Click(object sender, EventArgs e)//BOTON CALCULAR.
        {
            try
            {
                lblResultado.Text = (Ackermann(Convert.ToInt64(txtN1.Text), Convert.ToInt64(txtN2.Text))).ToString();
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

        private void btnComprobar_Click(object sender, EventArgs e)//BOTON COMPROBAR.
        {
            txtN1.Text = "2";
            txtN2.Text = "3";
        }


    }
}
