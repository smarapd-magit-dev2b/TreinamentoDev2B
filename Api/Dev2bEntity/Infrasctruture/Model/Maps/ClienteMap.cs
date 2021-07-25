using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrasctruture.Model.Maps
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("cliente");

            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.Nome)
                .IsUnique();
            builder.HasIndex(x => x.Cpf)
                .IsUnique();

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .HasColumnType("INT")
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Nome)
                .HasColumnName("nome")
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.DataNascimento)
                .HasColumnName("dataNascimento")
                .HasColumnType("DATETIME")
                .IsRequired();

            builder.Property(x => x.Telefone)
                .HasColumnName("telefone")
                .HasColumnType("VARCHAR")
                .HasMaxLength(20);

            builder.Property(x => x.Cpf)
                .HasColumnName("cpf")
                .HasColumnType("VARCHAR")
                .HasMaxLength(14)
                .IsRequired();

            builder.Property(x => x.Rg)
                .HasColumnName("rg")
                .HasColumnType("VARCHAR")
                .HasMaxLength(12)
                .IsRequired();

            builder.Property(x => x.Sexo)
                .HasColumnName("sexo")
                .HasColumnType("CHAR")
                .HasMaxLength(1);
            builder.HasMany(x => x.Venda)
                .WithOne(x => x.Cliente);
        }
    }
}
