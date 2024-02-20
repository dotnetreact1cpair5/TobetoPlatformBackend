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
            builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
            builder.Property(c => c.Name).HasColumnName("Name").IsRequired();
            builder.Property(c => c.Image).HasColumnName("Image");
            builder.Property(c => c.Duration).HasColumnName("Duration");
            builder.Property(c => c.StartDate).HasColumnName("StartDate");
            builder.Property(c => c.EndDate).HasColumnName("EndDate");
            builder.HasQueryFilter(c => !c.DeletedDate.HasValue);
        }
    }
}
