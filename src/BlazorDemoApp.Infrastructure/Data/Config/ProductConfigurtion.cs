using BlazorDemoApp.Core.Entities.ProductAggregate;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorDemoApp.Infrastructure.Data.Config;
public class ProductConfigurtion : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Name)
               .IsRequired()
               .HasMaxLength(256);

        builder.Property(p => p.Description)
               .IsRequired()
               .HasMaxLength(1024);

        builder.Property(p => p.ImageUrl)
               .HasMaxLength(256);

        builder.Property(p => p.Price)
               .HasColumnType("money");

        builder.HasOne(p => p.Brand)
               .WithMany()
               .HasForeignKey(p => p.BrandId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(p => p.Category)
               .WithMany()
               .HasForeignKey(p => p.CategoryId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(p => p.Name)
               .IsUnique();
    }
}
