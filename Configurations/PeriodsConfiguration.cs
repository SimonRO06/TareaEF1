using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TareaEF1.Entities;

namespace TareaEF1.Configurations
{
    public class PeriodsConfiguration : IEntityTypeConfiguration<Periods>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Periods> builder)
        {
            builder.ToTable("periods");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).IsRequired().HasColumnName("id");
            builder.Property(p => p.Name).HasMaxLength(50).IsRequired().HasColumnName("name");

            builder.HasIndex(p => p.Name).IsUnique();
        }
    }
}