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
    public partial class Cliente : Form
    {
        int poc, poc2, comuna, provincia, region, transporte, dias;
        public int comunaN, provinciaN, regionN, tamañoN, colorN, marcaN;
        string[] informacion;
        string rutB;
        ConexionBDD c = new ConexionBDD();

        public Cliente()
        {
            InitializeComponent();
            Limpiar();
            btnCancelar.Text = "Cerrar";
            
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtANumero.Text != "" && txtDNumero.Text != "")
            {
                dgvTelefonos.Rows.Add(TipoTel(), txtANumero.Text + txtDNumero.Text);
                btnModificar.Enabled = false;
                btnBorrar.Enabled = false;
                btnNuevo.Enabled = false;
                txtANumero.Text = "";
                txtDNumero.Text = "";
            }
            else
            {
                MessageBox.Show("Se deben llenar todos los campos correctamente");
            }
        }

        private int idTipoT(string tipo)
        {
            if (tipo == "Movil") return 1;
            if (tipo == "Casa") return 2;
            if (tipo == "Oficina") return 3;
            if (tipo == "Otro") return 4;
            return 1;
        }

        private void Limpiar()
        {
            btnBorrar.Enabled = false;
            btnModificar.Enabled = false;
            btnNuevo.Enabled = false;
            txtANumero.Clear();
            txtDNumero.Clear();
            btnBorrarProducto.Enabled = false;
            btnModificarProducto.Enabled = false;
            btnNuevoProducto.Enabled = false;
        }

        private void dgvTelefonos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Limpiar();
                poc = dgvTelefonos.CurrentRow.Index;

                ObtenerTipo();

                if (dgvTelefonos[1, poc].Value.ToString().Length == 9)
                {
                    txtANumero.Text = dgvTelefonos[1, poc].Value.ToString().Substring(0, 1);
                    txtDNumero.Text = dgvTelefonos[1, poc].Value.ToString().Substring(1, 8);
                }
                else
                {
                    txtANumero.Text = dgvTelefonos[1, poc].Value.ToString().Substring(0, 2);
                    txtDNumero.Text = dgvTelefonos[1, poc].Value.ToString().Substring(2, 8);
                }



                btnBorrar.Enabled = true;
                btnModificar.Enabled = true;
                btnNuevo.Enabled = true;
                btnAgregar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se debe llenar por lo menos un telefono para modificar o borrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rbCasa.Focus();
                btnAgregar.Enabled = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
             try
            {
                string tipo, numero;
                int i = 0;

                tipo = TipoTel();

                if ((txtANumero.Text.ToString().Length == 2 || txtANumero.Text.ToString().Length == 1) && int.TryParse(txtANumero.Text.ToString(), out i))
                {
                    if (txtDNumero.Text.ToString().Length == 8 && int.TryParse(txtDNumero.Text.ToString(), out i))
                    {
                        numero = txtANumero.Text + txtDNumero.Text;
                        dgvTelefonos[0, poc].Value = tipo;
                        dgvTelefonos[1, poc].Value = numero;
                    }
                    else
                    {
                        MessageBox.Show("El numero debe contener 8 números y no letras. Intente otra ves.");
                        txtANumero.Focus();

                    }
                }

                else
                {
                    MessageBox.Show("El prefijo debe contener a lo más 2 números y no letras. Intente otra ves.");
                    txtANumero.Focus();
                }
                btnAgregar.Enabled = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Se debe rellenar todos los datos antes de agregar.", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Limpiar();

        }    

        private string TipoTel()
        {
            if (rbCasa.Checked)
                return rbCasa.Text;
            if (rbMovil.Checked)
                return rbMovil.Text;
            if (rbOficina.Checked)
                return rbOficina.Text;
            if (rbOtro.Checked)
                return rbOtro.Text;
            else
                return "Casa";

            
           
        }

        private void ObtenerTipo()
       {
           if (dgvTelefonos[0, poc].Value == "Movil")
               rbMovil.Checked = true;
           if (dgvTelefonos[0, poc].Value == "Oficina")
               rbOficina.Checked = true;
           if (dgvTelefonos[0, poc].Value == "Otro")
               rbOtro.Checked = true;
           if (dgvTelefonos[0, poc].Value == "Casa")
               rbCasa.Checked = true;
       }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtANumero.Clear();
           txtDNumero.Clear();
           btnAgregar.Enabled = true;
           btnBorrar.Enabled = false;
           btnModificar.Enabled = false;
           btnNuevo.Enabled = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
           dgvTelefonos.Rows.RemoveAt(poc);
           Limpiar();
           btnAgregar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void revisarRut()
        {
            try
            {
                string dv;
                int aux1, aux2, suma = 0, aux3 = 2, DigVerif;

                aux1 = Convert.ToInt32(txtRut.Text);

                while (aux1 > 0)
                {
                    aux2 = aux1 % 10;
                    aux1 = aux1 / 10;
                    suma = suma + aux2 * aux3;
                    aux3++;
                    if (aux3 == 8)
                    {
                        aux3 = 2;
                    }
                }

                DigVerif = (suma % 11);
                DigVerif = 11 - DigVerif;
                if (DigVerif == 11)
                    dv = "0";
                else
                {
                    if (DigVerif == 10)
                        dv = "k";
                    else
                        dv = DigVerif.ToString();
                }

                if(dv != txtDV.Text)
                {
                    pbRut.Visible = true;
                    pbRutB.Visible = false;
                }
                else
                {
                    pbRutB.Visible = true;
                    pbRut.Visible = false;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar el rut. Intente nuevamente.", "Rut", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRut.Clear();
                txtDV.Clear();
                txtRut.Focus();
            }
        }

        private void txtDV_Leave(object sender, EventArgs e)
        {
            revisarRut();
        }
       
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar)  && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void Cliente_Load(object sender, EventArgs e)
        {

            c.llenarCbRegion(cbRegion);
            c.llenarCbColor(cbColor);
            c.llenarCbMarca(cbMarca);
            c.llenarCbTamaño(cbTamaño);
            c.llenarCbTransporte(cbTrasporte);

            dtpFEntrega.MinDate = DateTime.Today;
            dtpFEntrega.Value = DateTime.Now.AddDays(10);
            toolTip1.SetToolTip(this.dtpFEntrega, "Elegir fecha de entrega, con 10 días de anticipación desde la fecha actual.");
        }  //Carga de ComboBox

        private void btnSgte_Click(object sender, EventArgs e)
        {
            if (pbRutB.Visible == true && txtNombre.Text != "" && txtNfb.Text != "" && dgvTelefonos.Rows.Count != 0)
            {
                tabControl1.SelectTab(1);
                txtDireccion.Focus();
            }
            else
            {
                MessageBox.Show("Rellene todos los campos antes de continuar.");
            }
            /*
            panel1.Enabled = true;
            panel1.Visible = true;
            txtDireccion.Focus();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        } //Primera Pagina  

        private void txtANumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbTamaño.SelectedItem.ToString() != "" && cbMarca.SelectedItem.ToString() != "" && cbColor.SelectedItem.ToString() != "")
                {
                    txtPrecio.Text = ((calcularPrecio() + 1500) * nudCantidad.Value).ToString();

                    if (dgvProductos.Rows.Count == 0)
                    {
                        dgvProductos.Rows.Add(cbColor.SelectedItem.ToString(), cbTamaño.SelectedItem.ToString(), cbMarca.SelectedItem.ToString(), nudCantidad.Value, txtPrecio.Text, cbColor.SelectedIndex + 1, cbTamaño.SelectedIndex + 1, cbMarca.SelectedIndex + 1);
                    }
                    else
                    {
                        for (int k = 0; k < dgvProductos.Rows.Count; k++)
                        {
                            if (cbColor.SelectedItem.ToString() == dgvProductos[0, k].Value.ToString() && cbTamaño.SelectedItem.ToString() == dgvProductos[1, k].Value.ToString() && cbMarca.SelectedItem.ToString() == dgvProductos[2, k].Value.ToString())
                            {
                                int cant = Convert.ToInt32(dgvProductos[3, k].Value.ToString());
                                int precio = Convert.ToInt32(dgvProductos[4, k].Value.ToString());
                                dgvProductos[3, k].Value = (cant + nudCantidad.Value).ToString();
                                dgvProductos[4, k].Value = (((calcularPrecio() + 1500) * nudCantidad.Value) + precio).ToString();
                                break;
                            }
                            else
                            {
                                dgvProductos.Rows.Add(cbColor.SelectedItem.ToString(), cbTamaño.SelectedItem.ToString(), cbMarca.SelectedItem.ToString(), nudCantidad.Value, txtPrecio.Text, cbColor.SelectedIndex + 1, cbTamaño.SelectedIndex + 1, cbMarca.SelectedIndex + 1);
                                break;
                            }

                        }
                    }

                    cbTamaño.ResetText();
                    cbMarca.ResetText();
                    cbColor.ResetText();
                    nudCantidad.Value = 1;
                    txtPrecio.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto, rellene los datos necesarios antes de continuar", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private int calcularPrecio()
        {
            int precio1 = 0;
            if(cbMarca.SelectedItem.ToString() == "Polemic" || cbMarca.SelectedItem.ToString() == "Nike" || cbMarca.SelectedItem.ToString() == "Adiddas")
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

            if(cbTamaño.SelectedItem.ToString() == "XL" || cbTamaño.SelectedItem.ToString() == "L")
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

        private void btnCPrecio_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbTamaño.SelectedItem.ToString() != "" && cbMarca.SelectedItem.ToString() != "" && cbColor.SelectedItem.ToString() != "")
                {
                    txtPrecio.Text = ((calcularPrecio() + 1500) * nudCantidad.Value).ToString();
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

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnNuevoProducto.Enabled = true;
            btnAgregarProducto.Enabled = false;
            poc2 = dgvProductos.CurrentRow.Index;
            btnModificarProducto.Enabled = true;
            btnBorrarProducto.Enabled = true;
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            btnAgregarProducto.Enabled = true;
            btnBorrarProducto.Enabled = false;
            btnModificarProducto.Enabled = false;
            btnNuevoProducto.Enabled = false;
            cbTamaño.ResetText();
            cbMarca.ResetText();
            cbColor.ResetText();
            nudCantidad.Value = 1;
            txtPrecio.Text = "0";
        }

        private void txtDNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            cbColor.Enabled = false;
            cbMarca.Enabled = false;
            cbTamaño.Enabled = false;
            nudCantidad.Enabled = false;
            btnCPrecio.Enabled = false;
            btnAgregarProducto.Enabled = false;
            btnBorrarProducto.Enabled = false;
            btnNuevo.Enabled = false;
            btnNuevo.Enabled = false;
            dgvProductos.Enabled = false;



            Modificacion m = new Modificacion();
            m.Location = new Point(groupBox5.Left + 45, groupBox5.Height - 65);
            DialogResult res = m.ShowDialog();

            if (res == DialogResult.OK)
            {
                informacion = m.info;
                dgvProductos[0, poc2].Value = informacion[0];
                dgvProductos[1, poc2].Value = informacion[1];
                dgvProductos[2, poc2].Value = informacion[2];
                dgvProductos[3, poc2].Value = informacion[3];
                dgvProductos[4, poc2].Value = informacion[4];
            }



            cbColor.Enabled = true;
            cbMarca.Enabled = true;
            cbTamaño.Enabled = true;
            nudCantidad.Enabled = true;
            btnCPrecio.Enabled = true;
            btnAgregarProducto.Enabled = true;
            btnNuevoProducto.Enabled = false;
            dgvProductos.Enabled = true;
            btnModificarProducto.Enabled = false;
        }

        private void btnBorrarProducto_Click(object sender, EventArgs e)
        {
            dgvProductos.Rows.RemoveAt(poc2);
            btnAgregarProducto.Enabled = true;
            btnBorrarProducto.Enabled = false;
            btnModificarProducto.Enabled = false;
            btnNuevoProducto.Enabled = false;
            cbTamaño.ResetText();
            cbMarca.ResetText();
            cbColor.ResetText();
            nudCantidad.Value = 1;
            txtPrecio.Text = "0";
        }

        private bool verificarFecha()
        {
            DateTime hoy = DateTime.Now;
            DateTime fecha = dtpFEntrega.Value;
            int dias = Math.Abs((DateTime.Now - fecha).Days);

            if(dias > 8)
            {
                return true;
            }
            return false;

        }

        private void btnSiguiente2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbTrasporte.SelectedItem.ToString() != "" && txtDireccion.Text != "" && cbRegion.SelectedItem.ToString() != "" && cbComuna.SelectedItem.ToString() != "" && cbCiudad.SelectedItem.ToString() != "" && dgvProductos.Rows.Count != 0 && verificarFecha())
                {
                    tabControl1.SelectTab(2);


                    pasarDatos();

                }
                else
                {
                    MessageBox.Show("Rellene todos los campos antes de continuar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rellene todos los campos antes de continuar");
            }

        }

        private void btnAtras2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
            Productos.Rows.Clear();
            Telefonos.Rows.Clear();
        }

        private int obtenerTipoTel(string tipo)
        {
            if(tipo == "Movil")
            {
                return 1;
            }
            if (tipo == "Casa")
            {
                return 2;
            }
            if (tipo == "Oficina")
            {
                return 3;
            }
            if (tipo == "Otro")
            {
                return 4;
            }
            else
            {
                return 1;
            }
        }

        private int setProvincia(int provincia, int region)
        {
            return ((region * 10) + provincia);
        }

        private int setComuna(int comuna, int provincia)
        {
            return ((provincia * 100) + comuna);
        }
        
        private void pasarDatos()
        {
            int comunaCB = cbComuna.SelectedIndex + 1;
            int provinciaCB =cbCiudad.SelectedIndex + 1;
            int regionCB = cbRegion.SelectedIndex + 1;

            Nombre.Text = txtNombre.Text;
            RUT.Text = txtRut.Text + "-" + txtDV.Text;
            rutB = txtRut.Text + txtDV.Text;
            NombreFB.Text = txtNfb.Text;
            txtTransporte.Text = cbTrasporte.SelectedItem.ToString();
            Direccion.Text = txtDireccion.Text;
            txtComuna.Text = cbComuna.SelectedItem.ToString();
            Ciudad.Text = cbCiudad.SelectedItem.ToString();
            txtRegion.Text = cbRegion.SelectedItem.ToString();

            regionN = regionCB;
            provinciaN = setProvincia(provinciaCB, regionCB);
            comunaN = setComuna(comunaCB, provinciaN);
            

            FechaEntrega.Text = dtpFEntrega.Value.ToString("dd/MM/yyyy");
            

            string tipo, telefono, id;
            for (int i = 0; i < dgvTelefonos.Rows.Count; i++)
            {
                tipo = dgvTelefonos[0, i].Value.ToString();
                telefono = dgvTelefonos[1, i].Value.ToString();
                id = (obtenerTipoTel(tipo)).ToString();
                Telefonos.Rows.Add(tipo, telefono, id);
            }

            string marca, precio, tamaño, color, cantidad, idcolor, idtamaño, idmarca;
            for (int j = 0; j < dgvProductos.Rows.Count; j++)
            {
                color = dgvProductos[0, j].Value.ToString();
                tamaño = dgvProductos[1, j].Value.ToString();
                marca = dgvProductos[2, j].Value.ToString();
                cantidad = dgvProductos[3, j].Value.ToString();
                precio = dgvProductos[4, j].Value.ToString();
                idcolor = dgvProductos[5, j].Value.ToString();
                idtamaño = dgvProductos[6, j].Value.ToString();
                idmarca = dgvProductos[7, j].Value.ToString();

                Productos.Rows.Add(color, tamaño, marca, cantidad, precio, idcolor, idtamaño, idmarca);
            }

            DateTime hoy = DateTime.Now;
            DateTime fecha = dtpFEntrega.Value;
            dias = Math.Abs((DateTime.Now - fecha).Days);

            comuna = index(cbComuna);
            provincia = index(cbCiudad);
            region = index(cbRegion);
            transporte = index(cbTrasporte);
        }

        private int index(ComboBox cb)
        {
            return cb.SelectedIndex;
        }

        private void btnRealizarP_Click(object sender, EventArgs e)
        {
            Loguear.nuevoPedido(Nombre.Text, int.Parse(rutB), NombreFB.Text, cbTrasporte.SelectedIndex + 1, Direccion.Text, comunaN, provinciaN, regionN, 10, FechaEntrega.Text, Telefonos, Productos, 123456789, 0);

        }

        private void cbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCiudad.Enabled = true;
            cbCiudad.DataSource = null;
            cbCiudad.Items.Clear();
            c.llenarCbCiudad(cbCiudad, cbRegion.SelectedItem.ToString());
        }

        private void cbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbComuna.Enabled = true;
            cbComuna.DataSource = null;
            cbComuna.Items.Clear();
            c.llenarCbComuna(cbComuna, cbCiudad.SelectedItem.ToString());
        }

    }
}
