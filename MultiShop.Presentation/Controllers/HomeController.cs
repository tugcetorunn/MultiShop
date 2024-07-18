using Microsoft.AspNetCore.Mvc;
using MultiShop.Business;
using MultiShop.Business.Dtos;
using MultiShop.Data;
using MultiShop.Data.Configurations;

namespace MultiShop.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService categoryService; // categoryservice teki metodları kullanacağımız için onun interface ini inject
                                                           // ediyoruz. inject sonucu interface le bağlantı kuruluyor. interface de service
                                                           // teki metodları çalıştırıyor.

        private readonly IProductService productService;
        private readonly ISliderService sliderService;
        public HomeController(ICategoryService _categoryService, IProductService _productService, ISliderService _sliderService)
        {
            categoryService = _categoryService; // CategoryService i inject ettik.
            productService = _productService;
            sliderService = _sliderService;
        }
        public IActionResult Index()
        {
            // Index sayfamızda sadece category listesi yok model olarak tek bir tip gönderebiliyoruz fakat slider ve product ların da
            // gönderilmesi gerekiyor. bu durumda birden fazla model göndermemiz gerektiğinde iki yol var. 1. kod fazlalığı yapacak;
            // HomeController class ının altında bir HomeModel class ı oluşturduk. Olması gereken modelleri de property gibi içine ekledik.
            
            var categories = categoryService.GetCategoriesWithProducts(); // controllerlarda sadece hazır metodları ÇAĞIRIRIZ. context ya da crud olmaz.

            // daha sonra bu model i Index action ında instance ını oluşturuyoruz, property leri service ler aracılığıyla tanımlıyoruz ve
            // return olarak bu içinde üç property bulunduran modeli gönderiyoruz.
            // HomeModel model = new HomeModel() { Categories = categories, Products = productService.GetProducts(), 
            //                                     Sliders = sliderService.GetSliders() };
            // ya da burada hiç model oluşturmadan view de component yapısı kullanıyoruz (2. yöntem)

            return View(categories);
        }
        public IActionResult Detail(int id)
        {
            var category = categoryService.GetCategoryById(id);
            return View(category);
        }
    }

    //public class HomeModel
    //{
    //    public List<SliderDto>? Sliders { get; set; }
    //    public List<CategoryDto>? Categories { get; set; }
    //    public List<Product>? Products { get; set; }

    //}
}
