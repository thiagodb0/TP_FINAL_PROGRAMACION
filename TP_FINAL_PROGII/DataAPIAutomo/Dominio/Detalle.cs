using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPIAutomo.Dominio
{
    public class Detalle
    {
        public int CodDetalle { get; set; }
        public int CodFactura { get; set; }
        public Producto producto { get; set; }
        public int Cantidad { get; set; }
        public double PrecioVent { get; set; }


        //Metodos
        public double CalcularSubt()
        {
            return Cantidad * PrecioVent;
        }
    }
}
