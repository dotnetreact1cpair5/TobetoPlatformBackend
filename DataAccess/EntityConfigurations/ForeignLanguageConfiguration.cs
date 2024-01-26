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
    public class ForeignLanguageConfiguration : IEntityTypeConfiguration<ForeignLanguage>
    {
        public void Configure(EntityTypeBuilder<ForeignLanguage> builder)
        {
            builder.ToTable("ForeignLanguages").HasKey(fl => fl.Id);
            builder.Property(fl => fl.Id).HasColumnName("Id").IsRequired();
            builder.Property(fl => fl.Name).HasColumnName("Name");
            builder.HasQueryFilter(fl => !fl.DeletedDate.HasValue);
        }
    }
}
