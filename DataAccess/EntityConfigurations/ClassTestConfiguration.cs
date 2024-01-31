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
    public class ClassTestConfiguration : IEntityTypeConfiguration<ClassTest>
    {
        public void Configure(EntityTypeBuilder<ClassTest> builder)
        {
            builder.ToTable("ClassTests").HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
            builder.Property(c => c.AccountStudentClassId).HasColumnName("AccountStudentClassId");
            builder.Property(c => c.TestId).HasColumnName("TestId");
           
            builder.HasQueryFilter(c => !c.DeletedDate.HasValue);
        }
    }
    
}
