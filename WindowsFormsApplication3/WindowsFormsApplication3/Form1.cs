using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Vision.Motion;
using BarcodeLib.BarcodeReader;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private FilterInfoCollection Dispositivos;

        private VideoCaptureDevice FuenteVideo;
        MotionDetector Detector;
        float NivelDeteccion; 

        private void Form1_Load(object sender, EventArgs e)
        {

            Detector = new MotionDetector(new TwoFramesDifferenceDetector(), new MotionBorderHighlighting());
            NivelDeteccion = 0;   
            Dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo x in Dispositivos)
            {
                comboBox1.Items.Add(x.Name);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            FuenteVideo = new VideoCaptureDevice(Dispositivos[comboBox1.SelectedIndex].MonikerString);
            videoSourcePlayer1.VideoSource = FuenteVideo;
            videoSourcePlayer1.Start();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            videoSourcePlayer1.SignalToStop();
            
        }

        private void videoSourcePlayer1_NewFrame(object sender, ref Bitmap image)
        {
            NivelDeteccion = Detector.ProcessFrame(image);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = string.Format("{0:00.0000}", NivelDeteccion);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(videoSourcePlayer1.GetCurrentVideoFrame() != null)
            {
                Bitmap img = new Bitmap(videoSourcePlayer1.GetCurrentVideoFrame());
                string[] resultados = BarcodeReader.read(img, BarcodeReader.QRCODE);
                img.Dispose();
                if(resultados != null && resultados.Count() > 0)
                {
                    listBox1.Items.Add(resultados[0]);
                    
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QR qr = new QR();
            qr.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Image img = (Image)videoSourcePlayer1.GetCurrentVideoFrame();
            SaveFileDialog sv = new SaveFileDialog();
            sv.AddExtension = true;
            sv.Filter = "Image JPG (*.JPG)|*.JPG";
            sv.ShowDialog();
            if (!string.IsNullOrEmpty(sv.FileName))
            {
                img.Save(sv.FileName);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
