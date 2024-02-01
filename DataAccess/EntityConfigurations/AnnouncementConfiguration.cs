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
    public class AnnouncementConfiguration : IEntityTypeConfiguration<Announcement>
    {
        public void Configure(EntityTypeBuilder<Announcement> builder)
        {
            builder.ToTable("Announcements").HasKey(a => a.Id);
            builder.Property(a => a.Id).HasColumnName("Id").IsRequired();
            builder.Property(a => a.AnnouncementTypeId).HasColumnName("AnnouncementTypeId").IsRequired();
            builder.Property(a => a.OrganizationId).HasColumnName("OrganizationId").IsRequired();
            builder.Property(a => a.Subject).HasColumnName("Subject");
            builder.Property(a => a.Description).HasColumnName("Description");
            builder.Property(a => a.PublishedDate).HasColumnName("PublishedDate");
            builder.Property(a => a.Priority).HasColumnName("Priority");
            builder.Property(a => a.Visibility).HasColumnName("Visibility");
           // builder.HasIndex(indexExpression: a => a.AnnouncementTypeId, name: "FK_Announcements_AnnouncementTypes");
          //  builder.HasIndex(indexExpression: a => a.OrganizationId, name: "FK_Announcements_Organizations");
            builder.HasQueryFilter(a => !a.DeletedDate.HasValue);
        }
    }
}
