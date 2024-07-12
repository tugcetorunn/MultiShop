using MultiShop.Data;

namespace MultiShop.Business
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
        Category? GetCategoryById(int id);
    }
}

