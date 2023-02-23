using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPIAutomo.Dominio
{
    public class FacturaRev
    {
        int nro { get; set; }
        string producto { get; set; }
        int cantidad { get; set; }
        double precio { get; set; }

        public FacturaRev(int nro, string producto, int cantidad, double precio)
        {
            this.nro = nro;
            this.producto = producto;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public FacturaRev()
        {
            this.precio = 0;
            this.nro = 0;
            this.cantidad = 0;
            this.producto = string.Empty;
        }
    }
}
