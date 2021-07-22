using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository.Context
{
    public class PP_DbContext : DbContext
    {
        public PP_DbContext(DbContextOptions<PP_DbContext> options) : base(options) { }

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) =>
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}
