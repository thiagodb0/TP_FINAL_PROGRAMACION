using DataAPIAutomo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPIAutomo.Datos.Interfaces
{
    public interface IFacturaDAO
    {
       public List<Producto> GetAutos();

        public List<Cliente> GetClientes();

        public List<Vendedor> GetVendedores();

        public List<FormaPago> GetFormaPagos();

        public List<Marca> GetMarcas();

        public List<Modelo> GetModelo();

        public bool Crear(Factura oFactura);

        public bool CrearProducto(Producto producto);
    }
}
