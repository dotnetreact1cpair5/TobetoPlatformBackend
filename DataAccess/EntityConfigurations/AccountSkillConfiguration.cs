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
    public class AccountSkillConfiguration : IEntityTypeConfiguration<AccountSkill>
    {
        public void Configure(EntityTypeBuilder<AccountSkill> builder)
        {
            builder.ToTable("AccountSkills").HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("Id").IsRequired();
            builder.Property(e => e.AccountId).HasColumnName("AccountId").IsRequired();
            builder.Property(e => e.SkillId).HasColumnName("SkillId").IsRequired();
            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);

            builder.HasOne(a => a.Account)
                .WithMany(account => account.AccountSkills)
                .HasForeignKey(a => a.AccountId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(a => a.Skill)
                .WithMany()
                .HasForeignKey(a => a.SkillId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
