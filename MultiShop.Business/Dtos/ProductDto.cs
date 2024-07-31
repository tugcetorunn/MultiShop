namespace MultiShop.Business.Dtos
{
    public class ProductDto : BaseEntityDto
    {
        public int ProductId { get; set; }
        public required string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal? SalePrice { get; set; }
        public int Stock { get; set; }
        public string? Description { get; set; }
        public string? Detail { get; set; }
        public string? Information { get; set; }
        public Size? Size { get; set; } 
        public Color? Color { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public List<ProductImage>? ProductImages { get; set; }
        public List<ProductComment>? ProductComments { get; set; }
        public short RatingAvg { get; set; }
    }
}
