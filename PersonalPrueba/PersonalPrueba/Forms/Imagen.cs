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

namespace PersonalPrueba
{
    public partial class Imagen : Form
    {

        public OpenFileDialog examinar = new OpenFileDialog();

        private FilterInfoCollection Dispositivos;
        private VideoCaptureDevice FuenteVideo;

        public string var;
        public string qe;
        public string imgn;

        public Imagen()
        {
            InitializeComponent();
            this.Size = new Size(330, 139);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Size = new Size(330, 139);
            examinar.Filter = "image files|*.jpg;*.png;*.gif;*.ico;.*;";
            DialogResult dr = examinar.ShowDialog();
            if (dr == DialogResult.Abort) return;
            if (dr == DialogResult.Cancel) return;
            var = examinar.FileName;
            qe = "texto";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            videoSourcePlayer1.Visible = true;
            button3.Visible = true;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new Size(330, 465);


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo x in Dispositivos)
            {
                comboBox1.Items.Add(x.Name);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FuenteVideo = new VideoCaptureDevice(Dispositivos[comboBox1.SelectedIndex].MonikerString);
            videoSourcePlayer1.VideoSource = FuenteVideo;
            videoSourcePlayer1.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            videoSourcePlayer1.SignalToStop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Image img = (Image)videoSourcePlayer1.GetCurrentVideoFrame();
            SaveFileDialog sv = new SaveFileDialog();
            sv.AddExtension = true;
            sv.Filter = "Image JPG (*.JPG)|*.JPG";
            sv.ShowDialog();
            if (!string.IsNullOrEmpty(sv.FileName))
            {
                img.Save(sv.FileName);
                imgn = sv.FileName;
            }
            qe = "imagen";
            FuenteVideo.SignalToStop();
            this.Close();
        }
    }
}
