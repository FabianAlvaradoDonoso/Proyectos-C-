using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFD
{
    public partial class Form1 : Form
    {
        List<string> Estados = new List<string>();
        List<string> Lenguaje = new List<string>();
        List<string> Finales = new List<string>();
        string Inicial;

        public Form1()
        {
            InitializeComponent();
        }


        #region Botones

        
        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            pertenece();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtEstadoFinal.Clear();
            txtEstadoInicial.Clear();
            txtEstados.Clear();
            txtLenguaje.Clear();
            vaciarListas();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            txtPalabra.Clear();
            pictureBox1.Image = AFD.Properties.Resources.Blanco;
            txtEstados.Focus();
        }

        #endregion






        #region Funciones

        public void llenarDgv()
        {
            try
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                //if (txtEstados.Text == "" || txtLenguaje.Text == "")
                //{
                //    MessageBox.Show("Primero llene las demas partes.", "Error Quintupla");
                //    return;
                //}
                vaciarListas();
                llenarTodasListas();

                for (int i = 0; i < Estados.Count; i++)
                {
                    for (int j = 0; j < Lenguaje.Count; j++)
                    {
                        dataGridView1.Rows.Add(Estados[i], Lenguaje[j], "");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error en llenar la tabla", "ERROR - TABLA");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.LightGray;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        public void llenarLista(TextBox texto, List<string> lista)
        {
            try
            {
                char[] delimiterChars = { ',', ' ', '-' };

                string text = texto.Text;

                string[] words = text.Split(delimiterChars);

                foreach (string s in words)
                {
                    lista.Add(s);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al llenar las listas", "ERROR - LISTA");
            }
            
        }

        public void llenarTodasListas()
        {
            llenarLista(txtEstados, Estados);
            llenarLista(txtLenguaje, Lenguaje);
            llenarLista(txtEstadoFinal, Finales);
            Inicial = txtEstadoInicial.Text;
        }

        public void mostrarLista(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                MessageBox.Show(list[i]);
            }
        }

        public void vaciarListas()
        {
            Estados.Clear();
            Lenguaje.Clear();
            Finales.Clear();
        }

        public void pertenece()
        {
            try
            {
                string palabra = txtPalabra.Text; //Obtengo palabra del textbox
                bool pertenece = false;
                string inicio = txtEstadoInicial.Text; //Obtengo estado inicial.




                while (palabra.Length != 0)
                {
                    string caracter = palabra.Substring(0, 1); //Obtengo primer caracter de la palabra



                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[0].Value.ToString() == inicio && row.Cells[1].Value.ToString() == caracter)
                        {
                            inicio = row.Cells[2].Value.ToString();
                            break;
                        }

                    }

                    palabra = palabra.Substring(1, palabra.Length - 1); //Se borra primer cararter de la palabra
                }

                for (int i = 0; i < Finales.Count; i++)
                {
                    if (Finales[i] == inicio)
                    {
                        pertenece = true;
                        break;
                    }
                }

                if (pertenece)
                {
                    pictureBox1.Image = AFD.Properties.Resources.Bien;
                    lbResultado.Text = "PERTENECE";
                }
                else
                {
                    pictureBox1.Image = AFD.Properties.Resources.Error;
                    lbResultado.Text = "NO PERTENECE";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al verificar si pertene al lenguaje", "ERROR - PERTENECE");
            }
        }


        #endregion






        #region Eventos

        private void txtEstados_TextChanged(object sender, EventArgs e)
        {
            llenarDgv();
            pictureBox1.Image = AFD.Properties.Resources.Blanco;
        }

        private void txtLenguaje_TextChanged(object sender, EventArgs e)
        {
            llenarDgv();
            pictureBox1.Image = AFD.Properties.Resources.Blanco;
        }

        private void txtEstadoInicial_TextChanged(object sender, EventArgs e)
        {
            llenarDgv();
            pictureBox1.Image = AFD.Properties.Resources.Blanco;
        }

        private void txtEstadoFinal_TextChanged(object sender, EventArgs e)
        {
            llenarDgv();
            pictureBox1.Image = AFD.Properties.Resources.Blanco;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            pictureBox1.Image = AFD.Properties.Resources.Blanco;
        }




        #endregion

        
    }
}
