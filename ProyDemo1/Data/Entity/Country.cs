using System.ComponentModel.DataAnnotations;

namespace ProyDemo1.Data.Entity
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name = "Pais")]
        public string Name { get; set; } = null!;

        [Display(Name = "Activo")]
        public bool IsActive { get; set; }

    }
}
