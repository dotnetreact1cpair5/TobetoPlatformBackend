using Core.Entities.Concrete;
using Core.Security.Hashing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users").HasKey(b => b.Id);
            builder.Property(u => u.FirstName).HasColumnName("FirstName");
            builder.Property(u => u.LastName).HasColumnName("LastName").IsRequired();
            builder.Property(u => u.Email).HasColumnName("Email").IsRequired();
            builder.Property(u => u.Status).HasColumnName("Status").IsRequired();
            builder.HasIndex(indexExpression: u => u.Email, name: "UK_Users_Email").IsUnique();
          
            builder.HasQueryFilter(u => !u.DeletedDate.HasValue);

        }
        private IEnumerable<User> getSeeds()
        {
            List<User> users = new();

            HashingHelper.CreatePasswordHash(
                password: "admin",
                passwordHash: out byte[] passwordHash,
                passwordSalt: out byte[] passwordSalt
            );
            User adminUser =
                new()
                {
                    Id = 1,
                    FirstName = "admin",
                    LastName = "admin",
                    Email = "admin@admin.com",
                    Status = true,
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt
                };
            users.Add(adminUser);

            return users.ToArray();
        }
    }
}
