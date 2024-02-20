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
    public class SessionRecordConfiguration : IEntityTypeConfiguration<SessionRecord>
    {
        public void Configure(EntityTypeBuilder<SessionRecord> builder)
        {
            builder.ToTable("SessionRecords").HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
            builder.Property(c => c.Name).HasColumnName("Name");
            builder.Property(c => c.Description).HasColumnName("Description");
           
            builder.HasQueryFilter(c => !c.DeletedDate.HasValue);
        }
    }

}
