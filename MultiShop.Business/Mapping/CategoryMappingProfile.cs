using AutoMapper;
using MultiShop.Business.Dtos;
using MultiShop.Data;

namespace MultiShop.Business.Mapping
{
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile() 
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
        }
    }
}
