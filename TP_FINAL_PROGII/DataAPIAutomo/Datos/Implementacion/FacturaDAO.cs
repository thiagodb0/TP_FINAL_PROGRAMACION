using DataAPIAutomo.Datos.Interfaces;
using DataAPIAutomo.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
