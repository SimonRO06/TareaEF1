using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TareaEF1.Entities;

namespace TareaEF1.Configurations
{
    public class CompanyProductsConfiguration : IEntityTypeConfiguration<CompanyProducts>
    {
        public void Configure(EntityTypeBuilder<CompanyProducts> builder)
        {
            builder.ToTable("company_products");

            builder.HasKey(cp => new { cp.CompanyId, cp.ProductId });
            builder.Property(cp => cp.CompanyId)
                .HasColumnName("company_id")
                .IsRequired();
                
            builder.Property(cp => cp.ProductId)
                .HasColumnName("product_id")
                .IsRequired();

            builder.Property(cp => cp.Price)
                .HasColumnName("price")
                .IsRequired();

            builder.Property(cp => cp.UnitOfMeasureId)
                .HasColumnName("unit_of_measure_id")
                .IsRequired();

            builder.HasOne<Companies>()
                .WithMany()
                .HasForeignKey(cp => cp.CompanyId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<Products>()
                .WithMany()
                .HasForeignKey(cp => cp.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<UnitOfMeasure>()
                .WithMany()
                .HasForeignKey(cp => cp.UnitOfMeasureId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}