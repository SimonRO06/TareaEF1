using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TareaEF1.Entities;

namespace TareaEF1.Configurations
{
    public class CompaniesConfiguration : IEntityTypeConfiguration<Companies>
    {
        public void Configure(EntityTypeBuilder<Companies> builder)
        {
            builder.ToTable("companies");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).IsRequired().HasColumnName("id").HasMaxLength(20);
            builder.Property(c => c.TypeId).IsRequired().HasColumnName("type_id");
            builder.Property(c => c.Name).IsRequired().HasColumnName("name").HasMaxLength(80);
            builder.Property(c => c.CategoryId).IsRequired().HasColumnName("category_id");
            builder.Property(c => c.CountryId).IsRequired().HasColumnName("country_id").HasMaxLength(6);
            builder.Property(c => c.AudienceId).IsRequired().HasColumnName("audience_id");
            builder.Property(c => c.Cellphone).IsRequired().HasColumnName("cellphone").HasMaxLength(15);
            builder.Property(c => c.Email).IsRequired().HasColumnName("email").HasMaxLength(80);

            builder.HasIndex(c => c.Cellphone).IsUnique();
            builder.HasIndex(c => c.Email).IsUnique();

            builder.HasOne<TypesIdentifications>()
                   .WithMany()
                   .HasForeignKey(c => c.TypeId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Categories>()
                   .WithMany()
                   .HasForeignKey(c => c.CategoryId)
                   .OnDelete(DeleteBehavior.Restrict);

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