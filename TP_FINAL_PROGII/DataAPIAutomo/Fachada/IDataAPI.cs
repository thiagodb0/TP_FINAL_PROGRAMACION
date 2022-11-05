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
        public List<Cliente> GetClientes();

        public List<Vendedor> GetVendedor();

        public List<FormaPago> GetFormaPagos();

        public bool SaveFactura(Factura oFactura);
    }
}
