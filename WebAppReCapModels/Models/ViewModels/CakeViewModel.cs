using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppReCapModels.Models
{
    public class CakeViewModel
    {
        [Required]
        [StringLength(63, MinimumLength = 1)]
        public string Name { get; set; }

        [Required]
        [Range(1, double.MaxValue)]
        public double Price { get; set; }

        [Required]
        [Range(1, 1024)]
        [Display(Name = "Person servings / Size")]
        public int Servings { get; set; }

        [Display(Name = "No gluten")]
        public bool GlutenFree { get; set; }

        [Display(Name = "No lactose")]
        public bool LactoseFree { get; set; }

        [Display(Name = "No nuts")]
        public bool NutsFree { get; set; }
    }
}
