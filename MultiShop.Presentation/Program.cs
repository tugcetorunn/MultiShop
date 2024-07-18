using Microsoft.EntityFrameworkCore;
using MultiShop.Data;
using MultiShop.Presentation.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // controller ve view leri g�rebilmesi i�in

builder.Services.AddDbContext<MultiShopContext>(options => options
                                                           .UseSqlServer(builder.Configuration
                                                           .GetConnectionString("MultiShopConnection")
                                                           ,b => b.MigrationsAssembly("MultiShop.Presentation")));
                                                           // db connection edilmesi i�in

builder.ServiceExtension(); // ICategoryService g�nderdi�imizde bizi CategoryService e g�t�rmesi i�in yaz�lan scope metodlar�n
                            // extension metodunu �al��t�rd���m�z yer

// automapper extension metodunu �al��t�rd���m�z yer
builder.Services.AddAutoMapperProfiles();

var app = builder.Build();

app.UseRouting(); // route u eklemeden �nce yaz�yoruz

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}"); // route olmazsa olmaz

app.UseStaticFiles(); // wwwroot dosyas�n� aktif hale getirmemiz i�in

app.Run();

// projemizin aya�a kalkt��� yer. 