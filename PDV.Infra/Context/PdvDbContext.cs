using Microsoft.EntityFrameworkCore;
using PDV.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Infra.Context
{
    public class PdvDbContext : DbContext
    {
        public PdvDbContext(DbContextOptions<PdvDbContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<ItensVenda> ItensVendas { get; set; }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sale>()
                .HasMany(s => s.Items)
                .WithOne()
                .HasForeignKey(si => si.SaleId);

            base.OnModelCreating(modelBuilder);
        }*/
    }
}
