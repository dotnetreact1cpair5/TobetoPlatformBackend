using Entities.Concretes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EntityConfigurations
{
    public class ApplicationStepConfiguration : IEntityTypeConfiguration<ApplicationStep>
    {
        public void Configure(EntityTypeBuilder<ApplicationStep> builder)
        {
            builder.ToTable("ApplicationSteps").HasKey(a => a.Id);
            builder.Property(a => a.Id).HasColumnName("Id").IsRequired();
            builder.Property(a => a.Name).HasColumnName("Name");
           // builder.HasMany(a=>a.a)
            
            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);
        }
    }
}
