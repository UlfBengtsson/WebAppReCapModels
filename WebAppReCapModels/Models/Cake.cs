using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppReCapModels.Models
{
    public class Cake
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(63, MinimumLength = 1)]
        public string Name { get; set; }

        [Required]
        [Range(1,double.MaxValue)]
        public double Price { get; set; }

        [Required]
        [Range(1,1024)]
        public int Servings { get; set; }

        public bool GlutenFree { get; set; }
        public bool LactoseFree { get; set; }
        public bool NutsFree { get; set; }

    }
}
