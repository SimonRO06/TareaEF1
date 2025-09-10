using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TareaEF1.Entities;

namespace TareaEF1.Configurations
{
    public class CustomersConfiguration : IEntityTypeConfiguration<Customers>
    {
        public void Configure(EntityTypeBuilder<Customers> builder)
        {
            builder.ToTable("customers");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).IsRequired().HasColumnName("id");
            builder.Property(c => c.Name).HasMaxLength(80).IsRequired().HasColumnName("name");
            builder.Property(c => c.CountryId).HasMaxLength(6).IsRequired().HasColumnName("country_id");
            builder.Property(c => c.AudienceId).IsRequired().HasColumnName("audience_id");
            builder.Property(c => c.Cellphone).HasMaxLength(20).IsRequired().HasColumnName("cellphone");
            builder.Property(c => c.Email).HasMaxLength(100).IsRequired().HasColumnName("email");
            builder.Property(c => c.Address).HasMaxLength(120).IsRequired().HasColumnName("address");

            builder.HasIndex(c => c.Cellphone).IsUnique();
            builder.HasIndex(c => c.Email).IsUnique();

            builder.HasOne<Countries>()
                   .WithMany()
                   .HasForeignKey(c => c.CountryId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Audiences>()
                    .WithMany()
                    .HasForeignKey(c => c.AudienceId)
                    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}