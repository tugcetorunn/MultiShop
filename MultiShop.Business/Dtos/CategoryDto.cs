namespace MultiShop.Business.Dtos
{
    public class CategoryDto : BaseEntityDto
    {
        public int CategoryId { get; set; }
        public int? ParentCategoryId { get; set; }
        public required string CategoryName { get; set; }
        public string? Image { get; set; }
        public List<Product>? Products { get; set; }
    }
}
