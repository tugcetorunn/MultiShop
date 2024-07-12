using MultiShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Business.Services;

public class CategoryService : ICategoryService
{
    public List<Category> GetCategories()
    {
        // deneme
        Category category1 = new Category() { CategoryId = 1, CategoryName = "textile" };
        Category category2 = new Category() { CategoryId = 2, CategoryName = "foods and drinks" };

        List<Category> list = new List<Category>() { category1, category2 };
        
        return list;
    }
}
