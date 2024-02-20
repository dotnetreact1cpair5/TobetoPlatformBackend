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
    public class QuestionSetConfiguration : IEntityTypeConfiguration<QuestionSet>
    {
        public void Configure(EntityTypeBuilder<QuestionSet> builder)
        {
            builder.ToTable("QuestionSets").HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
            builder.Property(c => c.Name).HasColumnName("Name").IsRequired();
            builder.Property(c => c.Name).HasColumnName("Description").IsRequired();
            builder.Property(c => c.Name).HasColumnName("Duration").IsRequired();
            builder.Property(c => c.Name).HasColumnName("TotalQuestion").IsRequired();
            builder.Property(c => c.Name).HasColumnName("Type").IsRequired();
            builder.Property(c => c.Name).HasColumnName("Status").IsRequired();
            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);
        }
    }
}
