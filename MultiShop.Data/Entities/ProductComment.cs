namespace MultiShop.Data
{
    public class ProductComment
    {
        public int ProductCommentId { get; set; }
        public string? Comment { get; set; }
        public required string CommenterName { get; set; }
        public string? CommenterEmail { get; set; }
        public short Rating { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
