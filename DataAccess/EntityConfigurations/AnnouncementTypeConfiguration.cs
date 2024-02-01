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
    public class AnnouncementTypeConfiguration : IEntityTypeConfiguration<AnnouncementType>
    {
        public void Configure(EntityTypeBuilder<AnnouncementType> builder)
        {
            builder.ToTable("AnnouncementTypes").HasKey(at => at.Id);
            builder.Property(at => at.Id).HasColumnName("Id").IsRequired();
            builder.Property(at => at.Name).HasColumnName("Name");
            builder.Property(at => at.Priority).HasColumnName("Priority");
            builder.Property(at => at.Visibility).HasColumnName("Visibility");
            builder.HasQueryFilter(at => !at.DeletedDate.HasValue);
        }
    }
}
