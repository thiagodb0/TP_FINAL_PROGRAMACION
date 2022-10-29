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

        [HttpGet("/productos")]

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

    }
}
