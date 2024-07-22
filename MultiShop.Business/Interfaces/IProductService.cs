namespace MultiShop.Business
{
    public interface IProductService
    {
        List<ProductDto> GetProducts();
        ProductDto? GetProductByCategory(int id);
        List<ProductDto> GetProductsByShowPlace(ShowPlace showPlace);
    }
}