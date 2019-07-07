using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba1a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
                    //
            // Required for Windows Form Designer support.
            //
            InitializeComponent();
            // Initialize the user-defined button,
            // including defining handler for Click message,
            // location and size.
            myButtonObject myButton = new myButtonObject();
            EventHandler myHandler = new EventHandler(myButton_Click);
            myButton.Click += myHandler;
            myButton.Location = new System.Drawing.Point(20, 20);
            myButton.Size = new System.Drawing.Size(101, 101);
            this.Controls.Add(myButton);
        }
        public class myButtonObject : UserControl
        {
            // Draw the new button.
            protected override void OnPaint(PaintEventArgs e)
            {
                Graphics graphics = e.Graphics;
                Pen myPen = new Pen(Color.Black);
                // Draw the button in the form of a circle
                graphics.DrawEllipse(myPen, 0, 0, 100, 100);
                myPen.Dispose();
            }
        }
        // Handler for the click message.
        void myButton_Click(Object sender, System.EventArgs e)
        {
            MessageBox.Show("Click");
        }
        
    }
}
