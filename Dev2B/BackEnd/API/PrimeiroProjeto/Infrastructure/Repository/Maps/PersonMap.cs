using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Repository.Maps
{
    public class PersonMap : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("person");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                   .HasColumnName("id")
                   .HasColumnType("INT");

            builder.Property(p => p.IdMon)
                   .HasColumnName("idMon")
                   .HasColumnType("INT");

            builder.Property(p => p.IdDad)
                   .HasColumnName("idDad")
                   .HasColumnType("INT");

            builder.Property(p => p.Name)
                   .HasColumnName("name")
                   .HasMaxLength(50);

            builder.Property(p => p.LastName)
                   .HasColumnName("lastName")
                   .HasMaxLength(100);

            builder.Property(p => p.BirthDate)
                   .HasColumnName("birthDate");

            builder.Property(p => p.Height)
                   .HasColumnName("height")
                   .HasColumnType("DECIMAL(2,2)");

            builder.Property(p => p.Weight)
                   .HasColumnName("weight")
                   .HasColumnType("DECIMAL(3,2)");

            builder.Property(p => p.Race)
                   .HasColumnName("race")
                   .HasMaxLength(5);

            builder.Property(p => p.Status)
                   .HasColumnName("status")
                   .HasColumnType("BIT");

            builder.Property(x => x.Cpf)
                   .HasColumnName("cpf")
                   .HasMaxLength(11);
        }
    }
}
