namespace MultiShop.Presentation.Views.Home.Components.Slider
{
    public class SliderViewComponent : ViewComponent
    {
        private readonly ISliderService sliderService;
        public SliderViewComponent(ISliderService _sliderService)
        {
            sliderService = _sliderService;
        }

        public IViewComponentResult Invoke()
        {
            var sliders = sliderService.GetSliders();
            return View(sliders);
        }
    }
}
