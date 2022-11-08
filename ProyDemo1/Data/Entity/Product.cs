using System.ComponentModel.DataAnnotations;


namespace ProyDemo1.Data.Entity
{ 
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Producto")]
        [Required]
        public string Name { get; set; } = null!;

        [Display(Name = "Precio")]
        [Required]
        [DisplayFormat(DataFormatString = "0:C2", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        [Display(Name = "Imagen")]
        public string ImageUrl { get; set; } = null!;

        public DateTime LastPurchase { get; set; }

        public DateTime LastSale { get; set; }

        [Display(Name = "Activo")]
        [Required]
        public bool IsActive { get; set; }

        [Display(Name = "Stock en almacenes")]
        [Required]
        [DisplayFormat(DataFormatString = "0:N2", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }
    }
}
