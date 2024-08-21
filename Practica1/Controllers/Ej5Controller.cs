using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Practica1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej5Controller : ControllerBase
    {
        // GET: api/<Ej5Controller>
        [HttpGet]
        public ActionResult Get(string day)
        {
            var week = new List<string> { "lunes", "martes", "miercoles", "jueves", "viernes" };
            var weekend = new List<string> { "sabado", "domingo" };

            if (week.Contains(day.ToLower().Trim()))
            { 
                return Ok("Es un dia de semana");

            }
            else if (weekend.Contains(day.ToLower().Trim()))
                { 
                    return Ok("Es fin de semana"); 
                }
                else
                    { 
                        //return StatusCode(400);
                        return BadRequest("No lo reconozco");
                    }

                return StatusCode(500);

             }
         }


    }

