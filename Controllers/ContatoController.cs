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

        // >> Obter pelo ID
        [HttpGet]
        public IActionResult ObterPeloId(int id){
            var contato = _context.Contatos.Find(id);
            
            if(contato==null) return NotFound();
            
            return Ok(contato);
        }

        // >> Obter pelo Nome 
        [HttpGet]
        public IActionResult ObterPorNome(String nome){
            
            var contatos = _context.Contatos
                                   .Where(x => x.NomeContato
                                                .Contains(nome));
            if(contatos==null) return NotFound();
            
            return Ok(contatos);
        }

        // >> Obter pelo Todos
        [HttpGet]
        public IActionResult ObterTodos(){
            var contato = _context.Contatos.Find();
            return Ok(contato);
        }

        // >> Alterando um contato
        [HttpPut("{id}")]
        public IActionResult UpdateContato(int id, Contato contato){
            var contatoBanco = _context.Contatos.Find(id);
            
            if (contatoBanco == null)  return NotFound();
            
            // Atualizando
            contatoBanco.NomeContato = contato.NomeContato;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;
            
            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();

            return Ok(contatoBanco);
        }

        // >> Deletando um contato
        [HttpDelete("{id}")]
        public IActionResult DeletaContato(int id){
             var contatoBanco = _context.Contatos.Find(id);
             if (contatoBanco == null)  return NotFound();
             _context.Contatos.Remove(contatoBanco);
             _context.SaveChanges();

             return NoContent();

        }
       
    }
}