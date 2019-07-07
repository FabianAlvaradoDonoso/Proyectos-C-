using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebas1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Visible = false;
            
        }

        string url = "http://www.valor-dolar.cl/";
        WebBrowser navegador = new WebBrowser();
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            navegador.ScriptErrorsSuppressed = true;
            navegador.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.datos_cargados);

        }

        private void datos_cargados(object sender, EventArgs e)
        {
            foreach(HtmlElement etiqueta in navegador.Document.All)
            {
                if (etiqueta.GetAttribute("classname").Contains("valor valor-big"))
                {
                    string valor = etiqueta.InnerText;

                    textBox1.Text = valor.Substring(12,14);
                }
                

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            navegador.Navigate(url);
        }


    }
}
