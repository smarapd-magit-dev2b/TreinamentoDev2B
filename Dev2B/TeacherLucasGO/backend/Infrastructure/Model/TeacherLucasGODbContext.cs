using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Model
{
    public class TeacherLucasGODbContext : DbContext
    {
        public TeacherLucasGODbContext(DbContextOptions<TeacherLucasGODbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) =>
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}
