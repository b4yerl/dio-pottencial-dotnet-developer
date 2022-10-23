using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IntroAPI.Entities;
using IntroAPI.Context;

namespace IntroAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;
        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ObterPorId), new {id = contato.Id}, contato);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var contato = _context.Contatos.Find(id);

            if(contato == null) return NotFound();
            return Ok(contato);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(id);
            
            if (contatoBanco == null) return NotFound();

            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contato.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();
            return Ok(contatoBanco);
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var contatoBanco = _context.Contatos.Find(id);
            if (contatoBanco == null) return NotFound();

            _context.Contatos.Remove(contatoBanco);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpGet]
        public IActionResult ObterTodos()
        {
            var teste = _context.Contatos.ToList();
            // List<Contato> geral = new List<Contato>();
            // int i = 1;
            // var objAtual = _context.Contatos.Find(i);

            // if (objAtual == null) return NotFound();
            // while(objAtual != null)
            // {
            //     geral.Add(objAtual);
            //     i++;
            //     objAtual = _context.Contatos.Find(i);
            // }
            // return Ok(geral);
            return Ok(teste);
        }

        [HttpGet("ObterPorNome")]
        public IActionResult ObterPorNome(string nome)
        {
            var listaContatos = _context.Contatos.Where(contato => contato.Nome.Contains(nome));
            return Ok(listaContatos);
        }
    }
}