
namespace MultiShop.Business
{ 
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IMapper mapper;
        public CategoryService(ICategoryRepository _categoryRepository, IMapper _mapper)
        {
            categoryRepository = _categoryRepository;
            mapper = _mapper;
        }
        public List<CategoryDto> GetCategories()
        {
            // var categories = context.Categories.ToList();
            var categories = categoryRepository.GetAllAsNoTracking();
            List<CategoryDto> categoryDtos = mapper.Map<List<CategoryDto>>(categories);
            return categoryDtos;
        }
        public List<CategoryDto> GetCategoriesWithProducts()
        {
            var categories = categoryRepository.GetCategoriesWithProducts();
            List<CategoryDto> categoryDtos = mapper.Map<List<CategoryDto>>(categories);
            return categoryDtos;
        }

        public CategoryDto? GetCategoryById(int id)
        {
            var category = categoryRepository.GetById(id);
            CategoryDto categoryDto = mapper.Map<CategoryDto>(category);
            return categoryDto;
        }
        
        public bool InsertCategory(CategoryDto categoryDto)
        {
            //Category category = mapper.Map<Category>(categoryDto);
            //context.Categories.Add(category);
            //return context.SaveChanges() > 0; // save ederken bir sorun olmamışsa bu savechanges sonucu 1 olur ve return 1 den metod bool
            //                                  // tipinde true döndürür.

            Category category = mapper.Map<Category>(categoryDto);
            return categoryRepository.Add(category);

        }
    }
}
