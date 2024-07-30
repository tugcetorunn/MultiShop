
namespace MultiShop.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly IConfiguration configuration; // indexteki featured ve recent products için kaç product tan oluşan bir liste
                                                       // oluşturacağımız bilgisini dinamik hale getirmek için appsettings dosyasına
                                                       // verdik. json dosyasını okumak için de ıconfiguration ı inject ediyoruz.
        public ProductRepository(MultiShopContext context, IConfiguration _configuration) : base(context)
        {
            configuration = _configuration;
        }

        public Product? GetProductWithInclude(int id)
        {
            return context.Products.Where(c => c.ProductId == id)
                                   .Include(p => p.ProductImages)
                                   .Include(p => p.ProductComments)
                                   .FirstOrDefault();
        }

        public List<Product> Get4ProductsByCategory(int id)
        {
            int count = Convert.ToInt32(configuration.GetSection("ProductSettings:SimilarProductShowItemCountInDetail").Value);
            var products = context.Products.Where(c => c.CategoryId == id)
                                          .Include(p => p.ProductImages)
                                          .Include(p => p.ProductComments)
                                          .Take(count)
                                          .ToList();
            return products;
        }

        public List<Product> GetAllProductsByCategory(int id)
        {
            return context.Products.Where(c => c.CategoryId == id)
                                          .Include(p => p.ProductImages)
                                          .Include(p => p.ProductComments)
                                          .Include(p => p.Category)
                                          .ToList();
        }

        public List<Product> Get8ProductsByShowPlace(ShowPlace showPlace)
        {
            List<Product> products = new List<Product>();

            int count = Convert.ToInt32(configuration.GetSection("ProductSettings:ProductShowItemCountInIndex").Value);
            /*int prCount = count != null ? count : 8;*/ // yukarıdaki ifade null gelirse count ı 8 say dedik. 

            if (showPlace == ShowPlace.Featured)
            {
                products = context.Products.Where(p => p.ShowPlace == ShowPlace.Featured).Take(count)
                                           .Include(p => p.ProductImages).Include(p => p.ProductComments).ToList();

            }
            else
            {
                products = context.Products.OrderByDescending(p => p.CreatedDate)
                                           .Include(p => p.ProductImages)
                                           .Include(p => p.ProductComments).Take(count)
                                           .ToList();
            }

            return products;
        }

        
    }
}
