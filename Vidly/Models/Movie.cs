using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public String Name { get; set; }
        
        public Genre Genre { get; set; }
        
        [Display (Name = "Genre")]
        public byte GenreId { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }
        
        [Range(1,20)]
        [Display(Name = "Number In Stock")]
        public int Quantity { get; set; }

    }
}