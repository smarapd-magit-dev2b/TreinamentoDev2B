using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Model.Maps
{
    public class SaleItemMap : IEntityTypeConfiguration<SaleItem>
    {
        public void Configure(EntityTypeBuilder<SaleItem> builder)
        {
            builder.ToTable("saleItem");

            builder.HasKey(si => new { si.SaleId, si.ProductId })
                   .HasName("PK_SaleItem");

            builder.Property(si => si.SaleId)
                   .HasColumnName("saleId")
                   .HasColumnType("INT")
                   .IsRequired();

            builder.Property(si => si.ProductId)
                   .HasColumnName("productId")
                   .HasColumnType("INT")
                   .IsRequired();

            builder.Property(si => si.Price)
                   .HasColumnName("price")
                   .HasColumnType("MONEY")
                   .IsRequired();

            builder.Property(si => si.Amount)
                   .HasColumnName("amount")
                   .HasColumnType("INT")
                   .IsRequired();

            builder.HasOne(si => si.Sale)
                   .WithMany(s => s.Items)
                   .HasForeignKey(si => si.SaleId)
                   .HasConstraintName("FK_SALE_ID_SaleItem#ID_Sale");

            builder.HasOne(si => si.Product)
                   .WithMany(p => p.Items)
                   .HasForeignKey(si => si.ProductId)
                   .HasConstraintName("FK_PRODUCT_ID_SaleItem#ID_Product");
        }
    }
}
