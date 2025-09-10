using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TareaEF1.Entities;

namespace TareaEF1.Configurations
{
    public class CategoriesPollsConfiguration : IEntityTypeConfiguration<CategoriesPolls>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CategoriesPolls> builder)
        {
            builder.ToTable("categories_polls");
            builder.HasKey(cp => cp.Id);
            builder.Property(cp => cp.Name)
                   .IsRequired()
                   .HasMaxLength(80);
            builder.HasIndex(cp => cp.Name)
                   .IsUnique();
        }
    }
}