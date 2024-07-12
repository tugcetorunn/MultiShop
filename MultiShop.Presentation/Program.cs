var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // controller ve view leri görebilmesi için

var app = builder.Build();

app.UseRouting(); // route u eklemeden önce yazýyoruz

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}"); // route olmazsa olmaz

app.UseStaticFiles(); // wwwroot dosyasýný aktif hale getirmemiz için

app.Run();

// projemizin ayaða kalktýðý yer. 