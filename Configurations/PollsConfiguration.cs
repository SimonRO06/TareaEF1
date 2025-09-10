using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TareaEF1.Entities;

namespace TareaEF1.Configurations
{
    public class PollsConfiguration : IEntityTypeConfiguration<Polls>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Polls> builder)
        {
            builder.ToTable("polls");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name)
                   .IsRequired()
                   .HasMaxLength(80)
                   .HasColumnName("name");
            builder.HasIndex(p => p.Name)
                   .IsUnique();
            builder.Property(p => p.Description)
                   .IsRequired()
                   .HasColumnType("TEXT")
                   .HasColumnName("description");
            builder.Property(p => p.IsActive)
                   .IsRequired()
                   .HasColumnType("BOOLEAN");
            builder.Property(p => p.CategoryPollId)
                   .IsRequired()
                   .HasColumnName("categorypoll_id");
            builder.HasOne<CategoriesPolls>()
                   .WithMany()
                   .HasForeignKey(p => p.CategoryPollId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}