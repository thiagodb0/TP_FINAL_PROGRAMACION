using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPIAutomo.Dominio
{
    public class Producto
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Tipo_prod { get; set; }
        public int Stock { get; set; }
        public int StockMin { get; set; }
        public int Modelo { get; set; }
        public int Marca { get; set; }

        public Producto(int codigo, string descripcion, double precio, int tipo_prod, int stock, int stockMin, int modelo, int marca)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Precio = precio;
            Tipo_prod = tipo_prod;
            Stock = stock;
            StockMin = stockMin;
            Modelo = modelo;
            Marca = marca;
        }
    }
}
