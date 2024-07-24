namespace MultiShop.Data
{
    public class BaseEntity
    {
        public int? Order { get; set; } // listelemelerde sıra belirtebilmek için
        public bool IsActive { get; set; } = true;
        public DateTime CreatedDate { get; set; }
    }
}
