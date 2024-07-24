namespace MultiShop.Data
{
    public class MultiShopContext : DbContext
    {
        //db context connection bilgilerini dışarıdan (bu class veya proje dışından) erişilebilir hale getirdik.
        //configuration dosyasından (appsettings.json, program.cs den veya bu class tan connection bağlantısı kurabiliriz.)
        //publishment için en uygunu json dosyasından bağlantı vermektir. json dosyasına girdiğimiz bilgileri düzenlediğimizde tekrar
        // publish etmemize gerek yoktur. çünkü json dosyası fiziksel bir dosyadır. Hard code yerine dinamik yapmış oluyoruz.
        public MultiShopContext(DbContextOptions<MultiShopContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductComment> ProductComments { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) // extension method yapacağız
        {
            // entity configuration larının uygulamaya alındığı tetiklendiği yer(extension çağırılıyor);
            modelBuilder.ConfigurationExtension();
            modelBuilder.CreateDummyDataExtension();
        }
        
    }
}
