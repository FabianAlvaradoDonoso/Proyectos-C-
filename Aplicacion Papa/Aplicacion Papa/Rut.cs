using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Papa
{
    public partial class Rut : Form
    {
        public Rut()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            string dv;
            int aux1, aux2, suma = 0, aux3 = 2, DigVerif;
            aux1 = Convert.ToInt32(textBox1.Text);
            while (aux1 > 0)
            {
                aux2 = aux1 % 10;
                aux1 = aux1 / 10;
                suma = suma + aux2 * aux3;
                aux3++;
                if (aux3 == 8)
                {
                    aux3 = 2;
                }
            }

            DigVerif = (suma % 11);
            DigVerif = 11 - DigVerif;
            if (DigVerif == 11)
                dv = "0";
            else
            {
                if (DigVerif == 10)
                    dv = "k";
                else
                    dv = DigVerif.ToString();
            }
            label1.Text = dv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Verificar RUT", "RUUUUUUT", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
