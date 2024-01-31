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
    public class LessonFavouriteConfiguration : IEntityTypeConfiguration<LessonFavourite>
    {
        public void Configure(EntityTypeBuilder<LessonFavourite> builder)
        {
            builder.ToTable("LessonFavourites").HasKey(ac => ac.Id);
            builder.Property(ac => ac.Id).HasColumnName("Id").IsRequired();
            builder.Property(ac => ac.AccountId).HasColumnName("AccountId");
            builder.Property(ac => ac.LessonId).HasColumnName("LessonId").IsRequired();
          
            builder.HasQueryFilter(ac => !ac.DeletedDate.HasValue);
  
        }
    }
}
