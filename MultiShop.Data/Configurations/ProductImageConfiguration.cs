using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Data.Configurations
{
    public class ProductImageConfiguration : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.HasKey(p => p.ProductImageId);
            builder.Property(p => p.ProductImageId)
                   .ValueGeneratedOnAdd();
            builder.Property(p => p.Image)
                   .IsRequired();
            builder.HasOne(p => p.Product)
                   .WithMany(p => p.ProductImages)
                   .HasForeignKey(p => p.ProductId);

        }
    }
}
