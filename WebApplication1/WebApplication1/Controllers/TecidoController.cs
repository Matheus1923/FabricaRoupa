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
    public class TecidoController : ControllerBase
    {
        public Contexto Contexto { get; set; }

        public TecidoController(Contexto novoContexto)
        {
            this.Contexto = novoContexto;
        }

        [HttpGet]
        public List<Tecido> get()
        {
            return this.Contexto.Tecidos.ToList();
        }

        [HttpGet("{id}")]

        public Tecido Get(int id)
        {
            return this.Contexto.Tecidos.First(e => e.IdTecido == id);
        }

        [HttpGet("idTecido/{idTecido}")]
        public List<Tecido> filtrar(int id)
        {
            return Contexto.Tecidos.Where(e => e.IdTecido == id).ToList();
        }


        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<Tecido>> Create(Tecido Tecido)
        {
            Tecido.IdTecido = 0;
            Contexto.Tecidos.Add(Tecido);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Tecido.IdTecido, Tecido });
        }


        [HttpPost]
        [Route("update")]
        public async Task<ActionResult<Tecido>> Update(Tecido Tecido)
        {
            Contexto.Tecidos.Update(Tecido);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Tecido.IdTecido, Tecido });
        }
    }
}
