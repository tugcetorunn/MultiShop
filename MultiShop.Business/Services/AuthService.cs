
namespace MultiShop.Business
{
    public class AuthService : IAuthService
    {
        // repository inject etmiyoruz, repository ye gitmeyeceğiz. microsoft un identity yapısıyla işlemlerimizi yapıyoruz.
        private readonly IMapper mapper;
        private readonly UserManager<ApplicationUser> userManager; // user ekleme işlemlerini yürütür.
        private readonly SignInManager<ApplicationUser> signInManager; // login işlemlerini yürütür.
        public AuthService(IMapper _mapper, UserManager<ApplicationUser> _userManager, SignInManager<ApplicationUser> _signInManager)
        {
            mapper = _mapper;
            userManager = _userManager;
            signInManager = _signInManager;
        }

        public async Task<bool> SignUpUser(UserDto userDto) // async işlem olduğu için geriye task döndürecek bir metod olmalı.
                                                            // return userCreate.Succeeded yaptığımız için de bool tipli task dememiz gerek.
                                                            // succeded kullanmak opsiyonel.
        {
            var user = new ApplicationUser
            {
                UserName = userDto.UserName, // formdan çektiğimiz userDto property lerini identityUser property lerine aktarıyoruz.  
                Email = userDto.Email
            };

            var userCreate = await userManager.CreateAsync(user, userDto.Password); // bu değer failed dönerse hangi hataların çıktığını ekrana
                                                                                    // yazdırsın...

            return userCreate.Succeeded;
        }

        public async Task<bool> SignInUser(UserDto userDto)
        {
            var user = new ApplicationUser
            { 
                UserName = userDto.UserName,
                Email = userDto.Email
            };

            //var userControlMail = await userManager.FindByEmailAsync(userDto.Email);
            var userControlName = await userManager.FindByNameAsync(userDto.UserName);

            var userLogin = await signInManager.PasswordSignInAsync(user.UserName, userDto.Password, isPersistent: userDto.IsPersistent, lockoutOnFailure: false);

            return userLogin.Succeeded;
        }

        public async Task SignOutUser()
        {
            await signInManager.SignOutAsync();
        }
    }
}
