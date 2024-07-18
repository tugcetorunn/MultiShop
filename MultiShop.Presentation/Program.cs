using Microsoft.EntityFrameworkCore;
using MultiShop.Data;
using MultiShop.Presentation.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // controller ve view leri görebilmesi için

builder.Services.AddDbContext<MultiShopContext>(options => options
                                                           .UseSqlServer(builder.Configuration
                                                           .GetConnectionString("MultiShopConnection")
                                                           ,b => b.MigrationsAssembly("MultiShop.Presentation")));
                                                           // db connection edilmesi için

builder.ServiceExtension(); // ICategoryService gönderdiðimizde bizi CategoryService e götürmesi için yazýlan scope metodlarýn
                            // extension metodunu çalýþtýrdýðýmýz yer

// automapper extension metodunu çalýþtýrdýðýmýz yer
builder.Services.AddAutoMapperProfiles();

var app = builder.Build();

app.UseRouting(); // route u eklemeden önce yazýyoruz

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}"); // route olmazsa olmaz

app.UseStaticFiles(); // wwwroot dosyasýný aktif hale getirmemiz için

app.Run();

// projemizin ayaða kalktýðý yer. 