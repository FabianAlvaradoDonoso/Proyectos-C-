using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Pago_Clientes_2
{
   
    public partial class Trabajador_Nuevo : Form
    {
        double suma1, suma2, porcentaje, afp, descuento;
        ConexionDatos c = new ConexionDatos();

        public Trabajador_Nuevo()
        {
            InitializeComponent();
            txtSueldo.Text = "0";
            txtBono.Text = "0";
            txtGrafic.Text = "0";
            txtOtrosImpo.Text = "0";
            txtMovil.Text = "0";
            txtColac.Text = "0";
            txtOtrosNoImpon.Text = "0";
            txtSeguroC.Text = "$0";
            txtOtroDesc.Text = "$0";
            lblTotalImpo.Text = "$O";
            lblTotalNoImpon.Text = "$O";
            nudPorcentaje.Value = 0;
            
        }//Inicializacion

        private void button2_Click(object sender, EventArgs e)
        {
            
            

            suma1= Convert.ToDouble(txtSueldo.Text) + Convert.ToDouble(txtBono.Text) + Convert.ToDouble(txtGrafic.Text) + Convert.ToDouble(txtOtrosImpo.Text);
            lblTotalImpo.Text = suma1.ToString("c0");
            //textBox5.Text = (Convert.ToDouble(textBox5.Text)).ToString("c0");
            //textBox6.Text = (Convert.ToDouble(textBox6.Text)).ToString("c0");
            //textBox7.Text = (Convert.ToDouble(textBox7.Text)).ToString("c0");
            //textBox8.Text = (Convert.ToDouble(textBox8.Text)).ToString("c0");
        }//CLICK IMPONIBLE

        private void button3_Click(object sender, EventArgs e)
        {
            suma2 = Convert.ToDouble(txtMovil.Text) + Convert.ToDouble(txtColac.Text) + Convert.ToDouble(txtOtrosNoImpon.Text);
            lblTotalNoImpon.Text = suma2.ToString("c0");
            //textBox9.Text = (Convert.ToDouble(textBox9.Text)).ToString("c0");
            //textBox10.Text = (Convert.ToDouble(textBox10.Text)).ToString("c0");
            //textBox11.Text = (Convert.ToDouble(textBox11.Text)).ToString("c0");
        }//CLICK NO IMPONIBLE

        private void button4_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
            button3_Click(sender, e);
            lblTotalHaberes.Text = (suma1 + suma2).ToString("c0");
        }//CLICK TOTAL IMPONIBLE

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)//AFP
        {
            porcentaje = Convert.ToDouble(nudPorcentaje.Value);
            afp = suma1 * porcentaje / 100.0;
            lblMontoAFP.Text = afp.ToString("C0"); 
        }

        private void radioButton1_Click(object sender, EventArgs e)//FONASA
        {
            txtSaludI.Enabled = false;
            lblSaludF.Enabled = true;
            lblSaludF.Text = (suma1 * 7.0 / 100.0).ToString("c0");
        }

        private void radioButton2_Click(object sender, EventArgs e)//ISAPRE
        {
            txtSaludI.Enabled = true;
            lblSaludF.Enabled = false;
            //textBox14.Text = (Convert.ToDouble(textBox14.Text)).ToString("c0");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double salud;
            if(radioButton1.Checked){
                salud = suma1 * 7.0 / 100.0;
            }
            else{
                salud = Convert.ToDouble(txtSaludI.Text);
            }

            double afp1 = suma1 * Convert.ToDouble(nudPorcentaje.Value) / 100.0;
            double seguro = Convert.ToDouble(txtSeguroC.Text);
            double otro = Convert.ToDouble(txtOtroDesc.Text);

            descuento = seguro + otro + salud + afp1; 

            lblTotalDesc.Text = descuento.ToString("c0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }//CLICK TOTAL DESCUENTOS

      




    }
}
