using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Model.Maps
{
    public class SaleMap : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.ToTable("sale");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Id)
                   .HasColumnName("id")
                   .HasColumnType("INT")
                   .IsRequired();

            builder.Property(s => s.CustomerId)
                   .HasColumnName("customerId")
                   .HasColumnType("INT")
                   .IsRequired();

            builder.Property(s => s.Date)
                   .HasColumnName("date")
                   .HasColumnType("DATETIME")
                   .HasDefaultValueSql("GETDATE()")
                   .IsRequired();

            builder.HasOne(s => s.Customer)
                   .WithMany(c => c.Sales)
                   .HasForeignKey(s => s.CustomerId)
                   .HasConstraintName("FK_COSTUMER_ID_Sale#ID_Costumer");

            builder.HasMany(s => s.Products)
                   .WithMany(p => p.Sales)
                   .UsingEntity<SaleItem>(
                        sim => sim.HasOne(si => si.Product).WithMany(),
                        sim => sim.HasOne(si => si.Sale).WithMany())
                   .HasKey(x => new { x.SaleId, x.ProductId });

            builder.HasMany(s => s.Items)
                   .WithOne(si => si.Sale);
        }
    }
}
