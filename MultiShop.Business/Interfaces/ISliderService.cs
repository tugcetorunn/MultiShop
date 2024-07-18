using MultiShop.Business.Dtos;
using MultiShop.Data;

namespace MultiShop.Business 
{
    public interface ISliderService
    {
        List<SliderDto> GetSliders();
    }
}

