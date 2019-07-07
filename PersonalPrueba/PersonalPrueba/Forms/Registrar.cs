using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace PersonalPrueba
{
    public partial class Registrar : Form
    {
        public OpenFileDialog examinar = new OpenFileDialog();
        string img;

        public Registrar()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtApellido.Clear();
            txtDirec.Clear();
            txtNombre.Clear();
            maskedTextBox1.Clear();
            NumEdad.ResetText();
            cbComuna.ResetText();
            label8.Text = "";
            pictureBox1.Image = PersonalPrueba.Properties.Resources.contact;
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            Imagen f3 = new Imagen();
            DialogResult res = f3.ShowDialog();
            if(res == DialogResult.OK)
            {
                if(f3.qe == "texto")
                {
                    pictureBox1.Image = Image.FromFile(f3.var);
                    img = f3.var;
                }
                else if(f3.qe == "imagen")
                {
                    pictureBox1.Image = Image.FromFile(f3.imgn);
                    img = f3.imgn;
                }
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" || txtApellido.Text != "" || txtDirec.Text != "" || cbComuna.SelectedItem != null ||
                    maskedTextBox1.Text != "" || NumEdad.Value.ToString() != "")
            {
                Forms.Visualizar v = new Forms.Visualizar();

                try
                {

                    {
                        revisarRut();
                        v.lbNombre.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNombre.Text);
                        v.lbApellidos.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtApellido.Text);
                        v.lbComuna.Text = cbComuna.SelectedItem.ToString();
                        v.lbDireccion.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtDirec.Text);
                        v.lbEdad.Text = NumEdad.Value.ToString();
                        v.lbRut.Text = maskedTextBox1.Text + "-" + label8.Text;
                        v.picfoto.Image = pictureBox1.Image;
                        v.textBox1.Text = img;

                        this.Close();
                        v.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ingresar los datos");
                    return;
                }
            }
                
        }

        private void revisarRut()
        {
            try
            {
                string dv;
                int aux1, aux2, suma = 0, aux3 = 2, DigVerif;

                aux1 = Convert.ToInt32(maskedTextBox1.Text.Replace(",", string.Empty));

                while (aux1 > 0)
                {
                    aux2 = aux1 % 10;
                    aux1 = aux1 / 10;
                    suma = suma + aux2 * aux3;
                    aux3++;
                    if (aux3 == 8)
                    {
                        aux3 = 2;
                    }
                }

                DigVerif = (suma % 11);
                DigVerif = 11 - DigVerif;
                if (DigVerif == 11)
                    dv = "0";
                else
                {
                    if (DigVerif == 10)
                        dv = "k";
                    else
                        dv = DigVerif.ToString();
                }
                label8.Text = dv;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error al ingresar los datos");
            }
        }

    }
}
