using System;
using System.Reflection;
using System.Threading;
using System.Globalization;
using System.Resources;
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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmCeros Ceros = new frmCeros();
            Ceros.ShowDialog();
        }//CANTIDAD CEROS.

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmShift s = new frmShift();
            s.ShowDialog();
        }//MULTIPLICACION SHIFT.

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmFuncionR R = new frmFuncionR();
            R.ShowDialog();
        }//FUNCION R.

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmCoefBinom C = new frmCoefBinom();
            C.ShowDialog();
        }//COEFICIENTE BINOMIAL.

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmFibonacci f = new frmFibonacci();
            f.ShowDialog();
        }//FIBONACCI.

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmAckermann A = new frmAckermann();
            A.ShowDialog();
        }//ACKERMANN.

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            frmInfo I = new frmInfo();
            I.ShowDialog();
        }//INFO.

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Esta seguro de Salir?", "Trabajo Computacional", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (r == DialogResult.Yes) this.Close();
        }//SALIR.


        /*************************************CAMBIO COLORES DE BOTONES******************/
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Trabajo_2.Properties.Resources.c2;
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Trabajo_2.Properties.Resources.c2_1;
        }
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = Trabajo_2.Properties.Resources.c3;
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Trabajo_2.Properties.Resources.c3_1;
        }
        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Trabajo_2.Properties.Resources.c4;
        }
        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Trabajo_2.Properties.Resources.c4_1;
        }
        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Image = Trabajo_2.Properties.Resources.c5;
        }
        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Trabajo_2.Properties.Resources.c5_1;
        }
        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.Image = Trabajo_2.Properties.Resources.c6;
        }
        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = Trabajo_2.Properties.Resources.c6_1;
        }
        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.Image = Trabajo_2.Properties.Resources.c7;
        }
        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Image = Trabajo_2.Properties.Resources.c7_1;
        }
        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            pictureBox8.Image = Trabajo_2.Properties.Resources.INFO1;
        }
        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Image = Trabajo_2.Properties.Resources.INFO1_1;
        }
        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            pictureBox7.Image = Trabajo_2.Properties.Resources.SALIR1;
        }
        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Image = Trabajo_2.Properties.Resources.SALIR1_1;
        }
        
        /********************************************************************************/

       


    }
}
