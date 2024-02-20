using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class AccountEducationConfiguration:IEntityTypeConfiguration<AccountEducation>
    {
        public void Configure(EntityTypeBuilder<AccountEducation> builder)
        {
            builder.ToTable("AccountEducations").HasKey(a=>a.Id);
            builder.Property(a=>a.Id).HasColumnName("Id").IsRequired();
            builder.Property(a => a.AccountId).HasColumnName("AccountId").IsRequired();
            builder.Property(a => a.EducationStatusId).HasColumnName("EducationStatusId").IsRequired();
            builder.Property(a => a.EducationProgramId).HasColumnName("EducationProgramId").IsRequired();
            builder.Property(a => a.UniversityId).HasColumnName("UniversityId").IsRequired();
            builder.Property(a => a.StartYear).HasColumnName("StartYear"); 
            builder.Property(a => a.GraduationYear).HasColumnName("GraduationYear");
            builder.Property(a => a.IsGraduated).HasColumnName("IsGraduated");
            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);

            builder.HasOne(a => a.Account)
                .WithMany(account => account.AccountEducations)
                .HasForeignKey(a => a.AccountId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(a => a.EducationStatus)
                .WithMany()
                .HasForeignKey(a => a.EducationStatusId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(a => a.EducationProgram)
                .WithMany()
                .HasForeignKey(a => a.EducationProgramId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(a => a.University)
                .WithMany()
                .HasForeignKey(a => a.UniversityId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
