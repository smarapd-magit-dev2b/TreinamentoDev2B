using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrasctruture.Model.Maps
{
    public class VendaMap : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {
            builder.ToTable("venda");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .HasColumnType("INT")
                .ValueGeneratedOnAdd();

            builder.HasOne(x => x.Cliente)
                .WithMany(x => x.Venda)
                .HasForeignKey(x => x.IdCliente)
                .IsRequired();

            builder.Property(x => x.Data)
                .HasColumnName("dataVenda")
                .HasColumnType("DATETIME")
                .IsRequired();

            builder.HasMany(x => x.ItensVenda)
                .WithOne(x => x.Venda);
        }
    }
}
