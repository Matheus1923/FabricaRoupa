using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FabricaRoupa.Models
{
    public class Contexto:DbContext
    {
        public DbSet<Funcao> Funcaos { get; set; }
        public DbSet<Loja> Lojas { get; set; }
        public DbSet<Roupa> Roupas { get; set; }
        public DbSet<RoupaTecido> RoupaTecidos { get; set; }
        public DbSet<Setor> Setors { get; set; }
        public DbSet<Tecido> Tecidos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }
    }
}
