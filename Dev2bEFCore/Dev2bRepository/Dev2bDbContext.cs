using Dev2bDomain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dev2bRepositories
{
    public class Dev2bDbContext : DbContext
    {
        public Dev2bDbContext(DbContextOptions<Dev2bDbContext> options) : base(options) { }

        public DbSet<ClienteEntity> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
