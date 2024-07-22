namespace MultiShop.Business.Dtos
{
    public class SliderDto /* SliderModel */ : BaseEntityDto
    {
        // maplemede (entity to dto / dto to entity) 1. işlem dto class larını oluşturmaktır. 2. olarak business a automapper yüklüyoruz.
        // 3. işlem maplemenin yapılacağı mapping klasörünü oluşturmak.
        public int SliderId { get; set; }
        public required string Header { get; set; }
        public required string Content { get; set; }
        public required string Image { get; set; }
        public required Position Position { get; set; }
    }
}
