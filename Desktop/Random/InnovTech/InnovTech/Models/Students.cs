using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace InnovTech.Models
{
    public class Students
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        public int? Course_Id { get; set; }
        public virtual Course Course { get; set; }
        public string Course_Name { get; set; }

        [Display(Name = "Name")]
        public string StudentName { get; set; } 
        
        [Required]
        [Display(Name = "Email Address")]

        public string StudentEmail { get; set; }
        [Required]

        public string StudentPhone { get; set; }
        [Required]

        public string Gender { get; set; }
        [Required]

        public int Phone { get; set; }
        [Required]
        [Display(Name = "Age")]
        public int StudentAge { get; set; }

        public DateTime StudentBirthdate { get; set; }

        ApplicationDbContext db = new ApplicationDbContext();
        public string getCourse_Name()
        {
            var Name = (from N in db.courses
                        where N.Course_Id == Course_Id
                        select N.Course_Name).SingleOrDefault();
            return Name;
        }
            

        


    }
}