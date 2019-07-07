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


namespace PersonalPrueba.Forms
{
    class ConexionGrabar
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataRow drw;
        DataSet ds;
        bool Conexion = false;

        public ConexionGrabar()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=Cliente;Integrated Security=True");
                cn.Open();
                Conexion = true;

            }
            catch (Exception ex)
            {
                Conexion = false;
            }
        }//Conexion con Base de Datos...Constructor.

      
        public bool ConexionExitosa(object sender, EventArgs e)
        {
            if(Conexion)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RegistarUsuario(int rut, Label nombre, Label apellido, Label edad, Label direccion, Label comuna, TextBox img, PictureBox picfoto)
        {
            FileStream stream = new FileStream(img.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(stream);
            FileInfo fi = new FileInfo(img.Text);
            byte[] binData = new byte[stream.Length];
            stream.Read(binData, 0, Convert.ToInt32(stream.Length));

            picfoto.Image = Image.FromStream(stream);

            SqlCommand cmd = new SqlCommand("insert into Personal2(Rut, Nombre, Apellido, Edad, Direccion, Comuna, Foto) values (@RUT, @NOMBRES,@APELLIDO,@EDAD,@DIRECCION,@COMUNA,@FOTO)", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RUT", Convert.ToInt32(rut));
            cmd.Parameters.AddWithValue("@NOMBRES", nombre.Text.ToString());
            cmd.Parameters.AddWithValue("@APELLIDOS", apellido.Text.ToString());
            cmd.Parameters.AddWithValue("@EDAD", edad.Text.ToString());
            cmd.Parameters.AddWithValue("@DIRECCION", direccion.Text.ToString());
            cmd.Parameters.AddWithValue("@DISTRITO", comuna.Text.ToString());
            cmd.Parameters.AddWithValue("@FOTO", binData);


            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Registro Registrado con Exito", "CompuBinario", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return true;
            }
            else
            {
                MessageBox.Show("NO FUE REGISTRADO", "CompuBinario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
                
        }//Usuario Nuevo.

        public bool existeUsuario(int rut)
        {
            int salida = 0;
            try
            {
                cmd = new SqlCommand("Select * from Personal2 where Rut = " + rut + "", cn);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    salida++;
                }
                dr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            if (salida == 0) return true;
            else return false;
        } //Verificador de usuario registrado.

    }
}
