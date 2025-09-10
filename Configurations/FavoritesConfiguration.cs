using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TareaEF1.Entities;

namespace TareaEF1.Configurations
{
    public class FavoritesConfiguration : IEntityTypeConfiguration<Favorites>
    {
        public void Configure(EntityTypeBuilder<Favorites> builder)
        {
            builder.ToTable("favorites");
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Id).IsRequired().HasColumnName("id");
            builder.Property(f => f.CustomerId).IsRequired().HasColumnName("customer_id");
            builder.Property(f => f.CompanyId).IsRequired().HasMaxLength(20).HasColumnName("company_id");

            builder.HasOne<Customers>()
                   .WithMany()
                   .HasForeignKey(f => f.CustomerId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Companies>()
                   .WithMany()
                   .HasForeignKey(f => f.CompanyId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}