using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class BookAllViewModel
    {
        public int Id { get; set; }

        [Display(Name = "BookName")]

        public string BookName { get; set; }

        [Display(Name = "Author")]

        public string Author { get; set; }


        [Display(Name = "Genre")]

        public string Genre { get; set; }

        [Display(Name = "Picture")]

        public string Picture
        {
            get; set;
        }

        [Display(Name = "YearOfPublication")]

        public DateTime YearOfPublication { get; set; }

        [Display(Name = "Price")]

        public double Price { get; set; }

    }
}
