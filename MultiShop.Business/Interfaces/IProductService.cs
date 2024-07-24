namespace MultiShop.Business
{
    public interface IProductService
    {
        List<ProductDto> GetProducts();
        ProductAndCommentsDto? GetProduct(int id);
        List<ProductDto>? GetProductsByCategory(int id);
        List<ProductDto> GetProductsByShowPlace(ShowPlace showPlace);
        ProductDetailDto GetProductDetailAndSimilarProducts(int id);
    }
}