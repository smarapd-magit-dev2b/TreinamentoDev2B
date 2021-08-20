using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Model.Maps
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            _ = builder.ToTable("usuario");

            _ = builder.HasKey(user => user.Id);

            _ = builder.Property(user => user.Id)
                       .HasColumnName("idUsuario")
                       .HasColumnType("INT");

            _ = builder.Property(user => user.Username)
                       .HasColumnName("userName")
                       .HasColumnType("VARCHAR")
                       .HasMaxLength(100)
                       .IsRequired();

            _ = builder.Property(user => user.Password)
                       .HasColumnName("senha")
                       .HasColumnType("VARCHAR")
                       .HasMaxLength(75)
                       .IsRequired();

            _ = builder.Property(user => user.Name)
                       .HasColumnName("nomeDoUsuario")
                       .HasColumnType("VARCHAR")
                       .HasMaxLength(100)
                       .IsRequired();

            _ = builder.HasIndex(user => user.Username)
                       .IsUnique();
        }
    }
}
