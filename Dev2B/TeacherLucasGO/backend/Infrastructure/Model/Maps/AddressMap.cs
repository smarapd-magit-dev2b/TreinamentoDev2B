using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Model.Maps
{
    public class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            _ = builder.ToTable("endereco");

            _ = builder.HasKey(address => address.Id);

            _ = builder.Property(address => address.Id)
                       .HasColumnName("idEndereco")
                       .HasColumnType("INT");

            _ = builder.Property(address => address.Cep)
                       .HasColumnName("cep")
                       .HasColumnType("CHAR")
                       .HasMaxLength(8)
                       .IsRequired();

            _ = builder.Property(address => address.Street)
                       .HasColumnName("logradouro")
                       .HasColumnType("VARCHAR")
                       .HasMaxLength(100)
                       .IsRequired();

            _ = builder.Property(address => address.District)
                       .HasColumnName("bairro")
                       .HasColumnType("VARCHAR")
                       .HasMaxLength(75)
                       .IsRequired();

            _ = builder.Property(address => address.City)
                       .HasColumnName("cidade")
                       .HasColumnType("VARCHAR")
                       .HasMaxLength(100)
                       .IsRequired();

            _ = builder.Property(address => address.State)
                       .HasColumnName("uf")
                       .HasColumnType("CHAR")
                       .HasMaxLength(2)
                       .IsRequired();

            _ = builder.Property(address => address.Number)
                       .HasColumnName("numero")
                       .HasColumnType("VARCHAR")
                       .HasMaxLength(6)
                       .IsRequired();

            _ = builder.HasMany(address => address.Teachers)
                       .WithOne(teacher => teacher.Address);
        }
    }
}
