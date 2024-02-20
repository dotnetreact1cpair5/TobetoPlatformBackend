using Entities.Concretes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EntityConfigurations
{
    public class AccountApplicationConfiguration : IEntityTypeConfiguration<AccountApplication>
    {
        public void Configure(EntityTypeBuilder<AccountApplication> builder)
        {
            builder.ToTable("AccountApplications").HasKey(a => a.Id);
            builder.Property(a => a.Id).HasColumnName("Id").IsRequired();
            builder.Property(a => a.UserId).HasColumnName("UserId");
            builder.Property(a => a.ApplicationId).HasColumnName("ApplicationId");
          //  builder.Property(a => a.ApplicationStepId).HasColumnName("ApplicationStepId");

            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);


        }
    }
}
