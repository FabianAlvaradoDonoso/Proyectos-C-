﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vidacero2.Clases;

namespace Vidacero2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        public bool usuarioLogueado = false;


        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.ResetText();
        }
    }
}
