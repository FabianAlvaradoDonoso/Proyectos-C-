using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Vidacero2.Clases
{
    class Datos
    {
        static SqlConnection conexion = new SqlConnection();

        public static void abrirConexion()
        {
            conexion.ConnectionString = @"Data Source=Fabian-PC\Fabian;Initial Catalog=Vidacero;Integrated Security=True";
            conexion.Open();
        }

        public static void cerrarConexion()
        {
            conexion.Close();
        }

        public static string iniciarSesion(string usuario, string contraseña)
        {
            int logueado = 0;
            string mensaje = "";

            abrirConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Logear";
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Nusuario", usuario));
            cmd.Parameters.Add(new SqlParameter("@Ncontraseña", conexion));

            SqlParameter pLogueado = new SqlParameter("@logueado", 0);
            pLogueado.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(pLogueado);

            SqlParameter pMensaje = new SqlParameter("@mensaje", SqlDbType.VarChar);
            pMensaje.Direction = ParameterDirection.Output;
            pMensaje.Size = 40;
            cmd.Parameters.Add(pMensaje);

            cmd.ExecuteNonQuery();
            cerrarConexion();

            logueado = Int32.Parse(cmd.Parameters["@logueado"].Value.ToString());
            if(logueado > 0)
            {
                mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                return mensaje;
            }
            else
            {
                return mensaje;
            }


        }
    }
}
