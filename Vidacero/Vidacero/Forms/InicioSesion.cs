using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vidacero.Clases;

namespace Vidacero
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
            
        }
        public bool sesionIniciada = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text != "" && txtContraseña.Text != "")
            {
                string resultados = Loguear.LoguearSesion(txtUsuario.Text, txtContraseña.Text);

                if (resultados != "")
                {
                    sesionIniciada = true;
                    MessageBox.Show(resultados, "Vidacero", MessageBoxButtons.OK);
                    this.Hide();
                    Contenedor c = new Contenedor();
                    c.ShowDialog();
                    this.Close();
                }
                else
                {
                    sesionIniciada = false;
                    MessageBox.Show("Acceso denegado, intente nuevamente");
                    txtUsuario.Text = "";
                    txtContraseña.Text = "";
                    txtUsuario.Focus();
                }
            }
            else
            {
                sesionIniciada = false;
                MessageBox.Show("Acceso denegado, intente nuevamente");
                txtUsuario.Text = "";
                txtContraseña.Text = "";
                txtUsuario.Focus();
            }
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            sesionIniciada = false;
            MessageBox.Show("Para recuperar su contraseña pongase en contacto con el administrador.", "Vidacero");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sesionIniciada = false;
            this.Close();
        }

        


      

        

        

    }
}
