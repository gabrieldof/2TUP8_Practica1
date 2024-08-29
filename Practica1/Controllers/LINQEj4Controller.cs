using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Practica1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LINQEj4Controller : ControllerBase
    {
        // GET: api/<LINQEj4Controller>
        [HttpGet]

        public ActionResult Get([FromQuery] List<int> numeros)
        {
            var numerosOrdenados = numeros.OrderByDescending(x => x).Take(5);
            return Ok(numerosOrdenados);
        }

    }
}
