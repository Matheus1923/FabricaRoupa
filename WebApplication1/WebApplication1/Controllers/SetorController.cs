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
    public class SetorController : ControllerBase
    {
        public Contexto Contexto { get; set; }

        public SetorController(Contexto novoContexto)
        {
            this.Contexto = novoContexto;
        }

        [HttpGet]
        public List<Setor> get()
        {
            return this.Contexto.Setors.ToList();
        }

        [HttpGet("{id}")]

        public Setor Get(int id)
        {
            return this.Contexto.Setors.First(e => e.IdSetor == id);
        }

        [HttpGet("idSetor/{idSetor}")]
        public List<Setor> filtrar(int id)
        {
            return Contexto.Setors.Where(e => e.IdSetor == id).ToList();
        }


        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<Setor>> Create(Setor Setor)
        {
            Setor.IdSetor = 0;
            Contexto.Setors.Add(Setor);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Setor.IdSetor, Setor });
        }


        [HttpPost]
        [Route("update")]
        public async Task<ActionResult<Setor>> Update(Setor Setor)
        {
            Contexto.Setors.Update(Setor);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Setor.IdSetor, Setor });
        }
    }
}
