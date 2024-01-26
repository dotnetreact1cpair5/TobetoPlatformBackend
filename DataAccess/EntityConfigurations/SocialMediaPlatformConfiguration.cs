using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations
{
    public class SocialMediaPlatformConfiguration : IEntityTypeConfiguration<SocialMediaPlatform>
    {
        public void Configure(EntityTypeBuilder<SocialMediaPlatform> builder)
        {
            builder.ToTable("SocialMediaPlatforms").HasKey(sm => sm.Id);
            builder.Property(sm => sm.Id).HasColumnName("Id").IsRequired();
            builder.Property(sm => sm.Name).HasColumnName("Name").IsRequired();
            builder.HasQueryFilter(sm => !sm.DeletedDate.HasValue);
        }
    }
}
