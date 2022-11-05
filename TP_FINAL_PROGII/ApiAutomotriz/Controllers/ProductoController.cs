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

    }
}
