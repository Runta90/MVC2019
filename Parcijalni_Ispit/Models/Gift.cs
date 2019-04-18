using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcijalni_Ispit.Models
{
    public class Gift
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Name must be shorter than 50 characters")]
        public string Name { get; set; }
        [Required]
        [Range(0, 9999999999999999.99)]
        public decimal Price { get; set; }

        public bool Bought { get; set; }
    }
}
