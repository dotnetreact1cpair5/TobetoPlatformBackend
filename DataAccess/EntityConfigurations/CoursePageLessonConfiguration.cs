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
    public class CoursePageLessonConfiguration : IEntityTypeConfiguration<CoursePageLesson>
    {
        public void Configure(EntityTypeBuilder<CoursePageLesson> builder)
        {
            builder.ToTable("CoursePageLesson").HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
            builder.Property(c => c.CoursePageId).HasColumnName("CoursePageId");
            builder.Property(c => c.LessonId).HasColumnName("LessonId");

            builder.HasQueryFilter(c => !c.DeletedDate.HasValue);
        }
    }

}
