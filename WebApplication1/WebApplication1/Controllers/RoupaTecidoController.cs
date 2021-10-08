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
    public class RoupaTecidoController : ControllerBase
    {
        public Contexto Contexto { get; set; }

        public RoupaTecidoController(Contexto novoContexto)
        {
            this.Contexto = novoContexto;
        }

        [HttpGet]
        public List<RoupaTecido> get()
        {
            return this.Contexto.RoupaTecidos.ToList();
        }

        [HttpGet("{id}")]

        public RoupaTecido Get(int id)
        {
            return this.Contexto.RoupaTecidos.First(e => e.IdRoupaTecido == id);
        }

        [HttpGet("idRoupaTecido/{idRoupaTecido}")]
        public List<RoupaTecido> filtrar(int id)
        {
            return Contexto.RoupaTecidos.Where(e => e.IdRoupaTecido == id).ToList();
        }


        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<RoupaTecido>> Create(RoupaTecido RoupaTecido)
        {
            RoupaTecido.IdRoupaTecido = 0;
            Contexto.RoupaTecidos.Add(RoupaTecido);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = RoupaTecido.IdRoupaTecido, RoupaTecido });
        }


        [HttpPost]
        [Route("update")]
        public async Task<ActionResult<RoupaTecido>> Update(RoupaTecido RoupaTecido)
        {
            Contexto.RoupaTecidos.Update(RoupaTecido);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = RoupaTecido.IdRoupaTecido, RoupaTecido });
        }
    }
}
