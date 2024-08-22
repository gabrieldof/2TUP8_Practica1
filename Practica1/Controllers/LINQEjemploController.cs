using Microsoft.AspNetCore.Mvc;
using Practica1.Entities;
using System.Linq;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Practica1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LINQEjemploController : ControllerBase
    {
        // GET: api/<LINQEjemploController>
        [HttpGet]
        public ActionResult Get()
        {
            var clubesdefutbol = new List<ClubDeFutbol>()
           {
                new ClubDeFutbol() { Nombre = "River Plate", Provincia = "Buenos Aires", Fundacion = 1901 },
                new ClubDeFutbol() { Nombre = "Boca Juniors", Provincia = "Buenos Aires", Fundacion = 1905 },
                new ClubDeFutbol() { Nombre = "Rosario Central", Provincia = "Santa Fe", Fundacion = 1889 },
                new ClubDeFutbol() { Nombre = "Newell's Old Boys", Provincia = "Santa Fe", Fundacion = 1903 },
                new ClubDeFutbol() { Nombre = "Talleres", Provincia = "Córdoba", Fundacion = 1913 },
                new ClubDeFutbol() { Nombre = "Belgrano", Provincia = "Córdoba", Fundacion = 1905 },
                new ClubDeFutbol() { Nombre = "Atlético Tucumán", Provincia = "Tucumán", Fundacion = 1902 },
                new ClubDeFutbol() { Nombre = "San Martín de Tucumán", Provincia = "Tucumán", Fundacion = 1909 },
                new ClubDeFutbol() { Nombre = "Gimnasia y Esgrima de Jujuy", Provincia = "Jujuy", Fundacion = 1931 },
                new ClubDeFutbol() { Nombre = "Patronato", Provincia = "Entre Ríos", Fundacion = 1914 },
             };
            //new Club() { Nombre = "Patronato", Provincia = "Entre Ríos", Fundacion = 1914 };

            
            //QUERY SYNTAX o QUERY EXPRESSIONS en LINQ
            //SELECT

            var nombreclubes = from c in clubesdefutbol
                         select c.Nombre;
            //WHERE
            var nombreclubesfiltrado = from c in clubesdefutbol
                                       where c.Provincia == "Santa Fe"
                                       select c.Nombre;

            //Method

            var nombreclubesfiltrado1 = clubesdefutbol.Where(c => c.Provincia == "Santa Fe")
                                                .Select(c => c.Nombre);



            return Ok(nombreclubesfiltrado1);

        }


    }
}
