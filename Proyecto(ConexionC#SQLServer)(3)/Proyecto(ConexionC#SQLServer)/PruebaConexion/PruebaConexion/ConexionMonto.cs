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
    class ConexionMonto
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;


        public ConexionMonto()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=Cliente;Integrated Security=True");
                cn.Open();
                //MessageBox.Show("Conectado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la base de datos: " + ex.ToString());
            }
        }//Conexion con Base de Datos...Constructor.

        public string agregar(int cod, string nombre, string direc, int cantidad, int total)
        {
            string salida = "Se agrego Correctamente";
            try
            {
                cmd = new SqlCommand("Insert into Monto(Codigo, Nombre, Direccion, CantidadProd, MontoPagar) values (" + cod + " , '" + nombre + "', '" + direc + "', " + cantidad + ", " + total + ")", cn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                salida = "No se pudo agregar" +ex.ToString();
            }
            return salida;
        }//Agregar a Base de Datos.

        public int clienteRegistrado(int id)
        {
            int salida = 0;
            try
            {
                cmd = new SqlCommand("Select * from Monto where Codigo = " + id + "", cn);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    salida++;
                }
                dr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return salida;
        }//Buscar Codigo.

        public void llenarTextBoxMonto(int cod, TextBox nombre, TextBox direc, TextBox cant, TextBox monto)
        {
            try
            {
                cmd = new SqlCommand("Select * from Monto where Codigo=" + cod + "", cn);
                dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    nombre.Text = dr["Nombre"].ToString();
                    direc.Text = dr["Direccion"].ToString();
                    cant.Text = dr["CantidadProd"].ToString();
                    monto.Text = dr["MontoPagar"].ToString();
                }
                dr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString());
            }
        }//Llenar campos.

        public string eliminar(int cod)
        {
            string salida = "Se elimino el dato";
            try
            {
                cmd = new SqlCommand("Delete from Monto where Codigo=" + cod + "", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se pudo eliminar el dato: " + ex.ToString();
            }
            return salida;
        }//Eliminar Codigo.

        public string actualizar(int cod, string nombre, string direc, int cant, int total)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cmd = new SqlCommand("Update Monto set Nombre = '" + nombre + "' ,Direccion = '" + direc + "' ,CantidadProd = " + cant + " ,MontoPagar="+total+" where Codigo = " + cod + " ", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se pudo actualizar los datos: " + ex.ToString();
            }
            return salida;
        }//Actualizar Codigo.

        public void CargarCliente(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from Monto", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo llenar el DataGridView" + e.ToString());
            }
        }//Actualizar Tabla.


    }
}

     

