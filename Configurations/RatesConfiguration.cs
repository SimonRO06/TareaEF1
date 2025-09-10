using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TareaEF1.Entities;

namespace TareaEF1.Configurations
{
    public class RatesConfiguration : IEntityTypeConfiguration<Rates>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Rates> builder)
        {
            builder.ToTable("rates");
            builder.HasKey(r => new { r.CustomerId, r.CompanyId, r.PollId });
            builder.Property(r => r.DateRating)
                   .IsRequired()
                   .HasColumnType("DATETIME")
                   .HasDefaultValueSql("CURRENT_TIMESTAMP")
                   .HasColumnName("daterating");
            builder.Property(r => r.Rate)
                   .IsRequired()
                   .HasColumnType("DOUBLE")
                   .HasColumnName("rate");
            builder.HasOne<Customers>()
                   .WithMany()
                   .HasForeignKey(r => r.CustomerId)
                   .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne<Companies>()
                   .WithMany()
                   .HasForeignKey(r => r.CompanyId)
                   .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne<Polls>()
                   .WithMany()
                   .HasForeignKey(r => r.PollId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}