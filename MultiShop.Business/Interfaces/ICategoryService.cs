namespace MultiShop.Business
{
    public interface ICategoryService
    {
        List<CategoryDto> GetCategories();
        List<CategoryDto> GetCategoriesWithProducts();
        CategoryDto? GetCategoryById(int id);
        bool InsertCategory(CategoryDto categoryDto);
    }
}

