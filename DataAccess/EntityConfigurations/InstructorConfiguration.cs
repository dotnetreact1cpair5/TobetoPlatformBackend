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
    public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.ToTable("Instructor").HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
            builder.Property(c => c.FirstName).HasColumnName("FirstName");
            builder.Property(c => c.LastName).HasColumnName("LastName");
            builder.Property(c => c.Descrription).HasColumnName("Descrription");
            
            builder.HasQueryFilter(c => !c.DeletedDate.HasValue);
        }
    }

}
