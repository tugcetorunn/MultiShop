using Microsoft.AspNetCore.Mvc;

namespace MultiShop.Presentation.Controllers
{
    //Navbar (Categories) dan gelen request leri karşılayacak. Category lere göre ürün getirecek.
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;
        public CategoryController(ICategoryService _categoryService)
        {
            categoryService = _categoryService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetProductByCategory(int id)
        {
            return View(categoryService.GetCategoryById(id)); // neden getCategoryById kullandık, product gelmesi lazım??

        }
    }
}
