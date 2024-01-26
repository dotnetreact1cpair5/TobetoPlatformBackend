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
    public class SkillConfiguration : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.ToTable("Skills").HasKey(s => s.Id);
            builder.Property(s => s.Id).HasColumnName("Id").IsRequired();
            builder.Property(s => s.Name).HasColumnName("Name").IsRequired();
            builder.HasQueryFilter(s => !s.DeletedDate.HasValue);
        }
    }
}
