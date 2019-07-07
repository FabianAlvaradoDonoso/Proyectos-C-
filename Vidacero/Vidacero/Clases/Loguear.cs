using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Vidacero.Clases
{
    class Loguear
    {
        static SqlConnection conexion = new SqlConnection();
        public static int tipo_admin;

        public static void Abrirconexion()
        {
            conexion.ConnectionString = @"Data Source=.; Initial Catalog=Vidacero; Integrated Security=True";
            conexion.Open();
        }
        public static void CerrarConexion()
        {
            conexion.Close();
        }

        //-------------------------FUNCIONES------------------------------------

        public static string LoguearSesion(string usuario, string contraseña)
        {
            int logueado = 0;
            string mensaje = "";

            Abrirconexion();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Logear";
            cmd.Connection = conexion;

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Nusuario", usuario));
            cmd.Parameters.Add(new SqlParameter("@Ncontraseña", contraseña));

            SqlParameter plogueado = new SqlParameter("@logueado", 0);
            plogueado.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(plogueado);

            SqlParameter pmensaje = new SqlParameter("@mensaje", SqlDbType.VarChar);
            pmensaje.Direction = ParameterDirection.Output;
            pmensaje.Size = 40;
            cmd.Parameters.Add(pmensaje);

            SqlParameter ptipo_admin = new SqlParameter("@tipo_Admin", 0);
            ptipo_admin.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(ptipo_admin);

            cmd.ExecuteNonQuery();
            CerrarConexion();

            logueado = Int32.Parse(cmd.Parameters["@logueado"].Value.ToString());
            tipo_admin = Int32.Parse(cmd.Parameters["@tipo_Admin"].Value.ToString());

            if (logueado > 0)
            {
                mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                return mensaje;
            }
            else
            {
                return mensaje;
            }
        }



        public static string ObtenerC(string nombre)
        {
            try
            {
                string id ;
                Abrirconexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "ObtenerComuna";
                cmd.Connection = conexion;

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@nombre", nombre));

                SqlParameter pid = new SqlParameter("@id", 0);
                pid.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pid);

                cmd.ExecuteNonQuery();
                CerrarConexion();

                id = cmd.Parameters["@id"].Value.ToString();

                return id;
            }
            catch ( Exception ex)
            {
                MessageBox.Show("Error en Comuna" + ex.ToString());
            }
            return "";
           
        }
        public static string ObtenerProv(string nombre)
        {
            try
            {
                string id;
                Abrirconexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "ObtenerProvincia";
                cmd.Connection = conexion;

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@nombre", nombre));

                SqlParameter pid = new SqlParameter("@id", 0);
                pid.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pid);

                cmd.ExecuteNonQuery();
                CerrarConexion();

                id = cmd.Parameters["@id"].Value.ToString();

                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Provincia" + ex.ToString());
            }
            return "";

        }
        public static string ObtenerRegi(string nombre)
        {
            try
            {
                string id;
                Abrirconexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "ObtenerRegion";
                cmd.Connection = conexion;

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@nombre", nombre));

                SqlParameter pid = new SqlParameter("@id", 0);
                pid.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pid);

                cmd.ExecuteNonQuery();
                CerrarConexion();

                id = cmd.Parameters["@id"].Value.ToString();

                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Region" + ex.ToString());
            }
            return "";

        }
        public static string ObtenerBodega(string nombre)
        {
            try
            {
                string id;
                Abrirconexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "ObtenerBodega";
                cmd.Connection = conexion;

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@nombre", nombre));

                SqlParameter pid = new SqlParameter("@id", 0);
                pid.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pid);

                cmd.ExecuteNonQuery();
                CerrarConexion();

                id = cmd.Parameters["@id"].Value.ToString();

                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Bodega" + ex.ToString());
            }
            return "";

        }
        public static string ObtenerMarca(string nombre)
        {
            try
            {
                string id;
                Abrirconexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "ObtenerMarca";
                cmd.Connection = conexion;

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@nombre", nombre));

                SqlParameter pid = new SqlParameter("@id", 0);
                pid.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pid);

                cmd.ExecuteNonQuery();
                CerrarConexion();

                id = cmd.Parameters["@id"].Value.ToString();

                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Marca" + ex.ToString());
            }
            return "";

        }
        public static string ObtenerTamaño(string nombre)
        {
            try
            {
                string id;
                Abrirconexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "ObtenerTamaño";
                cmd.Connection = conexion;

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@nombre", nombre));

                SqlParameter pid = new SqlParameter("@id", 0);
                pid.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pid);

                cmd.ExecuteNonQuery();
                CerrarConexion();

                id = cmd.Parameters["@id"].Value.ToString();

                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Tamaño" + ex.ToString());
            }
            return "";

        }
        public static string ObtenerColor(string nombre)
        {
            try
            {
                string id;
                Abrirconexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "ObtenerColor";
                cmd.Connection = conexion;

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@nombre", nombre));

                SqlParameter pid = new SqlParameter("@id", 0);
                pid.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pid);

                cmd.ExecuteNonQuery();
                CerrarConexion();

                id = cmd.Parameters["@id"].Value.ToString();

                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Color" + ex.ToString());
            }
            return "";

        }



        public static void EliminarVenta(string id)
        {
            try
            {
                Abrirconexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Delete from Pedido where Cod_Pedido = '" + id + "'";
                cmd.Connection = conexion;

                cmd.ExecuteNonQuery();
                CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Eliminar" + ex.ToString());
            }

        }
        public static void EliminarUsuario(string id)
        {
            try
            {
                Abrirconexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Delete from InicioSesion where Usuario = '" + id + "'";
                cmd.Connection = conexion;

                cmd.ExecuteNonQuery();
                CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Eliminar" + ex.ToString());
            }

        }




        public static void nuevoPedido(string nombre, int rut, string nfb, int transporte, string direccion, int comuna, int provincia, int region, int fechaPlazo, string fechaEntrega, DataGridView telefonos, DataGridView productos, int rutTrabajador, int estado)
        {
            agregarCliente(nombre, rut, nfb);//BIEN
            agregarTelefonosC(rut, telefonos);//BIEN
            agregarPedido(rut, fechaPlazo, fechaEntrega, direccion, comuna, provincia, region, rutTrabajador, transporte, estado);//BIEN
            agregarProducto(productos);//BIEN
            agregarContenido(productos, rut, comuna, provincia, region, fechaPlazo);
            MessageBox.Show("Agregador Correctamente");
        }




        public static void agregarCliente(string nombre, int rut, string nfb)
        {
            Abrirconexion();
            try
            {
                

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "AgregarCliente";
                cmd.Connection = conexion;

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@rut", rut));
                cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                cmd.Parameters.Add(new SqlParameter("@nFacebook", nfb));


                cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cliente" + ex.ToString());
            }
            CerrarConexion();
            
        } //BIEN
        public static void agregarTelefonosC(int rut, DataGridView telefonos)
        {
            Abrirconexion();
            try
            {
                foreach (DataGridViewRow row in telefonos.Rows)
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "AgregarTelefonosC";
                    cmd.Connection = conexion;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Clear();

                    cmd.Parameters.Add(new SqlParameter("@rut", rut));
                    cmd.Parameters.AddWithValue("@idtipo", Convert.ToInt32(row.Cells["id_Tipo"].Value.ToString()));
                    cmd.Parameters.AddWithValue("@numero", Convert.ToInt32(row.Cells["Número_Teléfono"].Value.ToString()));

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Telefonos" + ex.ToString());
            }
            CerrarConexion();
            
        }  //
        public static void agregarPedido(int rut, int fechaPlazo, string FechaEntrega, string direccion, int comuna, int provincia, int region,  int rutTrabajador, int transporte, int estado)
        {
            Abrirconexion();
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "AgregarPedido";
                cmd.Connection = conexion;

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@rut", rut));
                cmd.Parameters.Add(new SqlParameter("@fechaPlazo", fechaPlazo));
                cmd.Parameters.Add(new SqlParameter("@fechaEntrega", FechaEntrega));
                cmd.Parameters.Add(new SqlParameter("@direccion", direccion));
                cmd.Parameters.Add(new SqlParameter("@comuna", comuna));
                cmd.Parameters.Add(new SqlParameter("@provincia", provincia));
                cmd.Parameters.Add(new SqlParameter("@region", region));
                cmd.Parameters.Add(new SqlParameter("@rutTrabajador", rutTrabajador));
                cmd.Parameters.Add(new SqlParameter("@transporte", transporte));
                cmd.Parameters.Add(new SqlParameter("@estado", estado));

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ErrorPedido" + ex.ToString());
            }
            CerrarConexion();
            
        } //
        public static void agregarProducto(DataGridView productos)
        {
            Abrirconexion();
            try
            {
                foreach (DataGridViewRow row in productos.Rows)
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "AgregarProducto";
                    cmd.Connection = conexion;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Clear();

                    cmd.Parameters.AddWithValue("@precio", Convert.ToInt32(row.Cells["precioo"].Value.ToString()));
                    cmd.Parameters.AddWithValue("@color", Convert.ToInt32(row.Cells["ColorID"].Value.ToString()));
                    cmd.Parameters.AddWithValue("@tamaño", Convert.ToInt32(row.Cells["TamañoID"].Value.ToString()));
                    cmd.Parameters.AddWithValue("@marca", Convert.ToInt32(row.Cells["MarcaID"].Value.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@bodega", 1));
                    cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(row.Cells["cantidada"].Value.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@nombre", "P. " + row.Cells["colorr"].Value.ToString() + " " + row.Cells["marcaa"].Value.ToString() + " " + row.Cells["tamañoo"].Value.ToString()));


                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Producto" + ex.ToString());
            }
            CerrarConexion();
        }
        public static void agregarProducto2(int precio, int color, int tamaño, int marca, int stock, string nombre)
        {
            Abrirconexion();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "AgregarProducto";
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Clear();

                cmd.Parameters.Add(new SqlParameter("@precio", precio));
                cmd.Parameters.Add(new SqlParameter("@color", color));
                cmd.Parameters.Add(new SqlParameter("@tamaño", tamaño));
                cmd.Parameters.Add(new SqlParameter("@marca", marca));
                cmd.Parameters.Add(new SqlParameter("@bodega", 1));
                cmd.Parameters.Add(new SqlParameter("@stock", stock));
                cmd.Parameters.Add(new SqlParameter("@nombre", nombre));


                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Producto" + ex.ToString());
            }
            CerrarConexion();
        }
        public static void agregarCompra(int proveedor, int producto, int cantidad, int estado)
        {
            Abrirconexion();
            try
            {
                SqlCommand cmd = new SqlCommand();  
                cmd.CommandText = "AgregarCompra";
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Clear();

                cmd.Parameters.Add(new SqlParameter("@proveedor", proveedor));
                cmd.Parameters.Add(new SqlParameter("@producto", producto));
                cmd.Parameters.Add(new SqlParameter("@cantidad", cantidad));
                cmd.Parameters.Add(new SqlParameter("@estado", estado));


                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Compra" + ex.ToString());
            }
            CerrarConexion();
        }
        public static void agregarContenido(DataGridView productos, int rut, int comuna, int provincia, int region, int fechaPlazo)
        {
            Abrirconexion();
            try
            {
                foreach (DataGridViewRow row in productos.Rows)
                {
                    

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "AgregarContenido";
                    cmd.Connection = conexion;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Clear();

                    cmd.Parameters.AddWithValue("@color", Convert.ToInt32(row.Cells["ColorID"].Value.ToString()));
                    cmd.Parameters.AddWithValue("@tamaño", Convert.ToInt32(row.Cells["TamañoID"].Value.ToString()));
                    cmd.Parameters.AddWithValue("@marca", Convert.ToInt32(row.Cells["MarcaID"].Value.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@rut", rut));
                    cmd.Parameters.Add(new SqlParameter("@comuna", comuna));
                    cmd.Parameters.Add(new SqlParameter("@provincia", provincia));
                    cmd.Parameters.Add(new SqlParameter("@region", region));
                    cmd.Parameters.Add(new SqlParameter("@fechaPlazo", fechaPlazo));



                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Contenido " + ex.ToString());
            }
            CerrarConexion();
        }
        public static void agregarUsuario(string Usuario, string Contraseña, int Tipo)
        {
            Abrirconexion();
            try
            {


                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "NuevoUsuario";
                cmd.Connection = conexion;

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@usuario", Usuario));
                cmd.Parameters.Add(new SqlParameter("@contraseña", Contraseña));
                cmd.Parameters.Add(new SqlParameter("@tipo", Tipo));


                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Usuario" + ex.ToString());
            }
            CerrarConexion();

        } //BIEN





        public static void modificarUsuario(string Usuario, string Contraseña, int Tipo, int id)
        {
            Abrirconexion();
            try
            {


                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "modificarUsuarios";
                cmd.Connection = conexion;

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Usuario", Usuario));
                cmd.Parameters.Add(new SqlParameter("@Contraseña", Contraseña));
                cmd.Parameters.Add(new SqlParameter("@Tipo", Tipo));
                cmd.Parameters.Add(new SqlParameter("@id", id));


                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el Usuario" + ex.ToString());
            }
            CerrarConexion();

        } //BIEN




        public static void updateEntregar(int cod)
        {
            Abrirconexion();
            try
            {


                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "updateVenta";
                cmd.Connection = conexion;

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@cod", cod));


                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la venta" + ex.ToString());
            }
            CerrarConexion();

        } //BIEN
        public static void updateCliente(int rut, string nombre, string nombrefb)
        {
            Abrirconexion();
            try
            {


                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "updateCliente";
                cmd.Connection = conexion;

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@rut", rut));
                cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                cmd.Parameters.Add(new SqlParameter("@nfb", nombrefb));


                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el cliente" + ex.ToString());
            }
            CerrarConexion();

        } //BIEN
        public static void updateCompra(int cod)
        {
            Abrirconexion();
            try
            {


                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "updateCompra";
                cmd.Connection = conexion;

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@cod", cod));


                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la Compra" + ex.ToString());
            }
            CerrarConexion();

        } //BIEN

    }
}
