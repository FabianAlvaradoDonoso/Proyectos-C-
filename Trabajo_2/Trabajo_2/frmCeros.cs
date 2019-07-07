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
    public partial class frmCeros : Form
    {
        int contador = 0;
        public frmCeros()
        {
            InitializeComponent();
        }

        private void btnConvBinario_Click(object sender, EventArgs e)
        {
            try
            {
                lblNumBinario.Text = (convBin(Convert.ToInt64(textNumero.Text))).ToString();

            }
            catch (System.FormatException)
            {
                MessageBox.Show("El formato no es correcto, Ingrese otro", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnBorrarCeros_Click(sender, e);
                contador = 0;
            }
        } //Boton de convertir a binario.
   
        long convBin(long numeroBinario)
        {                
            string sbinario = "";
            string aux2 = "";
            double aux;
            while (numeroBinario >= 1)
            {
                aux = numeroBinario % 2;
                if (aux == 0)
                {
                    sbinario = sbinario + "0";
                }
                else
                {
                    sbinario = sbinario + "1";
                }
                numeroBinario = numeroBinario / 2;
            }
            for (int i = sbinario.Length - 1; i >= 0; i--)
            {
                aux2 += sbinario[i];
            }

            return Convert.ToInt64(aux2);     
        }//Conviete de un numero real a uno binario.

        long cantidadCerosR(long x)
        {
            long numero = x;

            if (numero == 0)
            {
                return 0;
            }
            else
            {
                long ultimoDigito = numero % 10;


                if (ultimoDigito == 0)
                {
                    contador++;                
                    return cantidadCerosR(numero / 10) + 1;
                }
                else
                {
                    contador++;
                    return cantidadCerosR(numero / 10);
                }
            }


        } //Cuenta cantidad de ceros en un numero binario.

        
        private void btnContarCeros_Click(object sender, EventArgs e)
        {
            try
            {
                lblCantCeros.Text = cantidadCerosR(convBin(Convert.ToInt64(textNumero.Text))).ToString(); 
                lblR.Text = contador.ToString();
                lblM.Text = (contador * 40).ToString();
                contador = 0;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("El formato no es correcto, Ingrese otro", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnBorrarCeros_Click(sender, e);
                contador = 0;
            }
            
        } //Boton de contar ceros.

        private void btnBorrarCeros_Click(object sender, EventArgs e)
        {
            lblCantCeros.Text = "";
            lblNumBinario.Text = "";
            lblR.Text = "";
            lblM.Text = "";
            textNumero.Clear();
            textNumero.Focus();

        } //Boton de borrar datos.

        private void btnSalirCeros_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Esta seguro de Salir?", "Contar Ceros", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (r == DialogResult.Yes) this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textNumero.Text = "3333";
        }
        
    }
}
