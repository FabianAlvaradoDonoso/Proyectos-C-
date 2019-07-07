using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PersonalPrueba.Forms
{
    public partial class Visualizar : Form
    {
        ConexionGrabar cg = new ConexionGrabar();
        public Visualizar()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registrar r = new Registrar();
            this.Close();
            r.Show();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Registrar r = new Registrar();
                string rut;
                string aux;
                string string2 = lbRut.Text.Substring(lbRut.Text.Length - 1, 1);
                if (lbRut.Text.Substring(lbRut.Text.Length - 1, 1) == "k")
                {
                    rut = (lbRut.Text.Replace("-k", string.Empty)).Replace(",", string.Empty);
                    aux = "k";
                }
                else
                {
                    rut = (Convert.ToInt32((lbRut.Text.Replace(",", string.Empty)).Replace("-", string.Empty)) / 10).ToString();
                    aux = (Convert.ToInt32((lbRut.Text.Replace(",", string.Empty)).Replace("-", string.Empty)) % 10).ToString();
                }


                r.txtNombre.Text = lbNombre.Text;
                r.txtApellido.Text = lbApellidos.Text;
                r.txtDirec.Text = lbDireccion.Text;
                r.NumEdad.Value = Convert.ToInt32(lbEdad.Text);
                r.maskedTextBox1.Text = rut;
                r.cbComuna.SelectedItem = lbComuna.Text;
                r.label8.Text = aux;
                r.pictureBox1.Image = picfoto.Image;

                this.Close();
                r.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error");
            }
            
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            
            string rut;
            string string2 = lbRut.Text.Substring(lbRut.Text.Length - 1, 1);
            if (lbRut.Text.Substring(lbRut.Text.Length - 1, 1) == "k")
            {
                rut = (lbRut.Text.Replace("-k", string.Empty)).Replace(",", string.Empty);
            }
            else
            {
                rut = (Convert.ToInt32((lbRut.Text.Replace(",", string.Empty)).Replace("-", string.Empty)) / 10).ToString();
            }

            
            byte[] img = Image2Bytes(this.picfoto.Image);


            string sql = "insert into Personal values(@Rut,@Nombre,@Apellido,@Edad,@Direccion,@Comuna,@Foto)";
            string cadena = @"Data Source=.;Initial Catalog=Cliente;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(cadena);
            SqlCommand comando = new SqlCommand(sql, conexion);

            try
            {
                conexion.Open();
                comando.Parameters.AddWithValue("@Rut", Convert.ToInt32(rut));
                comando.Parameters.AddWithValue("@Nombre", lbNombre.Text);
                comando.Parameters.AddWithValue("@Apellido", lbApellidos.Text);
                comando.Parameters.AddWithValue("@Edad", lbEdad.Text);
                comando.Parameters.AddWithValue("@Direccion", lbDireccion.Text);
                comando.Parameters.AddWithValue("@Comuna", lbComuna.Text);
                comando.Parameters.AddWithValue("@Foto", img);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conexion.Close();
            }


            
        
        }


            /*if(cg.existeUsuario(Convert.ToInt32(rut)))
            {
                cg.RegistarUsuario(Convert.ToInt32(rut), lbNombre, lbApellidos, lbEdad, lbDireccion, lbComuna, textBox1, picfoto);
            }*/

        private byte[] Image2Bytes(Image img)
        {
            string sTemp = Path.GetTempFileName();
            FileStream fs = new FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            img.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
            fs.Position = 0;

            int imgLength = Convert.ToInt32(fs.Length);
            byte[] bytes = new byte[imgLength];
            fs.Read(bytes, 0, imgLength);
            fs.Close();
            return bytes;
        }

/// <summary>
        /// el método Byte2Image recibe un array de bytes como parámetro,
        /// lo asigna a un objeto del tipo MemoryStream y ese "stream" lo utiliza para crear un objeto del tipo Bitmap,
        /// finalmente devuelve ese objeto que en el fondo es un objeto de tipo Image.
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        private Image Bytes2Image(byte[] bytes)
        {
            if (bytes == null) return null;

            MemoryStream ms = new MemoryStream(bytes);
            Bitmap bm = null;
            
            try
            {
                bm = new Bitmap(ms);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return bm;
        }




        


    }
}
