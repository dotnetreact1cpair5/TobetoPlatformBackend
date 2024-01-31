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
    public class ClassCourseConfiguration : IEntityTypeConfiguration<ClassCourse>
    {
        public void Configure(EntityTypeBuilder<ClassCourse> builder)
        {
            builder.ToTable("ClassCourses").HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
            builder.Property(c => c.CourseId).HasColumnName("CourseId");
            builder.Property(c => c.AccountStudentClassId).HasColumnName("AccountStudentClassId");
           
            builder.HasQueryFilter(c => !c.DeletedDate.HasValue);
        }
    }

}
