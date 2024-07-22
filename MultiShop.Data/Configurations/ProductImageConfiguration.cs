namespace MultiShop.Data.Configurations
{
    public class ProductImageConfiguration : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.HasKey(p => p.ProductImageId);
            builder.Property(p => p.Image)
                   .IsRequired();
            builder.HasOne(p => p.Product)
                   .WithMany(p => p.ProductImages)
                   .HasForeignKey(p => p.ProductId);

        }
    }
}
