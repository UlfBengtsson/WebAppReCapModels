using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppReCapModels.Models
{
    public class CarViewModel
    {
        [Required]
        [StringLength(60, MinimumLength = 2)]
        public string Brand { get; set; }
        [Required]
        [Display(Name = "Model")]
        [StringLength(60, MinimumLength = 2)]
        public string ModelName { get; set; }
        [Required]
        public DateTime Year { get; set; }
    }
}
