using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Data;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Aplicacion_Imagenes
{
    class Conexiones
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Funciona!!;Integrated Security=True");

        public bool Insertar(string nombre, PictureBox pb)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into imagen values (@nombre, @imagen)", con);
            cmd.Parameters.Add("@nombre", SqlDbType.NVarChar);
            cmd.Parameters.Add("@imagen", SqlDbType.Image);

            cmd.Parameters["@nombre"].Value = nombre;
            MemoryStream ms = new MemoryStream();

            pb.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            cmd.Parameters["@imagen"].Value = ms.GetBuffer();

            int resultado = cmd.ExecuteNonQuery();
            con.Close();

            if (resultado > 0) return true;
            else return false;

        }

        public bool Actualizar(string id, string nombre, PictureBox pb)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update imagen set nombre=@nombre, image=@imagen where id=" +id, con);
            cmd.Parameters.Add("@nombre", SqlDbType.NVarChar);
            cmd.Parameters.Add("@imagen", SqlDbType.Image);

            cmd.Parameters["@nombre"].Value = nombre;
            MemoryStream ms = new MemoryStream();

            pb.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            cmd.Parameters["@image"].Value = ms.GetBuffer();

            int resultado = cmd.ExecuteNonQuery();
            con.Close();

            if (resultado > 0) return true;
            else return false;

        }

        public bool Eliminar(string id)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from imagen where id=" + id, con);
            
            int resultado = cmd.ExecuteNonQuery();
            con.Close();

            if (resultado > 0) return true;
            else return false;

        }

        public void verImagen(PictureBox pb, string id)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select image from image where id" + id, con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds, "img");

            byte[] datos = new byte[0];
            DataRow dr = ds.Tables["img"].Rows[0];
            datos = (byte[])dr["imagen"];
            MemoryStream ms = new MemoryStream(datos);
            pb.Image = System.Drawing.Bitmap.FromStream(ms);

            con.Close();
        }

        public void llenarCombo(ComboBox cb)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select nombre from imagen", con);
            con.Close();
        }

    }
}
