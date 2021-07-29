using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Model
{
    public class Dev2bDbContext : DbContext
    {
        public Dev2bDbContext(DbContextOptions<Dev2bDbContext> options) : base(options) { }

        public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new PessoaMap());
            //modelBuilder.ApplyConfiguration(new EnderecoMap());

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
