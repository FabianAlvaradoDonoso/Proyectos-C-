using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vidacero2.Clases;

namespace Vidacero2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public bool logueado = false;

        private void button1_Click(object sender, EventArgs e)
        {
            string resultado = Datos.iniciarSesion(txtNombre.Text, txtContraseña.Text);

            if(resultado != "")
            {
                logueado = true;
                MessageBox.Show(resultado, "Mensaje", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Acceso denegado", "Error", MessageBoxButtons.OK);
                txtNombre.Text = "";
                txtContraseña.Text = "";
                txtNombre.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
