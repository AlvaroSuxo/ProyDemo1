﻿using ProyDemo1.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace ProyDemo1.Models
{
    public class ProductViewModel : Product
    {
        [Display(namespace = "Imagen")]
        public IFormFile ImageFile { get; set; }
    }
}
