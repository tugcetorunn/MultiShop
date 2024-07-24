using System.Runtime.InteropServices;

namespace MultiShop.Business.Dtos
{
    public class ProductDetailDto
    {
        // dto ları yani modellerimizi sadece db de göründüğü gibi oluşturmak zorunda değiliz dto lar bize back end tarafında yardımcı 
        // olacak db modellerini sağlar. ihtiyaca göre oluşturulabilirler.
        public ProductDto? Product { get; set; }
        public List<ProductDto>? Products { get; set; }
        
        // ayrıca buradan bir metod oluşturarak product service te dışarıdan alacağımız productdto ve list<productdto> yu eşleştireceğiz.
        public static ProductDetailDto Create(ProductDto productDto, List<ProductDto> productDtos)
        {
            return new ProductDetailDto()
            {
                Product = productDto,
                Products = productDtos
            };
            
        }

    }
}
