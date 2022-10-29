using DataAPIAutomo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPIAutomo.Fachada
{
     public interface IDataAPI
    {
        public List<Producto> GetAutos();
        public bool SavePresupuesto(Factura factura);
    }
}
