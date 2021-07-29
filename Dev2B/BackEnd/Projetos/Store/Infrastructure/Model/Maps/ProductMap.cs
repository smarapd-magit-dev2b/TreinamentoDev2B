using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


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
                   .HasColumnName("price")
                   .HasColumnType("MONEY")
                   .IsRequired();

            builder.Property(p => p.InclusionDate)
                   .HasColumnName("inclusionDate")
                   .HasColumnType("DATETIME")
                   .HasDefaultValueSql("GETDATE()")
                   .IsRequired();

            builder.Property(p => p.Amount)
                   .HasColumnName("amount")
                   .HasColumnType("INT")
                   .IsRequired();

            builder.HasMany(p => p.Sales)
                   .WithMany(s => s.Products)
                   .UsingEntity<SaleItem>(
                        sim => sim.HasOne(si => si.Sale).WithMany(),
                        sim => sim.HasOne(si => si.Product).WithMany())
                   .HasKey(x => new { x.SaleId, x.ProductId }); ;

            builder.HasMany(p => p.Items)
                   .WithOne(si => si.Product);

            builder.HasIndex(p => p.Description)
                   .IsUnique();
        }
    }
}
