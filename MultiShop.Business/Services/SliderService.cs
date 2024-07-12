using MultiShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Business
{
    public class SliderService : ISliderService
    {
        private readonly MultiShopContext context;
        public SliderService(MultiShopContext _context)
        {
            context = _context;
        }

        public List<Slider> GetSliders()
        {
            var sliders = context.Sliders.ToList();
            return sliders;
        }

    }
}
