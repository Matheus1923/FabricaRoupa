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
    public class VendaController : ControllerBase
    {
        public Contexto Contexto { get; set; }

        public VendaController(Contexto novoContexto)
        {
            this.Contexto = novoContexto;
        }

        [HttpGet]
        public List<Venda> get()
        {
            return this.Contexto.Vendas.ToList();
        }

        [HttpGet("{id}")]

        public Venda Get(int id)
        {
            return this.Contexto.Vendas.First(e => e.IdVenda == id);
        }

        [HttpGet("idVenda/{idVenda}")]
        public List<Venda> filtrar(int id)
        {
            return Contexto.Vendas.Where(e => e.IdVenda == id).ToList();
        }


        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<Venda>> Create(Venda Venda)
        {
            Venda.IdVenda = 0;
            Contexto.Vendas.Add(Venda);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Venda.IdVenda, Venda });
        }


        [HttpPost]
        [Route("update")]
        public async Task<ActionResult<Venda>> Update(Venda Venda)
        {
            Contexto.Vendas.Update(Venda);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Venda.IdVenda, Venda });
        }
    }
}
