using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPIAutomo.Dominio
{
    public class DetalleRev
    {
        
        public int Factura { get; set; }
        public int detalle { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }
        public string producto { get; set; }


        public DetalleRev(int factura, int detalle,  int cantidad, double precio, string producto)
        {
            
            Factura = factura;
            this.detalle = detalle;
            this.cantidad = cantidad;
            this.precio = precio;
            this.producto = producto;
        }

        public DetalleRev()
        {
            this.precio = 0;
            this.detalle = 0;
            this.Factura = 0;
            this.cantidad = 0;
            this.producto = string.Empty;
            
        }
    }
}
