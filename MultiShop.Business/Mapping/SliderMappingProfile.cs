namespace MultiShop.Business.Mapping
{
    public class SliderMappingProfile : Profile
    {
        // 4. işlem
        // entityismiMappingProfile klasik isimlendirmedir. bu class createmap ve reversemap yapabilmesi için profile base class ından
        // miras almalıdır. mapleme işlemi constructorda yapılır. slidermappingprofile i çağırdığımızda burası çalışacak.
        public SliderMappingProfile() 
        {
            // createMap<kaynak, dönüştürülecek hedef>().reverseMap() --> createmap slider ı sliderdto ya dönüştürür,
            // reversemap dto yu slider a dönüştürür. dto ya dönüştürdüğümüz veriyi gören kullanıcı bir form işlemi yaptığında bu yine dto
            // şeklinde olur. bu veriyi database e entity olarak göndermemiz gerektiğinden dto to entity ye bu noktada ihtiyacımız olacak.
            // fakat prosesi ikiye katlamamak amacıyla reversemap i ihtiyacımız olacak yerde yani kullanıcıdan veri alıp db ye göndermemiz
            // gereken durumlarda reversemap uygulamak daha uygun olacaktır.
            CreateMap<Slider, SliderDto>().ReverseMap();
            // buradaki işlemler eşleştirmedir.
        }
    }
}
