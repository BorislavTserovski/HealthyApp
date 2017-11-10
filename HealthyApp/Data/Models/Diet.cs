using HealthyApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyApp.Data.Models
{
    public class Diet
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        [Display(Name ="Diet Name")]
        public string Name { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(1000)]
        public string Content { get; set; }

        public byte[] Picture { get; set; }

        public string AuthorId { get; set; }

        public ApplicationUser Author { get; set; }
    }
}
