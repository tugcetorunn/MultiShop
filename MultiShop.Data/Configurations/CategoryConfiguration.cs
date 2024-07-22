namespace MultiShop.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories"); // tablo ismini verebiliriz. bunun için ef core relational da yüklememiz gerek.
                                           // bu tanımı yapmak zorunlu değil db nin olulturacağı plural isimden farklı
                                           // isimde olmasını istiyorsak kullanabiliriz.
            builder.HasKey(c => c.CategoryId);
            builder.Property(c => c.CategoryName)
                   .IsRequired() // bu ifadeyi burada tanımlasak da property olarak da required ekiyle tanımlanması gerek.
                   .HasMaxLength(50);

        }
    }
}
