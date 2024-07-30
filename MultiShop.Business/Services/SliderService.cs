
namespace MultiShop.Business
{
    public class SliderService : ISliderService
    {
        private readonly ISliderRepository sliderRepository;
        // 6. işlem service e mapper ı inject ediyoruz.
        private readonly IMapper mapper;
        public SliderService(ISliderRepository _sliderRepository, IMapper _mapper)
        {
            sliderRepository = _sliderRepository;
            mapper = _mapper;
        }

        public List<SliderDto> GetSliders()
        {
            var sliders = sliderRepository.GetAllAsNoTracking();
            // 7. işlem Dönüştürülecek hedef tip ve veri = mapper.Map<Dönüştürelecek hedef tip>(kaynak);
            List<SliderDto> sliderDtos = mapper.Map<List<SliderDto>>(sliders);
            // buradaki işlem dönüştürmedir.
            return sliderDtos;
        }

    }
}
