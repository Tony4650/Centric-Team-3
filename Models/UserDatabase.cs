using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Centric_Team_3.Models
{
    public class UserDatabase
    {
            
        public int ID { get; set; }

        [Required]
        public string lastName { get; set; }

        [Required]
        public string firstName { get; set; }

        [Display(Name = "Full Name")]
        [Required]
        public string fullName { get
            {
                return lastName + "," + firstName;
            }
                }

        [Required]
        public string department { get; set; }

        [Required]
        public string office { get; set; }

        [Required]
        public DateTime startDate { get; set; }


    }
}