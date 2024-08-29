using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Practica1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LINQEj3Controller : ControllerBase
    {
        // GET: api/<LINQEj3Controller>
        [HttpGet]
        public ActionResult Get([FromQuery] List<string> palabras)
        {
            var palabrasFiltradas = palabras.Where(x => x.StartsWith('b') && x.EndsWith('r'));
            return Ok(palabrasFiltradas);
        }
    }
}
