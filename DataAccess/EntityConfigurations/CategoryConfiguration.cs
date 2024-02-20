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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories").HasKey(cc => cc.Id);
            builder.Property(cc => cc.Id).HasColumnName("Id").IsRequired();
            builder.Property(cc => cc.Name).HasColumnName("Name").IsRequired();
            builder.HasQueryFilter(cc => !cc.DeletedDate.HasValue);
        }
    }
}
