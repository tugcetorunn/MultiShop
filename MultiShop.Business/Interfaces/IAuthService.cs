
namespace MultiShop.Business
{
    public interface IAuthService
    {
        Task<bool> SignUpUser(UserDto userDto);
        Task<bool> SignInUser(UserDto userDto);
        Task SignOutUser();
    }
}