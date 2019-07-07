using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class QR : Form
    {
        public QR()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            qrCodeImgControl1.Text = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image img = (Image)qrCodeImgControl1.Image.Clone();
            SaveFileDialog sv = new SaveFileDialog();
            sv.AddExtension = true;
            sv.Filter = "Image JPG (*.JPG)|*.JPG";
            sv.ShowDialog();
            if(!string.IsNullOrEmpty(sv.FileName))
            {
                img.Save(sv.FileName);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
