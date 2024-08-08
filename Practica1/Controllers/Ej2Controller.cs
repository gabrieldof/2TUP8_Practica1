using Microsoft.AspNetCore.Mvc;

namespace Practica1.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class Ej2Controller : ControllerBase
    {

        [HttpGet("NombreCiudad")]
        public string Get (string nombre, string ciudad)
        {
            return $"Hola {nombre}, Bienvenido a {ciudad}";
        }


    }
}
