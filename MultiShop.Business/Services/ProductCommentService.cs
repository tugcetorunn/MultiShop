using System.Collections.Generic;

namespace MultiShop.Business
{
    public class ProductCommentService : IProductCommentService
    {
        private readonly MultiShopContext context;
        private readonly IMapper mapper;
        public ProductCommentService(MultiShopContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }

        public List<ProductCommentDto> GetProductComments()
        {
            var comments = context.ProductComments.ToList();
            List<ProductCommentDto> productCommentDtos = mapper.Map<List<ProductCommentDto>>(comments);
            return productCommentDtos;
        }
    }
}
