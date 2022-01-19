using ApiPersonas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPersonas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        List<Persona> personas;

        public PersonasController()
        {
            //CREAMOS UNAS CUANTAS PERSONAS PARA MOSTRAR DATOS
            //EN EL SERVICIO
            this.personas = new List<Persona>
            {
                new Persona {IdPersona = 1, Nombre = "Lucia", Edad = 18},
                new Persona {IdPersona = 2, Nombre = "Clu", Edad = 20},
                new Persona {IdPersona = 3, Nombre = "Bor", Edad = 15},
                new Persona {IdPersona = 4, Nombre = "Sal", Edad = 30},
                new Persona {IdPersona = 5, Nombre = "Mon", Edad = 43},
                new Persona {IdPersona = 6, Nombre = "Vin", Edad = 72}
            };
        }
        [HttpGet]
        public ActionResult<List<Persona>> Get()
        {
            return this.personas;
        }

        [HttpGet("{id}")]
        public ActionResult<Persona> Get(int id)
        {
            return this.personas.SingleOrDefault(x => x.IdPersona == id);
        }
    }
}
