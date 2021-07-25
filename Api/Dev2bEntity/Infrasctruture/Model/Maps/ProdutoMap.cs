using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrasctruture.Model.Maps
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("produto");

            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.Descricao)
                .IsUnique();

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .HasColumnType("INT")
                .ValueGeneratedOnAdd();

            builder.Property(x => x.DataInclusao)
                .HasColumnName("dataInclusao")
                .HasColumnType("DATETIME")
                .HasDefaultValueSql("GETDATE()")
                .IsRequired();

            builder.Property(x => x.Descricao)
                .HasColumnName("descricao")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Preco)
                .HasColumnName("preco")
                .HasColumnType("DECIMAL(16,2)")
                .IsRequired();

            builder.Property(x => x.Quantidade)
                .HasColumnName("quantidade")
                .HasColumnType("INT")
                .IsRequired();

            builder.HasMany(x => x.ItensVenda)
                .WithOne(x => x.Produto);
        }
    }
}
