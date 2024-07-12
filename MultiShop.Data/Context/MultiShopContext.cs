using Microsoft.EntityFrameworkCore;
using MultiShop.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Data
{
    public class MultiShopContext : DbContext
    {
        public MultiShopContext(DbContextOptions<MultiShopContext> options) : base(options)
        //db context connection bilgilerini dışarıdan (bu class veya proje dışından) erişilebilir hale getirdik.
        //configuration dosyasından (appsettings.json, program.cs den veya bu class tan connection bağlantısı kurabiliriz.)
        //publishment için en uygunu json dosyasından bağlantı vermektir.
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // entity configuration larının uygulamaya alındığı tetiklendiği yer;
            modelBuilder.ApplyConfiguration(new CategoryConfiguration()); 
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("name=MultiShopConnection", b => b.MigrationsAssembly("MultiShop.Presentation"));
        //}
    }
}
