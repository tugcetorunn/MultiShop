

namespace MultiShop.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(MultiShopContext context) : base(context)
        {
            // bir class ı base alıyorsak oradaki constructor ı da çağırmamız gerekir. bu sayede basedeki context i kullanmış oluyoruz.
            // base(context) ifadesi Repository<Category> classının constructor ını çağırır ve ona context parametresini iletir.
            // Bu işlem, CategoryRepository nin Repository<Category> class ındaki özellikleri ve metodları kullanabilmesini sağlar.
            // context in tanımlandığı yer public veya en azından protected olmalı buradan da erişmek için.
        }

        public List<Category> GetCategoriesWithProducts()
        {
            return context.Categories.Include(c => c.Products).ToList();
        }
    }
}
