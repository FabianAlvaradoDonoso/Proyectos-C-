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
    public partial class Compras : Form
    {
        ConexionBDD c = new ConexionBDD();
        int  poc;
        public Compras()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            c.llenarCbColor(cbColor);
            c.llenarCbMarca(cbMarca);
            c.llenarCbTamaño(cbTamaño);
            c.llenarCbProveedor(cbProveedor);
            c.cargarCompras(dgvCompras);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            int precio = calcularPrecio();
            int color = cbColor.SelectedIndex +1;
            string colorN = cbColor.SelectedItem.ToString();
            int tamaño = cbTamaño.SelectedIndex +1;
            string tamañoN = cbTamaño.SelectedItem.ToString();
            int marca = cbMarca.SelectedIndex +1;
            string marcaN = cbMarca.SelectedItem.ToString();
            int prod = (((color + tamaño + marca) * color)-marca);
            string nombre = "P. " + colorN + " " + marcaN + " " + tamañoN;
            Loguear.agregarProducto2((precio * Convert.ToInt32(NUPcantidad.Value)), cbColor.SelectedIndex + 1, cbTamaño.SelectedIndex + 1, cbMarca.SelectedIndex + 1, Convert.ToInt32(NUPcantidad.Value) , nombre);
            Loguear.agregarCompra(cbProveedor.SelectedIndex + 1, prod, Convert.ToInt32(NUPcantidad.Value), 0);
            c.cargarCompras(dgvCompras);
            limpiar();
        }


        private int calcularPrecio()
        {
            int precio = 0;
            if (cbMarca.SelectedItem.ToString() == "Polemic" || cbMarca.SelectedItem.ToString() == "Nike" || cbMarca.SelectedItem.ToString() == "Adiddas")
            {
                precio += 3000;
            }
            if (cbMarca.SelectedItem.ToString() == "Lee" || cbMarca.SelectedItem.ToString() == "Polo")
            {
                precio += 2500;
            }
            if (cbMarca.SelectedItem.ToString() == "Genérico")
            {
                precio += 2000;
            }

            if (cbTamaño.SelectedItem.ToString() == "XL" || cbTamaño.SelectedItem.ToString() == "L")
            {
                precio += 300;
            }
            if (cbTamaño.SelectedItem.ToString() == "M" || cbTamaño.SelectedItem.ToString() == "S")
            {
                precio += 200;
            }
            if (cbTamaño.SelectedItem.ToString() == "XS")
            {
                precio += 100;
            }
            return precio;
        }

        private void limpiar()
        {
            cbMarca.ResetText();
            cbColor.ResetText();
            cbProveedor.ResetText();
            cbTamaño.ResetText();
            NUPcantidad.ResetText();
        }

        private void dgvCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox1.Enabled = false;
            poc = dgvCompras.CurrentRow.Index;
            btnBodega.Enabled = true;
        }

        private void btnBodega_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(dgvCompras[0,poc].Value.ToString());
            Loguear.updateCompra(cod);
            c.cargarCompras(dgvCompras);
            btnBodega.Enabled = false;
            groupBox1.Enabled = true;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btnBodega.Enabled = false;
            c.cargarCompras(dgvCompras);
        }
    }
}
