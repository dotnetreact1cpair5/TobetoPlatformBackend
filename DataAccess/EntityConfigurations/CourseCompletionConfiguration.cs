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
    public class CourseCompletionConfiguration : IEntityTypeConfiguration<CourseCompletion>
    {
        public void Configure(EntityTypeBuilder<CourseCompletion> builder)
        {
            builder.ToTable("CourseCompletions").HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
            builder.Property(c => c.UserId).HasColumnName("UserId");
            builder.Property(c => c.CourseId).HasColumnName("CourseId");
            builder.Property(c => c.PercentageOfCompletion).HasColumnName("PercentageOfCompletion");
            builder.Property(c => c.Point).HasColumnName("Point");
           
            builder.HasQueryFilter(c => !c.DeletedDate.HasValue);
        }
    }

}
