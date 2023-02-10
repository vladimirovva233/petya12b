using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class BookCreateViewModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [Display(Name = "BookName")]
        public string BookName { get; set; }
       
        [Required]
        
        [MaxLength(30)]
        [Display(Name = "Author")]

        public string Author { get; set; }
        
        [Required]
        [MaxLength(30)]
        [Display(Name = "Genre")]
        public string Genre { get; set; }
       
        [Display(Name = "Picture")]
        public string Picture { get; set; }

        [Display(Name = "YearOfPublication")]
        public DateTime YearOfPublication { get; set; }

        [Required]
        [Range(5,200, ErrorMessage = "error")]
        [Display(Name = "Price")]
        public double Price { get; set; }

    }
}
