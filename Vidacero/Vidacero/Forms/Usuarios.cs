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
    public partial class Usuarios : Form
    {
        ConexionBDD c = new ConexionBDD();
        int poc, tipoU = 2;
        string id;
        public Usuarios()
        {
            InitializeComponent();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            c.cargarInicioSesion(dgvInicio);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvInicio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = dgvInicio.CurrentRow.Index;
            id = dgvInicio[3, poc].Value.ToString();
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;

            string usuario = dgvInicio[0, poc].Value.ToString();
            string contraseña = dgvInicio[1, poc].Value.ToString();
            string tipo = dgvInicio[2, poc].Value.ToString();

            groupBox1.Enabled = true;
            txtUsuario.Text = usuario;
            txtContraseña.Text = contraseña;

            if (tipo == "1") rbAdministrador.Checked = true;
            if (tipo == "2") rbTrabajador.Checked = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
            c.cargarInicioSesion(dgvInicio);
        }

        private void limpiar()
        {
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnNuevo.Enabled = true;
            groupBox1.Enabled = false;
            txtContraseña.Text = "";
            txtUsuario.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtContraseña.Text != "" && (rbAdministrador.Checked || rbTrabajador.Checked))
            {
                if (rbTrabajador.Checked) tipoU = 2;
                if (rbAdministrador.Checked) tipoU = 1;

                Loguear.agregarUsuario(txtUsuario.Text, txtContraseña.Text, tipoU);
                c.cargarInicioSesion(dgvInicio);
                limpiar();


            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos para agregar un nuevo usuario", "Nuevo Usuario", MessageBoxButtons.OK);
            }
            


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string cod = dgvInicio[0, poc].Value.ToString();
            Loguear.EliminarUsuario(cod);
            c.cargarInicioSesion(dgvInicio);
            limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtContraseña.Text != "" && (rbAdministrador.Checked || rbTrabajador.Checked))
            {
                if (rbTrabajador.Checked) tipoU = 2;
                if (rbAdministrador.Checked) tipoU = 1;

                Loguear.modificarUsuario(txtUsuario.Text, txtContraseña.Text, tipoU, Convert.ToInt32(id));
                c.cargarInicioSesion(dgvInicio);
                limpiar();


            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos para modificar un usuario o ver si no existe un usuario con el mismo nombre", "Nuevo Usuario", MessageBoxButtons.OK);
            }
        }

        
    }
}
