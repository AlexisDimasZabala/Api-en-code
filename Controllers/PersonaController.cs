using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Api_en_code.Models;

namespace Api_en_code.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonaController : ControllerBase
    {
        //private readonly List<Persona> personas = new List<Persona>();

        public PersonaController()
        {/*
            personas.Add(new Persona(){
                Id = 1,
                Nombre = "Juan pedro",
                Email = "Juan@gmail.com",
                Domicilio = "J.Pedro 7569",
                Telefono = "0000000001",
                Activo = true
            });

            personas.Add(new Persona(){
                Id = 2,
                Nombre = "Maria Tulin",
                Email = "Maria@gmail.com",
                Domicilio = "Gaich 1151",
                Telefono = "0000000002",
                Activo = true
            });

            personas.Add(new Persona(){
                Id = 3,
                Nombre = "Fede Garcia",
                Email = "Fede@gmail.com",
                Domicilio = "Moreno 849",
                Telefono = "0000000003",
                Activo = true
            });

            personas.Add(new Persona(){
                Id = 4,
                Nombre = "Mario Huck",
                Email = "Huck@gmail.com",
                Domicilio = "Gonzales 4555",
                Telefono = "0000000004",
                Activo = true
            });

            personas.Add(new Persona(){
                Id = 5,
                Nombre = "Daiana Fordi",
                Email = "Dai@gmail.com",
                Domicilio = "Gonzales 2560",
                Telefono = "0000000005",
                Activo = true
            });

            personas.Add(new Persona(){
                Id = 6,
                Nombre = "Lucas Older",
                Email = "LucOld@gmail.com",
                Domicilio = "Huncal 455",
                Telefono = "0000000006",
                Activo = true
            });

            personas.Add(new Persona(){
                Id = 7,
                Nombre = "Gaston Muchit",
                Email = "Gasti@gmail.com",
                Domicilio = "Torres 878",
                Telefono = "0000000007",
                Activo = true
            });*/
        }
         //-------------------------Personas all -------------------
        [HttpGet]
        public ActionResult<IEnumerable<Persona>> Get(){
            return Ok(PersonaServices.Services.PersonaServices.GetAll());
        }
        
        //-------------------------Personas by id -------------------
        [HttpGet("{id}")]
        public ActionResult<Persona> Get(int id)
        {
            var per = PersonaServices.Services.PersonaServices.Get(id);//PersonaServices.Get(); //Persona.Get(id);

            if(per == null)
                return NotFound();

            return Ok(per);
        }
        
        //-------------------------Personas create-------------------
        [HttpPost]
        public IActionResult Create(Persona persona)
        {            
            PersonaServices.Services.PersonaServices.Add(persona);
            return CreatedAtAction(nameof(Create), new { id = persona.Id }, persona);
        }

        //-------------------------Personas update -------------------
        [HttpPut("{id}")]
        public IActionResult Update(int id, Persona persona)
        {
            if (id != persona.Id)
            return BadRequest();

            var existingPersona = PersonaServices.Services.PersonaServices.Get(id);
            if(existingPersona is null)
                return NotFound();

            PersonaServices.Services.PersonaServices.Update(persona);           

            return NoContent();
        }

        //-------------------------Personas delete -------------------
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var pizza = PersonaServices.Services.PersonaServices.Get(id);

            if (pizza is null)
                return NotFound();

            PersonaServices.Services.PersonaServices.Delete(id);

            return NoContent();
        }
    }
}