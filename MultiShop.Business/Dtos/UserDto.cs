
namespace MultiShop.Business.Dtos
{
    public class UserDto
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string? UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsPersistent { get; set; }
        public bool AgreeToTerms { get; set; }
    }
}
