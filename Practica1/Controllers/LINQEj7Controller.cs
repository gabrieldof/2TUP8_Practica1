using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Practica1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LINQEj7Controller : ControllerBase
    {
        // GET: api/<LINQEj7Controller>
        [HttpGet]
        public ActionResult Get([FromQuery] string frase)
        {
            var palabras = frase.Split(' ');
            var palabrasMayus = palabras.Where(pal => string.Equals(pal, pal.ToUpper(), StringComparison.Ordinal));

            return Ok(palabrasMayus);
        }


    }
}
