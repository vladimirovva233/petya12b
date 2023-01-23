using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDog.Models
{
    public class DogCreateViewModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [Display(Name ="Name")]
        public string Name { get; set; }
        [Required]
        [Range(1,30,ErrorMessage ="error")]
        [Display (Name ="Age")]

        public int Age { get; set; }
        [Required]
        [Display(Name ="Breed")]

        public string Breed { get; set; }
        [Display(Name ="DogPicture")]
        public string Picture { get; set; }

    }
}
