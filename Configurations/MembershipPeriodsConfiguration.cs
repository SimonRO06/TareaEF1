using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TareaEF1.Entities;

namespace TareaEF1.Configurations
{
    public class MembershipPeriodsConfiguration : IEntityTypeConfiguration<MembershipPeriods>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<MembershipPeriods> builder)
        {
            builder.ToTable("MembershipPeriods");
            builder.HasKey(mp => mp.Id);
            builder.Property(mp => mp.Id).IsRequired().HasColumnName("id");
            builder.Property(mp => mp.MembershipId).IsRequired().HasColumnName("membershipId");
            builder.Property(mp => mp.PeriodId).IsRequired().HasColumnName("periodId");
            builder.Property(mp => mp.Name).IsRequired().HasMaxLength(80).HasColumnName("name");
            builder.Property(mp => mp.Description).IsRequired().HasColumnName("description");
            builder.Property(mp => mp.Price).IsRequired().HasColumnType("decimal(18,2)").HasColumnName("price");
            builder.Property(mp => mp.CompanyId).IsRequired().HasMaxLength(20).HasColumnName("companyId");

            builder.HasOne<Memberships>().WithMany().HasForeignKey(mp => mp.MembershipId);
            builder.HasOne<Periods>().WithMany().HasForeignKey(mp => mp.PeriodId);
            builder.HasOne<Companies>().WithMany().HasForeignKey(mp => mp.CompanyId);
        }
    }
}