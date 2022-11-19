using ProyDemo1.Data.Entidad;
using System.ComponentModel.DataAnnotations;

namespace ProyDemo1.Data.Entity
{
    public class City : IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Ciudad")]
        [MaxLength(50, ErrorMessage = "El campo {0} su maximo de caracteres es de {1}")]
        [Required(ErrorMessage = "El campo {0} es requerido...")]
        public string Name { get; set; } = null!;

        [Display(Name = "Activo")]
        [Required(ErrorMessage = "El campo {0} es requerido...")]
        public bool IsActive { get; set; }

    }
}
