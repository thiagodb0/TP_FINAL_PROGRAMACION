using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPIAutomo.Dominio
{
    public class Detalle
    {
        
        public Producto producto { get; set; }
        public int Cantidad { get; set; }
        public double PrecioVent { get; set; }

        public Detalle (Producto producto, int cantidad, double precioVent)
        {
            this.producto = producto;
            Cantidad = cantidad;
            PrecioVent = precioVent;
        }




        //Metodos
        public double CalcularSubt()
        {
            return Cantidad * PrecioVent;
        }
    }
}
