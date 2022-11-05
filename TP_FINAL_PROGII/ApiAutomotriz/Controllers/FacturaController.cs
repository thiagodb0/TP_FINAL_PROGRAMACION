using DataAPIAutomo.Dominio;
using DataAPIAutomo.Fachada;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAutomotriz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        private IDataAPI dataApi; //punto de acceso a la API

        public FacturaController()
        {
            dataApi = new DataApimp();
        }

        [HttpGet("/autos")]

        public IActionResult GetAutos()
        {
            List<Producto> lst = null;
            try
            {
                lst = dataApi.GetAutos();
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/clientes")]

        public IActionResult GetClientes()
        {
            List<Cliente> lst = null;
            try
            {
                lst = dataApi.GetClientes();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente Luego");
            }
        }

        [HttpGet("/vendedores")]
        public IActionResult GetVendedores()
        {
            List<Vendedor> lst = null;
            try
            {
                lst = dataApi.GetVendedor();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente Luego");
            }
        }


        [HttpGet("/formas_pago")]

        public IActionResult GetFormasPago()
        {
            List<FormaPago> lst = null;
            try
            {
                lst = dataApi.GetFormaPagos();
                return Ok(lst);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente Luego");

            }
        }

        [HttpGet("/marcas")]

        public IActionResult GetMarcas()
        {
            List<Marca> lst = null;
            try
            {
                lst = dataApi.GetMarcas();
                return Ok(lst);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente Luego");

            }
        }


        [HttpGet("/modelos")]

        public IActionResult GetModelos()
        {
            List<Modelo> lst = null;
            try
            {
                lst = dataApi.GetModelos();
                return Ok(lst);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente Luego");

            }
        }




        [HttpPost("/factura")]
        public IActionResult PostFactura(Factura oFactura)
        {
            try
            {
                if (oFactura == null)
                {
                    return BadRequest("Datos de la factura incorrectos!");
                }

                return Ok(dataApi.SaveFactura(oFactura));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
    }
}
