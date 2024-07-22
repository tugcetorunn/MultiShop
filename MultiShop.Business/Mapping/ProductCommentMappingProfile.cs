namespace MultiShop.Business.Mapping
{
    public class ProductCommentMappingProfile : Profile
    {
        public ProductCommentMappingProfile()
        {
            CreateMap<ProductComment, ProductCommentDto>().ReverseMap();
        }
    }
}
