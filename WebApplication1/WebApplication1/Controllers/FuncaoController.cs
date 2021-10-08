using FabricaRoupa.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FabricaRoupa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncaoController : ControllerBase
    {
        public Contexto Contexto { get; set; }

        public FuncaoController (Contexto novoContexto)
        {
            this.Contexto = novoContexto;
        }

        [HttpGet]
        public List<Funcao> get()
        {
            return this.Contexto.Funcaos.ToList();
        }

        [HttpGet("{id}")]

        public Funcao Get(int id)
        {
            return this.Contexto.Funcaos.First(e => e.IdFuncao == id);
        }

        [HttpGet("idFuncao/{idFuncao}")]
        public List<Funcao> filtrar(int id)
        {
            return Contexto.Funcaos.Where(e => e.IdFuncao == id).ToList();
        }


        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<Funcao>> Create(Funcao Funcao)
        {
            Funcao.IdFuncao = 0;
            Contexto.Funcaos.Add(Funcao);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Funcao.IdFuncao, Funcao });
        }


        [HttpPost]
        [Route("update")]
        public async Task<ActionResult<Funcao>> Update(Funcao Funcao)
        {
            Contexto.Funcaos.Update(Funcao);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Funcao.IdFuncao, Funcao });
        }
    }
}
