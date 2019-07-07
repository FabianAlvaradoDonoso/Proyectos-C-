using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Pago_Clientes_2
{
    public partial class frmPago : Form
    {
        ConexionDatos c = new ConexionDatos();
        public frmPago()
        {
            InitializeComponent();
           
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            Trabajador_Nuevo Trabajador = new Trabajador_Nuevo();
            Trabajador.ShowDialog();
        }

        private void frmPago_Load(object sender, EventArgs e)
        {

        }

       
        
    }
}
