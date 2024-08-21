using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Practica1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej6Controller : ControllerBase
    {
        // GET: api/<Ej6Controller>
        [HttpGet]

        public IActionResult Get(int precio, int cantidad, string tipoDePago, string? numeroTarjeta = null)
        {
            if (precio <= 0)
            {
                return BadRequest("Precio invalido");
            }

            if (cantidad <= 0)
            {
                return BadRequest("Cantidad invalida");
            }

            decimal costoTotal = precio * cantidad;

            if (tipoDePago.ToLower() == "tarjeta")
            {
                if (string.IsNullOrEmpty(numeroTarjeta) || numeroTarjeta.Length != 16 || !numeroTarjeta.All(char.IsDigit))
                {
                    return BadRequest("Numero de trajeta invalido. Debe ser un numero de 16 digitos");
                }

                costoTotal += costoTotal * 0.10m;
                return Ok($"el costo total con recargo del 10% es: {costoTotal:C}");
            }
            else if (tipoDePago.ToLower() == "efectivo")
            {
                return Ok($"El costo total es: {costoTotal:C}");
            }
            else
            {
                return BadRequest("Tipo de pago invalido. Debe ser 'efectivo' o 'tarjeta'");
            }
        }

    }
}
