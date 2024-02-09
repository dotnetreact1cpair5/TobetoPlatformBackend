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
    public class ContentTypeConfiguration : IEntityTypeConfiguration<ContentType>
    {
        public void Configure(EntityTypeBuilder<ContentType> builder)
        {
            builder.ToTable("ContentTypes").HasKey(cct => cct.Id);
            builder.Property(cct => cct.Id).HasColumnName("Id").IsRequired();
            builder.Property(cct => cct.Name).HasColumnName("Name").IsRequired();

            builder.HasQueryFilter(cct => !cct.DeletedDate.HasValue);
        }
    }
}
