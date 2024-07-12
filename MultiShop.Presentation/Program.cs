using Microsoft.EntityFrameworkCore;
using MultiShop.Business.Services;
using MultiShop.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // controller ve view leri g�rebilmesi i�in

builder.Services.AddDbContext<MultiShopContext>(options => options
                                                           .UseSqlServer(builder.Configuration
                                                           .GetConnectionString("MultiShopConnection")
                                                           ,b => b.MigrationsAssembly("MultiShop.Presentation")));
                                                           // db connection edilmesi i�in

builder.Services.AddScoped<ICategoryService,CategoryService>(); // ICategoryService g�nderdi�imizde bizi CategoryService e g�t�rmesi i�in

var app = builder.Build();

app.UseRouting(); // route u eklemeden �nce yaz�yoruz

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}"); // route olmazsa olmaz

app.UseStaticFiles(); // wwwroot dosyas�n� aktif hale getirmemiz i�in

app.Run();

// projemizin aya�a kalkt��� yer. 