using System.ComponentModel.DataAnnotations;

namespace ProyDemo1.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Username { get; set; } = null!;

        [Required]
        public string Password { get; set; } = null!;
        public bool RememberMe { get; set; }

    }
}
