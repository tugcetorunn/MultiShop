namespace MultiShop.Presentation.Views.Shared.Components.Navbar
{
    public class NavbarViewComponent : ViewComponent
    {
        private readonly ICategoryService categoryService;
        public NavbarViewComponent(ICategoryService _categoryService)
        {
            categoryService = _categoryService;
        }
        public IViewComponentResult Invoke()
        {
            var categories = categoryService.GetCategories();
            return View(categories);
        }
    }
}
