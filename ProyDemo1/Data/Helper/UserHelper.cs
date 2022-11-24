using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProyDemo1.Data.Entity;
using ProyDemo1.Models;

namespace ProyDemo1.Data.Helper
{
    public class UserHelper : IUserHelper
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> singInManager;
        public UserHelper(UserManager<User> userManager, SignInManager<User> singInManager)
        {
            this.userManager = userManager;
            this.singInManager = singInManager;
        }
        public async Task<Microsoft.AspNetCore.Identity.SignInResult> LoginAsync(LoginViewModel model)
        {
            return await this.singInManager.PasswordSignInAsync(
                model.Username,
                model.Password,
                model.RememberMe,
                false);
        }
        public async Task LogoutAsync()
        {
            await this.singInManager.SignOutAsync();
        }
        public async Task<IdentityResult> AddUserAsync(User user, string password)
        {
            return await this.userManager.CreateAsync(user, password);
        }
        public async Task<User> GetUserByEmailAsync(string email)
        {
            var user = await this.userManager.FindByEmailAsync(email);
            return user;
        }
        Task<Microsoft.AspNetCore.Identity.SignInResult> IUserHelper.LoginAsync(LoginViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}