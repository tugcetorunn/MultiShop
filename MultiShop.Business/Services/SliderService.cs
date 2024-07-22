namespace MultiShop.Business
{
    public class SliderService : ISliderService
    {
        private readonly MultiShopContext context;
        // 6. işlem service e mapper ı inject ediyoruz.
        private readonly IMapper mapper;
        public SliderService(MultiShopContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }

        public List<SliderDto> GetSliders()
        {
            var sliders = context.Sliders.ToList();
            // 7. işlem Dönüştürülecek hedef tip ve veri = mapper.Map<Dönüştürelecek hedef tip>(kaynak);
            List<SliderDto> sliderDtos = mapper.Map<List<SliderDto>>(sliders);
            // buradaki işlem dönüştürmedir.
            return sliderDtos;
        }

    }
}
