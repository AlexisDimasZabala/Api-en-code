using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Api_en_code.Models;
using Api_en_code.Services;

namespace Api_en_code.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonaController : ControllerBase
    {

        public PersonaController()
        {

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

            if(per == null){
                return NotFound();
            }
            else{
                return Ok(per);
            }
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