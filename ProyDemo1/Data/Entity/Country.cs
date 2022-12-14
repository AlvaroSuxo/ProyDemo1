using System.ComponentModel.DataAnnotations;

namespace ProyDemo1.Data.Entity
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name = "Pais")]
        [MaxLength(50, ErrorMessage = "El campo {0} su maximo de caracteres es de {1}")]
        [Required(ErrorMessage = "El campo {0} es requerido...")]
        public string Name { get; set; } = null!;

        [Display(Name = "Activo")]
        [Required(ErrorMessage = "El campo {0} es requerido...")]
        public bool IsActive { get; set; }

    }
}
