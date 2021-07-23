using System;
using System.Collections.Generic;
using System.Text;
using Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Maps
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("pessoa");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Nome)
                .HasColumnName("nome")
                .HasColumnType("VARCHAR(50)");
            builder.Property(x => x.SobreNome)
                .HasColumnName("sobrenome")
                .HasColumnType("VARCHAR(50)");
            builder.Property(x => x.DataNascimento)
                .HasColumnName("dataNascimento")
                .HasColumnType("DATETIME");
            builder.Property(x => x.Altura)
                .HasColumnName("altura")
                .HasColumnType("DECIMAL(16,2)");
            builder.Property(x => x.Peso)
                .HasColumnName("peso")
                .HasColumnType("DECIMAL(16,2)");
            builder.Property(x => x.Raca)
                .HasColumnName("raca")
                .HasColumnType("VARCHAR(50)");
            builder.Property(x => x.UsuarioAtivo)
                .HasColumnName("usuarioAtivo")
                .HasColumnType("bit");
            builder.Property(x => x.Cpf)
                .HasColumnName("cpf")
                .HasColumnType("VARCHAR(14)");
            builder.HasMany(e => e.Filhos)
                .WithOne(e => e.Pai)
                .HasForeignKey(x => x.idPai);
        }
    }
}
