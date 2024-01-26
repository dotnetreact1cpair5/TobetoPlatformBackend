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
    public class AccountForeignLanguageConfiguration : IEntityTypeConfiguration<AccountForeignLanguage>
    {
        public void Configure(EntityTypeBuilder<AccountForeignLanguage> builder)
        {
            builder.ToTable("AccountForeignLanguages").HasKey(af => af.Id);
            builder.Property(af => af.Id).HasColumnName("Id").IsRequired();
            builder.Property(af => af.AccountId).HasColumnName("AccountId").IsRequired();
            builder.HasQueryFilter(af => !af.DeletedDate.HasValue);
            builder.HasOne(a => a.Account)
.WithMany(city => city.AccountForeignLanguages)
.HasForeignKey(d => d.AccountId)
.IsRequired()
.OnDelete(DeleteBehavior.NoAction);
        }
    }
}
