namespace MultiShop.Data.Configurations
{
    public class SliderConfiguration : IEntityTypeConfiguration<Slider>
    {
        public void Configure(EntityTypeBuilder<Slider> builder)
        {
            builder.HasKey(s => s.SliderId);
            builder.Property(s => s.Header)
                   .IsRequired() 
                   .HasMaxLength(50);
            builder.Property(s => s.Content)
                   .HasMaxLength(70)
                   .IsRequired();
            builder.Property(s => s.Image)
                   .IsRequired();
            builder.Property(s => s.Position)
                   .IsRequired();

        }
    }
}
