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
    public class AccountStudentClassConfiguration : IEntityTypeConfiguration<AccountStudentClass>
    {
        public void Configure(EntityTypeBuilder<AccountStudentClass> builder)
        {
            builder.ToTable("AccountStudentClasses").HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
            builder.Property(c => c.AccountId).HasColumnName("AccountId").IsRequired();
            builder.Property(c => c.StudentClassId).HasColumnName("StudentClassId").IsRequired();
           
          
            builder.HasQueryFilter(c => !c.DeletedDate.HasValue);
        }
    }

}
