using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations
{
    public class ApplicationConfiguration : IEntityTypeConfiguration<Application>
    {
        public void Configure(EntityTypeBuilder<Application> builder)
        {
            builder.ToTable("Applications").HasKey(a => a.Id);
            builder.Property(a => a.Id).HasColumnName("Id").IsRequired();
            builder.Property(a => a.OrganizationId).HasColumnName("OrganizationId");
            builder.Property(a => a.DocumentName).HasColumnName("DocumentName");
            builder.Property(a => a.ApplicationStepId).HasColumnName("ApplicationStepId");
            builder.Property(a => a.Title).HasColumnName("Title");

            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);
      

        }
    }
}
