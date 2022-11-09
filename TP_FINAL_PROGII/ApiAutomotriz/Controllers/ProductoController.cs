using DataAPIAutomo.Dominio;
using DataAPIAutomo.Fachada;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAutomotriz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {

        private IDataAPI dataApi;
        public ProductoController()
        {
            dataApi = new DataApimp();
        }


        [HttpPost("/crearProducto")]
        
        public IActionResult PostProducto(Producto product)
        {
            try
            {
                if (product == null)
                {
                    return BadRequest("Datos de Producto incorrectos!");
                }

                return Ok(dataApi.SaveProducto(product));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }


        [HttpPost("/AlterProducto")]

        public IActionResult AlterProducto(Producto product)
        {
            try
            {
                if (product == null)
                {
                    return BadRequest("Datos de Producto incorrectos!");
                }

                return Ok(dataApi.AlterProducto(product));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        [HttpPost("/bajaProd")]

        public IActionResult PutFactura(NroParam nro)
        {
            try
            {
                if (nro == null)
                {
                    return BadRequest("Datos del Producto incorrectos!");
                }

                return Ok(dataApi.BajaFactura(nro));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

    }
}
