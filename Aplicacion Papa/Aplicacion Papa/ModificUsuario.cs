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
    public partial class ModificUsuario : Form
    {
        ConexionUsuarios conUsu = new ConexionUsuarios();

        public ModificUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(conUsu.eliminarUsuario(txtUsuario.Text, txtContraseñaO.Text))
            {
                MessageBox.Show("Se elimino el usuario");
                this.Close();
            }
            else
            {
                txtContraseñaN.Clear();
                txtContraseñaO.Clear();
                txtRContraseñaN.Clear();
                txtContraseñaO.Focus();
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtContraseñaN.Text == txtRContraseñaN.Text)
            {
                int cerrar = 0;
                conUsu.modificarUsuario(txtUsuario.Text, txtContraseñaO.Text, txtContraseñaN.Text, cerrar);
                if (cerrar == 1)this.Close();
                
            } 
            else
            {
                MessageBox.Show("Las contraseñas no son iguales","Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseñaN.Clear();
                txtRContraseñaN.Clear();
                txtContraseñaO.Clear();
                txtContraseñaO.Focus();
            }
            
        }
    }
}
