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
    public class AccountAnswerConfiguration : IEntityTypeConfiguration<AccountAnswer>
    {
        public void Configure(EntityTypeBuilder<AccountAnswer> builder)
        {
            builder.ToTable("AccountAnswers").HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("Id").IsRequired();
            builder.Property(e => e.AccountId).HasColumnName("AccountId").IsRequired();
            builder.Property(e => e.AnswerId).HasColumnName("AnswerId").IsRequired();
            builder.Property(e => e.QuestionId).HasColumnName("QuestionId").IsRequired();
            builder.Property(e => e.QuestionSetId).HasColumnName("QuestionSetId").IsRequired();
            builder.Property(e => e.IsCorrect).HasColumnName("IsCorrect").IsRequired();
            builder.Property(e => e.IsIncorrect).HasColumnName("IsIncorrect");
            builder.Property(e => e.IsEmpty).HasColumnName("IsEmpty");
            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);

            builder.HasOne(a => a.Account)
                .WithMany(account => account.AccountAnswers)
                .HasForeignKey(a => a.AccountId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(a => a.Answer)
                .WithMany()
                .HasForeignKey(a => a.AnswerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(a => a.Question)
                .WithMany()
                .HasForeignKey(a => a.QuestionId)
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
