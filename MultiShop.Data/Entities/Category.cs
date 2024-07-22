namespace MultiShop.Data
{
    public class Category : BaseEntity
    {
        //[Key] annotion ları configuration class larında yönettik.
        public int CategoryId { get; set; }
        public int? ParentCategoryId { get; set; }
        public required string CategoryName { get; set; }
        public string? Image {  get; set; }
        public List<Product>? Products { get; set; }
    }
}
