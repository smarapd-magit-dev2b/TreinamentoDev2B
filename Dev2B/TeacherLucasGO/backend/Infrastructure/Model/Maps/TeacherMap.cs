using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Model.Maps
{
    public class TeacherMap : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            _ = builder.ToTable("professor");

            _ = builder.HasKey(teacher => teacher.Id);

            _ = builder.Property(teacher => teacher.Id)
                       .HasColumnName("idProfessor")
                       .HasColumnType("INT");

            _ = builder.Property(teacher => teacher.FullName)
                       .HasColumnName("nomeCompleto")
                       .HasColumnType("VARCHAR")
                       .HasMaxLength(100)
                       .IsRequired();

            _ = builder.Property(teacher => teacher.Cpf)
                       .HasColumnName("cpf")
                       .HasColumnType("CHAR")
                       .HasMaxLength(11)
                       .IsRequired();

            _ = builder.Property(teacher => teacher.BirthDate)
                       .HasColumnName("dataNascimento")
                       .HasColumnType("DATETIME");

            _ = builder.Property(teacher => teacher.Phone)
                       .HasColumnName("telefone")
                       .HasColumnType("VARCHAR")
                       .HasMaxLength(14);

            _ = builder.Property(teacher => teacher.Email)
                       .HasColumnName("email")
                       .HasColumnType("VARCHAR")
                       .HasMaxLength(50);

            _ = builder.Property(teacher => teacher.FluentEnglish)
                       .HasColumnName("inglesFluente")
                       .HasColumnType("BIT");

            _ = builder.Property(teacher => teacher.Formation)
                       .HasColumnName("formacao")
                       .HasColumnType("VARCHAR")
                       .HasMaxLength(15);

            _ = builder.Property(teacher => teacher.AdmissionDate)
                       .HasColumnName("dataAdmissao")
                       .HasColumnType("DATETIME")
                       .IsRequired();

            _ = builder.Property(teacher => teacher.Wage)
                       .HasColumnName("salario")
                       .HasColumnType("DECIMAL(12, 2)")
                       .IsRequired();

            _ = builder.Property(teacher => teacher.IdAddress)
                       .HasColumnName("idEndereco")
                       .HasColumnType("INT")
                       .IsRequired();

            _ = builder.Property(teacher => teacher.ProfessionalExperience)
                       .HasColumnName("experienciaProfissional")
                       .HasColumnType("VARCHAR")
                       .HasMaxLength(500);

            _ = builder.HasOne(teacher => teacher.Address)
                       .WithMany(address => address.Teachers)
                       .HasForeignKey(teacher => teacher.IdAddress);

            _ = builder.HasMany(teacher => teacher.Disciplines)
                       .WithOne(discipline => discipline.Teacher);
        }
    }
}
