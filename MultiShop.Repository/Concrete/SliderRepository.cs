
namespace MultiShop.Repository
{
    public class SliderRepository : Repository<Slider>, ISliderRepository
    {
        public SliderRepository(MultiShopContext _context) : base(_context)
        {
        }
    }
}
