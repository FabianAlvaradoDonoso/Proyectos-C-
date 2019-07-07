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
        List<string> Dijkstra = new List<string>();
        List<string> FinalD = new List<string>();
        List<string> letras = new List<string>();
        float[,] tempMatriz1;
        int linha1;
        string input, nodo, origen;
        bool simetrica = true;
        bool zero = true;
        bool dijkstra = false;

        public Grafos()
        {
            InitializeComponent();
            letraLista();
        }


        #region Botones y Funciones

        public void letraLista()
        {
            letras.Add("A"); letras.Add("B"); letras.Add("C"); letras.Add("D");
            letras.Add("E"); letras.Add("F"); letras.Add("G"); letras.Add("H");
            letras.Add("I"); letras.Add("J"); letras.Add("K"); letras.Add("L");
            letras.Add("M"); letras.Add("N"); letras.Add("Ñ"); letras.Add("O");
            letras.Add("P"); letras.Add("Q"); letras.Add("R"); letras.Add("S");
            letras.Add("T"); letras.Add("U"); letras.Add("V"); letras.Add("W");
            letras.Add("X"); letras.Add("Y"); letras.Add("Z");

        }

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

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            try
            {
                if (Matriz1 == null)
                {
                    MessageBox.Show("Matriz nula !", "Error - Matriz");
                    return;
                }

                if (Matriz1 != null && MatrizResultante == null) //primera ves
                {
                    float[,] tempMatriz1 = new float[Matriz1.GetLength(0), Matriz1.GetLength(1)];

                    for (int x = 0; x < Matriz1.GetLength(0); x++)
                    {
                        for (int y = 0; y < Matriz1.GetLength(1); y++)
                        {
                            float n = 0;
                            float.TryParse(Matriz1[x, y].Text, out n);
                            tempMatriz1[x, y] = n;
                            //tempMatriz1[x, y] = Convert.ToInt32(Matriz1[x, y].Text);
                        }
                    }

                    float[,] tempMatrizResultante = MultiplicarMatrizes(tempMatriz1, tempMatriz1);
                    MatrizResultante = new TextBox[tempMatrizResultante.GetLength(0), tempMatrizResultante.GetLength(1)];
                    int TamanhoText = (groupBoxMatrizResultante.Width / MatrizResultante.GetLength(1)) - 5;
                    groupBoxMatrizResultante.Controls.Clear();
                    for (int x = 0; x < MatrizResultante.GetLength(0); x++)
                    {
                        for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                        {
                            MatrizResultante[x, y] = new TextBox();
                            MatrizResultante[x, y].Text = tempMatrizResultante[x, y].ToString();
                            MatrizResultante[x, y].Top = (x * MatrizResultante[x, y].Height) + 20;
                            MatrizResultante[x, y].Left = y * TamanhoText + 6;
                            MatrizResultante[x, y].Width = TamanhoText - 5;
                            groupBoxMatrizResultante.Controls.Add(MatrizResultante[x, y]);
                        }
                    }

                    groupBoxMatrizResultante.Height = 20 * MatrizResultante.GetLength(1) + 30;
                    return;
                }

                if (Matriz1 != null && MatrizResultante != null)
                {
                    float[,] tempMatriz1 = new float[MatrizResultante.GetLength(0), MatrizResultante.GetLength(1)];
                    float[,] tempMatriz2 = new float[Matriz1.GetLength(0), Matriz1.GetLength(1)];

                    for (int x = 0; x < Matriz1.GetLength(0); x++)
                    {
                        for (int y = 0; y < Matriz1.GetLength(1); y++)
                        {
                            float n = 0;
                            float.TryParse(Matriz1[x, y].Text, out n);
                            tempMatriz2[x, y] = n;
                        }
                    }

                    for (int x = 0; x < MatrizResultante.GetLength(0); x++)
                    {
                        for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                        {
                            float n = 0;
                            float.TryParse(MatrizResultante[x, y].Text, out n);
                            tempMatriz1[x, y] = n;
                        }
                    }

                    float[,] tempMatrizResultante = MultiplicarMatrizes(tempMatriz1, tempMatriz2);
                    MatrizResultante = new TextBox[tempMatrizResultante.GetLength(0), tempMatrizResultante.GetLength(1)];
                    int TamanhoText = (groupBoxMatrizResultante.Width / MatrizResultante.GetLength(1)) - 5;
                    groupBoxMatrizResultante.Controls.Clear();
                    for (int x = 0; x < MatrizResultante.GetLength(0); x++)
                    {
                        for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                        {
                            MatrizResultante[x, y] = new TextBox();
                            MatrizResultante[x, y].Text = tempMatrizResultante[x, y].ToString();
                            MatrizResultante[x, y].Top = (x * MatrizResultante[x, y].Height) + 20;
                            MatrizResultante[x, y].Left = y * TamanhoText + 6;
                            MatrizResultante[x, y].Width = TamanhoText - 5;
                            groupBoxMatrizResultante.Controls.Add(MatrizResultante[x, y]);
                        }
                    }

                    groupBoxMatrizResultante.Height = 20 * MatrizResultante.GetLength(1) + 30;
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Se encontro un error. Revise la matriz", "Error");
            }
            
            

            
        }

        private void btnTraspaso_Click(object sender, EventArgs e)
        {
            try
            {
                if(Matriz1 == null || MatrizResultante == null)
                {
                    MessageBox.Show("Error. No se completo el traspaso", "Traspaso");
                    return;
                }
                groupBoxMatrizResultante.Controls.Clear();
                groupBoxMatriz1.Controls.Clear();


                int TamanhoText = (groupBoxMatriz1.Width / Matriz1.GetLength(1)) - 5;

                for (int x = 0; x < Matriz1.GetLength(0); x++)
                {
                    for (int y = 0; y < Matriz1.GetLength(1); y++)
                    {
                        Matriz1[x, y] = new TextBox();
                        Matriz1[x, y].Text = MatrizResultante[x, y].Text;
                        Matriz1[x, y].Top = (x * Matriz1[x, y].Height) + 20;
                        Matriz1[x, y].Left = y * TamanhoText + 6;
                        Matriz1[x, y].Width = TamanhoText - 5;
                        groupBoxMatriz1.Controls.Add(Matriz1[x, y]);
                    }
                }

                groupBoxMatriz1.Height = 20 * Matriz1.GetLength(1) + 30;
                button1.PerformClick();
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Traspaso");
            }
            
        }

        private void btnOriginal_Click(object sender, EventArgs e)
        {
            try
            {
                groupBoxMatriz1.Controls.Clear();


                Matriz1 = new TextBox[tempMatriz1.GetLength(0), tempMatriz1.GetLength(1)];
                int TamanhoText = (groupBoxMatriz1.Width / Matriz1.GetLength(1)) - 5;

                for (int x = 0; x < Matriz1.GetLength(0); x++)
                {
                    for (int y = 0; y < Matriz1.GetLength(1); y++)
                    {
                        Matriz1[x, y] = new TextBox();
                        Matriz1[x, y].Text = tempMatriz1[x, y].ToString();
                        Matriz1[x, y].Top = (x * Matriz1[x, y].Height) + 20;
                        Matriz1[x, y].Left = y * TamanhoText + 6;
                        Matriz1[x, y].Width = TamanhoText - 5;
                        groupBoxMatriz1.Controls.Add(Matriz1[x, y]);
                    }
                }

                groupBoxMatriz1.Height = 20 * Matriz1.GetLength(1) + 30;
            }
            catch (Exception)
            {
                MessageBox.Show("Error en el traspaso", "Error");
            }
            
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Matriz1 == null || MatrizResultante == null)
                {
                    MessageBox.Show("Matriz nula !", "Error - Matriz");
                    return;
                }
                float[,] tempMatriz1 = new float[Matriz1.GetLength(0), Matriz1.GetLength(1)];
                float[,] tempMatriz2 = new float[MatrizResultante.GetLength(0), MatrizResultante.GetLength(1)];
                if (tempMatriz1.GetLength(0) != tempMatriz2.GetLength(0) || tempMatriz1.GetLength(1) != tempMatriz2.GetLength(1))
                {
                    MessageBox.Show("So e possivel a soma de matrizes de mesma ordem !", "Erro - Soma Matrizes");
                    return;
                }

                for (int x = 0; x < Matriz1.GetLength(0); x++)
                {
                    for (int y = 0; y < Matriz1.GetLength(1); y++)
                    {
                        float n = 0;
                        float.TryParse(Matriz1[x, y].Text, out n);
                        tempMatriz1[x, y] = n;
                    }
                }
                for (int x = 0; x < MatrizResultante.GetLength(0); x++)
                {
                    for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                    {
                        float n = 0;
                        float.TryParse(MatrizResultante[x, y].Text, out n);
                        tempMatriz2[x, y] = n;
                    }
                }

                float[,] tempMatrizResultante = SumarMatrizes(tempMatriz1, tempMatriz2);
                MatrizResultante = new TextBox[tempMatrizResultante.GetLength(0), tempMatrizResultante.GetLength(1)];
                int TamanhoText = (groupBoxMatrizResultante.Width / MatrizResultante.GetLength(1)) - 5;
                groupBoxMatrizResultante.Controls.Clear();
                groupBoxMatriz1.Controls.Clear();
                for (int x = 0; x < MatrizResultante.GetLength(0); x++)
                {
                    for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                    {
                        MatrizResultante[x, y] = new TextBox();
                        MatrizResultante[x, y].Text = tempMatrizResultante[x, y].ToString();
                        MatrizResultante[x, y].Top = (x * MatrizResultante[x, y].Height) + 20;
                        MatrizResultante[x, y].Left = y * TamanhoText + 6;
                        MatrizResultante[x, y].Width = TamanhoText - 5;
                        groupBoxMatriz1.Controls.Add(MatrizResultante[x, y]);
                    }
                }
                groupBoxMatriz1.Height = 20 * MatrizResultante.GetLength(0) + 30;
                btnTraspaso.PerformClick();
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la suma", "Error");
            }
        }

        private void btnConexos_Click(object sender, EventArgs e)
        {
            try
            {
                if (Matriz1.GetLength(0) < 3)
                {
                    btnCuadrado.PerformClick();
                    btnSumar.PerformClick();
                }
                else
                {
                    for (int i = 0; i < Matriz1.GetLength(0) - 1; i++)
                    {
                        btnCuadrado.PerformClick();
                        btnSumar.PerformClick();
                    }
                }


                for (int x = 0; x < Matriz1.GetLength(0); x++)
                {
                    for (int y = 0; y < Matriz1.GetLength(1); y++)
                    {
                        if (Matriz1[x, y].Text == "0")
                        {
                            MessageBox.Show("Grafo NO conexo", "Grafos");
                            button1.PerformClick();
                            btnOriginal.PerformClick();
                            return;
                        }
                    }
                }

                MessageBox.Show("Grafo CONEXO", "Grafos");
                button1.PerformClick();
                btnOriginal.PerformClick();

            }
            catch (Exception)
            {

                MessageBox.Show("Error al determinar si es conexo o no", "Error");
            }

        }

        private void btnCaminos_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
            if (Matriz1 == null)
            {
                MessageBox.Show("Ingrese un matriz primero.", "Error");
                return;
            }

            if(numericUpDown1.Value > 0)
            {
                panelResultados.Visible = true;
                richTextBox1.Clear();

                richTextBox1.Text = "Caminos de largo" + numericUpDown1.Value + ":\n";

                if(numericUpDown1.Value == 1)
                {
                    for (int x = 0; x < Matriz1.GetLength(0); x++)
                    {
                        for (int y = 0; y < Matriz1.GetLength(1); y++)
                        {
                            if (Matriz1[x, y].Text != "0")
                            {
                                richTextBox1.Text += "\nDe " + letras[x].ToString() + " a " + letras[y].ToString() + " hay: " + Matriz1[x, y].Text + " Caminos\n";
                            }
                        }
                    }
                    richTextBox1.Text += "\nLos par de vertices que no aparecen se debe a que no hay caminos de largo " + numericUpDown1.Value + " en el grafo";
                    return;
                }

                for(int i = 0; i<numericUpDown1.Value - 1;i++)
                {
                    btnCuadrado.PerformClick();
                }

                for (int x = 0; x < MatrizResultante.GetLength(0); x++)
                {
                    for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                    {
                        if(MatrizResultante[x,y].Text != "0")
                        {
                            richTextBox1.Text += "\nDe " + letras[x].ToString() + " a " + letras[y].ToString() + " hay: " + MatrizResultante[x, y].Text + " Caminos\n";  
                        }
                    }
                }
                button1.PerformClick();

                richTextBox1.Text += "\nLos par de vertices que no aparecen se debe a que no hay caminos de largo " + numericUpDown1.Value + " en el grafo";
                return;
            }
            else
            {
                MessageBox.Show("Ingrese antes un numero de caminos.", "Error");
            }
           

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            panelResultados.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dijkstra == false)
            {
                groupBoxMatrizResultante.Controls.Clear();
                MatrizResultante = null;
            }
            else
            {
                groupBoxMatriz1.Controls.Clear();
                richTextBox1.Clear();
                textBox1.Clear();
                textBox2.Clear();
            }
            
        }

        private void btnDijkstra_Click(object sender, EventArgs e)
        {
            dijkstra = true;
            textBox1.Clear();
            btnOriginal.Visible = false;
            btnSumar.Visible = false;
            btnTraspaso.Visible = false;
            btnCuadrado.Visible = false;
            btnConexos.Visible = false;
            label2.Visible = false;
            numericUpDown1.Visible = false;
            btnCaminos.Visible = false;
            groupBoxMatrizResultante.Visible = false;
            groupBoxMatriz1.Text = "Matriz de Peso";
            btnDijkstra.Visible = false;
            btnAdyacencia.Visible = true;
            button1.PerformClick();
            groupBoxMatriz1.Controls.Clear();
            Matriz1 = null;
            label3.Visible = true;
            textBox2.Visible = true;
            btnEjecutarDijkstra.Visible = true;
            textBox1.Focus();
            panelResultados.Visible = true;
            btnCerrar.Visible = false;
            btnBorrarR.Visible = true;
        }

        private void btnAdyacencia_Click(object sender, EventArgs e)
        {
            dijkstra = false;
            textBox1.Clear();
            btnOriginal.Visible = true;
            btnSumar.Visible = true;
            btnTraspaso.Visible = true;
            btnCuadrado.Visible = true;
            btnConexos.Visible = true;
            label2.Visible = true;
            numericUpDown1.Visible = true;
            btnCaminos.Visible = true;
            groupBoxMatrizResultante.Visible = true;
            groupBoxMatriz1.Text = "Matriz de Adyacencia (Original)";
            btnDijkstra.Visible = true;
            btnAdyacencia.Visible = false;
            button1.PerformClick();
            groupBoxMatriz1.Controls.Clear();
            Matriz1 = null;
            label3.Visible = false;
            textBox2.Visible = false;
            btnEjecutarDijkstra.Visible = false;
            textBox1.Focus();
            panelResultados.Visible = false;
            btnCerrar.Visible = true;
            btnBorrarR.Visible = false;  
            
        }


        //-------------------------------Dijkstra-------------------------------

        public string devolverNodo(int indice)
        {
            return Dijkstra[indice].Substring(0, 1);
        }

        public string devolverOrigen(int indice)
        {
            return Dijkstra[indice].Substring(Dijkstra[indice].Length - 2, 1);
        }

        public int devolverCamino(int indice)
        {
            return Convert.ToInt32(Regex.Replace(Dijkstra[indice], @"[^\d]", ""));
        }

        public string devolverNodoFinal(int indice)
        {
            return FinalD[indice].Substring(0, 1);
        }

        public string devolverOrigenFinal(int indice)
        {
            return FinalD[indice].Substring(FinalD[indice].Length - 2, 1);
        }

        public int devolverCaminoFinal(int indice)
        {
            return Convert.ToInt32(Regex.Replace(FinalD[indice], @"[^\d]", ""));
        }

        public int devolverIndice()
        {
            for(int i=0;i<letras.Count;i++)
            {
                if(letras[i] == input)
                {
                    return i;
                }
            }
            return -1;
        }

        private void TraspasoRevez()
        {
            try
            {
                if (Matriz1 == null)
                {
                    MessageBox.Show("Error. No se completo el traspaso", "Traspaso");
                    return;
                }
                groupBoxMatrizResultante.Controls.Clear();


                int TamanhoText = (groupBoxMatriz1.Width / Matriz1.GetLength(1)) - 5;
                MatrizResultante = new TextBox[Matriz1.GetLength(0), Matriz1.GetLength(1)];

                for (int x = 0; x < Matriz1.GetLength(0); x++)
                {
                    for (int y = 0; y < Matriz1.GetLength(1); y++)
                    {
                        MatrizResultante[x, y] = new TextBox();
                        MatrizResultante[x, y].Text = Matriz1[x, y].Text;
                        MatrizResultante[x, y].Top = (x * MatrizResultante[x, y].Height) + 20;
                        MatrizResultante[x, y].Left = y * TamanhoText + 6;
                        MatrizResultante[x, y].Width = TamanhoText - 5;
                        groupBoxMatrizResultante.Controls.Add(MatrizResultante[x, y]);
                    }
                }

                groupBoxMatrizResultante.Height = 20 * MatrizResultante.GetLength(1) + 30;
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Traspaso");
            }

        }

        public void traspasoOriginal()
        {
            try
            {
                if (MatrizResultante == null)
                {
                    MessageBox.Show("Error. No se completo el traspaso", "Traspaso");
                    return;
                }
                groupBoxMatrizResultante.Controls.Clear();
                groupBoxMatriz1.Controls.Clear();


                int TamanhoText = (groupBoxMatrizResultante.Width / MatrizResultante.GetLength(1)) - 5;
                Matriz1 = new TextBox[MatrizResultante.GetLength(0), MatrizResultante.GetLength(1)];

                for (int x = 0; x < MatrizResultante.GetLength(0); x++)
                {
                    for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                    {
                        Matriz1[x, y] = new TextBox();
                        Matriz1[x, y].Text = MatrizResultante[x, y].Text;
                        Matriz1[x, y].Top = (x * Matriz1[x, y].Height) + 20;
                        Matriz1[x, y].Left = y * TamanhoText + 6;
                        Matriz1[x, y].Width = TamanhoText - 5;
                        groupBoxMatriz1.Controls.Add(Matriz1[x, y]);
                    }
                }

                groupBoxMatriz1.Height = 20 * Matriz1.GetLength(1) + 30;
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Traspaso");
            }
        }

        public void sumarNodos()
        {
            try
            {
                List<int> porBorrar = new List<int>();
                bool borrar = false;

                for (int i = 0; i < Dijkstra.Count - 1; i++)
                {
                    for (int j = Dijkstra.Count - 1; j >= 0; j--)
                    {
                        if (i >= j) break;

                        if (devolverNodo(i) == devolverOrigen(j))
                        {
                            Dijkstra[j] = devolverNodo(j) + "(" + (devolverCamino(i) + devolverCamino(j)).ToString() + devolverOrigen(j) + ")";
                            borrar = true;
                        }
                    }
                    if (borrar)
                    {
                        porBorrar.Add(i);
                    }
                    borrar = false;
                }

                for (int i = 0; i < porBorrar.Count; i++)
                {
                    FinalD.Add(Dijkstra[porBorrar[i]]);
                    Dijkstra.RemoveAt(porBorrar[i]);
                }
                //for (int i = 0; i < Dijkstra.Count; i++)
                //{
                //    MessageBox.Show(Dijkstra[i]);
                //}
            }
            catch (Exception)
            {
                MessageBox.Show("Error sumar nodos");
            }
           


        }

        public void eliminarNodo()
        {
            try
            {
                int borrar = -1;
                int instancia = -1;
                List<int> porBorrar = new List<int>();

                for (int i = 0; i < Dijkstra.Count - 1; i++)
                {
                    for (int j = Dijkstra.Count - 1; j >= 0; j--)
                    {
                        if (i >= j) break;

                        if (devolverNodo(i) == devolverNodo(j))
                        {
                            if (devolverCamino(i) > devolverCamino(j)) borrar = 1;
                            if (devolverCamino(i) < devolverCamino(j)) borrar = 2;
                            if (devolverCamino(i) == devolverCamino(j)) borrar = 0;
                            instancia = j;
                        }
                    }
                    if (borrar != -1)
                    {
                        if (borrar == 1) porBorrar.Add(i);
                        if (borrar == 2) porBorrar.Add(instancia);
                        if (borrar == 0) porBorrar.Add(instancia);
                    }
                    instancia = -1;
                    borrar = -1;
                }
                for (int i = 0; i < porBorrar.Count; i++)
                {
                    Dijkstra.RemoveAt(porBorrar[i]);
                }
                //for (int i = 0; i < Dijkstra.Count; i++)
                //{
                //    MessageBox.Show(Dijkstra[i]);
                //}
            }
            catch (Exception)
            {
                MessageBox.Show("Error eliminar nodo");
            }
            

        }

        public void llenarLista()
        {
            try
            {
                for (int x = 0; x < Matriz1.GetLength(0); x++)
                {
                    for (int y = 0; y < Matriz1.GetLength(1); y++)
                    {
                        if (x == devolverIndice())
                        {
                            if (Matriz1[x, y].Text != "0") Dijkstra.Add(letras[y] + "(" + Matriz1[x, y].Text + letras[x] + ")");
                        }

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error llenar lista");
            }
            

        }

        public bool NoZero()
        {
            try
            {
                for (int x = 0; x < Matriz1.GetLength(0); x++)
                {
                    for (int y = 0; y < Matriz1.GetLength(1); y++)
                    {
                        if (Matriz1[x, y].Text != "0")
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Error, NoZero");
                return false;
            }
            
        }

        public void borrarDatosMatriz()
        {
            try
            {
                simetrica = IsSimetrica();
                if (simetrica)
                {
                    for (int i = 0; i < Matriz1.GetLength(1); i++)
                    {
                        if (Matriz1[devolverIndice(), i].Text != "0")
                        {
                            Matriz1[devolverIndice(), i].Text = "0";
                            Matriz1[i, devolverIndice()].Text = "0";
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < Matriz1.GetLength(1); i++)
                    {
                        if (Matriz1[devolverIndice(), i].Text != "0")
                        {
                            Matriz1[devolverIndice(), i].Text = "0";
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Borrar Datos");
            }
            

        }

        public bool IsSimetrica()
        {
            try
            {
                for (int x = 0; x < Matriz1.GetLength(0); x++)
                {
                    for (int y = 0; y < Matriz1.GetLength(1); y++)
                    {
                        if (Matriz1[x, y].Text != Matriz1[y, x].Text)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error Simetrica");
                return false;
            }
            
        }

        public void indicarNodoMenor()
        {
            try
            {
                int min = int.MaxValue;

                for (int i = 0; i < Dijkstra.Count; i++)
                {
                    if (devolverCamino(i) < min)
                    {
                        min = devolverCamino(i);
                        nodo = devolverNodo(i);
                    }
                }

                input = nodo;
            }
            catch (Exception)
            {
                MessageBox.Show("Error nodo Menor");
            }
            
        }

        public void mostrarCaminos()
        {
            try
            {
                if (FinalD.Count == 0) return;

                richTextBox1.Text = "El Camino mas corto desde el vertice " + textBox2.Text + " a cualquier nodo:";

                for (int i = 0; i < FinalD.Count; i++)
                {
                    int sumaCamino = 0;
                    List<string> camino = new List<string>();

                    camino.Add(devolverNodoFinal(i));
                    camino.Add(devolverOrigenFinal(i));
                    sumaCamino += devolverCaminoFinal(i);
                    string buscar = devolverOrigenFinal(i);

                    L:

                    if (buscar == origen) goto M;

                    for (int j = 0; j < FinalD.Count; j++)
                    {
                        if (devolverNodoFinal(j) == buscar)
                        {
                            camino.Add(devolverOrigenFinal(j));
                            buscar = devolverOrigenFinal(j);
                            goto L;
                        }
                    }

                    M:

                    richTextBox1.Text += "\nVertice " + devolverNodoFinal(i) + ": ";
                    for (int j = camino.Count - 1; j >= 0; j--)
                    {
                        richTextBox1.Text += camino[j];
                        if (j != 0) richTextBox1.Text += "-";
                    }

                    richTextBox1.Text += "---> Largo camino = " + sumaCamino;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Caminos");
            }
            
            
            
        }

        private void btnBorrarR_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void btnEjecutarDijkstra_Click(object sender, EventArgs e)
        {
            try
            {
                origen = textBox2.Text;
                TraspasoRevez();
                while (zero)
                {
                    llenarLista();
                    sumarNodos();
                    eliminarNodo();
                    borrarDatosMatriz();
                    indicarNodoMenor();
                    zero = NoZero();
                }
                if (zero == false)
                {
                    for (int i = 0; i < Dijkstra.Count; i++)
                    {
                        FinalD.Add(Dijkstra[i]);
                    }
                }
                traspasoOriginal();


                mostrarCaminos();


                Dijkstra.Clear();
                FinalD.Clear();
                zero = !zero;
                input = textBox2.Text;
                nodo = null;
                MatrizResultante = null;
            }
            catch (Exception)
            {
                MessageBox.Show("Error en Dijkstra");
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

        private void textBox2_Leave(object sender, EventArgs e)
        {
            textBox2.CharacterCasing = CharacterCasing.Upper;
            input = textBox2.Text;
        }

        #endregion

        #region Funciones

        public static float[,] MultiplicarMatrizes(float[,] matriz1, float[,] matriz2)
        {
            float[,] matrizResultante = new float[matriz1.GetLength(0), matriz2.GetLength(1)];
            for (int x = 0; x < matrizResultante.GetLength(0); x++)
            {
                for (int y = 0; y < matrizResultante.GetLength(1); y++)
                {
                    for (int n = 0; n < matriz2.GetLength(0); n++)
                    {
                        //string i = "" + matriz1[x, n];
                        matrizResultante[x, y] += matriz1[x, n] * matriz2[n, y];
                    }
                }
            }
            return matrizResultante;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        public static float[,] SumarMatrizes(float[,] matriz1, float[,] matriz2)
        {
            float[,] matrizResultante = new float[matriz1.GetLongLength(0), matriz1.GetLength(1)];
            for (int x = 0; x < matrizResultante.GetLength(0); x++)
            {
                for (int y = 0; y < matrizResultante.GetLength(1); y++)
                {
                    matrizResultante[x, y] = matriz1[x, y] += matriz2[x, y];
                }
            }
            return matrizResultante;
        }

        

        public static float[,] Conexos(float[,] Matriz1, int linha1)
        {
            
            float[,] tempMatrizSuma = new float[Matriz1.GetLength(0), Matriz1.GetLength(1)];
            float[,] tempMatriz1 = new float[Matriz1.GetLength(0), Matriz1.GetLength(1)];
            float[,] tempMatrizResultante = new float[Matriz1.GetLength(0), Matriz1.GetLength(1)];

            for (int x = 0; x < Matriz1.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz1.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(Matriz1[x, y].ToString(), out n);
                    tempMatriz1[x, y] = n;
                }
            }

            tempMatrizSuma = SumarMatrizes(Matriz1, tempMatrizSuma);


            for (int i = 0; i < linha1 - 2; i++)//Conexo??
            {
                tempMatrizResultante = MultiplicarMatrizes(tempMatriz1, tempMatriz1);
                tempMatrizSuma = SumarMatrizes(tempMatrizResultante, tempMatrizSuma);

                for (int x = 0; x < tempMatrizResultante.GetLength(0); x++)
                {
                    for (int y = 0; y < tempMatrizResultante.GetLength(1); y++)
                    {
                        float n = 0;
                        float.TryParse(tempMatrizResultante[x, y].ToString(), out n);
                        tempMatriz1[x, y] = n;
                    }
                }
            }


            return tempMatrizSuma;
        }

















        #endregion

        
    }
}