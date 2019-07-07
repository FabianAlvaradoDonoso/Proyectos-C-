using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Vidacero.Clases
{
    class ConexionBDD
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;

        public ConexionBDD()
        {
            try
            {
                cnn = new SqlConnection("Data Source=.;Initial Catalog=Vidacero;Integrated Security=True");
                cnn.Open();
                cnn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se conecto" + ex.ToString());

            }
            finally
            {
                cnn.Close();
            }
        }

        public void llenarCbBodega(ComboBox cb)
        {
            try
            {
                cnn.Open();
                cmd = new SqlCommand("select Nombre from Bodega", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["Nombre"].ToString());
                }
                dr.Close();
            }
            catch
            {
                MessageBox.Show("No se pudo llenar la tabla");
            }
            finally
            {
                cnn.Close();
            }
        }
        public void llenarCbRegion(ComboBox cb)
        {
            try
            {
                cnn.Open();
                cmd = new SqlCommand("select Region from Region", cnn);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    cb.Items.Add(dr["Region"].ToString());
                }
                dr.Close();
            }
            catch
            {
                MessageBox.Show("No se pudo llenar la tabla");
            }
            finally
            {
                cnn.Close();
            }
        }
        public void llenarCbComuna(ComboBox cb, string ciudad)
        {
            try
            {
                cnn.Open();
                cmd = new SqlCommand("select C.Comuna from Comuna C, Provincia D where D.Provincia = '"+ciudad+"' and D.id_Provincia = C.cod_Provincia", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["Comuna"].ToString());
                }
                dr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
            finally
            {
                cnn.Close();
            }
        }
        public void llenarCbCiudad(ComboBox cb, string region)
        {
            try
            {
                cnn.Open(); 
                cmd = new SqlCommand("select C.Provincia from Provincia C, Region R where R.id_Region = C.cod_Region and R.Region = '" + region + "'", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["Provincia"].ToString());
                }
                dr.Close();
            }
            catch
            {
                MessageBox.Show("No se pudo llenar la tabla");
            }
            finally
            {
                cnn.Close();
            }
        }
        public void llenarCbTamaño(ComboBox cb)
        {
            try
            {
                cnn.Open();
                cmd = new SqlCommand("select Tamaño from Tamaño", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["Tamaño"].ToString());
                }
                dr.Close();
            }
            catch
            {
                MessageBox.Show("No se pudo llenar la tabla");
            }
            finally
            {
                cnn.Close();
            }
        }
        public void llenarCbColor(ComboBox cb)
        {
            try
            {
                cnn.Open();
                cmd = new SqlCommand("select Color from Color", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["Color"].ToString());
                }
                dr.Close();
            }
            catch
            {
                MessageBox.Show("No se pudo llenar la tabla");
            }
            finally
            {
                cnn.Close();
            }
        }
        public void llenarCbMarca(ComboBox cb)
        {
            try
            {
                cnn.Open();
                cmd = new SqlCommand("select Marca from Marca", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["Marca"].ToString());
                }
                dr.Close();
            }
            catch
            {
                MessageBox.Show("No se pudo llenar la tabla");
            }
            finally
            {
                cnn.Close();
            }
        }
        public void llenarCbTransporte(ComboBox cb)
        {
            try
            {
                cnn.Open();
                cmd = new SqlCommand("select Transporte from Tipo_Transporte", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["Transporte"].ToString());
                }
                dr.Close();
            }
            catch
            {
                MessageBox.Show("No se pudo llenar la tabla");
            }
            finally
            {
                cnn.Close();
            }
        }
        public void llenarCbProvincia(ComboBox cb)
        {
            try
            {
                cnn.Open();
                cmd = new SqlCommand("select Provincia from Provincia", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["Provincia"].ToString());
                }
                dr.Close();
            }
            catch
            {
                MessageBox.Show("No se pudo llenar la tabla");
            }
            finally
            {
                cnn.Close();
            }
        }
        public void llenarCbComuna2(ComboBox cb)
        {
            try
            {
                cnn.Open();
                cmd = new SqlCommand("select Comuna from Comuna", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["Comuna"].ToString());
                }
                dr.Close();
            }
            catch
            {
                MessageBox.Show("No se pudo llenar la tabla");
            }
            finally
            {
                cnn.Close();
            }
        }
        public void llenarCbProveedor(ComboBox cb)
        {
            try
            {
                cnn.Open();
                cmd = new SqlCommand("select Nombre from Proveedor", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["Nombre"].ToString());
                }
                dr.Close();
            }
            catch
            {
                MessageBox.Show("No se pudo llenar la tabla");
            }
            finally
            {
                cnn.Close();
            }
        }




        public void cargarVentas(DataGridView dgv)
        {
            try
            {
                cnn.Open();
                da = new SqlDataAdapter(" select p.Cod_Pedido as 'Cod Pedido', c.Nombre as 'Cliente', c.Rut_Cliente as 'Rut Cliente', p.Fecha_Pedido as 'Fecha Entrega', p.Direccion, cma.Comuna, prv.Provincia, rgn.Region, trans.Transporte from Pedido p inner join Cliente c on (p.Rut = c.Rut_Cliente) inner join Comuna cma on (p.id_Comuna = cma.id_Comuna) inner join Provincia prv on (p.id_Provincia = prv.id_Provincia) inner join Region rgn on (p.id_Region = rgn.id_Region) inner join Tipo_Transporte trans on (p.id_Transporte = trans.id_Transporte) where p.Estado = 0", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
            finally
            {
                cnn.Close();
            }

        }
        //public void cargarVentasTrabajador(DataGridView dgv, string nombre)
        //{
        //    try
        //    {
        //        cnn.Open();
        //        da = new SqlDataAdapter("Select * from Pedido where Rut_Trabajador like('%" + nombre + "%') and Estado = 0 ", cnn);
        //        dt = new DataTable();
        //        da.Fill(dt);
        //        dgv.DataSource = dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
        //    }
        //    finally
        //    {
        //        cnn.Close();
        //    }
            
        //}
        public void cargarVentasCliente(DataGridView dgv, string nombre)
        {
            try
            {
                cnn.Open();
                da = new SqlDataAdapter(" select p.Cod_Pedido as 'Cod Pedido', c.Nombre as 'Cliente', c.Rut_Cliente as 'Rut Cliente', p.Fecha_Pedido as 'Fecha Entrega', p.Direccion, cma.Comuna, prv.Provincia, rgn.Region, trans.Transporte from Pedido p inner join Cliente c on (p.Rut = c.Rut_Cliente) inner join Comuna cma on (p.id_Comuna = cma.id_Comuna) inner join Provincia prv on (p.id_Provincia = prv.id_Provincia) inner join Region rgn on (p.id_Region = rgn.id_Region) inner join Tipo_Transporte trans on (p.id_Transporte = trans.id_Transporte) where p.Estado = 0 and p.Rut like ('%"+nombre+"%')", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
            finally
            {
                cnn.Close();
            }

        }
        public void cargarVentasPedido(DataGridView dgv, string nombre)
        {
            try
            {
                cnn.Open();
                da = new SqlDataAdapter("Select * from Pedido where Cod_Pedido like('%" + nombre + "%') and Estado = 0", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
            finally
            {
                cnn.Close();
            }

        }
        public void cargarVentasComuna(DataGridView dgv, string id)
        {
            try
            {
                cnn.Open();
                da = new SqlDataAdapter("Select * from Pedido where id_Comuna = '" + id + "' and Estado = 0", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
            finally
            {
                cnn.Close();
            }

        }
        public void cargarVentasProvincia(DataGridView dgv, string id)
        {
            try
            {
                cnn.Open();
                da = new SqlDataAdapter("Select * from Pedido where id_Provincia = '" + id + "' and Estado = 0", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
            finally
            {
                cnn.Close();
            }

        }
        public void cargarVentasRegion(DataGridView dgv, string id)
        {
            try
            {
                cnn.Open();
                da = new SqlDataAdapter("Select * from Pedido where id_Region = '" + id + "' and Estado = 0", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
            finally
            {
                cnn.Close();
            }

        }




        public void cargarVentas2(DataGridView dgv)
        {
            try
            {
                cnn.Open();
                da = new SqlDataAdapter("Select * from Pedido where Estado = 1", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
            finally
            {
                cnn.Close();
            }

        }
        public void cargarVentasTrabajador2(DataGridView dgv, string nombre)
        {
            try
            {
                cnn.Open();
                da = new SqlDataAdapter("Select * from Pedido where Rut_Trabajador like('%" + nombre + "%') and Estado = 1 ", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
            finally
            {
                cnn.Close();
            }

        }
        public void cargarVentasCliente2(DataGridView dgv, string nombre)
        {
            try
            {
                cnn.Open();
                da = new SqlDataAdapter("Select * from Pedido where Rut like('%" + nombre + "%') and Estado = 1", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
            finally
            {
                cnn.Close();
            }

        }
        public void cargarVentasPedido2(DataGridView dgv, string nombre)
        {
            try
            {
                cnn.Open();
                da = new SqlDataAdapter("Select * from Pedido where Cod_Pedido like('%" + nombre + "%') and Estado = 1", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
            finally
            {
                cnn.Close();
            }

        }
        public void cargarVentasComuna2(DataGridView dgv, string id)
        {
            try
            {
                cnn.Open();
                da = new SqlDataAdapter("Select * from Pedido where id_Comuna = '" + id + "' and Estado = 1", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
            finally
            {
                cnn.Close();
            }

        }
        public void cargarVentasProvincia2(DataGridView dgv, string id)
        {
            try
            {
                cnn.Open();
                da = new SqlDataAdapter("Select * from Pedido where id_Provincia = '" + id + "' and Estado = 1", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
            finally
            {
                cnn.Close();
            }

        }
        public void cargarVentasRegion2(DataGridView dgv, string id)
        {
            try
            {
                cnn.Open();
                da = new SqlDataAdapter("Select * from Pedido where id_Region = '" + id + "' and Estado = 1", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
            finally
            {
                cnn.Close();
            }

        }



        public void cargarStockCod(DataGridView dgv, string nombre)
        {
            try
            {
                cnn.Open();
                da = new SqlDataAdapter("Select * from Producto where Cod_Producto like('%" + nombre + "%')", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
            finally
            {
                cnn.Close();
            }

        }
        public void cargarStockNombre(DataGridView dgv, string nombre)
        {
            try
            {
                cnn.Open();
                da = new SqlDataAdapter("Select * from Producto where Nombre like('%" + nombre + "%')", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
            finally
            {
                cnn.Close();
            }

        }
        public void cargarStockColor(DataGridView dgv, string nombre)
        {
            try
            {
                cnn.Open();
                da = new SqlDataAdapter("Select * from Producto where cod_color like('%" + nombre + "%')", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
            finally
            {
                cnn.Close();
            }

        }
        public void cargarStockTamaño(DataGridView dgv, string nombre)
        {
            try
            {
                cnn.Open();
                da = new SqlDataAdapter("Select * from Producto where cod_Tamaño like('%" + nombre + "%')", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
            finally
            {
                cnn.Close();
            }

        }
        public void cargarStockMarca(DataGridView dgv, string nombre)
        {
            try
            {
                cnn.Open();
                da = new SqlDataAdapter("Select * from Producto where cod_Marca like('%" + nombre + "%')", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
            finally
            {
                cnn.Close();
            }

        }
        public void cargarStockBodega(DataGridView dgv, string nombre)
        {
            try
            {
                cnn.Open();
                da = new SqlDataAdapter("Select * from Producto where cod_Bodega like('%" + nombre + "%')", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
            finally
            {
                cnn.Close();
            }

        }



        public void cargarCompras(DataGridView dgv)
        {
            try
            {
                cnn.Open();
                da = new SqlDataAdapter("select c.Cod_Compra as 'Cod Compra', p.Nombre as 'Proveedor', pdt.Nombre as 'Nombre Producto', c.Cantidad as 'Stock', c.Estado from Compra c inner join Proveedor p on (c.Cod_Proveedor = p.Cod_Proveedor) inner join Producto pdt on (c.Cod_Producto = pdt.Cod_Producto) where Estado = 0", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
            finally
            {
                cnn.Close();
            }

        }



        public void cargarStock(DataGridView dgv)
        {
            try
            {
                cnn.Open();
                da = new SqlDataAdapter("Select * from Producto ", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
            finally
            {
                cnn.Close();
            }

        }



        public void cargarInicioSesion(DataGridView dgv)
        {
            try
            {
                cnn.Open();
                da = new SqlDataAdapter("Select * from InicioSesion ", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
            finally
            {
                cnn.Close();
            }

        }



        public void cargarClientes(DataGridView dgv)
        {
            try
            {
                cnn.Open();
                da = new SqlDataAdapter("Select * from Cliente ", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
            finally
            {
                cnn.Close();
            }

        }


    }   
}
