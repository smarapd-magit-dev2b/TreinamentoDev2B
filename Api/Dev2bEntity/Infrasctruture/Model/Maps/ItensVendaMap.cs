using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrasctruture.Model.Maps
{
    public class ItensVendaMap : IEntityTypeConfiguration<ItensVenda>
    {
        public void Configure(EntityTypeBuilder<ItensVenda> builder)
        {
            builder.ToTable("itemVenda");

            builder.HasKey(iv => new { iv.IdVenda, iv.IdProduto });

            builder.Property(x => x.Quantidade)
                .HasColumnName("quantidade")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(x => x.ValorTotal)
                .HasColumnName("valorTotal")
                .HasColumnType("DECIMAL(16,2)")
                .IsRequired();

            builder.HasOne(x => x.Venda)
                .WithMany(x => x.ItensVenda)
                .HasForeignKey(x => x.IdVenda);

            builder.HasOne(x => x.Produto)
                .WithMany(x => x.ItensVenda)
                .HasForeignKey(x => x.IdProduto);
        }
    }
}
