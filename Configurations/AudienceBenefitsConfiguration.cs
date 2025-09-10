using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TareaEF1.Entities;

namespace TareaEF1.Configurations
{
    public class AudienceBenefitsConfiguration : IEntityTypeConfiguration<AudienceBenefits>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AudienceBenefits> builder)
        {
            builder.ToTable("audiencebenefits");
            builder.HasKey(ab => new { ab.AudienceId, ab.BenefitId });

            builder.Property(ab => ab.AudienceId).IsRequired().HasColumnName("audience_id");
            builder.Property(ab => ab.BenefitId).IsRequired().HasColumnName("benefit_id");

            builder.HasOne<Audiences>()
                   .WithMany()
                   .HasForeignKey(ab => ab.AudienceId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<Benefits>()
                   .WithMany()
                   .HasForeignKey(ab => ab.BenefitId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}