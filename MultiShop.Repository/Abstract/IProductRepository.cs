
namespace MultiShop.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        Product? GetProductWithInclude(int id);
        List<Product> Get4ProductsByCategory(int id);
        List<Product> GetAllProductsByCategory(int id);
        List<Product> Get8ProductsByShowPlace(ShowPlace showPlace);
    }
}
