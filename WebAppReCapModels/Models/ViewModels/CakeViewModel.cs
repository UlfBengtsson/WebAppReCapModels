using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppReCapModels.Models
{
    public class CakeViewModel
    {
        [Required(ErrorMessage = "Must have a Name")]
        [StringLength(63, MinimumLength = 1, ErrorMessage = "Must have a Name that is 1 to 63 letters long")]
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
