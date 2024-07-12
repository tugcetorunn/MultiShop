using MultiShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Business
{ 
    public class CategoryService : ICategoryService
    {
        private readonly MultiShopContext context;
        public CategoryService(MultiShopContext _context)
        {
            context = _context;
        }
        public List<Category> GetCategories()
        {
            var list = context.Categories.ToList();
            return list;
        }

        public Category? GetCategoryById(int id)
        {
            var category = context.Categories.Where(c => c.CategoryId == id).FirstOrDefault();
            return category;
        }
    }
}
