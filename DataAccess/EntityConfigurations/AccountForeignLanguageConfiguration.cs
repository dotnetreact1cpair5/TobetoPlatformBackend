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
    public class AccountForeignLanguageConfiguration : IEntityTypeConfiguration<AccountForeignLanguage>
    {
        public void Configure(EntityTypeBuilder<AccountForeignLanguage> builder)
        {
            builder.ToTable("AccountForeignLanguages").HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("Id").IsRequired();
            builder.Property(e => e.AccountId).HasColumnName("AccountId").IsRequired();
            builder.Property(e => e.ForeignLanguageId).HasColumnName("ForeignLanguageId").IsRequired();
            builder.Property(e => e.ForeignLanguageLevelId).HasColumnName("ForeignLanguageLevelId").IsRequired();
            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);

            builder.HasOne(a => a.Account)
                .WithMany(account => account.AccountForeignLanguages)
                .HasForeignKey(a => a.AccountId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(a => a.ForeignLanguage)
                .WithMany()
                .HasForeignKey(a => a.ForeignLanguageId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(a => a.ForeignLanguageLevel)
                .WithMany()
                .HasForeignKey(a => a.ForeignLanguageLevelId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
