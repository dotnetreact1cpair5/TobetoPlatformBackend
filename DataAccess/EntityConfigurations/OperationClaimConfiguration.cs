﻿using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations
{
    public class OperationClaimConfiguration : IEntityTypeConfiguration<OperationClaim>
    {
        public void Configure(EntityTypeBuilder<OperationClaim> builder)
        {
            builder.ToTable("OperationClaims").HasKey(o => o.Id);
            builder.Property(op => op.Id).HasColumnName("Id").IsRequired();
            builder.Property(op => op.Name).HasColumnName("Name").IsRequired();
            builder.HasMany(op => op.UserOperationClaims);

            builder.HasQueryFilter(c => !c.DeletedDate.HasValue);
        }
    }
}
