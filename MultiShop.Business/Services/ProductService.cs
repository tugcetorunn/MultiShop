namespace MultiShop.Business
{
    public class ProductService : IProductService
    {
        private readonly MultiShopContext context;
        private readonly IMapper mapper;
        public ProductService(MultiShopContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }
        public List<ProductDto> GetProducts()
        {
            var products = context.Products.ToList();
            List<ProductDto> productDtos = mapper.Map<List<ProductDto>>(products);
            return productDtos;
        }

        public ProductDto? GetProductByCategory(int id)
        {
            var product = context.Products.Where(c => c.CategoryId == id).Include(p => p.ProductImages).Include(p => p.ProductImages).
                FirstOrDefault();
            ProductDto productDto = mapper.Map<ProductDto>(product);
            return productDto;
        }

        public List<ProductDto> GetProductsByShowPlace(ShowPlace showPlace)
        {
            List<Product> products = new List<Product>();

            if (showPlace == ShowPlace.Featured)
            {
                products = context.Products.Where(p => p.ShowPlace == ShowPlace.Featured).Take(8)
                                           .Include(p => p.ProductImages).Include(p => p.ProductComments).ToList();

            }
            else
            {
                products = context.Products.OrderByDescending(p => p.CreatedDate)
                                           .Include(p => p.ProductImages)
                                           .Include(p => p.ProductComments).Take(8).ToList();
            }
            List<ProductDto> productDtos = mapper.Map<List<ProductDto>>(products);
            return productDtos;
        }
    }
}
