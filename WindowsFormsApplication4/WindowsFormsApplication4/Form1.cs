using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {

        StreamWriter escritura = File.CreateText("ejemplo.txt");
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                //Ruta de donde se obtendrá el archivo .txt
                string ruta = @"C:\Users\Fabia\Downloads\Chat1.txt";

                List<string> nuevoContenido = new List<string>();

                //Recorremos cada línea del archivo
                foreach (string linea in File.ReadLines(ruta))
                {
                    //Almacenará los valores
                    string lineaNueva = string.Empty;

                    foreach (var match in Regex.Split(linea, @"\d{2}/\d{1}/\d{2}, \d{2}:\d{2} - "))
                    {
                        lineaNueva += string.Concat(match, "♦");
                    }

                    //Terminado de recorrer la linea, agregamos el resultado a la lista
                    nuevoContenido.Add(lineaNueva.TrimEnd('♦'));
                }

                //Creo un nuevo archivo con los datos
                File.WriteAllLines(@"C:\Users\Fabia\Downloads\Chat1.txt", nuevoContenido);

                //textBox1.Text = string.Join(Environment.NewLine, nuevoContenido); //Borrar está línea

                MessageBox.Show("Datos completados!!");
            }
            catch (Exception ex)
            {
                //Si se produce algún error lo mostramos
                MessageBox.Show(ex.Message);
            }
        }
        


    }
}
