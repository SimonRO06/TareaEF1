using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TareaEF1.Entities;

namespace TareaEF1.Configurations
{
    public class SubdivisionCategoriesConfiguration : IEntityTypeConfiguration<SubdivisionCategories>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<SubdivisionCategories> builder)
        {
            builder.ToTable("subdivisioncategories");
            builder.HasKey(sc => sc.Id);
            builder.Property(sc => sc.Id).IsRequired().HasColumnName("id");
            builder.Property(sc => sc.Description).HasMaxLength(40).IsRequired().HasColumnName("description");

            builder.HasIndex(sc => sc.Description).IsUnique();
        }
    }
}