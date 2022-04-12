using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WeParkApp.Models
{
    public class Personal_Details
    {
        [Key] 
        public int PersonId { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]
        [StringLength(50)]

        public string D { get; set; }
    }
}