
namespace MultiShop.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        
        public ProductRepository(MultiShopContext context) : base(context)
        {
        }

        public Product? GetProductWithInclude(int id)
        {
            return context.Products.Where(c => c.ProductId == id)
                                   .Include(p => p.ProductImages)
                                   .Include(p => p.ProductComments)
                                   .FirstOrDefault();
        }

        public List<Product> Get4ProductsByCategory(int id, int productCount)
        {
            return context.Products.Where(c => c.CategoryId == id)
                                          .Include(p => p.ProductImages)
                                          .Include(p => p.ProductComments)
                                          .Take(productCount)
                                          .ToList();
        }

        public List<Product> GetAllProductsByCategory(int id)
        {
            return context.Products.Where(c => c.CategoryId == id)
                                          .Include(p => p.ProductImages)
                                          .Include(p => p.ProductComments)
                                          .Include(p => p.Category)
                                          .ToList();
        }

        public List<Product> Get8ProductsByShowPlace(ShowPlace showPlace, int productCount)
        {
            if (showPlace == ShowPlace.Featured)
            {
                return context.Products.Where(p => p.ShowPlace == ShowPlace.Featured).Take(productCount)
                                           .Include(p => p.ProductImages).Include(p => p.ProductComments).ToList();

            }
            else
            {
                return context.Products.OrderByDescending(p => p.CreatedDate)
                                           .Include(p => p.ProductImages)
                                           .Include(p => p.ProductComments).Take(productCount)
                                           .ToList();
            }
        }

        public short GetRatingAvg(int id)
        {
            return Convert.ToInt16(context.ProductComments.Where(c => c.ProductId == id).Average(c => c.Rating));
        }

    }
}
