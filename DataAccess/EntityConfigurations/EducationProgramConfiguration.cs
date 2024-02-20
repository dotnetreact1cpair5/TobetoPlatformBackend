using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class EducationProgramConfiguration:IEntityTypeConfiguration<EducationProgram>
    {
        public void Configure(EntityTypeBuilder<EducationProgram>builder)
        {
            builder.ToTable("EducationPrograms").HasKey(e=>e.Id);
            builder.Property(e=>e.Id).HasColumnName("Id").IsRequired();
            builder.Property(e=>e.Name).HasColumnName("Name");
            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);

            builder.HasOne(u => u.University)
                .WithMany(university => university.EducationPrograms)
                .HasForeignKey(u => u.UniversityId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
