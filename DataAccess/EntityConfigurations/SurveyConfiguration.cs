using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class SurveyConfiguration : IEntityTypeConfiguration<Survey>
    {
        public void Configure(EntityTypeBuilder<Survey> builder)
        {
            builder.ToTable("Surveys").HasKey(s => s.Id);
            builder.Property(s => s.Id).HasColumnName("Id").IsRequired();
            builder.Property(s => s.OrganizationId).HasColumnName("OrganizationId");
            builder.Property(s => s.Title).HasColumnName("Title");
            builder.Property(s => s.Description).HasColumnName("Description");
            builder.Property(s => s.Link).HasColumnName("Link");

            //builder
            //    .HasOne(s => s.Organization)
            //    .WithMany(o => o.Surveys)
            //    .HasForeignKey(s => s.OrganizationId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //builder
            //    .HasOne(s => s.SurveyTypes)
            //    .WithMany(st => st.Surveys)
            //    .HasForeignKey(s => s.SurveyTypeId)
            // .OnDelete(DeleteBehavior.Restrict);
            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);
        }
    }
}
