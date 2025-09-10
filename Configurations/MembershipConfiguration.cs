using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TareaEF1.Entities;

namespace TareaEF1.Configurations
{
    public class MembershipConfiguration : IEntityTypeConfiguration<Memberships>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Memberships> builder)
        {
            builder.ToTable("memberships");
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).IsRequired().HasColumnName("id");
            builder.Property(m => m.Name).HasMaxLength(100).IsRequired().HasColumnName("name");
            builder.Property(m => m.Description).HasColumnType("TEXT").IsRequired().HasColumnName("description");

            builder.HasIndex(m => m.Name).IsUnique();
        }
    }
}