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
    public partial class Stock : Form
    {
        ConexionBDD c = new ConexionBDD();
        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            c.cargarStock(dgvStock);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbEFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEFiltro.SelectedItem.ToString() == "Codigo Producto" || cbEFiltro.SelectedItem.ToString() == "Nombre")
            {
                txtFiltro.Visible = true;
                cbFiltro.Visible = false;
                if (cbEFiltro.SelectedItem.ToString() == "Codigo Producto") lblNombre.Text = "Ingrese codigo Producto:";
                if (cbEFiltro.SelectedItem.ToString() == "Nombre") lblNombre.Text = "Ingrese nombre Producto:";
            }
           
            if (cbEFiltro.SelectedItem.ToString() == "Marca" || cbEFiltro.SelectedItem.ToString() == "Tamaño" || cbEFiltro.SelectedItem.ToString() == "Color" || cbEFiltro.SelectedItem.ToString() == "Bodega")
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
                if (cbEFiltro.SelectedItem.ToString() == "Bodega")
                {
                    lblNombre.Text = "Seleccione Bodega:";
                    cbFiltro.DataSource = null;
                    cbFiltro.Items.Clear();
                    c.llenarCbBodega(cbFiltro);
                }
               
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (cbEFiltro.SelectedItem.ToString() == "Codigo Producto")
            {
                c.cargarStockCod(dgvStock, txtFiltro.Text);
            }
            if (cbEFiltro.SelectedItem.ToString() == "Nombre")
            {
                c.cargarStockNombre(dgvStock, txtFiltro.Text);
            }
            
            if (cbEFiltro.SelectedItem.ToString() == "Color")
            {
                string idColor = Loguear.ObtenerColor(cbFiltro.SelectedItem.ToString());
                c.cargarStockColor(dgvStock, idColor);
            }
            if (cbEFiltro.SelectedItem.ToString() == "Tamaño")
            {
                string idTamaño = Loguear.ObtenerTamaño(cbFiltro.SelectedItem.ToString());
                c.cargarStockTamaño(dgvStock, idTamaño);
            }
            if (cbEFiltro.SelectedItem.ToString() == "Marca")
            {
                string idMarca = Loguear.ObtenerMarca(cbFiltro.SelectedItem.ToString());
                c.cargarStockMarca(dgvStock, idMarca);
            }
            if (cbEFiltro.SelectedItem.ToString() == "Bodega")
            {
                string idBodega = Loguear.ObtenerBodega(cbFiltro.SelectedItem.ToString());
                c.cargarStockBodega(dgvStock, idBodega);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void limpiar()
        {
            cbEFiltro.ResetText();
            cbFiltro.ResetText();
            txtFiltro.Text = "";
            c.cargarStock(dgvStock);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            c.cargarStock(dgvStock);
        }
    }
}
