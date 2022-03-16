using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Centric_Team_3.Models
{
    public class UserDatabase
    {
        public Guid ID { get; set; }

        [Required]
        [Display(Name = " Last Name ")]
        public string lastName { get; set; }
        
        [Required]
        [Display(Name = " First Name")]
        public string firstName { get; set; }

        [Display(Name = "Full Name")]
        [Required]
        public string fullName { get
            {
                return lastName + "," + firstName;
            }
                }

        [Required]
        [Display(Name = " Department ")]
        public string department { get; set; }
        
        [Required]
        [Display(Name = " Office")]
        public string office { get; set; }
       
        [Required]
        [Display(Name = " Start Date")]
        public DateTime startDate { get; set; }
        

    }
}