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
            
            if(contato==null) return NotFound();
            
            return Ok(contato);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateContato(int id, Contato contato){
            var contatoBanco = _context.Contatos.Find(id);
            
            if (contatoBanco == null)  return NotFound();
            contatoBanco.NomeContato = contato.NomeContato;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;
            
            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();

            return Ok();
        }
       
    }
}