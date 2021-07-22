using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infrastructure.Model.Maps
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("product");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Description)
                   .HasColumnName("description")
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(75);

            builder.Property(p => p.Price)
                   .HasColumnType("MONEY")
                   .IsRequired();

            builder.Property(p => p.InclusionDate)
                   .HasColumnType("DATE")
                   .IsRequired();

            builder.HasIndex(p => p.Description)
                   .IsUnique();
        }
    }
}
