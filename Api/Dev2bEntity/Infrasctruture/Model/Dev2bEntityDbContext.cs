using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrasctruture.Model
{
    public class Dev2bEntityDbContext : DbContext
    {
        public Dev2bEntityDbContext(DbContextOptions<Dev2bEntityDbContext> options) : base(options) { }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
