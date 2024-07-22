namespace MultiShop.Presentation.Views.Home.Components.Product
{
    public class ProductViewComponent : ViewComponent
    {
        private readonly IProductService productService;
        public ProductViewComponent(IProductService _productService)
        {
            productService = _productService;
        }

        public IViewComponentResult Invoke(ShowPlace showPlace)
        {
            return View(productService.GetProductsByShowPlace(showPlace));
        }
    }
}
