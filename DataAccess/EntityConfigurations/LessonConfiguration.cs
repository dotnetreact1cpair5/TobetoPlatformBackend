using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations
{
    public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.ToTable("Lessons").HasKey(l => l.Id);
            builder.Property(l => l.Id).HasColumnName("Id").IsRequired();
            builder.Property(l => l.CategoryId).HasColumnName("CategoryId");
            builder.Property(l => l.ContentTypeId).HasColumnName("ContentTypeId");
            builder.Property(l => l.OrganizationId).HasColumnName("OrganizationId");
            builder.Property(l => l.Name).HasColumnName("Name");
            builder.Property(l => l.Language).HasColumnName("Language");
            builder.Property(l => l.VideoDuration).HasColumnName("VideoDuration");
            builder.Property(l => l.StartDate).HasColumnName("StartDate");
            builder.Property(l => l.EndDate).HasColumnName("EndDate");

            builder.HasQueryFilter(l => !l.DeletedDate.HasValue);
        }
    }
}
