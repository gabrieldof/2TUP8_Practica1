using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Practica1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LINQEj6Controller : ControllerBase
    {
        // GET: api/<LINQEj6Controller>
        [HttpGet]
        public ActionResult Get([FromQuery] List<string> palabras)
        {
            var nuevasPalabras = palabras.Select(pal => pal.Replace("ia", "*")).ToList();
            return Ok(nuevasPalabras);
        }


    }
}
