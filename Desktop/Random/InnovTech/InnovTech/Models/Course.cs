using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InnovTech.Models
{
    public class Course
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Course_Id { get; set; }
        [Required]

        
        [Display(Name = "Course Name")]
        public string Course_Name { get; set; }
        [Required]
       
        [Display(Name = "Course Description")]
        public string Course_Description { get; set; }
        
        public ICollection<Students> students { get; set; }
        


        



    }
}