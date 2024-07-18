using MultiShop.Business.Dtos;

namespace MultiShop.Business
{
    public interface ICategoryService
    {
        List<CategoryDto> GetCategoriesWithProducts();
        CategoryDto? GetCategoryById(int id);
        bool InsertCategory(CategoryDto categoryDto);
    }
}

