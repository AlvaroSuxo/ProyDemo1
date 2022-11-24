using System.ComponentModel.DataAnnotations;

namespace ProyDemo1.Models
{
    public class RegisterNewUserViewModel
    {
        [Required]
        [Display(Name = "Nombres")]
        public string FirsName { get; set; }

        [Required]
        [Display(Name = "Apellidos")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Nombre de usuario")]
        [DataType(DataType.EmailAddress)]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Clave")]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string Confirm { get; set; }
    }
}
