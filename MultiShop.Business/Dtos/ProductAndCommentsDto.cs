namespace MultiShop.Business.Dtos
{
    public class ProductAndCommentsDto
    {
        public ProductDto? Product { get; set; }
        public List<ProductCommentDto>? ProductComments { get; set; }
        public static ProductAndCommentsDto Create(ProductDto productDto, List<ProductCommentDto> commentDtos)
        {
            return new ProductAndCommentsDto()
            {
                Product = productDto,
                ProductComments = commentDtos
            };
        }
    }
}
