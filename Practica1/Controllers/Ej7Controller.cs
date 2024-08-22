using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Practica1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej7Controller : ControllerBase
    {
        // GET: api/<Ej7Controller>
        [HttpGet]
        public ActionResult Get(int inicio, int fin)
        {

            if (fin - inicio >= 1000)
            {
                return BadRequest("La diferencia entre inicio y fin debe ser menor a 1000.");
            }

            List<int> numeros = new List<int>();
             for (int i = inicio; i <= fin; i++)
             {
                    numeros.Add(i);
              }
            return Ok(numeros);

        }
    }
}
