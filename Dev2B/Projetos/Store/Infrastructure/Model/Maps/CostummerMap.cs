using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Model.Maps
{
    public class CostummerMap : IEntityTypeConfiguration<Costummer>
    {
        public void Configure(EntityTypeBuilder<Costummer> builder)
        {
            builder.ToTable("costummer");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                   .HasColumnName("id")
                   .HasColumnType("INT");

            builder.Property(c => c.Name)
                   .HasColumnName("name")
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(c => c.BirthDate)
                   .HasColumnName("birthDate")
                   .HasColumnType("DATE")
                   .IsRequired();

            builder.Property(c => c.Phone)
                   .HasColumnName("phone")
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(20);

            builder.Property(c => c.Cpf)
                .HasColumnName("cpf")
                .HasColumnType("CHAR")
                .HasMaxLength(11)
                .IsRequired();

            builder.Property(c => c.Rg)
                .HasColumnName("rg")
                .HasColumnType("CHAR")
                .HasMaxLength(9)
                .IsRequired();

            builder.Property(c => c.Gender)
                .HasColumnName("gender")
                .HasColumnType("CHAR")
                .HasMaxLength(1);

            builder.HasIndex(c => c.Name).IsUnique();

            builder.HasIndex(c => c.Cpf).IsUnique();
        }
    }
}
