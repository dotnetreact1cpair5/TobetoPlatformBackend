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
    public class DistrictConfiguration:IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.ToTable("Districts").HasKey(d => d.Id);
            builder.Property(d => d.Id).HasColumnName("Id").IsRequired();
            builder.Property(d => d.CityId).HasColumnName("CityId").IsRequired();
            builder.Property(d => d.Name).HasColumnName("Name").IsRequired();
            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);

            builder.HasOne(d => d.City)
                .WithMany(city => city.Districts)
                .HasForeignKey(d => d.CityId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
