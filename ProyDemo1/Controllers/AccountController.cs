using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using ProyDemo1.Data.Helper;
using ProyDemo1.Models;

namespace ProyDemo1.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserHelper userHelper;

        public AccountController(IUserHelper userHelper)
        {
            this.userHelper = userHelper;
        }
        [HttpGet]
        public IActionResult Login()
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return this.RedirectToAction("Index", "Home");
            }
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                var result = await this.userHelper.LoginAsync(model);

                if (result.Succeeded)
                {
                    if (this.Request.Query.Keys.Contains("RetumUrl"))
                    {
                        return this.Redirect(this.Request.Query["RetumUrl"].First());
                    }
                    return this.RedirectToAction("Index", "Home");
                }
            }
            this.ModelState.AddModelError(string .Empty, "Error en el Login");
            return this.View(model);
        }
        public async Task<IActionResult> Logout()
        {
            await this.userHelper .LogoutAsync();
            return this.RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return this.View();
        }
       // [HttpPost]
       // public async Task <IActionResult > Register (RegisterNewUserViewModel model)
       // {

       // }

    }
}