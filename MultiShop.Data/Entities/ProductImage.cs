namespace MultiShop.Data
{
    public class ProductImage
    {
        public int ProductImageId { get; set; }
        public required string Image { get; set; }
        public int ProductId { get; set; }
        public required Product Product { get; set; }
    }
}
