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

        public List<Cliente> GetClientes()
        {
            return dao.GetClientes();
        }

        public List<Vendedor> GetVendedor() { return dao.GetVendedores(); }

        public List<FormaPago> GetFormaPagos() { return dao.GetFormaPagos(); }

        public bool SaveFactura(Factura oFactura)
        {
            return dao.Crear(oFactura);
        }

        public List<Marca> GetMarcas()
        {
            return dao.GetMarcas();
        }

        public List<Modelo> GetModelos()
        {
            return dao.GetModelo();
        }

        public bool SaveProducto(Producto product)
        {
            return dao.CrearProducto(product);
        }

        public int ProxFact()
        {
            return dao.ProxFact();
        }

        public bool BajaFactura(NroParam nro)
        {
            return dao.BajaFactura(nro);
        }

        public List<Factura> GetFacturas()
        {
            return dao.GetFacturas();
        }

        public List<ClienteReport> GetClientesReport(string nombre)
        {
            return dao.GetClienteReports(nombre);
        }

        public List<Usuario> GetUsuarios()
            {
            return dao.GetUsuarios();
            }

        public bool AlterProducto(Producto product)
        {
            return dao.AlterProducto(product);
        }
    }
}
