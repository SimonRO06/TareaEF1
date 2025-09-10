using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TareaEF1.Entities;

namespace TareaEF1.Configurations
{
    public class BenefitsConfiguration : IEntityTypeConfiguration<Benefits>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Benefits> builder)
        {
            builder.ToTable("benefits");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).IsRequired().HasColumnName("id");
            builder.Property(b => b.Description).HasMaxLength(80).IsRequired().HasColumnName("description");
            builder.Property(b => b.Detail).HasColumnType("TEXT").IsRequired().HasColumnName("detail");
        }
    }
}