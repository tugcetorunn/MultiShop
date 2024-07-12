namespace MultiShop.Data
{
    public class Slider : BaseEntity
    {
        public int SliderId { get; set; }
        public required string Header { get; set; }
        public required string Content { get; set; }
        public required string Image { get; set; }
        public required Position Position { get; set; }
    }
}
