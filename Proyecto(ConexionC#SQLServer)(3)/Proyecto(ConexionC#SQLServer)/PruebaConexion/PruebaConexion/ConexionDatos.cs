using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PruebaConexion
{
    class ConexionDatos
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;

        public ConexionDatos()
        {
           try
           {
               cn = new SqlConnection("Data Source=.;Initial Catalog=Cliente;Integrated Security=True");
               cn.Open();
               MessageBox.Show("Conectado");

           }
            catch(Exception ex)
           {
               MessageBox.Show("No se conecto con la base de datos: "+ex.ToString());
           }
        }

        public string insertar(int id,string nombre,string apellidos,string fecha)
        {
            string salida = "Se se inserto";
            try
            {
                cmd = new SqlCommand("Insert into Datos(Id, Nombre, Apellidos, FechaNacimiento) values("+id+",'"+nombre+"','"+apellidos+"','"+fecha+"')",cn);
                cmd.ExecuteNonQuery();//para insertar el nuevo comando cmd
            }
            catch(Exception ex)
            {
                salida = "No se inserto: " + ex.ToString();
            }
            return salida;
        }
               
        public int personaRegistrada(int id)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from Datos where Id="+id+"", cn);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: "+ex.ToString());
            }
            return contador;
        }

        public void CargarCliente(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from Datos", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch(Exception e)
            {
                MessageBox.Show("No se pudo llenar el DataGridView" + e.ToString());
            }
        }

        public void llenarTextBoxConsulta(int id, TextBox txtNombre, TextBox txtApellidos, DateTimePicker dtpFecha)
        {
            try
            {
                cmd = new SqlCommand("select * from Datos where Id=" + id + "", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtNombre.Text = dr["Nombre"].ToString();
                    txtApellidos.Text = dr["Apellidos"].ToString();
                    dtpFecha.Text = dr["FechaNAcimiento"].ToString();
                }
                dr.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("No se pudo llenar los datos" + e.ToString());
            }
        }

        public string actualizar(int id, string nombre, string apellidos, string fecha)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cmd = new SqlCommand("Update Datos set Nombre = '"+nombre+"' ,Apellidos = '"+apellidos+"' ,FechaNacimiento = '"+fecha+"' where Id = "+id+" ", cn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                salida = "No se pudo actualizar los datos: " + ex.ToString();
            }
            return salida;
        }

        public string eliminar(int id)
        {
            string salida = "Se elimino el dato";
            try
            {
                cmd = new SqlCommand("Delete from Datos where Id=" + id + "", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se pudo eliminar el dato: " + ex.ToString();
            }
            return salida;
        }

    }
}
