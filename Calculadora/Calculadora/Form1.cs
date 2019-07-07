using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double auxSuma = 0;
        double auxResta = 0;
        double auxMulti = 0;
        double auxDivis = 0;
        double auxSegundo = 0;
        double auxResultado = 0;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            lbResultado.Text = "0";
            txtAnterior.Text = "";
            borrarMemoria(sender, e);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (lbResultado.Text == "0") lbResultado.Text = "1";
            else lbResultado.Text += "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (lbResultado.Text == "0") lbResultado.Text = "2";
            else lbResultado.Text += "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (lbResultado.Text == "0") lbResultado.Text = "3";
            else lbResultado.Text += "3";
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (lbResultado.Text == "0") lbResultado.Text = "4";
            else lbResultado.Text += "4";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (lbResultado.Text == "0") lbResultado.Text = "5";
            else lbResultado.Text += "5";
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (lbResultado.Text == "0") lbResultado.Text = "6";
            else lbResultado.Text += "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (lbResultado.Text == "0") lbResultado.Text = "7";
            else lbResultado.Text += "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (lbResultado.Text == "0") lbResultado.Text = "8";
            else lbResultado.Text += "8";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (lbResultado.Text == "0") lbResultado.Text = "9";
            else lbResultado.Text += "9";
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            if(lbResultado.Text == "0") lbResultado.Text += "";
            else lbResultado.Text += "0";
        }


        private void btnComma_Click(object sender, EventArgs e)
        {
            lbResultado.Text += ",";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            auxSegundo = Convert.ToDouble(lbResultado.Text);
            if (auxSuma != 0) auxResultado = auxSuma + auxSegundo;
            else if (auxResta != 0) auxResultado = auxResta - auxSegundo;
            else if (auxMulti != 0) auxResultado = auxMulti * auxSegundo;
            else if (auxDivis != 0) auxResultado = auxDivis / auxSegundo;
            lbResultado.Text = auxResultado.ToString();
            txtAnterior.Text = "";
        }

        public void borrarMemoria(object sender, EventArgs e)
        {
            auxDivis = 0;
            auxMulti = 0;
            auxResta = 0;
            auxResultado = 0;
            auxSegundo = 0;
            auxSuma = 0;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            auxDivis = 0;
            auxMulti = 0;
            auxResta = 0;
            auxSuma = Convert.ToDouble(lbResultado.Text);
            txtAnterior.Text = auxSuma.ToString() + " + ";
            lbResultado.Text = "";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            auxDivis = 0;
            auxMulti = 0;
            auxSuma = 0;
            auxResta = Convert.ToDouble(lbResultado.Text);
            txtAnterior.Text = auxResta.ToString() + " - ";
            lbResultado.Text = "";
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            auxDivis = 0;
            auxSuma = 0;
            auxResta = 0;
            auxMulti = Convert.ToDouble(lbResultado.Text);
            txtAnterior.Text = auxMulti.ToString() + " * ";
            lbResultado.Text = "";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            auxSuma = 0;
            auxMulti = 0;
            auxResta = 0;
            auxDivis = Convert.ToDouble(lbResultado.Text);
            txtAnterior.Text = auxDivis.ToString() + " / ";
            lbResultado.Text = "";
        }




    }
}
