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
    public class CourseFavouriteConfiguration : IEntityTypeConfiguration<CourseFavourite>
    {
        public void Configure(EntityTypeBuilder<CourseFavourite> builder)
        {
            builder.ToTable("CourseFavourites").HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
            builder.Property(c => c.AccountId).HasColumnName("AccountId");
            builder.Property(c => c.CourseId).HasColumnName("CourseId").IsRequired();
           
            builder.HasQueryFilter(c => !c.DeletedDate.HasValue);
        }
    }

}
