using Microsoft.AspNetCore.Mvc;

namespace Practica1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3Controller : ControllerBase
    {

        [HttpGet]
        public string Get(string nombre, int edad)
        {
            return $"Te llamas {nombre} y tienes {edad}";
        }

    }
}
