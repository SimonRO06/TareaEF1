using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TareaEF1.Entities;

namespace TareaEF1.Configurations
{
    public class CountriesConfiguration : IEntityTypeConfiguration<Countries>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Countries> builder)
        {
            builder.ToTable("countries");
            builder.HasKey(c => c.IsoCode);
            builder.Property(c => c.IsoCode).HasMaxLength(6).IsRequired().HasColumnName("isocode");
            builder.Property(c => c.Name).HasMaxLength(50).IsRequired().HasColumnName("name");
            builder.Property(c => c.AlfaIsoTwo).HasMaxLength(2).IsRequired().HasColumnName("alfaisotwo");
            builder.Property(c => c.AlfaIsoThree).HasMaxLength(4).IsRequired().HasColumnName("alfaisothree");

            builder.HasIndex(p => new { p.Name, p.AlfaIsoTwo, p.AlfaIsoThree }).IsUnique();
        }
    }
}