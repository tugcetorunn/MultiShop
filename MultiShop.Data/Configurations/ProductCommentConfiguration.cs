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
                   .HasMaxLength(100)
                   .IsRequired();
            builder.Property(p => p.CommenterEmail)
                   .HasMaxLength(100);
            builder.Property(p => p.Comment)
                   .HasMaxLength(100);
            builder.HasOne(p => p.Product)
                   .WithMany(p => p.ProductComments)
                   .HasForeignKey(p => p.ProductId);

        }
    }
}
