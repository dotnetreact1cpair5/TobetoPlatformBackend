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
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses").HasKey(c => c.Id);
            builder.Property(c=>c.Id).HasColumnName("Id").IsRequired();
            builder.Property(c => c.CategoryId).HasColumnName("CategoryId");
            builder.Property(c => c.OrganizationId).HasColumnName("OrganizationId");
            builder.Property(c => c.ContentTypeId).HasColumnName("ContentTypeId");
            builder.Property(c => c.Name).HasColumnName("Name");
          //  builder.Property(c => c.UserId).HasColumnName("UserId");
            builder.Property(c => c.EstimatedVideoDuration).HasColumnName("EstimatedVideoDuration");
            builder.Property(c => c.StartDate).HasColumnName("StartDate");
            builder.Property(c => c.EndDate).HasColumnName("EndDate");
           // builder.HasOne(c=>c.User);

            builder.HasQueryFilter(c => !c.DeletedDate.HasValue);
        }
    }
}
