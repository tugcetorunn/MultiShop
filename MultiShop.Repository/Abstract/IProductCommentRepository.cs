
namespace MultiShop.Repository
{
    public interface IProductCommentRepository : IRepository<ProductComment>
    {
        List<ProductComment> GetProductCommentsDesc(int id);
    }
}
