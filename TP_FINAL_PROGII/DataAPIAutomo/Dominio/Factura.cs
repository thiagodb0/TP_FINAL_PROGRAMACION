using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPIAutomo.Dominio
{
    public class Factura
    {
        public int CodFactura { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public FormaPago Forma_Pago { get; set; }
        public Vendedor Vendedor { get; set; }
        public List<Detalle> detalles { get; set; }

        public Factura()
        {
            detalles = new List<Detalle>();
        }

        public void AddDetalle(Detalle d)
        {
            detalles.Add(d);
        }

        public void QuitarDetalle(int posicion)
        {
            detalles.RemoveAt(posicion);
        }

        public double CalcularTotal()
        {
            double total = 0;
            foreach(Detalle d in detalles)
            {
                total += d.CalcularSubt();
            }
            return total;
        }
    }
}
