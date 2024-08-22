using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Practica1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej10Controller : ControllerBase
    {
        // GET: api/<Ej10Controller>
        [HttpGet]
        public ActionResult Get(int inicio, int fin)
        {

            if (fin - inicio < 1000)
            {
                return BadRequest("La diferencia entre inicio y fin debe ser menor a 1000.");
            }

            List<int> pares = new List<int>();
            List<int> impares = new List<int>();

            for (int i = inicio; i <= fin; i++)
            {
                if (i % 2 == 0)
                {
                    pares.Add(i);
                }
                else
                {
                    impares.Add(i);
                }
                
            }

            return Ok(new { pares, impares });

        }
    }
}
