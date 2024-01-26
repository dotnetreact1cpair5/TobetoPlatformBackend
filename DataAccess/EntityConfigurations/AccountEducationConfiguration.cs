using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class AccountEducationConfiguration : IEntityTypeConfiguration<AccountEducation>
    {
        public void Configure(EntityTypeBuilder<AccountEducation> builder)
        {
            builder.ToTable("AccountEducations").HasKey(a => a.Id);
            builder.Property(a => a.Id).HasColumnName("Id").IsRequired();
            builder.Property(a => a.AccountId).HasColumnName("AccountId").IsRequired();
            builder.Property(a => a.UniversityId).HasColumnName("UniversityId");
            builder.Property(a => a.EducationProgramId).HasColumnName("EducationProgramId");
            builder.Property(a => a.EducationStatusId).HasColumnName("EducationStatusId");
            builder.Property(a => a.StartYear).HasColumnName("StartYear");
            builder.Property(a => a.GraduationYear).HasColumnName("GraduationYear");
            builder.Property(a => a.IsGraduated).HasColumnName("IsGraduated");
            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);

            builder.HasOne(a => a.Account)
                    .WithMany(city => city.AccountEducations)
                    .HasForeignKey(d => d.AccountId)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(a => a.University)
                .WithOne(b => b.AccountEducation)
                .HasForeignKey<AccountEducation>(b => b.UniversityId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(a => a.EducationProgram)
                .WithOne(b => b.AccountEducation)
                .HasForeignKey<AccountEducation>(b => b.EducationProgramId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(a => a.EducationStatus)
                .WithOne(b => b.AccountEducation)
                .HasForeignKey<AccountEducation>(b => b.EducationStatusId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
