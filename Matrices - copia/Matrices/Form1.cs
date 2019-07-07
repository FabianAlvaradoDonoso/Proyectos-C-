using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Matrices
{
    public partial class Grafos : Form
    {
        public TextBox[,] Matriz1;
        public TextBox[,] MatrizResultante;
        float[,] tempMatriz1;
        int linha1;
        Random rdm = new Random();

        public Grafos()
        {
            InitializeComponent();
        }


        #region Botones y Funciones

        

        private void btnCriarMatriz_Click_1(object sender, EventArgs e)
        {
            try
            {
                groupBoxMatriz1.Controls.Clear();

                if (!int.TryParse(textBox1.Text, out linha1))
                {
                    MessageBox.Show("El numero de vertices no puede ser menor o igual a 0", "Error");
                    textBox1.Clear();
                    textBox1.Focus();
                    return;
                }

                Matriz1 = new TextBox[linha1, linha1];
                int TamanhoText = (groupBoxMatriz1.Width / linha1) - 5;
                for (int x = 0; x < Matriz1.GetLength(0); x++)
                {
                    for (int y = 0; y < Matriz1.GetLength(1); y++)
                    {
                        Matriz1[x, y] = new TextBox();
                        Matriz1[x, y].Text = "0";
                        Matriz1[x, y].Top = (x * Matriz1[x, y].Height) + 20;
                        Matriz1[x, y].Left = y * TamanhoText + 6;
                        Matriz1[x, y].Width = TamanhoText - 5;
                        groupBoxMatriz1.Controls.Add(Matriz1[x, y]);

                    }
                }

                groupBoxMatriz1.Height = 20 * linha1 + 30;
            }
            catch (Exception ex)
            {
                MessageBox.Show("El numero de vertices no puede ser menor o igual a 0", "Error");
                textBox1.Clear();
                textBox1.Focus();
            }



        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            try
            {
                for (int x = 0; x < Matriz1.GetLength(0); x++)
                {
                    for (int y = 0; y < Matriz1.GetLength(1); y++)
                    {
                        Matriz1[x, y].Text = rdm.Next(0, 21).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el llenado automatico de la matriz.");
            }
            
        }

        private int CaminoCorto(TextBox[,] Matriz, int x, int y, int suma, int xAnt, int yAnt, int numAnt)
        {
            suma = Math.Abs(numAnt - Convert.ToInt32(Matriz[x, y].Text)) + suma;
            if (x == Matriz.GetLength(0) && y == Matriz.GetLength(1))
            {
                return suma;
            }
            else
            {
                if (x != Matriz.GetLength(0)) CaminoCorto(Matriz, x + 1, y, suma, x, y, Convert.ToInt32(Matriz[x, y].Text));
                if (y != Matriz.GetLength(1)) CaminoCorto(Matriz, x, y + 1, suma, x, y, Convert.ToInt32(Matriz[x, y].Text));
                if (x != 0) CaminoCorto(Matriz, x - 1, y, suma, x, y, Convert.ToInt32(Matriz[x, y].Text));
                if (y != 0) CaminoCorto(Matriz, x, y - 1, suma, x, y, Convert.ToInt32(Matriz[x, y].Text));
            }
        }



        #endregion

        #region Acciones

        private void groupBoxMatriz1_Leave(object sender, EventArgs e)
        {

            for (int x = 0; x < Matriz1.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz1.GetLength(1); y++)
                {
                    if (!int.TryParse(Matriz1[x, y].Text, out linha1))
                    {
                        MessageBox.Show("Todos los elementos de la matriz deben ser NUMEROS, iguales o mayores a 1");
                        groupBoxMatriz1.Focus();
                    }
                }
            }

            tempMatriz1 = new float[Matriz1.GetLength(0), Matriz1.GetLength(1)];

            for (int x = 0; x < Matriz1.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz1.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(Matriz1[x, y].Text, out n);
                    tempMatriz1[x, y] = n;
                }
            }
        }




        #endregion

        #region Funciones


        #endregion

       
    }
}