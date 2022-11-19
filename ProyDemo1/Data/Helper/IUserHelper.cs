using Microsoft.AspNetCore.Identity;
using ProyDemo1.Data.Entity;

namespace ProyDemo1.Data.Helper
{
    public interface IUserHelper
    {
        Task<User>GetUserByEmailAsync(string email);

        Task<IdentityResult>AddUserAsync(User user, string password);
    }
}
