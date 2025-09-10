using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TareaEF1.Entities;

namespace TareaEF1.Configurations
{
    public class ProductsConfiguration : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(60);
            builder.Property(p => p.Detail).IsRequired();
            builder.Property(p => p.Price).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(p => p.Image).HasMaxLength(80);

            builder.HasOne<TypesProducts>()
                   .WithMany()
                   .HasForeignKey(p => p.TypeProductId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}