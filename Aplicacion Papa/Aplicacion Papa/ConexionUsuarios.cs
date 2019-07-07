using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Aplicacion_Papa
{
    class ConexionUsuarios
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataRow drw;
        DataSet ds;
        bool Conexion = false;

        public ConexionUsuarios()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=IniciarSesion;Integrated Security=True");
                cn.Open();
                Conexion = true;

            }
            catch (Exception ex)
            {
                Conexion = true;
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

        public string RegistarUsuario(string usuario, string contraseña)
        {
            string salida = "Usuario Nuevo Registrado";
            try
            {
                cmd = new SqlCommand("Insert into Usuarios(Usuario, Contraseña) values('" + usuario + "','" + contraseña + "')", cn);
                cmd.ExecuteNonQuery();//para insertar el nuevo comando cmd
            }
            catch (Exception ex)
            {
                salida = "ERROR. No se pudo registrar el usuario: " + ex.ToString();
            }
            return salida;
        }//Usuario Nuevo.


        public bool IniciarSesion(string usuario, string contraseña)
        {
            try
            {

                cmd = new SqlCommand("select Usuario, Contraseña from Usuarios where Usuario = '" + usuario + "'And Contraseña = '" + contraseña + "' ", cn);
                cmd.ExecuteNonQuery();

                ds = new DataSet();
                da = new SqlDataAdapter(cmd);

                da.Fill(ds, "Usuario");
                drw = ds.Tables["Usuario"].Rows[0];

                if ((usuario == drw["Usuario"].ToString()) || (contraseña == drw["Contraseña"].ToString()))return true;
                else return false;

            }
            catch
            {
                MessageBox.Show("Error! Su contraseña y/o usuario son invalidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }//Iniciar Sesion.


        public bool existeUsuario(string usuario)
        {
            int salida = 0;
            try
            {
                cmd = new SqlCommand("Select * from Usuarios where Usuario = '" + usuario + "'", cn);
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


        public bool eliminarUsuario(string usuario, string contraseña)
        {
            bool existe = IniciarSesion(usuario, contraseña);
            try
            {
                if (existe)
                {
                    cmd = new SqlCommand("Delete from Usuarios where Usuario = '" + usuario + "'", cn);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("No se pudo eliminar el dato: " + ex.ToString());
                return false;
            }
            return false;
        } // Eliminar Usuario.


        public bool modificarUsuario(string usuario, string contraseña, string nuevaContraseña, int cerrar)
        {
            bool existe = IniciarSesion(usuario, contraseña);
            try
            {
                if(existe)
                {
                    cmd = new SqlCommand("Update Usuarios set Contraseña = '" + nuevaContraseña + "' where Usuario = '" + usuario + "'", cn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Se modifico el usuario");
                    cerrar++;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("No se pudo modificar el dato: " + ex.ToString());
                return false;
            }
            return false;
        } //Modificar Usuario.

    }
}
