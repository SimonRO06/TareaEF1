using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TareaEF1.Entities;

namespace TareaEF1.Configurations
{
    public class TypesIdentificationsConfiguration : IEntityTypeConfiguration<TypesIdentifications>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TypesIdentifications> builder)
        {
            builder.ToTable("typesidentifications");
            builder.HasKey(ti => ti.Id);
            builder.Property(ti => ti.Id).IsRequired().HasColumnName("id");
            builder.Property(ti => ti.Description).HasMaxLength(60).IsRequired().HasColumnName("description");
            builder.Property(ti => ti.Sufix).HasMaxLength(5).IsRequired().HasColumnName("sufix");

            builder.HasIndex(ti => new { ti.Description, ti.Sufix }).IsUnique();
        }
    }
}