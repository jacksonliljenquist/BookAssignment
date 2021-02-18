using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookAssignment.Models
{
    public class Project
    {
        [Key]
        [Required]
        public int BookID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string publisher { get; set; }
        [Required]
        [RegularExpression("^[0-9]{3}[- /][0-9]{10}$")]
        public string ISBN { get; set; }
        [Required]
        public string Classification { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
