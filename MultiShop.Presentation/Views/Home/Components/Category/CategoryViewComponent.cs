using Microsoft.AspNetCore.Mvc;
using MultiShop.Business;

namespace MultiShop.Presentation.Views.Home.Components.Category
{
    public class CategoryViewComponent : ViewComponent
    {
        // mvc component yapısında view içinde controller oluşturulur.
        // component yapısında bir cs bir de cshtml bulunur. cs controller, cshtml component in html ini içeren view dosyası görevi görür.

        private readonly ICategoryService categoryService;

        public CategoryViewComponent(ICategoryService _categoryService)
        {
            categoryService = _categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var categories = categoryService.GetCategoriesWithProducts();
            return View(categories);
        }

    }
}
