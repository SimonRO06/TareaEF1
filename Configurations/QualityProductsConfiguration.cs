using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TareaEF1.Entities;

namespace TareaEF1.Configurations
{
    public class QualityProductsConfiguration : IEntityTypeConfiguration<QualityProducts>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<QualityProducts> builder)
        {
            builder.ToTable("quality_products");
            builder.HasKey(qp => new { qp.ProductId, qp.CustomerId, qp.PollId, qp.CompanyId });
            builder.Property(qp => qp.DateRating)
                   .IsRequired()
                   .HasColumnType("DATETIME")
                   .HasDefaultValueSql("CURRENT_TIMESTAMP")
                   .HasColumnName("daterating");
            builder.Property(qp => qp.Rate)
                   .IsRequired()
                   .HasColumnType("DOUBLE")
                   .HasColumnName("rate");
            builder.HasOne<Products>()
                   .WithMany()
                   .HasForeignKey(qp => qp.ProductId)
                   .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne<Customers>()
                   .WithMany()
                   .HasForeignKey(qp => qp.CustomerId)
                   .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne<Polls>()
                   .WithMany()
                   .HasForeignKey(qp => qp.PollId)
                   .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne<Companies>()
                   .WithMany()
                   .HasForeignKey(qp => qp.CompanyId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}