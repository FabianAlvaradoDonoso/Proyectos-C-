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
    public partial class Contenedor : Form
    {
        public Contenedor()
        {
            InitializeComponent();
            if(Loguear.tipo_admin == 1)
            {
                usuarios.Enabled = true;
            }
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Está seguro de salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.No) e.Cancel = true;

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is ListaClientes);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //se abre el form de clientes
            frm = new ListaClientes();
            frm.MdiParent = this;
            frm.Show();



        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is Stock);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //se abre el form de clientes
            frm = new Stock();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is Ventas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //se abre el form de clientes
            frm = new Ventas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is Compras);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //se abre el form de clientes
            frm = new Compras();
            frm.MdiParent = this;
            frm.Show();
        }

        private void usuarios_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is Usuarios);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //se abre el form de clientes
            frm = new Usuarios();
            frm.MdiParent = this;
            frm.Show();
        }

        private void listaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void nuevoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is Cliente);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //se abre el form de clientes
            frm = new Cliente();
            frm.MdiParent = this;
            frm.Show();
        }

        /*private void desactivado()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Cliente))
                {
                    ventas.Enabled = false;
                    compras.Enabled = false;
                    stock.Enabled = false;
                    break;
                }
                if (frm.GetType() == typeof(Compras))
                {
                    ventas.Enabled = false;
                    Clientes.Enabled = false;
                    stock.Enabled = false;
                    break;
                }
                if (frm.GetType() == typeof(Ventas))
                {
                    Clientes.Enabled = false;
                    compras.Enabled = false;
                    stock.Enabled = false;
                    break;
                }
                if (frm.GetType() == typeof(Stock))
                {
                    ventas.Enabled = false;
                    compras.Enabled = false;
                    Clientes.Enabled = false;
                    break;
                }
            }
        }*/
    }
}
