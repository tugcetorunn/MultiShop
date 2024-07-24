namespace MultiShop.Business
{
    public interface IProductCommentService
    {
        List<ProductCommentDto> GetProductComments(int id);
    }
}