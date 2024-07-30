
namespace MultiShop.Business
{
    public class ProductCommentService : IProductCommentService
    {
        private readonly IProductCommentRepository commentRepository;
        private readonly IMapper mapper;
        public ProductCommentService(IProductCommentRepository _commentRepository, IMapper _mapper)
        {
            commentRepository = _commentRepository;
            mapper = _mapper;
        }

        public List<ProductCommentDto> GetProductComments(int id)
        {
            var comments = commentRepository.GetProductCommentsDesc(id);
            List<ProductCommentDto> productCommentDtos = mapper.Map<List<ProductCommentDto>>(comments);
            return productCommentDtos;
        }
    }
}
