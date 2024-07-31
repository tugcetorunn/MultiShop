

namespace MultiShop.Repository
{
    public class ProductCommentRepository : Repository<ProductComment>, IProductCommentRepository
    {
        public ProductCommentRepository(MultiShopContext _context) : base(_context)
        {
        }

        public List<ProductComment> GetProductCommentsDesc(int id)
        {
            return context.ProductComments.Where(c => c.ProductId == id).OrderByDescending(c => c.CreatedDate).ToList();
        }

    }
}
