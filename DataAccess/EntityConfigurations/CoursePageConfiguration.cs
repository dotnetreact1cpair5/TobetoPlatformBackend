using Entities.Concretes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations
{
    public class CoursePageConfiguration : IEntityTypeConfiguration<CoursePage>
    {
        public void Configure(EntityTypeBuilder<CoursePage> builder)
        {
            builder.ToTable("CoursePages").HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
            builder.Property(c => c.Name).HasColumnName("Name");
            builder.Property(c => c.PathFileId).HasColumnName("PathFileId");

            builder.HasQueryFilter(c => !c.DeletedDate.HasValue);
        }
    }

}
