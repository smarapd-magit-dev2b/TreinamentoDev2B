using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Model.Maps
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Cep)
                .HasColumnName("CEP")
                .HasColumnType("char")
                .HasMaxLength(8)
                .IsRequired();

            builder.Property(x => x.Logradouro)
                .HasColumnName("Logradouro")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.Bairro)
                .HasColumnName("Bairro")
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            builder
                .HasMany(e => e.Pessoas)
                .WithOne(e => e.Endereco);

            builder.HasData
                (
                    new Endereco()
                    {
                        Id = 1,
                        Cep = "11111111",
                        Logradouro = "Rua 1",
                        Bairro = "Bairro 1"
                    },
                    new Endereco()
                    {
                        Id = 2,
                        Cep = "22222222",
                        Logradouro = "Rua 2",
                        Bairro = "Bairro 2"
                    }
                );
        }
    }
}
