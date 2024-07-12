using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);
            builder.Property(p => p.ProductName)
                   .IsRequired()
                   .HasMaxLength(70);
            builder.Property(p => p.Description)
                   .HasMaxLength(150)
                   .IsRequired();
            builder.Property(p => p.Detail)
                   .HasMaxLength(300);
            builder.Property(p => p.Information)
                   .HasMaxLength(500);
            builder.HasOne(p => p.Category)
                   .WithMany(p => p.Products)
                   .HasForeignKey(p => p.CategoryId);
            builder.HasMany(p => p.ProductImages)
                   .WithOne(p => p.Product)
                   .HasForeignKey(p => p.ProductId);
            builder.HasMany(p => p.ProductComments)
                   .WithOne(p => p.Product)
                   .HasForeignKey(p => p.ProductId);
        }
    }
}
