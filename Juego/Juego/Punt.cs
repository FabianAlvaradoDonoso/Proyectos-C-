using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego
{
    public partial class Punt : Form
    {
        public Punt()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var NuevoHilo = new System.Threading.Thread(new System.Threading.ThreadStart(Run));
            this.Close();
            NuevoHilo.SetApartmentState(System.Threading.ApartmentState.STA);
            NuevoHilo.Start();
        }
        public void Run()
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
