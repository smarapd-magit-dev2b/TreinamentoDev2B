using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Model.Maps
{
    public class DisciplineMap : IEntityTypeConfiguration<Discipline>
    {
        public void Configure(EntityTypeBuilder<Discipline> builder)
        {
            _ = builder.ToTable("disciplina");

            _ = builder.HasKey(discipline => discipline.Id);

            _ = builder.Property(disciplene => disciplene.Id)
                       .HasColumnName("idDisciplina")
                       .HasColumnType("INT");

            _ = builder.Property(discipline => discipline.Description)
                       .HasColumnName("descricao")
                       .HasColumnType("VARCHAR")
                       .HasMaxLength(100)
                       .IsRequired();

            _ = builder.Property(discipline => discipline.Cid)
                       .HasColumnName("cid")
                       .HasColumnType("VARCHAR")
                       .HasMaxLength(35)
                       .IsRequired();

            _ = builder.Property(discipline => discipline.InclusionDate)
                       .HasColumnName("dataInclusao")
                       .HasColumnType("DATETIME")
                       .IsRequired();

            _ = builder.Property(discipline => discipline.IdTeacher)
                       .HasColumnName("idProfessor")
                       .HasColumnType("INT");

            _ = builder.HasOne(discipline => discipline.Teacher)
                       .WithMany(teacher => teacher.Disciplines)
                       .HasForeignKey(discipline => discipline.IdTeacher);
        }
    }
}
