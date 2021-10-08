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
    public class RoupaController : ControllerBase
    {
        public Contexto Contexto { get; set; }

        public RoupaController(Contexto novoContexto)
        {
            this.Contexto = novoContexto;
        }

        [HttpGet]
        public List<Roupa> get()
        {
            return this.Contexto.Roupas.ToList();
        }

        [HttpGet("{id}")]

        public Roupa Get(int id)
        {
            return this.Contexto.Roupas.First(e => e.IdRoupa == id);
        }

        [HttpGet("idRoupa/{idRoupa}")]
        public List<Roupa> filtrar(int id)
        {
            return Contexto.Roupas.Where(e => e.IdRoupa == id).ToList();
        }


        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<Roupa>> Create(Roupa Roupa)
        {
            Roupa.IdRoupa = 0;
            Contexto.Roupas.Add(Roupa);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Roupa.IdRoupa, Roupa });
        }


        [HttpPost]
        [Route("update")]
        public async Task<ActionResult<Roupa>> Update(Roupa Roupa)
        {
            Contexto.Roupas.Update(Roupa);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Roupa.IdRoupa, Roupa });
        }
    }
}
