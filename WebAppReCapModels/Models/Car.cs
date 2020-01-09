using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppReCapModels.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        [Display(Name = "Model")]
        public string ModelName { get; set; }
    }
}
