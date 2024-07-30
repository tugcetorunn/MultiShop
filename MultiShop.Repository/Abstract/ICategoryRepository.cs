
namespace MultiShop.Repository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        List<Category> GetCategoriesWithProducts();
    }
}
