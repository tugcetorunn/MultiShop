
namespace MultiShop.Presentation.Extensions
{
    public static class ServiceScopedExtension
    {
        public static void ServiceExtension(this WebApplicationBuilder webApplicationBuilder)
        {
            // ICategoryService gönderdiğimizde bizi CategoryService e götürmesi için
            webApplicationBuilder.Services.AddScoped<ICategoryService, CategoryService>();
            webApplicationBuilder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

            webApplicationBuilder.Services.AddScoped<ISliderService, SliderService>();
            webApplicationBuilder.Services.AddScoped<ISliderRepository, SliderRepository>();

            webApplicationBuilder.Services.AddScoped<IProductService, ProductService>();
            webApplicationBuilder.Services.AddScoped<IProductRepository, ProductRepository>();

            webApplicationBuilder.Services.AddScoped<IProductCommentService, ProductCommentService>();
            webApplicationBuilder.Services.AddScoped<IProductCommentRepository, ProductCommentRepository>();
        }
    }
}
