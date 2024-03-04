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
    public class FavouriteConfiguration : IEntityTypeConfiguration<Favourite>
    {
        public void Configure(EntityTypeBuilder<Favourite> builder)
        {
            builder.ToTable("Favourites").HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
            builder.Property(c => c.UserId).HasColumnName("UserId");
            builder.Property(c => c.CourseId).HasColumnName("CourseId").IsRequired();
            builder.Property(c => c.LessonId).HasColumnName("LessonId").IsRequired();

            builder.HasQueryFilter(c => !c.DeletedDate.HasValue);
        }
    }

}
