
namespace MultiShop.Presentation.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly IConfiguration configuration;
        public ProductController(IProductService _productService, IConfiguration _configuration)
        {
            productService = _productService;
            configuration = _configuration;

        }
        public IActionResult Detail(int id)
        {
            // detail için tek bir product ve similar listesi için product list göndermemiz gerektiği için bunu bir model oluşturarak
            // yapmak uygun olur. (başka yollarla da yapılabilir fakat bu şekilde solid ilkelerine daha uygun hareket edilmiş oluruz.)
            // productDetailDto yapacağız.
            return View(productService.GetProductDetailAndSimilarProducts(id));
        }

        
    }
}
