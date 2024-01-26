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
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Accounts").HasKey(b => b.Id);
            builder.Property(a => a.FirstName).HasColumnName("FirstName").IsRequired();
            builder.Property(a => a.LastName).HasColumnName("LastName").IsRequired();
            builder.Property(a => a.NationalId).HasColumnName("NationalId").IsRequired();
            builder.Property(a => a.Email).HasColumnName("Email").IsRequired();
            builder.Property(a => a.BirthDate).HasColumnName("BirthDate").IsRequired();
            builder.Property(a => a.PhoneNumber).HasColumnName("PhoneNumber").IsRequired();
            builder.Property(a => a.Address).HasColumnName("Address").IsRequired();
            builder.Property(a => a.Description).HasColumnName("Description");
            builder.Property(a => a.CountryId).HasColumnName("CountryId");
            builder.Property(a => a.CityId).HasColumnName("CityId");
            builder.Property(a => a.DistrictId).HasColumnName("DistrictId");
            builder.HasIndex(indexExpression: a => a.NationalId, name: "UK_Accounts_NationalId").IsUnique();
            builder.HasQueryFilter(a => !a.DeletedDate.HasValue);

            builder.HasOne(a => a.City)
    .WithOne(b => b.Account)
    .HasForeignKey<Account>(b => b.CityId)
    .IsRequired()
    .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(a => a.Country)
                .WithOne(b => b.Account)
                .HasForeignKey<Account>(b => b.CountryId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(a => a.District)
                .WithOne(b => b.Account)
                .HasForeignKey<Account>(b => b.DistrictId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
