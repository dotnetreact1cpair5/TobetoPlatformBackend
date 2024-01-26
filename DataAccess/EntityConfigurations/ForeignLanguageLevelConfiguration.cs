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
    public class ForeignLanguageLevelConfiguration : IEntityTypeConfiguration<ForeignLanguageLevel>
    {
        public void Configure(EntityTypeBuilder<ForeignLanguageLevel> builder)
        {
            builder.ToTable("ForeignLanguageLevels").HasKey(fll => fll.Id);
            builder.Property(fll => fll.Id).HasColumnName("Id").IsRequired();
            builder.Property(fll => fll.Name).HasColumnName("Name").IsRequired();
            builder.HasQueryFilter(fll => !fll.DeletedDate.HasValue);
        }
    }
}
