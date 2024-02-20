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
    public class AccountQuestionSetConfiguration : IEntityTypeConfiguration<AccountQuestionSet>
    {
        public void Configure(EntityTypeBuilder<AccountQuestionSet> builder)
        {
            builder.ToTable("AccountQuestionSet").HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("Id").IsRequired();
            builder.Property(e => e.AccountId).HasColumnName("AccountId").IsRequired();
            builder.Property(e => e.QuestionSetId).HasColumnName("QuestionSetId").IsRequired();
            builder.Property(e => e.Status).HasColumnName("Status").IsRequired();
            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);

            builder.HasOne(a => a.Account)
                .WithMany(account => account.AccountQuestionSets)
                .HasForeignKey(a => a.AccountId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(a => a.QuestionSet)
                .WithMany()
                .HasForeignKey(a => a.QuestionSetId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
