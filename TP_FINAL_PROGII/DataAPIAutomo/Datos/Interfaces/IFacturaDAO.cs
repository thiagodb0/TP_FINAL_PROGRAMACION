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

        public int ProxFact();

        public bool BajaFactura(NroParam nro);

        public List<Factura> GetFacturas();
        public List<ClienteReport> GetClienteReports(string nombre);

        public List<Usuario> GetUsuarios();

        public List<TipoDoc> GetTiposDoc();








        public bool AlterProducto(Producto p);
       
    }
}
