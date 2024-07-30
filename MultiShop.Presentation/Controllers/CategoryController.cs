using Microsoft.AspNetCore.Mvc;

namespace MultiShop.Presentation.Controllers
{
    //Navbar (Categories) dan gelen request leri karşılayacak. Category lere göre ürün getirecek.
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly IProductService productService;
        public CategoryController(ICategoryService _categoryService, IProductService _productService)
        {
            categoryService = _categoryService;
            productService = _productService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetProductByCategory(int id)
        {
            return View(productService.GetAllProductsByCategory(id)); // neden getCategoryById kullandık, product gelmesi lazım??

        }
    }
}
