using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TareaEF1.Entities;

namespace TareaEF1.Configurations
{
    public class StateOrRegionConfiguration : IEntityTypeConfiguration<StateOrRegions>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<StateOrRegions> builder)
        {
            builder.ToTable("stateorregions");
            builder.HasKey(sr => sr.Code);
            builder.Property(sr => sr.Code).IsRequired().HasColumnName("code").HasMaxLength(6);
            builder.Property(sr => sr.Name).IsRequired().HasColumnName("name").HasMaxLength(60);
            builder.Property(sr => sr.CountryId).IsRequired().HasColumnName("country_id").HasMaxLength(6);
            builder.Property(sr => sr.Code3166).IsRequired().HasColumnName("code_3166").HasMaxLength(10);
            builder.Property(sr => sr.SubdivisionId).IsRequired().HasColumnName("subdivision_id").HasMaxLength(11);

            builder.HasIndex(sr => new { sr.Name, sr.Code3166 }).IsUnique();

            builder.HasOne<SubdivisionCategories>()
                   .WithMany()
                   .HasForeignKey(sr => sr.SubdivisionId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Countries>()
                   .WithMany()
                   .HasForeignKey(sr => sr.CountryId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}