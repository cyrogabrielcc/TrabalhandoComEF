using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrabalhandoComEF.context;
using TrabalhandoComEF.Entities;

namespace TrabalhandoComEF.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        public readonly AgendaContext _context;
        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return Ok(contato);
        }

        [HttpGet]
        public IActionResult ObterPeloId(int id){
            var contato = _context.Contatos.Find(id);
            if(contato==null){
                return NotFound();
            }
            return Ok(contato);
        }
       
    }
}