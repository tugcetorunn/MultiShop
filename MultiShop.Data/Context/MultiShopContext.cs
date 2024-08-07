namespace MultiShop.Data
{
    // projemize authorization işlemleri için (admin kullanıcı oluşturma) identity kütüphanesini entegre ediyoruz. bunun için
    // contextimiz artık DbContext ten değil IdentityDbContext ten miras alması gerekiyor. Değişiklikler olacak.
    // 1. adım Identity kütüphanesini yüklemek
    // 2. adım Context class ımızın miras aldığı class ı IdentityDbContext olarak değiştirmek ve user işlemlerinin yürütüleceği class ı
    // <> içerisine yazmak.
    //public class MultiShopContext : DbContext
    public class MultiShopContext : IdentityDbContext<ApplicationUser>
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
            // 4. adım postgresql de gerekmiyor fakar mssql kullanıyorsak identity entity leri için primary key configuration
            // edilmeis gerekiyor.
            // Temel sınıfın (IdentityDbContext) OnModelCreating metodunu çağırarak Identity tablolarının varsayılan
            // yapılandırmalarını uygular
            base.OnModelCreating(modelBuilder);
            // identity configuration larının uygulamay alındığı tetiklendiği yer
            modelBuilder.IdentityModelExtension();
            // entity configuration larının uygulamaya alındığı tetiklendiği yer(extension çağırılıyor);
            modelBuilder.ConfigurationExtension();
            // dummy data oluşturma metodlarının tetiklendiği yer
            modelBuilder.CreateDummyDataExtension();
        }
        
    }
}
