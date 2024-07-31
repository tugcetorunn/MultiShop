
namespace MultiShop.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        Product? GetProductWithInclude(int id);
        List<Product> Get4ProductsByCategory(int id, int productCount);
        List<Product> GetAllProductsByCategory(int id);
        List<Product> Get8ProductsByShowPlace(ShowPlace showPlace, int productCount);
        short GetRatingAvg(int id);
    }
}
