using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TareaEF1.Entities;

namespace TareaEF1.Configurations
{
    public class TypesProductsConfiguration : IEntityTypeConfiguration<TypesProducts>
    {
        public void Configure(EntityTypeBuilder<TypesProducts> builder)
        {
            builder.ToTable("types_products");

            builder.HasKey(tp => tp.Id);

            builder.Property(tp => tp.Description)
                   .IsRequired()
                   .HasMaxLength(80);

            builder.HasIndex(tp => tp.Description).IsUnique();
        }
    }
}