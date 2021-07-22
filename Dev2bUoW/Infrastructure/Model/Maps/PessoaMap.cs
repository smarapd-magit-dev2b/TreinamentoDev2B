using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infrastructure.Model.Maps
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("Pessoa");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.SobreNome)
                .HasColumnName("Sobrenome")
                .HasColumnType("varchar")
                .HasMaxLength(50);

            builder.Property(x => x.DataNascimento)
                .HasColumnName("DataNascimento")
                .HasColumnType("date");

            builder.Property(x => x.CPF)
                .HasColumnName("CPF")
                .HasColumnType("char")
                .HasMaxLength(11)
                .IsRequired();

            builder.Property(x => x.Numero)
                .HasColumnName("Numero")
                .HasColumnType("int");

            builder
                .HasOne(e => e.Endereco)
                .WithMany(e => e.Pessoas);

            builder.HasData
                (
                    new Pessoa()
                    {
                        Id = 1,
                        Nome = "Nome 1",
                        SobreNome = "Sobrenome 1",
                        DataNascimento = new DateTime(2001, 1, 1),
                        CPF = "11111111111",
                        Numero = 100,
                        EnderecoId = 1
                    },
                    new Pessoa()
                    {
                        Id = 2,
                        Nome = "Nome 2",
                        SobreNome = "Sobrenome 2",
                        DataNascimento = new DateTime(2002, 2, 2),
                        CPF = "22222222222",
                        Numero = 200,
                        EnderecoId = 2
                    }
                );
        }
    }
}