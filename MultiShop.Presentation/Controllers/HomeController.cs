using Microsoft.AspNetCore.Mvc;
using MultiShop.Business;

namespace MultiShop.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService categoryService;
        public HomeController(ICategoryService _categoryService)
        {
            categoryService = _categoryService; // CategoryService i inject ettik.
        }
        public IActionResult Index()
        {
            var list = categoryService.GetCategories(); // controllerlarda sadece hazır metodları ÇAĞIRIRIZ. context ya da crud olmaz.
            return View(list);
        }
        public IActionResult Detail(int id)
        {
            var category = categoryService.GetCategoryById(id);
            return View(category);
        }
    }
}
