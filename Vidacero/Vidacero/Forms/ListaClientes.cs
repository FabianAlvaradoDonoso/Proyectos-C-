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
    public partial class ListaClientes : Form
    {
        ConexionBDD c = new ConexionBDD();
        int poc;

        public ListaClientes()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListaClientes_Load(object sender, EventArgs e)
        {
            c.cargarClientes(dgvClientes);
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = dgvClientes.CurrentRow.Index;
            groupBox1.Enabled = true;

            textBox1.Text = dgvClientes[1, poc].Value.ToString();
            textBox2.Text = dgvClientes[2, poc].Value.ToString();
        }

        private void Limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            groupBox1.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string rut = dgvClientes[0, poc].Value.ToString();
            Loguear.updateCliente(Convert.ToInt32(rut), textBox1.Text, textBox2.Text);
            c.cargarClientes(dgvClientes);
            Limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            c.cargarClientes(dgvClientes);
        }
    }
}
