using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Management;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && Convert.ToDouble(numericUpDown1.Value) == 1)
            {
                MessageBox.Show("Funciona", "Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Ticlea la casilla", "Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count != 0)
            {
                if (checkedListBox1.GetItemChecked(0))
                {
                    MessageBox.Show("Hola");
                }
                if (checkedListBox1.GetItemChecked(1))
                {
                    MessageBox.Show("Como");
                }
                if (checkedListBox1.GetItemChecked(2))
                {
                    MessageBox.Show("Estas");
                } 
                if (checkedListBox1.GetItemChecked(0) && checkedListBox1.GetItemChecked(1))
                {
                    MessageBox.Show("Hola Como");
                }
                if (checkedListBox1.GetItemChecked(0) && checkedListBox1.GetItemChecked(2))
                {
                    MessageBox.Show("Hola Estas");
                }
                if (checkedListBox1.GetItemChecked(1) && checkedListBox1.GetItemChecked(2))
                {
                    MessageBox.Show("Como Estas");
                }
            }
            else
            {
                MessageBox.Show("Adios");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            
            richTextBox1.ForeColor = colorDialog1.Color;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkArea = new LinkArea(0, 8);
            {
                try
                {
                    linkLabel1.LinkVisited = true;
                    System.Diagnostics.Process.Start("http://www.facebook.com");
                }
                catch (Exception ex )
                {
                    MessageBox.Show("Unable to open link that was clicked" + ex.ToString());
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            if (maskedTextBox1.Text == label1.Text)
            {
                MessageBox.Show("Despierta");
                Console.Beep(264, 125);
                Thread.Sleep(2500);
                Console.Beep(264,125);
            }

            progressBar1.Value = (int)(performanceCounter1.NextValue());
            label2.Text = "CPU: " + progressBar1.Value.ToString() + "%";
            progressBar2.Value =  100 - ((int)(performanceCounter2.NextValue()) * 100 / 12188);
            label3.Text = "RAM: " + progressBar2.Value.ToString() + "%";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "Cambiar") button6.Text = "Despertar";
            else button6.Text = "Cambiar";

            if (maskedTextBox1.Enabled == true) maskedTextBox1.Enabled = false;
            else maskedTextBox1.Enabled = true;


        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipText = "La aplicación esta minimizada";
                notifyIcon1.ShowBalloonTip(1000);
            }
            else if(this.WindowState == FormWindowState.Normal)
            {
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipText = "La aplicación esta Normal";
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }



       

    }

}
