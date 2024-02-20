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
    public class PathFileConfiguration : IEntityTypeConfiguration<PathFile>
    {
        public void Configure(EntityTypeBuilder<PathFile> builder)
        {
            builder.ToTable("PathFiles").HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
            builder.Property(c => c.FileName).HasColumnName("FileName");
            builder.Property(c => c.FileUrl).HasColumnName("FileUrl");
            builder.Property(c => c.Description).HasColumnName("Description");
          
            builder.HasQueryFilter(c => !c.DeletedDate.HasValue);
        }
    }


}
