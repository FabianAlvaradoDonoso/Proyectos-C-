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
    public partial class InicioSesion : Form
    {
        ConexionUsuarios coxUsu = new ConexionUsuarios();

        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if(!coxUsu.IniciarSesion(txtUsuario.Text, txtContraseña.Text))
            {
                txtContraseña.Clear();
                txtContraseña.Focus();
            }
            else
            {
                MessageBox.Show("Sesión Iniciada", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }


        } 

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            UsuarioNuevo UN = new UsuarioNuevo();
            UN.ShowDialog();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtUsuario.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Esta seguro de Salir?", "Remunex Pro 3000", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (r == DialogResult.Yes) this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificUsuario MU = new ModificUsuario();
            MU.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rut r = new Rut();
            r.ShowDialog();
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            if (!coxUsu.ConexionExitosa(sender, e))
            {
                label8.Visible = true;
            }
        }


    }
}
