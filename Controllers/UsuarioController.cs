using System.Linq;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Api_en_code.Models;
using Api_en_code.Services;


namespace Api_en_code.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {

        public UsuarioController(){

        }
        //http://127.0.0.1:5001/api/Persona Link de api por 0.0.0.0
        /*
        [HttpGet]
        public ActionResult<IEnumerable<Persona>> Get(){
            return Ok(UsuarioServices.GetAll());        //obtiene la lista de usuarios en el services
        }*/

        [HttpPost]
        public IActionResult Consultar(Usuario usuario)
        {
            var user = UsuarioServices.Get(usuario.Nombre, usuario.Contra);

            //Console.WriteLine(user.Nombre, user.Contra);

            if (user == null)
            {
                return Ok(user);//Ok("false");
            }
            
            if (user.Nombre == usuario.Nombre && user.Contra == usuario.Contra)
            {
                return Ok(user);//Ok("true");
            }
            else{
                return Ok(user);//Ok("false");
            }
        }
    }
}