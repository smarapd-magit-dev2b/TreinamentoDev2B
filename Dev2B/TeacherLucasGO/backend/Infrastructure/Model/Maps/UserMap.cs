using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Model.Maps
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("user");

            builder.HasKey(user => user.Id);

            builder.Property(user => user.Id)
                   .HasColumnName("id")
                   .HasColumnType("INT");

            builder.Property(user => user.UserName)
                   .HasColumnName("userName")
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(user => user.Senha)
                   .HasColumnName("senha")
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(75)
                   .IsRequired();

            builder.Property(user => user.NomeDeUsuario)
                   .HasColumnName("nome_do_usuario")
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(100)
                   .IsRequired();

            builder.HasIndex(user => user.UserName)
                   .IsUnique();
        }
    }
}
