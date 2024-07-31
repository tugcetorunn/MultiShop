
namespace MultiShop.Business
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper mapper;
        private readonly IProductCommentService commentService;
        private readonly IConfiguration configuration; // indexteki featured ve recent products için kaç product tan oluşan bir liste
                                                       // oluşturacağımız bilgisini dinamik hale getirmek için appsettings dosyasına
                                                       // verdik. json dosyasını okumak için de ıconfiguration ı inject ediyoruz.
        public ProductService(IProductRepository _productRepository, IMapper _mapper, IProductCommentService _commentService, IConfiguration _configuration)
        {
            productRepository = _productRepository;
            mapper = _mapper;
            commentService = _commentService;
            configuration = _configuration;
        }
        public List<ProductDto> GetProducts()
        {
            var products = productRepository.GetAllAsNoTracking();
            List<ProductDto> productDtos = mapper.Map<List<ProductDto>>(products);
            return productDtos;
        }
        public ProductAndCommentsDto GetProduct(int id)
        {
            var product = productRepository.GetProductWithInclude(id);
            var commentsDto = commentService.GetProductComments(id);
            ProductDto productDto = mapper.Map<ProductDto>(product);

            return ProductAndCommentsDto.Create(productDto, commentsDto);
        }
        public List<ProductDto>? GetProductsByCategory(int id)
        {
            int count = Convert.ToInt32(configuration.GetSection("ProductSettings:SimilarProductShowItemCountInDetail").Value);
            var products = productRepository.Get4ProductsByCategory(id, count);
            List<ProductDto> productDtos = mapper.Map<List<ProductDto>>(products);
            return productDtos;
        }
        public List<ProductDto>? GetAllProductsByCategory(int id)
        {
            var products = productRepository.GetAllProductsByCategory(id);
            List<ProductDto> productDtos = mapper.Map<List<ProductDto>>(products);
            return productDtos;
        }

        public List<ProductDto> GetProductsByShowPlace(ShowPlace showPlace)
        {
            int count = Convert.ToInt32(configuration.GetSection("ProductSettings:ProductShowItemCountInIndex").Value);
            /*int prCount = count != null ? count : 8;*/ // yukarıdaki ifade null gelirse count ı 8 say dedik. 
            var products = productRepository.Get8ProductsByShowPlace(showPlace, count);
            List<ProductDto> productDtos = mapper.Map<List<ProductDto>>(products);
            return productDtos;
        }

        public ProductDetailDto GetProductDetailAndSimilarProducts(int id)
        {
            var product = GetProduct(id);
            var similarProducts = GetProductsByCategory(product.Product.CategoryId);

            product.RatingAvg = productRepository.GetRatingAvg(id); // view de şimdilik bunu sadece detail sayfasına uyguladık.
                                                                    // diğer sayfalara da uygulayabilmek için metodların productDetailDto
                                                                    // tipinde olması veya çağırması gerekiyor. ileride yapacağız.

            return ProductDetailDto.Create(product.Product, similarProducts);
        }
    }
}
