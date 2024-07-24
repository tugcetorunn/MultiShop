using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Security.Principal;

namespace MultiShop.Business
{
    public class ProductService : IProductService
    {
        private readonly MultiShopContext context;
        private readonly IMapper mapper;
        private readonly IConfiguration configuration; // indexteki featured ve recent products için kaç product tan oluşan bir liste
                                                       // oluşturacağımız bilgisini dinamik hale getirmek için appsettings dosyasına
                                                       // verdik. json dosyasını okumak için de ıconfiguration ı inject ediyoruz.
        private readonly IProductCommentService commentService;
        public ProductService(MultiShopContext _context, IMapper _mapper, IConfiguration _configuration, IProductCommentService _commentService)
        {
            context = _context;
            mapper = _mapper;
            configuration = _configuration;
            commentService = _commentService;
        }
        public List<ProductDto> GetProducts()
        {
            var products = context.Products.ToList();
            List<ProductDto> productDtos = mapper.Map<List<ProductDto>>(products);
            return productDtos;
        }
        public ProductAndCommentsDto GetProduct(int id)
        {
            var product = context.Products.Where(c => c.ProductId == id)
                                          .Include(p => p.ProductImages)
                                          .Include(p => p.ProductComments)
                                          .FirstOrDefault();
            var commentsDto = commentService.GetProductComments(id);
            ProductDto productDto = mapper.Map<ProductDto>(product);

            return ProductAndCommentsDto.Create(productDto, commentsDto);
        }
        public List<ProductDto>? GetProductsByCategory(int id)
        {
            int count = Convert.ToInt32(configuration.GetSection("ProductSettings:SimilarProductShowItemCountInDetail").Value);
            var products = context.Products.Where(c => c.CategoryId == id)
                                          .Include(p => p.ProductImages)
                                          .Include(p => p.ProductComments)
                                          .Take(count)
                                          .ToList();
            List<ProductDto> productDtos = mapper.Map<List<ProductDto>>(products);
            return productDtos;
        }
        public List<ProductDto>? GetAllProductsByCategory(int id)
        {
            var products = context.Products.Where(c => c.CategoryId == id)
                                          .Include(p => p.ProductImages)
                                          .Include(p => p.ProductComments)
                                          .ToList();
            List<ProductDto> productDtos = mapper.Map<List<ProductDto>>(products);
            return productDtos;
        }

        public List<ProductDto> GetProductsByShowPlace(ShowPlace showPlace)
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
            List<ProductDto> productDtos = mapper.Map<List<ProductDto>>(products);
            return productDtos;
        }
        public ProductDetailDto GetProductDetailAndSimilarProducts(int id)
        {
            var product = GetProduct(id);
            var similarProducts = GetProductsByCategory(product.Product.CategoryId);
            return ProductDetailDto.Create(product.Product, similarProducts);
        }
    }
}
