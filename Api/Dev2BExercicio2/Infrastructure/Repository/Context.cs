using System;
using System.Collections.Generic;
using System.Text;
using Common.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Pessoa> Pessoas {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

    }
}
