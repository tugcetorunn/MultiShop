
namespace MultiShop.Presentation.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthService authService;
        public AuthController(IAuthService _authService)
        {
            authService = _authService;
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(UserDto userDto)
        {
            var result = await authService.SignInUser(userDto);

            //if (result)
            //{
            //    RedirectToAction("action", "controller");
            //} admin index oluşturulduğunda o sayfaya gönderilecek.
            // hatalı ise else içine hatalı giriş yazdıracağız.
            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(UserDto userDto)
        {
            var result = await authService.SignUpUser(userDto);

            if (result)
            {
                return RedirectToAction("SignIn"); // burayı ileride -> başarılı kayıt oluşturulmuşsa mail confirm ekranına yönlendireceğiz.
            }
            else
            {
                return View();
            }        
        }

        [HttpGet]
        public async Task<IActionResult> SignOut()
        {
            await authService.SignOutUser();
            return RedirectToAction("Index","Home");
        }
    }
}
