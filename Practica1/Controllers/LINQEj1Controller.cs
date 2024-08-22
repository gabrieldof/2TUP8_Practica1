using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Practica1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LINQEj1Controller : ControllerBase
    {
        // GET: api/<LINQEj1Controller>
        [HttpGet]
        public ActionResult GetNumbers()
        {
            List<int> numeros = [15, 25, 40, 50, 60, 101, 102];
            var resultado = numeros.Where(x => x > 30 && x < 100).Select(x => x);
            return Ok(resultado);
        }
  


    }
}
