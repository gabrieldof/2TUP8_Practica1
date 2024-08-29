using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Practica1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LINQEj2Controller : ControllerBase
    {
        // GET: api/<LINQEj2Controller>
        [HttpGet]
        public ActionResult Get([FromQuery]List <string> palabras) 
        {
            var palabrasFiltradas = palabras
                                        .Where(p => p.Length >= 5)
                                        .Select(p => p.ToUpper());
            

            return Ok(palabrasFiltradas);
        }

      
    }
}
