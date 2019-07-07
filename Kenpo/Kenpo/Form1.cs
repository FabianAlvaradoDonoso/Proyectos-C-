using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kenpo
{
    public partial class Form1 : Form
    {
        bool Play = false;
        string[] ArchivosMP3;
        string[] rutasArchivosMP3;

        string[] Audios = {"C:/Users/fabia/Downloads/Nueva carpeta/1-1 Delayed Sword.mp3", "C:/Users/fabia/Downloads/Nueva carpeta/1-2 Aggressive Twins.mp3", "C:/Users/fabia/Downloads/Nueva carpeta/1-3 Sword of Destruction.mp3",
            "C:/Users/fabia/Downloads/Nueva carpeta/1-4 Deflecting Hammer.mp3", "C:/Users/fabia/Downloads/Nueva carpeta/1-5 Spreading Branch.mp3", "C:/Users/fabia/Downloads/Nueva carpeta/1-6 Graps of Death.mp3",
            "C:/Users/fabia/Downloads/Nueva carpeta/1-7 Cheking the Storm.mp3", "C:/Users/fabia/Downloads/Nueva carpeta/1-8 Mace of Aggression.mp3", "C:/Users/fabia/Downloads/Nueva carpeta/1-9 Attacking Mace.mp3",
            "C:/Users/fabia/Downloads/Nueva carpeta/1-10 Intellectual Departure.mp3", "C:/Users/fabia/Downloads/Nueva carpeta/2-7 Cheking the Storm.mp3", "C:/Users/fabia/Downloads/Nueva carpeta/2-8 Mace of Aggression.mp3", "C:/Users/fabia/Downloads/Nueva carpeta/2-9 Attacking Mace.mp3",
            "C:/Users/fabia/Downloads/Nueva carpeta/2-10 Intellectual Departure.mp3" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog busqueda = new OpenFileDialog();
            busqueda.Multiselect = true;
            if(busqueda.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                ArchivosMP3 = busqueda.SafeFileNames;
                rutasArchivosMP3 = busqueda.FileNames;
                foreach(var ArchivoMP3 in ArchivosMP3)
                {
                    lstReproduccion.Items.Add(ArchivoMP3);
                }
                wmp1.URL = rutasArchivosMP3[0];
                lstReproduccion.SelectedIndex = 0;
                btnPlay.Image = Properties.Resources.pause;
            }
        }

        public void actualizarDatosTrack()
        {
            if (wmp1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                mtbReproduccion.Maximum=(int)wmp1.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if (wmp1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }
            else if (wmp1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                mtbReproduccion.Value = 0;
            }
        }

        private void lstReproduccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            wmp1.URL = rutasArchivosMP3[lstReproduccion.SelectedIndex];
            lbNombre.Text = ArchivosMP3[lstReproduccion.SelectedIndex];
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            switch (Play){
                case true:
                    
                    wmp1.Ctlcontrols.pause();
                    btnPlay.Image = Properties.Resources.play;
                    Play = false;
                    break;

                case false:
                    wmp1.Ctlcontrols.play();
                    btnPlay.Image = Properties.Resources.pause;
                    Play = true;
                    break;

                        
                    
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            wmp1.Ctlcontrols.stop();
            btnPlay.Image = Properties.Resources.play;
            Play = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            actualizarDatosTrack();
            mtbReproduccion.Value = (int)wmp1.Ctlcontrols.currentPosition;
            mtbVolumen.Value = wmp1.settings.volume;
        }

        private void wmp1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            actualizarDatosTrack();
        }

        private void mtbVolumen_ValueChanged(object sender, decimal value)
        {
            wmp1.settings.volume = mtbVolumen.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
