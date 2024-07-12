using Microsoft.EntityFrameworkCore;
using MultiShop.Business;
using MultiShop.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // controller ve view leri görebilmesi için

builder.Services.AddDbContext<MultiShopContext>(options => options
                                                           .UseSqlServer(builder.Configuration
                                                           .GetConnectionString("MultiShopConnection")
                                                           ,b => b.MigrationsAssembly("MultiShop.Presentation")));
                                                           // db connection edilmesi için

builder.Services.AddScoped<ICategoryService,CategoryService>(); // ICategoryService gönderdiðimizde bizi CategoryService e götürmesi için
builder.Services.AddScoped<ISliderService,SliderService>(); 

var app = builder.Build();

app.UseRouting(); // route u eklemeden önce yazýyoruz

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}"); // route olmazsa olmaz

app.UseStaticFiles(); // wwwroot dosyasýný aktif hale getirmemiz için

app.Run();

// projemizin ayaða kalktýðý yer. 