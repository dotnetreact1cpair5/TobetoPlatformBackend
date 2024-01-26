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
    public class AccountSkillConfiguration : IEntityTypeConfiguration<AccountSkill>
    {
        public void Configure(EntityTypeBuilder<AccountSkill> builder)
        {
            builder.ToTable("AccountSkills").HasKey(s => s.Id);
            builder.Property(s => s.Id).HasColumnName("Id").IsRequired();
            builder.Property(s => s.AccountId).HasColumnName("AccountId").IsRequired();
            builder.HasQueryFilter(s => !s.DeletedDate.HasValue);
            builder.HasOne(a => a.Account)
    .WithMany(account=>account.AccountSkills)
    .HasForeignKey(d => d.AccountId)
    .IsRequired()
    .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(a => a.Skill)
    .WithOne(b => b.AccountSkill)
    .HasForeignKey<AccountSkill>(b => b.SkillId)
    .IsRequired()
    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

