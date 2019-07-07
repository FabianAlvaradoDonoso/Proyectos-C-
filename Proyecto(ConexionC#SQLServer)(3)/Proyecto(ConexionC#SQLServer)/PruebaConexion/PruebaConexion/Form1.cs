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
    public partial class Form1 : Form
    {

        ConexionDatos c = new ConexionDatos();   
        public Form1()
        {
            InitializeComponent();
        }

       private void Form1_Load(object sender, EventArgs e)
        {
            txtId.Focus();
            BtnEliminar.Enabled = false;
            BtnModificar.Enabled = false;
            c.CargarCliente(DgvPersonas);

        }

       private void txtId_TextChanged(object sender, EventArgs e)
       {
           try
           {
               if (c.personaRegistrada(Convert.ToInt32(txtId.Text)) != 0)
               {
                   c.llenarTextBoxConsulta(Convert.ToInt32(txtId.Text), txtNombre, txtApellidos, dtpFecha);
                   BtnAgregar.Enabled = false;
                   BtnModificar.Enabled = true;
                   BtnEliminar.Enabled = true;
               }
               else
               {
                   txtNombre.Text = "";
                   txtApellidos.Text = "";
                   BtnAgregar.Enabled = true;
                   BtnModificar.Enabled = false;
                   BtnEliminar.Enabled = false;

               }
           }
           catch (System.FormatException) { }
           
           
       }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
          if(c.personaRegistrada(Convert.ToInt32(txtId.Text))==0)
          {
             MessageBox.Show(c.insertar(Convert.ToInt32(txtId.Text),txtNombre.Text,txtApellidos.Text,dtpFecha.Text));
             c.CargarCliente(DgvPersonas);
             txtId.Text = "";
             txtNombre.Text = "";
             txtApellidos.Text = "";
             dtpFecha.ResetText();
             txtId.Focus();


          }
          else
          {
              MessageBox.Show("Imposible de regitrar, El registro ya existe");
          }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(c.actualizar(Convert.ToInt32(txtId.Text),txtNombre.Text, txtApellidos.Text, dtpFecha.Text));
            c.CargarCliente(DgvPersonas);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(c.eliminar(Convert.ToInt32(txtId.Text)));
            c.CargarCliente(DgvPersonas);
            dtpFecha.ResetText();
            txtId.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtId.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteNuevo CN = new ClienteNuevo();
            CN.ShowDialog();
        }
    }
}

