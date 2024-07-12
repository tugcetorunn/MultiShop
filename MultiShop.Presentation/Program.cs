var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // controller ve view leri g�rebilmesi i�in

var app = builder.Build();

app.UseRouting(); // route u eklemeden �nce yaz�yoruz

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}"); // route olmazsa olmaz

app.UseStaticFiles(); // wwwroot dosyas�n� aktif hale getirmemiz i�in

app.Run();

// projemizin aya�a kalkt��� yer. 