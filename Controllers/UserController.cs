using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TrabalhandoComEF.Controllers
{
    public class UserController : ControllerBase
    {
        public IActionResult RotaDoUsuario(){
            
            var HoraDataObjeto = new {
                Data = DateTime.Now.ToLongDateString(),
            };
            return Ok(HoraDataObjeto);
        }

        public IActionResult RetornaUser(string nome){
            var retornaNome = $"Olá {nome}";
            return Ok(retornaNome);
        }

    }
}