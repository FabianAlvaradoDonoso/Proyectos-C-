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
    
    public partial class Form1 : Form
    {
        int time = 60;
        int points = 0;
        public Form1()
        {
            InitializeComponent();
            lbPuntuacion.Text = "Puntuación: " + points;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if(time == 0)
            {
                var NuevoHilo = new System.Threading.Thread(new System.Threading.ThreadStart(Run));
                this.Close();
                NuevoHilo.SetApartmentState(System.Threading.ApartmentState.STA);
                NuevoHilo.Start();
            }
            else
            {
                time -= 1;
                lbTiempo.Text = "Tiempo: " + time;
            }
        }
        public void Run()
        {
            Punt q = new Punt();
            q.label1.Text = points.ToString();
            q.ShowDialog();
            
        }
        private void moverNpc()
        {
            Random random = new Random();
            pictureBox1.Location = new Point(random.Next(611), random.Next(351));
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            moverNpc();
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            points += 1;
            lbPuntuacion.Text = "Puntuación: " + points;
        }

       

       

       

        
    }
}
