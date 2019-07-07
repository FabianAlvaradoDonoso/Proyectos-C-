using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByteClicker
{
    public partial class Juego : Form
    {
        //************************************Puntaje******************************************
        double puntaje = 999999999990;

        //************************************Precios******************************************
        long precioCursor = 10;
        long precioTeclado = 100;

        //************************************Niveles******************************************
        long nivelCursor = 0;
        long nivelTeclado = 0;

        //******************************Multiplicador Puntaje**********************************
        double Multiplicador = 0;
        
        //*********************** *****Multiplicador Especiales********************************
        long click_Multiplicador = 1;
        long teclado_Multiplicador = 0;
        
        //*************************************************************************************

        public Juego()
        {
            InitializeComponent();
            timer1.Start();
            lbPuntaje.BackColor = Color.FromArgb(119, 63, 12);
            lbPuntaje.Text = puntaje.ToString();
        }

        private void Juego_Load(object sender, EventArgs e)
        {
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            puntaje += click_Multiplicador;
            lbPuntaje.Text = (Convert.ToInt64(puntaje)).ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            puntaje += Multiplicador;
            lbPuntaje.Text = (Convert.ToInt64(puntaje)).ToString();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            puntaje = 0 + puntaje;
            lbPuntaje.Text = (Convert.ToInt64(puntaje)).ToString();
        }

        private void btnClicks_Click(object sender, EventArgs e)
        {
            if (puntaje >= precioCursor)
            {
                nivelCursor += 1;
                puntaje -= Convert.ToInt64(precioCursor);
                precioCursor += Convert.ToInt64((3 * nivelCursor + 1)/2);
                lbPrecioCursor.Text = precioCursor.ToString();
                Multiplicador += 0.1;
                lbMultiplicador.Text = Multiplicador.ToString();
                lbNivelCursor.Text = nivelCursor.ToString();
            }
            
        }

        private void btnTeclado_Click(object sender, EventArgs e)
        {
            if (puntaje >= precioTeclado)
            {
                nivelTeclado += 1;
                puntaje -= Convert.ToInt32(precioTeclado);
                precioTeclado += Convert.ToInt32((100 * nivelTeclado + 1));
                lbPrecioTeclado.Text = precioTeclado.ToString("N");
                Multiplicador += 1.0;
                lbMultiplicador.Text = Multiplicador.ToString();
                lbNivelTeclado.Text = nivelTeclado.ToString();
            }
        }


    }
}
