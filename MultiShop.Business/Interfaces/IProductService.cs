using MultiShop.Data;

namespace MultiShop.Business
{
    public interface IProductService
    {
        Product? GetProductByCategory(int id);
        List<Product> GetProducts();
    }
}