namespace MultiShop.Data.Extensions
{
    public static class EntityConfigurationsExtension
    {
        public static void ConfigurationExtension(this ModelBuilder modelBuilder) 
        {
            // entity configuration larının uygulamaya alındığı tetiklendiği yer;
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new SliderConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductImageConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCommentConfiguration());
        }
    }
}
