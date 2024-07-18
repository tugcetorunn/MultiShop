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
            builder.Property(p => p.ProductId)
                   .ValueGeneratedOnAdd();
            builder.Property(p => p.ProductName)
                   .IsRequired()
                   .HasMaxLength(50);
            builder.Property(p => p.Description)
                   .HasMaxLength(75)
                   .IsRequired();
            builder.Property(p => p.Detail)
                   .HasMaxLength(120);
            builder.Property(p => p.Information)
                   .HasMaxLength(180);
            builder.HasOne(p => p.Category)
                   .WithMany(p => p.Products)
                   .HasForeignKey(p => p.CategoryId);
            builder.HasMany(p => p.ProductImages)
                   .WithOne(p => p.Product)
                   .HasForeignKey(p => p.ProductId);
            builder.HasMany(p => p.ProductComments)
                   .WithOne(p => p.Product)
                   .HasForeignKey(p => p.ProductId);
            builder.Property(p => p.Price)
                   .HasColumnType("decimal(18,2)");
            builder.Property(p => p.SalePrice)
                   .HasColumnType("decimal(18,2)");
        }
    }
}
