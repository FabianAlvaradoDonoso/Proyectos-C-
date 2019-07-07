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
    public partial class Ventas : Form
    {
        ConexionBDD c = new ConexionBDD();
        int poc;
        public Ventas()
        {
            InitializeComponent();
        }

        private void cbEFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbEFiltro.SelectedItem.ToString() == "Trabajador" || cbEFiltro.SelectedItem.ToString() == "Cliente" || cbEFiltro.SelectedItem.ToString() == "Pedido")
            {
                txtFiltro.Visible = true;
                cbFiltro.Visible = false;
                if (cbEFiltro.SelectedItem.ToString() == "Trabajador") lblNombre.Text = "Ingrese RUT del Trabajador:";
                if (cbEFiltro.SelectedItem.ToString() == "Pedido") lblNombre.Text = "Ingrese Numero del Pedido:";
                if (cbEFiltro.SelectedItem.ToString() == "Cliente") lblNombre.Text = "Ingrese RUT del Cliente:";
            }
            if (cbEFiltro.SelectedItem.ToString() == "Fecha")
            {
                txtFiltro.Visible = false;
                cbFiltro.Visible = false;
                
                if (cbEFiltro.SelectedItem.ToString() == "Fecha") lblNombre.Text = "Ingrese Fecha:";
            }
            if (cbEFiltro.SelectedItem.ToString() == "Marca" || cbEFiltro.SelectedItem.ToString() == "Tamaño" || cbEFiltro.SelectedItem.ToString() == "Color" || cbEFiltro.SelectedItem.ToString() == "Comuna" || cbEFiltro.SelectedItem.ToString() == "Provincia" || cbEFiltro.SelectedItem.ToString() == "Región" )
            {
                cbFiltro.Visible = true;
                txtFiltro.Visible = false;

                if (cbEFiltro.SelectedItem.ToString() == "Marca")
                {
                    lblNombre.Text = "Seleccione Marca:";
                    cbFiltro.DataSource = null;
                    cbFiltro.Items.Clear();
                    c.llenarCbMarca(cbFiltro);
                }
                if (cbEFiltro.SelectedItem.ToString() == "Tamaño")
                {
                    lblNombre.Text = "Seleccione Tamaño:";
                    cbFiltro.DataSource = null;
                    cbFiltro.Items.Clear();
                    c.llenarCbTamaño(cbFiltro);
                }
                if (cbEFiltro.SelectedItem.ToString() == "Color")
                {
                    lblNombre.Text = "Seleccione Color:";
                    cbFiltro.DataSource = null;
                    cbFiltro.Items.Clear();
                    c.llenarCbColor(cbFiltro);
                }
                if (cbEFiltro.SelectedItem.ToString() == "Comuna")
                {
                    lblNombre.Text = "Seleccione Comuna:";
                    cbFiltro.DataSource = null;
                    cbFiltro.Items.Clear();
                    c.llenarCbComuna2(cbFiltro);
                }
                if (cbEFiltro.SelectedItem.ToString() == "Provincia")
                {
                    lblNombre.Text = "Seleccione Provincia";
                    cbFiltro.DataSource = null;
                    cbFiltro.Items.Clear();
                    c.llenarCbProvincia(cbFiltro);
                }
                if (cbEFiltro.SelectedItem.ToString() == "Región")
                {
                    lblNombre.Text = "Seleccione Región:";
                    cbFiltro.DataSource = null;
                    cbFiltro.Items.Clear();
                    c.llenarCbRegion(cbFiltro);
                }
            }
    

        }

        private void cbEFiltro2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEFiltro2.SelectedItem.ToString() == "Trabajador" || cbEFiltro2.SelectedItem.ToString() == "Cliente" || cbEFiltro2.SelectedItem.ToString() == "Pedido")
            {
                txtFiltro2.Visible = true;
                cbFiltro2.Visible = false;
                dtpFiltro2.Visible = false;
                if (cbEFiltro2.SelectedItem.ToString() == "Trabajador") lblNombre2.Text = "Ingrese RUT del Trabajador:";
                if (cbEFiltro2.SelectedItem.ToString() == "Pedido") lblNombre2.Text = "Ingrese Numero del Pedido:";
                if (cbEFiltro2.SelectedItem.ToString() == "Cliente") lblNombre2.Text = "Ingrese RUT del Cliente:";
            }
            if (cbEFiltro2.SelectedItem.ToString() == "Fecha")
            {
                dtpFiltro2.Visible = true;
                txtFiltro2.Visible = false;
                cbFiltro2.Visible = false;

                if (cbEFiltro2.SelectedItem.ToString() == "Fecha") lblNombre2.Text = "Ingrese Fecha:";
            }
            if (cbEFiltro2.SelectedItem.ToString() == "Marca" || cbEFiltro2.SelectedItem.ToString() == "Tamaño" || cbEFiltro2.SelectedItem.ToString() == "Color" || cbEFiltro2.SelectedItem.ToString() == "Comuna" || cbEFiltro2.SelectedItem.ToString() == "Provincia" || cbEFiltro2.SelectedItem.ToString() == "Región")
            {
                cbFiltro2.Visible = true;
                dtpFiltro2.Visible = false;
                txtFiltro2.Visible = false;

                if (cbEFiltro2.SelectedItem.ToString() == "Marca")
                {
                    lblNombre2.Text = "Seleccione Marca:";
                    cbFiltro2.DataSource = null;
                    cbFiltro2.Items.Clear();
                    c.llenarCbMarca(cbFiltro2);
                }
                if (cbEFiltro2.SelectedItem.ToString() == "Tamaño")
                {
                    lblNombre2.Text = "Seleccione Tamaño:";
                    cbFiltro2.DataSource = null;
                    cbFiltro2.Items.Clear();
                    c.llenarCbTamaño(cbFiltro2);
                }
                if (cbEFiltro2.SelectedItem.ToString() == "Color")
                {
                    lblNombre2.Text = "Seleccione Color:";
                    cbFiltro2.DataSource = null;
                    cbFiltro2.Items.Clear();
                    c.llenarCbColor(cbFiltro2);
                }
                if (cbEFiltro2.SelectedItem.ToString() == "Comuna")
                {
                    lblNombre2.Text = "Seleccione Comuna:";
                    cbFiltro2.DataSource = null;
                    cbFiltro2.Items.Clear();
                    c.llenarCbComuna2(cbFiltro2);
                }
                if (cbEFiltro2.SelectedItem.ToString() == "Provincia")
                {
                    lblNombre2.Text = "Seleccione Provincia";
                    cbFiltro2.DataSource = null;
                    cbFiltro2.Items.Clear();
                    c.llenarCbProvincia(cbFiltro2);
                }
                if (cbEFiltro2.SelectedItem.ToString() == "Región")
                {
                    lblNombre2.Text = "Seleccione Región:";
                    cbFiltro2.DataSource = null;
                    cbFiltro2.Items.Clear();
                    c.llenarCbRegion(cbFiltro2);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            if (cbEFiltro.SelectedItem.ToString() == "Trabajador")
            {
                //c.cargarVentasTrabajador(dgvVentasActivas, txtFiltro.Text);
            }
            if (cbEFiltro.SelectedItem.ToString() == "Cliente")
            {
                c.cargarVentasCliente(dgvVentasActivas, txtFiltro.Text);
            }
            if (cbEFiltro.SelectedItem.ToString() == "Pedido")
            {
                c.cargarVentasPedido(dgvVentasActivas, txtFiltro.Text);
            }
            if (cbEFiltro.SelectedItem.ToString() == "Comuna")
            {
                string idComuna = Loguear.ObtenerC(cbFiltro.SelectedItem.ToString());
                c.cargarVentasComuna(dgvVentasActivas, idComuna);
            }
            if (cbEFiltro.SelectedItem.ToString() == "Provincia")
            {
                string idProvincia = Loguear.ObtenerProv(cbFiltro.SelectedItem.ToString());
                c.cargarVentasProvincia(dgvVentasActivas, idProvincia);
            }
            if (cbEFiltro.SelectedItem.ToString() == "Región")
            {
                string idRegion = Loguear.ObtenerRegi(cbFiltro.SelectedItem.ToString());
                c.cargarVentasRegion(dgvVentasActivas, idRegion);
            }
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            c.cargarVentas(dgvVentasActivas);
            c.cargarVentas2(dgvVentasFinalizadas);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            c.cargarVentas(dgvVentasActivas);
            cbEFiltro.ResetText();
            cbFiltro.ResetText();
            txtFiltro.Text = "";
            btnBorrar.Enabled = false;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFiltrar2_Click(object sender, EventArgs e)
        {
            if (cbEFiltro2.SelectedItem.ToString() == "Trabajador")
            {
                c.cargarVentasTrabajador2(dgvVentasFinalizadas, txtFiltro2.Text);
            }
            if (cbEFiltro2.SelectedItem.ToString() == "Cliente")
            {
                c.cargarVentasCliente2(dgvVentasFinalizadas, txtFiltro2.Text);
            }
            if (cbEFiltro2.SelectedItem.ToString() == "Pedido")
            {
                c.cargarVentasPedido2(dgvVentasFinalizadas, txtFiltro2.Text);
            }
            if (cbEFiltro2.SelectedItem.ToString() == "Comuna")
            {
                string idComuna = Loguear.ObtenerC(cbFiltro2.SelectedItem.ToString());
                c.cargarVentasComuna2(dgvVentasFinalizadas, idComuna);
            }
            if (cbEFiltro2.SelectedItem.ToString() == "Provincia")
            {
                string idProvincia = Loguear.ObtenerProv(cbFiltro2.SelectedItem.ToString());
                c.cargarVentasProvincia2(dgvVentasFinalizadas, idProvincia);
            }
            if (cbEFiltro2.SelectedItem.ToString() == "Región")
            {
                string idRegion = Loguear.ObtenerRegi(cbFiltro2.SelectedItem.ToString());
                c.cargarVentasRegion2(dgvVentasFinalizadas, idRegion);
            }
        }

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            c.cargarVentas2(dgvVentasFinalizadas);
            cbFiltro2.ResetText();
            cbEFiltro2.ResetText();
            txtFiltro2.Text = "";
        }

        private void dgvVentasActivas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = dgvVentasActivas.CurrentRow.Index;

            btnBorrar.Enabled = true;
            button1.Enabled = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string cod = dgvVentasActivas[0, poc].Value.ToString();
            Loguear.EliminarVenta(cod);
            c.cargarVentas(dgvVentasActivas);
            cbEFiltro.ResetText();
            cbFiltro.ResetText();
            txtFiltro.Text = "";
            btnBorrar.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cod = dgvVentasActivas[0, poc].Value.ToString();
            Loguear.updateEntregar(Convert.ToInt32(cod));
            c.cargarVentas(dgvVentasActivas);
            c.cargarVentas2(dgvVentasFinalizadas);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            c.cargarVentas(dgvVentasActivas);
        }

        private void btnActualizar2_Click(object sender, EventArgs e)
        {
            c.cargarVentas2(dgvVentasFinalizadas);
        }

        private int totalVentas()
        {
            int suma = 0;
            foreach (DataGridViewRow row in dgvVentasActivas.Rows)
            {

            }
            return suma;
        }

    }
}
