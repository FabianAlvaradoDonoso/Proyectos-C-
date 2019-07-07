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
    public partial class UsuarioNuevo : Form
    {
        ConexionUsuarios conUsu = new ConexionUsuarios();

        public UsuarioNuevo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text != "" && txtContraseña.Text != "" && txtRcontraseña.Text != "")
            {
                if (txtContraseña.Text == txtRcontraseña.Text && pictureBox1.Visible == false)
                {
                    MessageBox.Show(conUsu.RegistarUsuario(txtUsuario.Text, txtContraseña.Text));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden o ya existe el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContraseña.Clear();
                    txtRcontraseña.Clear();
                    txtContraseña.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if(!conUsu.existeUsuario(txtUsuario.Text))
            {
                pictureBox1.Visible = true;
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }
    }
}
