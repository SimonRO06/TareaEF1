using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TareaEF1.Entities;

namespace TareaEF1.Configurations
{
    public class AudiencesConfiguration : IEntityTypeConfiguration<Audiences>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Audiences> builder)
        {
            builder.ToTable("audiences");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).IsRequired().HasColumnName("id");
            builder.Property(a => a.Description).HasMaxLength(60).IsRequired().HasColumnName("description");
        }
    }
}