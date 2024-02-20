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
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.ToTable("Answers").HasKey(d => d.Id);
            builder.Property(d => d.Id).HasColumnName("Id").IsRequired();
            builder.Property(d => d.QuestionId).HasColumnName("QuestionId").IsRequired();
            builder.Property(d => d.Name).HasColumnName("Name").IsRequired();
            builder.Property(d => d.IsCorrect).HasColumnName("IsCorrect").IsRequired();
            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);

            builder.HasOne(d => d.Question)
                .WithMany(question => question.Answers)
                .HasForeignKey(d => d.QuestionId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
