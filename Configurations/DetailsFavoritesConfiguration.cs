using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TareaEF1.Entities;

namespace TareaEF1.Configurations
{
    public class DetailsFavoritesConfiguration : IEntityTypeConfiguration<DetailsFavorites>
    {
        public void Configure(EntityTypeBuilder<DetailsFavorites> builder)
        {
            builder.ToTable("details_favorites");

            builder.HasKey(df => df.Id);

            builder.Property(df => df.FavoriteId)
                .HasColumnName("favorite_id")
                .IsRequired();

            builder.Property(df => df.ProductId)
                .HasColumnName("product_id")
                .IsRequired();

            builder.HasOne<Favorites>()
                .WithMany()
                .HasForeignKey(df => df.FavoriteId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<Products>()
                .WithMany()
                .HasForeignKey(df => df.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}