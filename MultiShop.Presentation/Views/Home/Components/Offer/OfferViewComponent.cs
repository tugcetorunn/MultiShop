namespace MultiShop.Presentation.Views.Home.Components.Offer
{
    public class OfferViewComponent : ViewComponent
    {
        private readonly ISliderService sliderService;
        public OfferViewComponent(ISliderService _sliderService)
        {
            sliderService = _sliderService;
        }

        public IViewComponentResult Invoke()
        {
            return View(sliderService.GetSliders());
        }
    }
}
