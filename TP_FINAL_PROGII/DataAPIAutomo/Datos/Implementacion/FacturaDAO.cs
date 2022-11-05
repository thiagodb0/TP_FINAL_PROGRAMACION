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

            foreach(DataRow dr in t.Rows)
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
            DataTable t =HelperDB.ObtenerInstancia().ConsultaSQL(sp, null);

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
                string nombre = dr["descripcion"].ToString() ;
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
    }
}
