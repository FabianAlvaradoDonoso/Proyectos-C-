using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaConexion
{
    public partial class ClienteNuevo : Form
    {
        ConexionMonto cD = new ConexionMonto();
        public ClienteNuevo()
        {
            InitializeComponent();
           
        }//Inicializacion del formulario.

        private void ClienteNuevo_Load(object sender, EventArgs e)
        {
            BtnEliminar.Enabled = false;
            BtnModificar.Enabled = false;
            cD.CargarCliente(DgvClientes);
            txtCodigoCliente.Focus();
        }//Carga del formulario.

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (cD.clienteRegistrado(Convert.ToInt32(txtCodigoCliente.Text)) == 0)
            {
                MessageBox.Show(cD.agregar(Convert.ToInt32(txtCodigoCliente.Text), txtNombreCliente.Text, txtDireccionCliente.Text, Convert.ToInt32(txtCantidadProductos.Text), Convert.ToInt32(txtMontoPagar.Text)));
                cD.CargarCliente(DgvClientes);
                txtCantidadProductos.Text = "";
                txtCodigoCliente.Text = "";
                txtDireccionCliente.Text = "";
                txtMontoPagar.Text = "";
                txtNombreCliente.Text = "";
                txtCodigoCliente.Focus();
            }
        }//Boton Agregar.

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Boton Atras.

        private void txtCodigoCliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cD.clienteRegistrado(Convert.ToInt32(txtCodigoCliente.Text)) != 0)
                {
                    cD.llenarTextBoxMonto(Convert.ToInt32(txtCodigoCliente.Text), txtNombreCliente, txtDireccionCliente, txtCantidadProductos, txtMontoPagar);
                    BtnAgregar.Enabled = false;
                    BtnModificar.Enabled = true;
                    BtnEliminar.Enabled = true;
                }
                else
                {
                    txtNombreCliente.Text = "";
                    txtDireccionCliente.Text = "";
                    txtCantidadProductos.Text = "";
                    txtNombreCliente.Text = "";
                    BtnAgregar.Enabled = true;
                    BtnEliminar.Enabled = false;
                    BtnModificar.Enabled = false;

                }
            }
            catch (System.FormatException) { }
        }//Buscador de Codigos.

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cD.eliminar(Convert.ToInt32(txtCodigoCliente.Text)));
            cD.CargarCliente(DgvClientes);
            txtCantidadProductos.Text = "";
            txtCodigoCliente.Text = "";
            txtDireccionCliente.Text = "";
            txtMontoPagar.Text = "";
            txtNombreCliente.Text = "";
            txtCodigoCliente.Focus();
        }//Boton Eliminar.

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cD.actualizar(Convert.ToInt32(txtCodigoCliente.Text), txtNombreCliente.Text, txtDireccionCliente.Text, Convert.ToInt32(txtCantidadProductos.Text), Convert.ToInt32(txtMontoPagar.Text)));
            cD.CargarCliente(DgvClientes);
        }//Boton Modificar.

    }
}
