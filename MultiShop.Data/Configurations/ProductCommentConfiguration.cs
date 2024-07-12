using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Data.Configurations
{
    public class ProductCommentConfiguration : IEntityTypeConfiguration<ProductComment>
    {
        public void Configure(EntityTypeBuilder<ProductComment> builder)
        {
            builder.HasKey(p => p.ProductCommentId);
            builder.Property(p => p.Rating)
                   .IsRequired();
            builder.Property(p => p.CommenterName)
                   .HasMaxLength(50)
                   .IsRequired();
            builder.Property(p => p.CommenterEmail)
                   .HasMaxLength(50);
            builder.Property(p => p.Comment)
                   .HasMaxLength(200);
            builder.HasOne(p => p.Product)
                   .WithMany(p => p.ProductComments)
                   .HasForeignKey(p => p.ProductId);

        }
    }
}
