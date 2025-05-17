using ContactListo.Services;
using Microsoft.AspNetCore.Mvc;
using ContactListo.Models;

namespace ContactListo.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Login(string returnUrl = "/")
        {
            return View(new LoginViewModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        public async Task <IActionResult> Login(LoginViewModel model)
        {
            var user = await _userService.GetUserByUsernameAndPassword(model.Username, model.Password);
            return View();
        }
    }
}
