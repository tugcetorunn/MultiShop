using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MultiShop.Business.Dtos;
using MultiShop.Data;

namespace MultiShop.Business
{ 
    public class CategoryService : ICategoryService
    {
        private readonly MultiShopContext context;
        private readonly IMapper mapper;
        public CategoryService(MultiShopContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }
        public List<CategoryDto> GetCategoriesWithProducts()
        {
            var categories = context.Categories.Include(c => c.Products).ToList();
            List<CategoryDto> categoryDtos = mapper.Map<List<CategoryDto>>(categories);
            return categoryDtos;
        }

        public CategoryDto? GetCategoryById(int id)
        {
            var category = context.Categories.Where(c => c.CategoryId == id).FirstOrDefault();
            CategoryDto categoryDto = mapper.Map<CategoryDto>(category);
            return categoryDto;
        }
        
        public bool InsertCategory(CategoryDto categoryDto)
        {
            Category category = mapper.Map<Category>(categoryDto);
            context.Categories.Add(category);
            return context.SaveChanges() > 0; // save ederken bir sorun olmamışsa bu savechanges sonucu 1 olur ve return 1 den metod bool
                                              // tipinde true döndürür.

        }
    }
}
