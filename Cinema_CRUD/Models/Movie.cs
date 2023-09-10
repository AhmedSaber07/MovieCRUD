using Cinema_CRUD.Data.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema_CRUD.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Required]
        [MinLength(5,ErrorMessage ="Movie Name must be at least 5 character")]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MinLength(25, ErrorMessage = "Movie Description must be at least 25 character")]
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }
        public MovieCategory movieCategory { get; set; }
        public byte[] image { get; set; }
    }
}
