namespace MultiShop.Business.Dtos
{
    public class BaseEntityDto
    {
        public int? Order { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
