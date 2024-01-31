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
    public class AccountCourseConfiguration : IEntityTypeConfiguration<CourseCompletion>
    {
        public void Configure(EntityTypeBuilder<CourseCompletion> builder)
        {
            builder.ToTable("CourseCompletions").HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("Id").IsRequired();
            builder.Property(e => e.AccountId).HasColumnName("AccountId").IsRequired();
            builder.Property(e => e.CourseId).HasColumnName("CourseId").IsRequired();
            builder.Property(e => e.PercentageOfCompletion).HasColumnName("PercentageOfCompletion");
            builder.Property(e => e.Point).HasColumnName("Point").IsRequired();
            
            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);
        }
    }
}
