using DataAPIAutomo.Datos.Interfaces;
using DataAPIAutomo.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPIAutomo.Datos.Implementacion
{
    public class FacturaDAO : IFacturaDAO
    {
        public List<Producto> GetAutos()
        {

            {
                List<Producto> lst = new List<Producto>();

                string sp = "SP_CONSULTAR_AUTOS";
                DataTable t = HelperDB.ObtenerInstancia().ConsultaSQL(sp, null);

                foreach (DataRow dr in t.Rows)
                {
                    //Mapear un registro a un objeto del modelo de dominio
                    int codigo = int.Parse(dr["cod_producto"].ToString());
                    string desc = dr["descripcion"].ToString();
                    double precio = Convert.ToDouble(dr["pre_unitario"].ToString());
                    int tipo = Convert.ToInt32(dr["cod_tipo_prod"].ToString());
                    int stock = Convert.ToInt32(dr["stock"].ToString());
                    int stockMin = Convert.ToInt32(dr["Stock_min"].ToString());
                    int modelo = Convert.ToInt32(dr["cod_modelo"].ToString());
                    int marca = Convert.ToInt32(dr["cod_marca"].ToString());

                    Producto p = new Producto(codigo, desc, precio, tipo, stock, stockMin, modelo, marca);
                    lst.Add(p);

                }

                return lst;
            }
        }

        public List<Cliente> GetClientes()
        {
            List<Cliente> lst = new List<Cliente>();
            string sp = "PA_CONS_CLIENTES";
            DataTable t = HelperDB.ObtenerInstancia().ConsultaSQL(sp, null);

            foreach (DataRow dr in t.Rows)
            {
                int cod = Convert.ToInt32(dr["cod_cliente"].ToString());
                string nombre = dr["nom_cliente"].ToString();

                Cliente c = new Cliente(cod, nombre);
                lst.Add(c);
            }
            return lst;
        }

        public List<Vendedor> GetVendedores()
        {
            List<Vendedor> lst = new List<Vendedor>();
            string sp = "PA_CONS_VENDEDORES";
            DataTable t = HelperDB.ObtenerInstancia().ConsultaSQL(sp, null);

            foreach (DataRow dr in t.Rows)
            {
                int cod = Convert.ToInt32(dr["cod_vendedor"].ToString());
                string nombre = dr["nom_vendedor"].ToString();

                Vendedor c = new Vendedor(cod, nombre);
                lst.Add(c);
            }

            return lst;
        }


        public List<FormaPago> GetFormaPagos()
        {
            List<FormaPago> lst = new List<FormaPago>();
            string sp = "PA_CONS_FORMA";
            DataTable t = HelperDB.ObtenerInstancia().ConsultaSQL(sp, null);

            foreach (DataRow dr in t.Rows)
            {
                int cod = Convert.ToInt32(dr["cod_forma_pago"].ToString());
                string nombre = dr["descripcion"].ToString();
                FormaPago c = new FormaPago(cod, nombre);
                lst.Add(c);


            }
            return lst;
        }


        public bool Crear(Factura oFactura)
        {
            bool ok = true;
            SqlConnection cnn = HelperDB.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            SqlCommand cmd = new SqlCommand();
            try
            {

                cnn.Open();
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.Transaction = t;
                cmd.CommandText = "PA_INSERT_MAESTRO";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cod_cliente", oFactura.Cliente.Id);
                cmd.Parameters.AddWithValue("@forma_pago", oFactura.Forma_Pago.Id);
                cmd.Parameters.AddWithValue("@vendedor", oFactura.Vendedor.Id);


                //parámetro de salida:
                SqlParameter pOut = new SqlParameter();
                pOut.ParameterName = "@nro_fact";
                pOut.DbType = DbType.Int32;
                pOut.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pOut);
                cmd.ExecuteNonQuery();

                int nroFactura = (int)pOut.Value;

                SqlCommand cmdDetalle;

                foreach (Detalle item in oFactura.detalles)
                {
                    cmdDetalle = new SqlCommand("PA_INSERT_DETALLE", cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@nro_fact", nroFactura);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", item.Cantidad);
                    cmdDetalle.Parameters.AddWithValue("@precio", item.producto.Precio);
                    cmdDetalle.Parameters.AddWithValue("@producto", item.producto.Codigo);
                    cmdDetalle.ExecuteNonQuery();


                }
                t.Commit();
            }

            catch (Exception)
            {
                if (t != null)
                    t.Rollback();
                ok = false;
            }

            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return ok;
        }

        public List<Marca> GetMarcas()
        {
            List<Marca> lst = new List<Marca>();
            string sp = "PA_CONS_MARCA";
            DataTable t = HelperDB.ObtenerInstancia().ConsultaSQL(sp, null);

            foreach (DataRow dr in t.Rows)
            {
                int cod = Convert.ToInt32(dr["cod_marca"].ToString());
                string nombre = dr["marca"].ToString();
                Marca c = new Marca(cod, nombre);
                lst.Add(c);


            }
            return lst;
        }

        public List<Modelo> GetModelo()
        {
            List<Modelo> lst = new List<Modelo>();
            string sp = "PA_CONS_MODELOS";
            DataTable t = HelperDB.ObtenerInstancia().ConsultaSQL(sp, null);

            foreach (DataRow dr in t.Rows)
            {
                int cod = Convert.ToInt32(dr["cod_modelo"].ToString());
                string nombre = dr["modelo"].ToString();
                Modelo c = new Modelo(cod, nombre);
                lst.Add(c);


            }
            return lst;
        }


        public bool CrearProducto(Producto producto)
        {
            bool ok = true;
            SqlConnection cnn = HelperDB.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            SqlCommand cmd = new SqlCommand();
            try
            {

                cnn.Open();
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.Transaction = t;
                cmd.CommandText = "PA_INSERT_PRODUCTO";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cod", producto.Codigo);
                cmd.Parameters.AddWithValue("@desc", producto.Descripcion);
                cmd.Parameters.AddWithValue("@precio", producto.Precio);
                cmd.Parameters.AddWithValue("@cod_tipo", producto.Tipo_prod);
                cmd.Parameters.AddWithValue("@stock", producto.Stock);
                cmd.Parameters.AddWithValue("@stockmin", producto.StockMin);
                cmd.Parameters.AddWithValue("@model", producto.modelo);
                cmd.Parameters.AddWithValue("@cod_marca", producto.Marca);
                cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (Exception)
            {
                if (t != null)
                    t.Rollback();
                ok = false;
            }

            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return ok;
        }

        public int ProxFact()
        {
            string sp = "PA_PROX_FACT";
            return HelperDB.ObtenerInstancia().ConsultaEscalarSQL(sp, "@next");
        }

        public bool BajaFactura(NroParam nro)
        {
            bool ok = true;
            SqlConnection cnn = HelperDB.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            SqlCommand cmd = new SqlCommand();
            try
            {

                cnn.Open();
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.Transaction = t;
                cmd.CommandText = "PA_BAJA_FACT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nro", nro.nro);

                cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (Exception)
            {
                if (t != null)
                    t.Rollback();
                ok = false;
            }

            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return ok;
        }

        public List<Factura> GetFacturas()
        {
            List<Factura> lst = new List<Factura>();
            string sp = "PA_CONS_FACTURAS";
            DataTable t = HelperDB.ObtenerInstancia().ConsultaSQL(sp, null);

            foreach (DataRow dr in t.Rows)
            {
                int cod = Convert.ToInt32(dr["cod_factura"].ToString());
                DateTime fecha = Convert.ToDateTime((dr["fecha"]).ToString());
                int codCli = Convert.ToInt32((dr["cod_cliente"]).ToString());
                string cliente = dr["Cliente"].ToString();
                int codVend = Convert.ToInt32((dr["cod_vendedor"]).ToString());
                string Vendedor = dr["Vendedor"].ToString();
                int codFp = Convert.ToInt32((dr["cod_forma_pago"]).ToString());
                string forma = dr["descripcion"].ToString();
                Cliente c = new Cliente(codCli, cliente);
                Vendedor v = new Vendedor(codVend, Vendedor);
                FormaPago fp = new FormaPago(codFp, forma);
                Factura f = new Factura(cod, fecha, c, fp, v);


                lst.Add(f);


            }
            return lst;
        }

        public List<ClienteReport> GetClienteReports(string nombre)
        {
            List<ClienteReport> lst = new List<ClienteReport>();
            string sp = "ClientesPromedio";
            SqlConnection cnn = HelperDB.ObtenerInstancia().ObtenerConexion();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sp,cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", nombre);
            DataTable t = new DataTable();
            t.Load(cmd.ExecuteReader());


            foreach (DataRow dr in t.Rows)
            {
                int cod = Convert.ToInt32(dr["Codigo"].ToString());
                string cliente = dr["Cliente"].ToString();
                double total = Convert.ToDouble(dr["Total"].ToString());
                double Promedio = Convert.ToDouble(dr["Promedio"].ToString());
                string primera = dr["Primera"].ToString();
                Cliente c = new Cliente(cod, cliente);
                ClienteReport cr = new ClienteReport(c, total, Promedio, primera);  



                lst.Add(cr);


            }
            cnn.Close();
            return lst;
        }

        public List<Usuario> GetUsuarios()
        {
            List<Usuario> lst = new List<Usuario>();
            string sp = "PA_CONS_USUARIOS";
            DataTable t = HelperDB.ObtenerInstancia().ConsultaSQL(sp, null);

            foreach (DataRow dr in t.Rows)
            {
                string usuario = (dr["usuario"].ToString());
                string clave = dr["contraseña"].ToString();
                Usuario u = new Usuario(usuario, clave);
                lst.Add(u);


            }
            return lst;
        }


        public bool AlterProducto(Producto producto)
        {
            bool ok = true;
            SqlConnection cnn = HelperDB.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            SqlCommand cmd = new SqlCommand();
            try
            {

                cnn.Open();
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.Transaction = t;
                cmd.CommandText = "PA_UPD_PROD";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cod", producto.Codigo);
                cmd.Parameters.AddWithValue("@desc", producto.Descripcion);
                cmd.Parameters.AddWithValue("@precio", producto.Precio);
                cmd.Parameters.AddWithValue("@cod_tipo", producto.Tipo_prod);
                cmd.Parameters.AddWithValue("@stock", producto.Stock);
                cmd.Parameters.AddWithValue("@stockmin", producto.StockMin);
                cmd.Parameters.AddWithValue("@model", producto.modelo);
                cmd.Parameters.AddWithValue("@cod_marca", producto.Marca);
                cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (Exception)
            {
                if (t != null)
                    t.Rollback();
                ok = false;
            }

            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return ok;
        }


        public bool BajaProducto(NroParam nro)
        {
            bool ok = true;
            SqlConnection cnn = HelperDB.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            SqlCommand cmd = new SqlCommand();
            try
            {

                cnn.Open();
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.Transaction = t;
                cmd.CommandText = "PA_BAJA_PROD";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nro", nro.nro);

                cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (Exception)
            {
                if (t != null)
                    t.Rollback();
                ok = false;
            }

            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return ok;
        }
    }
}

