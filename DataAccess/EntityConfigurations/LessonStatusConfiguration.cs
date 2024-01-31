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
    public class LessonStatusConfiguration : IEntityTypeConfiguration<LessonStatus>
    {
        public void Configure(EntityTypeBuilder<LessonStatus> builder)
        {
            builder.ToTable("LessonStatus").HasKey(ls => ls.Id);
            builder.Property(ls => ls.Id).HasColumnName("Id").IsRequired();
            builder.Property(ls => ls.Name).HasColumnName("Name").IsRequired();
            builder.HasQueryFilter(ls => !ls.DeletedDate.HasValue);
        }
    }
}
