using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ENTITY;
using BLL;

namespace APP_API77.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {

        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] CLIENTE cliente)
        {

            List<string> lstValidaciones = BLL_CLIENTE.ValidacionDatos(cliente);

            if (lstValidaciones.Count == 0)
            {
                List<string> lstDatos = BLL_CLIENTE.GuardarDatos(, cliente);

                return Ok("");
            }
            else
            {
                return Ok(lstValidaciones);
            }

           

        }

    }
}
