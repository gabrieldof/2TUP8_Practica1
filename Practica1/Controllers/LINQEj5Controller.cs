using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Practica1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LINQEj5Controller : ControllerBase
    {
        // GET: api/<LINQEj5Controller>
        [HttpGet]

        public ActionResult Get([FromQuery] List<int> numeros)
        {
            var numerosCuadrado = numeros
                        .Select(num => new { Numero = num, Cuadrado = num * num })
                        .Where(x => x.Cuadrado > 20)
                        .Select(x => $"{x.Numero} - {x.Cuadrado}");

            return Ok(numerosCuadrado);
        }


    }
}
