using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vidacero
{
    public partial class Modificacion : Form
    {
        public string[] info = new string[5] {"","","","",""};  
 
        public Modificacion()
        {
            InitializeComponent();
            
            
        }

        private void Modificacion_Load(object sender, EventArgs e)
        {
            Clases.ConexionBDD c = new Clases.ConexionBDD();
            c.llenarCbColor(cbColor);
            c.llenarCbMarca(cbMarca);
            c.llenarCbTamaño(cbTamaño);
            txtPrecio.Text = (1500).ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int calcularPrecioT()
        {
            int precio1 = 0;
            if (cbMarca.SelectedItem.ToString() == "Polemic" || cbMarca.SelectedItem.ToString() == "Nike" || cbMarca.SelectedItem.ToString() == "Adiddas")
            {
                precio1 += 3000;
            }
            if (cbMarca.SelectedItem.ToString() == "Lee" || cbMarca.SelectedItem.ToString() == "Polo")
            {
                precio1 += 2500;
            }
            if (cbMarca.SelectedItem.ToString() == "Genérico")
            {
                precio1 += 2000;
            }

            if (cbTamaño.SelectedItem.ToString() == "XL" || cbTamaño.SelectedItem.ToString() == "L")
            {
                precio1 += 300;
            }
            if (cbTamaño.SelectedItem.ToString() == "M" || cbTamaño.SelectedItem.ToString() == "S")
            {
                precio1 += 200;
            }
            if (cbTamaño.SelectedItem.ToString() == "XS")
            {
                precio1 += 100;
            }


            return precio1;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbTamaño.SelectedItem.ToString() != "" && cbMarca.SelectedItem.ToString() != "" && cbColor.SelectedItem.ToString() != "")
                {
                    txtPrecio.Text = ((calcularPrecioT() + 1500) * nudCantidad.Value).ToString();
                }
                else
                {
                    MessageBox.Show("Seleccione primero los elementos antes de calcular");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione primero los elementos antes de calcular");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbTamaño.SelectedItem.ToString() != "" && cbMarca.SelectedItem.ToString() != "" && cbColor.SelectedItem.ToString() != "")
                {
                    txtPrecio.Text = ((calcularPrecioT() + 1500) * nudCantidad.Value).ToString();
                }
                else
                {
                    MessageBox.Show("Seleccione primero los elementos antes de calcular");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione primero los elementos antes de calcular");
            }

            info[0] = cbColor.SelectedItem.ToString();
            info[1] = cbTamaño.SelectedItem.ToString();
            info[2] = cbMarca.SelectedItem.ToString();
            info[3] = nudCantidad.Value.ToString();
            info[4] = txtPrecio.Text;
        }

    }
}
