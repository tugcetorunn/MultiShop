
namespace MultiShop.Business
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper mapper;
        private readonly IProductCommentService commentService;
        public ProductService(IProductRepository _productRepository, IMapper _mapper, IProductCommentService _commentService)
        {
            productRepository = _productRepository;
            mapper = _mapper;
            commentService = _commentService;
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
            var products = productRepository.Get4ProductsByCategory(id);
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
            var products = productRepository.Get8ProductsByShowPlace(showPlace);
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
