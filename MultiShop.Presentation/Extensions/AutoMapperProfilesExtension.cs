namespace MultiShop.Presentation.Extensions
{
    public static class AutoMapperProfilesExtension
    {
        public static void AddAutoMapperProfiles(this IServiceCollection services) 
        {
            // 5. işlem
            // AutoMapper ı initialize ediyoruz.
            // Son işlem mapleme sonucu oluşturduğumuz dto ları kullanmak -> service lerde
            services.AddAutoMapper(typeof(SliderMappingProfile));
            services.AddAutoMapper(typeof(CategoryMappingProfile));
            services.AddAutoMapper(typeof(ProductMappingProfile));
            services.AddAutoMapper(typeof(ProductCommentMappingProfile));
        }
    }
}
