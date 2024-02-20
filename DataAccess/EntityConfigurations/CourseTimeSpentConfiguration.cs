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
    public class CourseTimeSpentConfiguration : IEntityTypeConfiguration<CourseTimeSpent>
    {
        public void Configure(EntityTypeBuilder<CourseTimeSpent> builder)
        {
            builder.ToTable("CourseTimeSpents").HasKey(cd => cd.Id);
            builder.Property(cd => cd.Id).HasColumnName("Id").IsRequired();
            builder.Property(cd => cd.CourseId).HasColumnName("CourseId").IsRequired();
            builder.Property(cd => cd.UserId).HasColumnName("UserId");
            builder.Property(cd => cd.TimeSpent).HasColumnName("TimeSpent");

            builder.HasQueryFilter(cd => !cd.DeletedDate.HasValue);
        }
    }
}
