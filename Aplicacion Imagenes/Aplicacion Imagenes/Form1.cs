using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Cryptography;
using Aplicacion_Imagenes;

namespace Aplicacion_Imagenes
{
    public partial class Form1 : Form
    {
        Conexiones img = new Conexiones();
        public Form1()
        {
            InitializeComponent();
            img.llenarCombo(cbNombre);
        }
        

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Todas las imagenes soportadas|*.jpeg;*.png;*.bmp;*.ico";
            ofd.InitialDirectory = @"C:\Users";
            if (ofd.ShowDialog() == DialogResult.OK) pbImagen.Load(ofd.FileName);
            textBox1.Text = ofd.FileName;
            cbNombre.Focus();
        }

        private void cbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtID.Text = cbNombre.SelectedIndex.ToString();
            textBox1.Text = cbNombre.SelectedItem.ToString();
            img.verImagen(pbImagen, txtID.Text);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            img.Insertar(textBox1.Text, pbImagen);
            img.llenarCombo(cbNombre);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            img.Eliminar(txtID.Text);
            img.llenarCombo(cbNombre);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            img.Actualizar(txtID.Text, textBox1.Text, pbImagen);
            img.llenarCombo(cbNombre);
        }
        
    }
}
