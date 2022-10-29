using DataAPIAutomo.Datos.Implementacion;
using DataAPIAutomo.Datos.Interfaces;
using DataAPIAutomo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPIAutomo.Fachada
{
    public class DataApimp : IDataAPI
    {
        private IFacturaDAO dao;

        public DataApimp()
        {
            dao = new FacturaDAO();
        }

        public List<Producto> GetAutos()
        {
            return dao.GetAutos();
        }

        public bool SavePresupuesto(Factura factura)
        {
            throw new NotImplementedException();
        }
    }
}
