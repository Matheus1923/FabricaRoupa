using FabricaRoupa.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FabricaRoupa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LojaController : ControllerBase
    {
        public Contexto Contexto { get; set; }

        public LojaController(Contexto novoContexto)
        {
            this.Contexto = novoContexto;
        }

        [HttpGet]
        public List<Loja> get()
        {
            return this.Contexto.Lojas.ToList();
        }

        [HttpGet("{id}")]

        public Loja Get(int id)
        {
            return this.Contexto.Lojas.First(e => e.IdLoja == id);
        }

        [HttpGet("idLoja/{idLoja}")]
        public List<Loja> filtrar(int id)
        {
            return Contexto.Lojas.Where(e => e.IdLoja == id).ToList();
        }


        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<Loja>> Create(Loja Loja)
        {
            Loja.IdLoja = 0;
            Contexto.Lojas.Add(Loja);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Loja.IdLoja, Loja });
        }


        [HttpPost]
        [Route("update")]
        public async Task<ActionResult<Loja>> Update(Loja Loja)
        {
            Contexto.Lojas.Update(Loja);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Loja.IdLoja, Loja });
        }
    }
}
