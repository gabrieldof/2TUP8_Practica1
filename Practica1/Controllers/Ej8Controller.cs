using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Practica1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej8Controller : ControllerBase
    {
        // GET: api/<Ej8Controller>
        [HttpGet]
        public ActionResult Get(int inicio, int fin)
        {
            if (fin - inicio < 1000)
            {
                return BadRequest("La diferencia entre inicio y fin debe ser menor a 1000.");
            }

            List<int> numeros = new List<int>();
            int i = inicio;
            while (i <= fin)
            {
                numeros.Add(i);
                i++;
            }


            return Ok(numeros);
        }
    }
}
