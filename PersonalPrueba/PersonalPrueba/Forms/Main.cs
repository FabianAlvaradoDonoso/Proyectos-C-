using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalPrueba.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registrar r = new Registrar();
            r.MdiParent = this;
            r.Show();
        }

        private void accionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Hola que hace");
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

    }
}
